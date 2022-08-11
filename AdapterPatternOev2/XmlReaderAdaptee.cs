using System.IO;
using System.Xml;

namespace AdapterPatternOev2
{
    public class XmlReaderAdaptee
    {
        public DataModel GetXmlData(string fileName)
        {
            DataModel dataModel = new DataModel();
            StreamReader streamReader = new StreamReader(fileName);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(streamReader);
            var parentnode = xmlDoc.SelectNodes("//Start//Persons//Person");
            foreach (XmlNode item in parentnode)
            {
                dataModel.FirstName = item["FirstName"].InnerText;
                dataModel.LastName = item["LastName"].InnerText;
                dataModel.Age = item["Age"].InnerText;
            }

            return dataModel;
        }
    }
}