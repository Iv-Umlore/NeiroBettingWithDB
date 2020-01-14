using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public FootballNetwork()
        {
            pathToWeights = "../Weights/Current/FootBall/";     // Вынести в конфиг, или в константы хелпера
            pathToWeightHistory = "../Weights/History/FootBall/";     // Вынести в конфиг, или в константы хелпера

            try
            {                
                netNetwork = new List<Network>();
                netNetwork.Add(new Network("TotalGoals", 3, 150, 1, new List<int>() { 10, 10, 10, 5 }, NetworkType.Football_Total));
                netNetwork.Add(new Network("Save_A", 3, 150, 1, new List<int>() { 10, 10, 10, 5 }, NetworkType.Football_SaveA));
                netNetwork.Add(new Network("Save_B", 3, 150, 1, new List<int>() { 10, 10, 10, 5 }, NetworkType.Football_SaveB));
                netNetwork.Add(new Network("Violations_A", 3, 150, 1, new List<int>() { 5, 8, 6, 4 }, NetworkType.Football_ViolationsA));
                netNetwork.Add(new Network("Violations_B", 3, 150, 1, new List<int>() { 5, 8, 6, 4 }, NetworkType.Football_ViolationsB));
                netNetwork.Add(new Network("Shot_A", 3, 150, 1, new List<int>() { 5, 8, 6, 4 }, NetworkType.Football_ShotA));
                netNetwork.Add(new Network("Shot_B", 3, 150, 1, new List<int>() { 5, 8, 6, 4 }, NetworkType.Football_ShotB));

                netNetwork.Add(new Network("Vanga", 2, 150, 10, new List<int>() { 14, 10, 10 }, NetworkType.Football_Vanga));

                SetLoadWeights();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Network ERROR. Football Network");
                Console.WriteLine("Error message: " + ex.Message);
            }
        }
        
        public double TestNetwork(Dictionary<LastMatch, List<LastMatch>> matches)
        {
            return 0.0;
        }

        public string Learning(Dictionary<LastMatch, List<LastMatch>> matches)
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
                var vangaNetworkReult = GetFinalPrediction(
                    FootballHelper.GetVangaInputParametersByCorrectMarchForFootballLearning(studyMatch)
                    );
                vangaNetworkReult.AddRange(new List<double>() { studyMatch.tier_A, studyMatch.tier_B, studyMatch.Important_A, studyMatch.Important_B, studyMatch.replacements_A, studyMatch.replacements_B, studyMatch.tier_tournament });
                var VangaAnswer = GetFinalPrediction(vangaNetworkReult);

                var perfectHelpAnswer = FootballHelper.GetCurrectParametersForHelperLearning(studyMatch);
                var perfectVangaAnswer = FootballHelper.GetPerfectArrayValue(studyMatch.Score_A - studyMatch.Score_B);

                // Подсчёт изначальной ошибки
                var helpErrors = new List<double>();
                for (int i = 0; i < perfectHelpAnswer.Count; i++)
                {
                    var tmp = helpNetworkResult[i] - perfectHelpAnswer[i];
                    if (minMaxHelperArray[2*i] > tmp)
                        minMaxHelperArray[2*i] = tmp;
                    if (minMaxHelperArray[2*i + 1] < tmp)
                        minMaxHelperArray[2*i + 1] = tmp;
                    helpErrors.Add(tmp);

                }
                var VangaErrors = new List<double>();
                for (int i = 0; i < perfectVangaAnswer.Count; i++)
                {
                    oneSumm += VangaAnswer[i] - perfectVangaAnswer[i];
                    VangaErrors.Add(VangaAnswer[i] - perfectVangaAnswer[i]);
                }

                // Запуск Шага Обучения
                LearningStep(helpErrors, VangaErrors);
                // Статистика
                oneSumm /= 10;
                fullSumm += oneSumm;

            }
            fullSumm /= matches.Count;
            var resultString = "Main: " + fullSumm.ToString("f4") + " other min/max: ";

            for (int i = 0; i < 14; i += 2)
                resultString += minMaxHelperArray[i].ToString("f2") + "/" + minMaxHelperArray[i + 1].ToString("f2") + " ";
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
        public void SaveCurrentWeights()
        {
            XDocument xDoc = new XDocument(new XElement("Value"));
            var value = xDoc.Element("Value");
            foreach (var singleNetwork in netNetwork)
                value.Add(singleNetwork.GetXmlWeights());

            // Сохранить
            if (!Directory.Exists(pathToWeights)) Directory.CreateDirectory(pathToWeights);
            if (!Directory.Exists(pathToWeightHistory)) Directory.CreateDirectory(pathToWeightHistory);

            XmlTextWriter xmlCurrWriter = new XmlTextWriter(pathToWeights + "Current.xml", null);
            XmlTextWriter xmlWriter = new XmlTextWriter(pathToWeightHistory +
                                                        DateTime.Now.Year + DateTime.Now.Month +
                                                        DateTime.Now.Day + DateTime.Now.Hour +
                                                        DateTime.Now.Minute + DateTime.Now.Second +
                                                        ".xml", null);

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

        }

    }
}
