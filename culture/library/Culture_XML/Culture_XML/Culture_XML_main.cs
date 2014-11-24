using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;

    namespace pl2.culture
    {
        public class Culture
        {

            public const string file_name_const_string = "culture.xml";

            [Description( "Путь к файлу с описанием культуры" ) , Category( "Default" )]
            protected string path{ get; set;}

            [Description( "Название локализации для файла" ) , Category( "Appearance" )]
            public string locale { get; set; }

            [Description( "Номер кодовой страницы для файла" ) , Category( "Appearance" )]
            public Int32 codepage { get; set;}

            [Description( "Массив путей к файлам описания культуры до draft" ) , Category( "Data" )]
            public string[] file_chain { get; set; }

            [Description( "Массив путей к включаемым файлам перевода" ) , Category( "Data" )]
            public string[] files_included { get; set; }

            [Description( "Массив локализаций имени до текущего представления для указанного имени draft" ) , Category( "Data" )]
            public string[] local(string draft)
            {
                return new string[0];
            }

            [Description( "Создание описания цепочки локализации с указанием начального пути" ) , Category( "Data" )]
            public Culture(string culture_path)
            {
                
                path = culture_path + file_name_const_string;
            }

            [Description( "Создание описания цепочки локализации с использованием начального пути по умолчанию" ) , Category( "Data" )]
            public Culture()
            {
                string localisation;
                localisation = Environment.CurrentDirectory + file_name_const_string;
                path = Environment.CurrentDirectory + "\\путь";
            }
        }
    }
