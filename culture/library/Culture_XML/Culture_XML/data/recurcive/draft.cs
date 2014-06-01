using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using pl2.data;

namespace pl2.culture
{
    public class Draft{
        public readonly string default_draft_path = "an\\draft\\";
        
        public string culture_path { get; set; }

        private string draft_path { get; set; }

        private string[] incuded_files_list = new string[0]; 

        private pl2.data.Draft draft_culture;

        public string value(string source_term, string target_path)
        {
            string result_value;
            result_value = Environment.SpecialFolderOption
            result_value = draft_value(source_term);
            return result_value;
            
        }

        private string draft_value(string source_term)
        {
            string return_value;
 	        pl2.data.Draft.DictionaryDataTable dt;
            System.Data.DataRow[] terms;
            dt = (pl2.data.Draft.DictionaryDataTable)draft_culture.Tables["Dictionary"];
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
               + culture_path_param + Path.DirectorySeparatorChar + Culture.file_name;
            incuded_files_list[0] = draft_file_name; 
            if (! System.IO.File.Exists( draft_file_name )){
                throw new FileNotFoundException( draft_file_name );
            }
            draft_culture = new pl2.data.Draft(); 
            draft_culture.ReadXml(draft_file_name);
        }

    }

}
