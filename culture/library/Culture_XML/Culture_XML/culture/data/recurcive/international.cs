using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace pl2.culture
{
    class International
    {
        public string culture_path { get; set; }

        public Int32 output_code_page { get; set; }

        private string draft_path { get; set; }

        private pl2.culture.data.National[] culture_collection;

        private string[] incuded_files_list; 

        public string translate(string source_term, string target_path)
        {
            string result_value;
            result_value = find_intrenational_value(source_term, target_path);
            return result_value;
        }

        string find_intrenational_value(string source_draft_term, string target_path)
        {
               return source_draft_term;
        }        
       
        public string value(string source_draft_term, string target_path)
        {
            string result_value = source_draft_term;
            // result_value = draft_value(source_draft_term);
            return result_value;
        }

        public International(string culture_path_parameter)
        {
            string culture_file_name;
            culture_path = culture_path_parameter;
            culture_file_name = culture_path_parameter + "\\culture.xml";
            if (!System.IO.File.Exists( culture_file_name ))
            {
                throw new FileNotFoundException( culture_file_name );
            }
            // international_culture = new pl2.data.International();
            // international_culture.ReadXml( culture_file_name );
        }

    }

}
