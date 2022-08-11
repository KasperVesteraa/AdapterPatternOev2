using System;
using System.Runtime.InteropServices;

namespace AdapterPatternOev2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IAdapter dataAdapter = new DataAdapter(new JsonReaderAdaptee(), new XmlReaderAdaptee());
            
            DataModel dataModel1 = dataAdapter.GetData("/home/dremacs/2022/adapter-pattern-oev1/" +
                                                      "AdapterPatternOev2/AdapterPatternOev2/person-data.json");

            DataModel dataModel2 = dataAdapter.GetData("/home/dremacs/2022/adapter-pattern-oev1/" +
                                                       "AdapterPatternOev2/AdapterPatternOev2/person-data.xml");
            
            Console.WriteLine(dataModel1.FirstName + "\n" + dataModel1.LastName + "\n" + dataModel1.Age);
            Console.WriteLine(dataModel2.FirstName + "\n" + dataModel2.LastName + "\n" + dataModel2.Age);
        }
    }
}