using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using pl2.culture.data.file;

namespace pl2.culture
{
    public class Draft{
        /// <summary>
        /// Путь к файлам приложений кодировки ASCII языка draft от каталога culture_path
        /// </summary>
        public readonly string default_draft_path = "an\\draft\\";
        
        /// <summary>
        /// полный путь ОС/URL к единому каталогу описания свойств файлов языка для всех приложений
        /// </summary>
        public string culture_path { get; set; }

        /// <summary>
        /// полный путь ОС/URL к размещению ресурсов для текущего приложения
        /// </summary>
        private string draft_path { get; set; }

        /// <summary>
        /// список путей подключаемых файлов для текущего контекста
        /// </summary>
        private string[] incuded_files_list = new string[0];

        /// <summary>
        /// список полных путей ОС/URL подключаемых файлов для текущего приложения
        /// используется для обнаружения рекусивных связей между файлами,
        /// и предотвращения входа в бесконечные циклы
        /// </summary>
        private static string[] used_files_list = new string[0];

        /// <summary>
        /// 
        /// </summary>
        private pl2.culture.data.file.Draft draft_culture_file;

        public string value(string source_term, string target_path)
        {
            string result_value;
            // result_value = Environment.SpecialFolderOption
            result_value = draft_value(source_term);
            return result_value;
            
        }

        private string draft_value(string source_term)
        {
            string return_value;
 	        pl2.culture.data.file.Draft.DictionaryDataTable dt;
            System.Data.DataRow[] terms;
            dt = (pl2.culture.data.file.Draft.DictionaryDataTable) draft_culture_file.Tables["Dictionary"];
            terms = dt.Select( "current=\"" + source_term + "\"" );
            if (terms.Length > 0)
            {
                return_value = (string) terms[0][0];
            }
            else
            {
                return_value = scan_included(source_term);
            }
            return return_value;
        }

        private string scan_included(string source_term)
        {
            string return_value;
            return_value = source_term;
            return return_value;

        }

        public Draft(string culture_path_param)
        {
            string draft_file_name;
            default_draft_path = "an" + Path.DirectorySeparatorChar + "draft";
            culture_path = culture_path_param;
            draft_file_name = default_draft_path + Path.DirectorySeparatorChar 
               + culture_path_param + Path.DirectorySeparatorChar + Culture.file_name_const_string;
            incuded_files_list[0] = draft_file_name; 
            if (! System.IO.File.Exists( draft_file_name )){
                throw new FileNotFoundException( draft_file_name );
            }
            draft_culture_file = new pl2.culture.data.file.Draft(); 
            draft_culture_file.ReadXml(draft_file_name);
        }

    }

}
