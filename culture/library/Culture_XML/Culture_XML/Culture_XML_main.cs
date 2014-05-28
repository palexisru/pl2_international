using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;

    namespace pl2
    {
        public class Culture
        {

            public const string file_name = "culture.xml";

            [Description( "Путь к файлу с описанием культуры" ) , Category( "Default" )]
            protected readonly string path{ get; set; };

            [Description( "Название локализации для файла" ) , Category( "Appearance" )]
            public string locale { get; set; };

            [Description( "Номер кодовой страницы для файла" ) , Category( "Appearance" )]
            public Int32 codepage { get;};

            [Description( "Массив путей к файлам описания культуры до draft" ) , Category( "Data" )]
            public string[] chain { get; set; }

            [Description( "Массив путей к включаемым файлам перевода" ) , Category( "Data" )]
            public string[] includes { get; set; }

            [Description( "Массив локализаций имени до текущего представления" ) , Category( "Data" )]
            public string[] local(string draft)
            {
                return new string[0];
            }

            [Description( "Создание описания цепочки локализации с указанием начального пути" ) , Category( "Data" )]
            public Culture(string culture_path)
            {
                
                path = culture_path + "culture.xml";
            }

            [Description( "Создание описания цепочки локализации с использованием начального пути по умолчанию" ) , Category( "Data" )]
            public Culture()
            {
                path = Environment.CurrentDirectory + "\\путь";
            }
        }
    }
