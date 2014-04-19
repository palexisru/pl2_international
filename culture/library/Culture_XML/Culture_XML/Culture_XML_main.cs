using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    namespace pl2.culture
    {
        public class XML
        {
            public const file_name = "culture.xml";
            protected readonly string path;
            public string source;
            public string name;
            public string[] local(string draft)
            {
                return new string[0];
            }
            public XML(string culture_path)
            {
                
                path = culture_path + "culture.xml";
            }
            public XML()
            {
                path = Environment.CurrentDirectory + "
            }
        }
    }
