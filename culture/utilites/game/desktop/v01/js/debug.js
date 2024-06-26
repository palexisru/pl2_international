    function show_source()
    {
        window.document.getElementById("program_name").innerText = example_list[Number.parseInt(local_example_id)].name;
        window.document.getElementById("program_code").innerHTML = "<TR><TD>&nbsp;</TD></TR>";
        debug_restart(); 
    }

    function debug_one_step()
    {
        if (local_debug_position == 0){
            local_debug_position = 1;
            execute_code();
        }
        else
        {
            local_debug_string = local_debug_string + 1;
            local_debug_position = 0;
        }
        debug_show_step();
    }
                     
    function debug_restart()
    {
        local_debug_string = 0;
        local_debug_position = 0;
        console_output = "";
        debug_show_step();
    }

    function debug_show_step()
    {
        ex = example_list[Number.parseInt(local_example_id)];
        t = "";
        for (c = 0; c < ex.code.length ; ++c)
        {
            t = t + "<TR>";
            color = (c == local_debug_string) ? 'green' : 'white';
            t = t + '<TD style="background-color:' + (local_debug_position == 0 ? color : 'white') + '">&nbsp;</TD>' ;
            t = t + "<TD>" + ex.code[c] + '</TD>';
            t = t + '<TD style="background-color:' + (local_debug_position == 1 ? color : 'white') + '">&nbsp;</TD></TR>';
        }
        window.document.getElementById("program_code").innerHTML = t;
        window.document.getElementById("program_output").innerHTML = console_output;
    }

    function debug_next_program()
    {
        local_example_id = example_list[Number.parseInt(local_example_id)+1].id;
        window.document.getElementById("example").value = local_example_id;
        show_source();     
    }
