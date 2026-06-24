using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class XmlFileReader : BaseFileReader
    {
        public override string SupportedFormat => "XML";

        protected override void ParseContent(string filePath)
        {
            Console.WriteLine(" -> Opening XML stream...");

            string fullText = File.ReadAllText(filePath);
            XDocument doc = XDocument.Load(filePath);

            string rootName = doc.Root?.Name.LocalName ?? "unknown";
            int nodeCount = doc.Descendants().Count();

            Console.WriteLine($" -> Root element: <{rootName}> with {nodeCount} descendant nodes.");

            string displayContent = fullText.Length > 250
                ? fullText.Substring(0, 250) + "..."
                : fullText;

            Console.WriteLine("\n-------- First 250 Characters --------");
            Console.WriteLine(displayContent);
            Console.WriteLine("-------------------------------------\n");
        }
    }
}
