using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace AdapterPatternOev2
{
    public class JsonReaderAdaptee
    {
        public DataModel GetJsonData(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);
            string jsonAsString = streamReader.ReadToEnd();
            DataModel dataModel = JsonConvert.DeserializeObject<DataModel>(jsonAsString);
            return dataModel;
        }
    }
}