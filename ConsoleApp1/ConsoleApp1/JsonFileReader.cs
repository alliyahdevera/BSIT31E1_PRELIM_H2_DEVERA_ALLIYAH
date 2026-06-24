using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ConsoleApp1
{
    public class JsonFileReader : BaseFileReader
    {
        public override string SupportedFormat => "JSON";

        protected override void ParseContent(string filePath)
        {
            Console.WriteLine(" -> Opening JSON stream...");

            string fullText = File.ReadAllText(filePath);

            using JsonDocument doc = JsonDocument.Parse(fullText);
            JsonElement root = doc.RootElement;

            if (root.ValueKind == JsonValueKind.Object)
            {
                int propertyCount = root.EnumerateObject().Count();
                Console.WriteLine($" -> Parsed {propertyCount} root properties.");
            }
            else if (root.ValueKind == JsonValueKind.Array)
            {
                int itemCount = root.EnumerateArray().Count();
                Console.WriteLine($" -> Parsed {itemCount} root items.");
            }
            else
            {
                Console.WriteLine(" -> Parsed a single JSON value.");
            }

            string displayContent = fullText.Length > 100
                ? fullText.Substring(0, 100) + "..."
                : fullText;

            Console.WriteLine("\n--- First 100 Characters ---");
            Console.WriteLine(displayContent);
            Console.WriteLine("----------------------------\n");
        }
    }
}
