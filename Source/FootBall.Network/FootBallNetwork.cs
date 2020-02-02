using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using ProjectHelper;
using NetworkInterface;

namespace Football.Network
{
    public class FootballNetwork : INetworkInterface
    {
        private string pathToWeights;
        private string pathToWeightHistory;
        private List<Network> netNetwork;

        private double[] lastError;
        private double[] BestError;
        private int[] lastErrorCount;

        public FootballNetwork()
        {
            pathToWeights = "../Weights/Current/FootBall/";     // Вынести в конфиг, или в константы хелпера
            pathToWeightHistory = "../Weights/History/FootBall/";     // Вынести в конфиг, или в константы хелпера

            lastError = new double[8];
            lastErrorCount = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0};
            BestError = new double[8] { 10.0, 10.0, 10.0, 10.0, 10.0, 10.0, 10.0, 10.0};

            try
            {                
                netNetwork = new List<Network>();
                netNetwork.Add(new Network("TotalGoals", 3, 150, 1, new List<int>() { 10, 12, 10, 5 }, NetworkType.Football_Total));
                netNetwork.Add(new Network("Save_A", 3, 150, 1, new List<int>() { 10, 8, 6, 4 }, NetworkType.Football_SaveA));
                netNetwork.Add(new Network("Save_B", 3, 150, 1, new List<int>() { 10, 8, 6, 4 }, NetworkType.Football_SaveB));
                netNetwork.Add(new Network("Violations_A", 3, 150, 1, new List<int>() { 5, 8, 6, 4 }, NetworkType.Football_ViolationsA));
                netNetwork.Add(new Network("Violations_B", 3, 150, 1, new List<int>() { 5, 8, 6, 4 }, NetworkType.Football_ViolationsB));
                netNetwork.Add(new Network("Shot_A", 3, 150, 1, new List<int>() { 5, 8, 6, 4 }, NetworkType.Football_ShotA));
                netNetwork.Add(new Network("Shot_B", 3, 150, 1, new List<int>() { 5, 8, 6, 4 }, NetworkType.Football_ShotB));

                netNetwork.Add(new Network("Vanga", 3, 150, 10, new List<int>() { 14, 20, 15, 10 }, NetworkType.Football_Vanga));

                SetLoadWeights();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Network ERROR. Football Network");
                Console.WriteLine("Error message: " + ex.Message);
            }
        }
        
        public string TestNetwork(Dictionary<LastMatch, List<LastMatch>> matches)
        {
            // Собираю статистику
            double[] minMaxHelperArray = new double[14];
            for (int i = 0; i < 14; i += 2)
            {
                minMaxHelperArray[i] = 1000.0;
                minMaxHelperArray[i + 1] = -1000.0;
            }
            double fullSumm = 0.0;
            double oneSumm = 0.0;

            // перебираем все пришедшие матчи для обучения
            foreach (var dict in matches)
            {
                var tmpInputParameters = new List<double>();
                // Преобразуем входные параметры к подходящему виду так же, как это делает нейросеть
                foreach (var Lmatch in dict.Value)
                    tmpInputParameters.AddRange(Lmatch.ToListDouble());
                // Получаем первичное предсказание вспомогательных сетей
                var helpNetworkResult = GetHistoryPrediction(tmpInputParameters);
                // Получаем входные параметры для Ванги
                var studyMatch = dict.Key;

                // Набираю параметры для нейронки
                var vangaNetworkReult = FootballHelper.GetVangaInputParametersByCorrectMarchForFootballLearning(studyMatch);
                var parametersList = new List<double>() { studyMatch.tier_A, studyMatch.tier_B, studyMatch.Important_A, studyMatch.Important_B, studyMatch.replacements_A, studyMatch.replacements_B, studyMatch.tier_tournament };
                vangaNetworkReult.AddRange(parametersList);

                var VangaAnswer = GetFinalPrediction(vangaNetworkReult);

                var perfectHelpAnswer = FootballHelper.GetCurrectParametersForHelperLearning(studyMatch);
                var perfectVangaAnswer = FootballHelper.GetPerfectArrayValue(studyMatch.Score_A - studyMatch.Score_B + 6);

                // Подсчёт изначальной ошибки
                var helpErrors = new List<double>();
                for (int i = 0; i < perfectHelpAnswer.Count; i++)
                {
                    var tmp = helpNetworkResult[i] - perfectHelpAnswer[i];
                    if (minMaxHelperArray[2 * i] > tmp)
                        minMaxHelperArray[2 * i] = tmp;
                    if (minMaxHelperArray[2 * i + 1] < tmp)
                        minMaxHelperArray[2 * i + 1] = tmp;
                    helpErrors.Add(tmp);
                }

                var VangaErrors = new List<double>();
                for (int i = 0; i < perfectVangaAnswer.Count; i++)
                {
                    oneSumm += VangaAnswer[i] - perfectVangaAnswer[i];
                    VangaErrors.Add(VangaAnswer[i] - perfectVangaAnswer[i]);
                }
                
                // Без Шага обучения
                // Статистика
                fullSumm += oneSumm;
                oneSumm = 0.0;
            }
            fullSumm /= matches.Count;
            var resultString = "Main: " + fullSumm.ToString("f4") + " other min/max: ";

            for (int i = 0; i < 14; i += 2)
            {
                switch (i)
                {
                    case 0:
                        resultString += "Tot: ";
                        break;
                    case 2:
                        resultString += "SvA: ";
                        break;
                    case 4:
                        resultString += "SvB: ";
                        break;
                    case 6:
                        resultString += "VA: ";
                        break;
                    case 8:
                        resultString += "VB: ";
                        break;
                    case 10:
                        resultString += "ShA: ";
                        break;
                    case 12:
                        resultString += "ShB: ";
                        break;
                    default:
                        break;
                }
                resultString += minMaxHelperArray[i].ToString("f2") + "/" + minMaxHelperArray[i + 1].ToString("f2") + " ";
            }
            return resultString;
        }

        public string Learning(Dictionary<LastMatch, List<LastMatch>> matches)
        {

            // Собираю статистику
            double[] minMaxHelperArray = new double[7];
            for (int i = 0; i < 7; i++)
            {
                minMaxHelperArray[i] = 0;
            }
            double fullSumm = 0.0;
            double oneSumm = 0.0;
            
            // перебираем все пришедшие матчи для обучения
            foreach(var dict in matches)
            {
                var tmpInputParameters = new List<double>();
                // Преобразуем входные параметры к подходящему виду так же, как это делает нейросеть
                foreach (var Lmatch in dict.Value)
                    tmpInputParameters.AddRange(Lmatch.ToListDouble());
                // Получаем первичное предсказание вспомогательных сетей
                var helpNetworkResult = GetHistoryPrediction(tmpInputParameters);
                // Получаем входные параметры для Ванги
                var studyMatch = dict.Key;

                // Набираю параметры для нейронки
                var vangaNetworkReult = FootballHelper.GetVangaInputParametersByCorrectMarchForFootballLearning(studyMatch);
                var parametersList = new List<double>() { studyMatch.tier_A, studyMatch.tier_B, studyMatch.Important_A, studyMatch.Important_B, studyMatch.replacements_A, studyMatch.replacements_B, studyMatch.tier_tournament };
                vangaNetworkReult.AddRange(parametersList);

                var VangaAnswer = GetFinalPrediction(vangaNetworkReult);

                var perfectHelpAnswer = FootballHelper.GetCurrectParametersForHelperLearning(studyMatch);
                var perfectVangaAnswer = FootballHelper.GetPerfectArrayValue(studyMatch.Score_A - studyMatch.Score_B + 6);

                // Подсчёт изначальной ошибки
                var helpErrors = new List<double>();
                for (int i = 0; i < perfectHelpAnswer.Count; i++)
                {
                    var tmp = helpNetworkResult[i] - perfectHelpAnswer[i];
                    minMaxHelperArray[i]+= Math.Abs(tmp);
                    helpErrors.Add(tmp);

                    lastError[i] += Math.Abs(tmp);

                }

                var VangaErrors = new List<double>();
                for (int i = 0; i < perfectVangaAnswer.Count; i++)
                {
                    oneSumm += Math.Abs(VangaAnswer[i] - perfectVangaAnswer[i]);
                    VangaErrors.Add(VangaAnswer[i] - perfectVangaAnswer[i]);
                }

                // Запуск Шага Обучения
                LearningStep(helpErrors, VangaErrors);
                // Статистика
                lastError[7] = oneSumm;
                fullSumm += oneSumm;
                oneSumm = 0;
            }
            // Считаем среднее отклонение по всем тестам
            fullSumm /= matches.Count;            

            var resultString = "Main: " + fullSumm.ToString("f4") + " other: ";

            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        resultString += "Tot: ";
                        break;
                    case 1:
                        resultString += "SvA: ";
                        break;
                    case 2:
                        resultString += "SvB: ";
                        break;
                    case 3:
                        resultString += "VA: ";
                        break;
                    case 4:
                        resultString += "VB: ";
                        break;
                    case 5:
                        resultString += "ShA: ";
                        break;                        
                    case 6:
                        resultString += "ShB: ";
                        break;
                    default:
                        break;
                }
                minMaxHelperArray[i] /= matches.Count;
                resultString += minMaxHelperArray[i].ToString("f3")  +  " ";
            }

            // Если нейронка не может обучиться или уходит не туда,
            // в таком случае принудительно немного изменяем веса нейронов
            for (int i = 0; i < 8; i++)
            {
                if (BestError[i] > lastError[i])
                {
                    BestError[i] = lastError[i];
                    lastErrorCount[i] = 0;
                }
                else lastErrorCount[i]++;
                
                if (lastErrorCount[i] > 2000 && i != 7)
                {
                    netNetwork[i].ChangeWeight();
                    lastErrorCount[i] = 0;
                }
            }
            
            return resultString;
        }
        
        public void SetLoadWeights()
        {
            try
            {
                XDocument xDoc = new XDocument();
                xDoc = XDocument.Load(pathToWeights + "Current.xml");

                var elements = xDoc.Element("Value");
                foreach (var network in netNetwork)
                    network.SetLoadWeight(elements.Element(network.NetworkName));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка установки весов...");
                throw ex;
            }
        }

        // think about good save
        public void SaveCurrentWeights(string historyFileName = "")
        {
            XDocument xDoc = new XDocument(new XElement("Value"));
            var value = xDoc.Element("Value");
            foreach (var singleNetwork in netNetwork)
                value.Add(singleNetwork.GetXmlWeights());

            // Сохранить
            if (!Directory.Exists(pathToWeights)) Directory.CreateDirectory(pathToWeights);
            if (!Directory.Exists(pathToWeightHistory)) Directory.CreateDirectory(pathToWeightHistory);

            XmlTextWriter xmlCurrWriter = new XmlTextWriter(pathToWeights + "Current.xml", null);

            // Определяем путь до историч. файла
            var fileName = string.IsNullOrEmpty(historyFileName) ?
                (pathToWeightHistory + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day +
                DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".xml") :
                (pathToWeightHistory + " "+ historyFileName + ".xml");

            XmlTextWriter xmlWriter = new XmlTextWriter(fileName, null);

            xDoc.Save(xmlWriter);
            xDoc.Save(xmlCurrWriter);
            xmlWriter.Close();
            xmlCurrWriter.Close();
        }

        public void ReloadWeights()
        {
            foreach (var netWork in netNetwork)
                netWork.ReloadWeight();
        }

        public bool ChangeDiscipline(Discipline type)
        {
            // Заглушка
            return true;
        }

        public List<double> GetHistoryPrediction(List<double> fullValues)
        {

            List<double> result = new List<double>();

            foreach (var network in netNetwork)
                if (network.NetworkName != "Vanga")
                    result.Add(network.GetPrediction(fullValues)[0]);            

            return result;
        }

        public List<double> GetFinalPrediction(List<double> inputParameters)
        {
            var final = netNetwork.First(it => it.NetworkName == "Vanga");
            return final.GetPrediction(inputParameters);
        }

        private void LearningStep(List<double> helperError, List<double> VangaError)
        {
            /*
             
            // total
            Thread TotalThread = new Thread(new ParameterizedThreadStart(netNetwork.First(it => it.NetworkName == "TotalGoals").Learning));
            TotalThread.Start(new List<double>() { helperError[0] });
            
            // Save_a
            Thread SaveAThread = new Thread(new ParameterizedThreadStart(netNetwork.First(it => it.NetworkName == "Save_A").Learning));
            SaveAThread.Start(new List<double>() { helperError[1] });
            
            // Save_b
            Thread SaveBThread = new Thread(new ParameterizedThreadStart(netNetwork.First(it => it.NetworkName == "Save_B").Learning));
            SaveBThread.Start(new List<double>() { helperError[2] });
            
            // Нарушения А
            Thread ViolationsAThread = new Thread(new ParameterizedThreadStart(netNetwork.First(it => it.NetworkName == "Violations_A").Learning));
            ViolationsAThread.Start(new List<double>() { helperError[3] });
            
            // Нарушения B
            Thread ViolationsBThread = new Thread(new ParameterizedThreadStart(netNetwork.First(it => it.NetworkName == "Violations_B").Learning));
            ViolationsBThread.Start(new List<double>() { helperError[4] });
            
            // Shot A
            Thread ShotAThread = new Thread(new ParameterizedThreadStart(netNetwork.First(it => it.NetworkName == "Shot_A").Learning));
            ShotAThread.Start(new List<double>() { helperError[5] });
            
            // Shot B
            Thread ShotBThread = new Thread(new ParameterizedThreadStart(netNetwork.First(it => it.NetworkName == "Shot_B").Learning));
            ShotBThread.Start(new List<double>() { helperError[6] });

            VangaError = GetVangaErrors(VangaError);

            Thread VangaThread = new Thread(new ParameterizedThreadStart(netNetwork.First(it => it.NetworkName == "Vanga").Learning));
            VangaThread.Start(VangaError);

            // Ждём завершения
            TotalThread.Join(50);
            SaveAThread.Join(50);
            SaveBThread.Join(50);
            ShotBThread.Join(50);
            ShotAThread.Join(50);
            ViolationsAThread.Join(50);
            ViolationsBThread.Join(50);

            VangaThread.Join();

            */

            for (int i = 0; i < netNetwork.Count - 1; i++)
                netNetwork[i].Learning(new List<double>() { helperError[i] });

            netNetwork.First(it => it.NetworkName == "Vanga").Learning(VangaError);


        }

        /// <summary>
        /// Необходима для исправления ситуации подгона нейронки к одному
        /// наиболее "Приемлемому" для всех матчей результату.
        /// Будем брать не все ошибки, на 5 наиболее весомых
        /// </summary>
        /// <param name="errors"></param>
        /// <returns></returns>
        private List<double> GetVangaErrors(List<double> errors)
        {
            var positionWithError = new Dictionary<int, double>();

            for (int i = 0; i < errors.Count; i++)
                positionWithError.Add(i, errors[i]);

            var badPosition = positionWithError.OrderByDescending(it => Math.Abs(it.Value)).ToList();

            int counter = 0;
            foreach (var bp in badPosition)
                if (counter > 4)
                    errors[bp.Key] = 0.0;                
                else counter++;

            return errors;
        }

    }
}
