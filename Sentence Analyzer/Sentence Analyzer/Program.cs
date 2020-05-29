using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sentence_Analyzer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            XmlReader xmlReader = XmlReader.Create("LEXIN.xml");

            while (xmlReader.Read())
            {
                // Do some work here on the data.
                Console.WriteLine(xmlReader.Name);
            }
        }
    }
}