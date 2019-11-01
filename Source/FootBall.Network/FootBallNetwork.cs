using INetwork;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using ProjectHelper;

namespace Network.Football
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

            netNetwork = new List<Network>();
            netNetwork.Add(new Network("TotalGoals", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            netNetwork.Add(new Network("Save_A", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            netNetwork.Add(new Network("Save_B", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            netNetwork.Add(new Network("Violations_A", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            netNetwork.Add(new Network("Violations_B", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            netNetwork.Add(new Network("Shot_A", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            netNetwork.Add(new Network("Shot_B", 3, 151, 1, new List<int>() { 40, 20, 10, 5 }));
            // + tournament
            netNetwork.Add(new Network("Vanga", 2, 10, 10, new List<int>() { 8, 8, 10 }));
        }

        public List<Prediction> GetPrediction(List<LastMatch> teamAMatches, List<LastMatch> teamBMatches, TournamentShort tournament, string[] parameters)
        {
            // 15 параметров для 1 матча + турнир
            return new List<Prediction>();
        }

        public double TestNetwork()
        {
            return 0.0;
        }

        public double Learning()
        {
            return 0.0;
        }

        public void SetLoadWeights()
        {
            XDocument xDoc = new XDocument();
            XmlTextReader xmlTextReader = new XmlTextReader(pathToWeights + "Current.xml");
            xDoc = XDocument.Parse(xmlTextReader.ReadString());
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
                                                        DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() +
                                                        DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() +
                                                        DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() +
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
    }
}
