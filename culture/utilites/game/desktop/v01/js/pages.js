            function set_page(page_no)
            {
                   window.document.getElementById("settings").style.display="none";
                   window.document.getElementById("select_source").style.display="none";
                   window.document.getElementById("debug_source").style.display="none";
                   window.document.getElementById("estimate_knowlange").style.display="none";
                   window.document.getElementById("show_results").style.display="none";
                   window.document.getElementById("show_contacts").style.display="none";
                   local_form_id = page_no;
                   switch (local_form_id){
                       case 1:
                           window.document.getElementById("settings").style.display="block";
                           break;
                       case 2:
                           window.document.getElementById("select_source").style.display="block";
                           break;
                       case 3:
                           window.document.getElementById("debug_source").style.display="block";
                           break;
                       case 4:
                           window.document.getElementById("estimate_knowlange").style.display="block";
                           break;
                       case 5:
                           window.document.getElementById("show_results").style.display="block";
                           break;
                       case 6:
                           window.document.getElementById("show_contacts").style.display="block";
                           break;
                    }
            }                                    

            function start_settings_timer(r)
            {
                window.document.getElementById("kw_lang").value = "  ";
                window.document.getElementById("example").value = "   ";
                window.setTimeout("set_page(1)", r==1 ? 100 : 5000 );
            }

            function settings_change_language()
            {
                let local_language_value = window.document.getElementById("kw_lang").value;
                if (local_language_value=="kw") window.document.getElementById("rainbow").innerText="Ӧшкамӧшка";
                if (local_language_value=="en") window.document.getElementById("rainbow").innerText="Rainbow";
                if (local_language_value=="ru") window.document.getElementById("rainbow").innerText="Радуга";
                if (local_language_value=="tt") window.document.getElementById("rainbow").innerText="Салават күпере";
                set_page(2);
                if (window.document.getElementById("example").value == "")
                {
                    window.document.getElementById("example").value = "000";
                    source_change();
                }
            }

            function source_change()
            {
                local_example_id = window.document.getElementById("example").value;
                set_page(3);
                show_source();
            }
