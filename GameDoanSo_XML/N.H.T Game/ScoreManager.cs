using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;
using System.Windows.Forms;

namespace N.H.T_Game
{
    public class ScoreManager
    {
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;
        private string fileName = "data/score.xml";
        private string result = "";
        private string highScore = "";

        private string resultEasy = "";
        private string resultNormal = "";
        private string resultHard = "";

        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        public string HighScore
        {
            get { return highScore; }
            set { highScore = value; }
        }

        public static ScoreManager instance = new ScoreManager();

        private ScoreManager()
        {
        }

        public bool loadFile()
        {
            try
            {
                doc.Load(fileName);
                root = doc.DocumentElement;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool add(Score score)
        {
            XmlElement newScore = doc.CreateElement("score");
            XmlElement level = doc.CreateElement("level");
            level.InnerText = score.Level;
            newScore.AppendChild(level);

            XmlElement name = doc.CreateElement("name");
            name.InnerText = score.Name;
            newScore.AppendChild(name);

            XmlElement score1 = doc.CreateElement("score");
            score1.InnerText = score.Score1.ToString();
            newScore.AppendChild(score1);

            XmlElement date = doc.CreateElement("dateTime");
            date.InnerText = score.DateTime;
            newScore.AppendChild(date);

            root.AppendChild(newScore);
            doc.Save(fileName);
            return true;
        }

        public void delete()
        {
            root.RemoveAll();
            doc.Save(fileName);
        }

        public string output()
        {
            try
            {
                result = "";
                XmlNodeList ds = root.SelectNodes("score");
                int sd = 0;

                foreach (XmlNode item in ds)
                {
                    result += item.SelectSingleNode("level").InnerText + " - " +
                    item.SelectSingleNode("name").InnerText + " - " +
                    item.SelectSingleNode("score").InnerText + " Điểm " + " - " +
                    item.SelectSingleNode("dateTime").InnerText + "\r\n";
                    sd++;
                }
                return result;
            }
            catch
            {
                return null;
            }
        }

        public string resultHighScore()
        {
            try
            {
                result = "";
                XmlNodeList ds = root.SelectNodes("score");
                int maxEasy = 0, maxNormal = 0, maxHard = 0;
                int sd = 0;

                foreach (XmlNode item in ds)
                {
                    if(item.SelectSingleNode("level").InnerText.Equals("Chế độ Dễ") 
                        && int.Parse(item.SelectSingleNode("score").InnerText) > maxEasy)
                    {
                        resultEasy = "";
                        maxEasy = int.Parse(item.SelectSingleNode("score").InnerText);
                        resultEasy += item.SelectSingleNode("level").InnerText + " - " +
                           item.SelectSingleNode("name").InnerText + " - " +
                           item.SelectSingleNode("score").InnerText + " Điểm " + " - " +
                           item.SelectSingleNode("dateTime").InnerText + "\r\n";
                    }

                    if (item.SelectSingleNode("level").InnerText.Equals("Chế độ Trung Bình") 
                        && int.Parse(item.SelectSingleNode("score").InnerText) > maxNormal)
                    {
                        resultNormal = "";
                        maxNormal = int.Parse(item.SelectSingleNode("score").InnerText);
                        resultNormal += item.SelectSingleNode("level").InnerText + " - " +
                           item.SelectSingleNode("name").InnerText + " - " +
                           item.SelectSingleNode("score").InnerText + " Điểm " + " - " +
                           item.SelectSingleNode("dateTime").InnerText + "\r\n";
                    }

                    if (item.SelectSingleNode("level").InnerText.Equals("Chế độ Khó")
                        && int.Parse(item.SelectSingleNode("score").InnerText) > maxHard)
                    {
                        resultHard = "";
                        maxHard = int.Parse(item.SelectSingleNode("score").InnerText);
                        resultHard += item.SelectSingleNode("level").InnerText + " - " +
                           item.SelectSingleNode("name").InnerText + " - " +
                           item.SelectSingleNode("score").InnerText + " Điểm " + " - " +
                           item.SelectSingleNode("dateTime").InnerText + "\r\n";
                    }

                    sd++;
                }
                return HighScore = resultEasy + "\r\n" + resultNormal + "\r\n" + resultHard;
            }
            catch
            {
                return null;
            }
        }
    }
}
