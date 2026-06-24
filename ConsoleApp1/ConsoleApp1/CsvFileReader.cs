using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CsvFileReader : BaseFileReader
    {
        public override string SupportedFormat => "CSV";

        protected override void ParseContent(string filePath)
        {

        }
    }
}
