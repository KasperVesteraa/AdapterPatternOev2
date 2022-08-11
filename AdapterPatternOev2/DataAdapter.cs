namespace AdapterPatternOev2
{
    public class DataAdapter : IAdapter
    {
        private readonly JsonReaderAdaptee _jsonReaderAdaptee;
        private readonly XmlReaderAdaptee _xmlReaderAdaptee;

        public DataAdapter(JsonReaderAdaptee jsonReaderAdaptee, XmlReaderAdaptee xmlReaderAdaptee)
        {
            _jsonReaderAdaptee = jsonReaderAdaptee;
            _xmlReaderAdaptee = xmlReaderAdaptee;
        }

        public DataModel GetData(string fileName)
        {
            DataModel dataModel = default;

            if (fileName.EndsWith(".json"))
                dataModel = _jsonReaderAdaptee.GetJsonData(fileName);
            else if (fileName.EndsWith(".xml")) 
                dataModel = _xmlReaderAdaptee.GetXmlData(fileName);

            return dataModel;
        }
    }
}