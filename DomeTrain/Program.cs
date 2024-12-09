using System.Runtime.CompilerServices;
using System.Xml;

namespace DomeTrain
{
    class Program
    {
        static void Main()
        {
            //string xml_records = """
            //    <?xml version="1.0" encoding="UTF-8"?>
            //    <people>
            //        <person>
            //            <name>John Doe</name>
            //            <age>30</age>
            //        </person>
            //        <person>
            //            <name>Jane Smith</name>
            //            <age>25</age>
            //        </person>
            //        <person>
            //            <name>Bob Johnson</name>
            //            <age>40</age>
            //        </person>
            //    </people> 
            // """;

            string filename = "people.xml";

            

            //File.WriteAllText(filename, xml_records);

            XmlDocument doc = new();
            doc.Load(filename);


            XmlNodeList people = doc.SelectNodes("/people/person")!;


            foreach(XmlNode node in people)
            {
                Console.WriteLine(node["name"]!.InnerText);
                Console.WriteLine(node["age"]!.InnerText);
                Console.WriteLine("---------------------");
            }


        }
    }
}
