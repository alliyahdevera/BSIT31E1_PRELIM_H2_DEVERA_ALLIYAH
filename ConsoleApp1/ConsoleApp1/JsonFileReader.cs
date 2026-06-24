using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class JsonFileReader : BaseFileReader
    {
        public override string SupportedFormat => "JSON";

        protected override void ParseContent(string filePath)
        {
            // code
        }
    }
}
