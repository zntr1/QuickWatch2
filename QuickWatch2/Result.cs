using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickWatch2
{
    public class Result
    {
        public string Title { get; set; }
        public string Link { get; set; }
       

        // Leeres Result, standard Constructor
        public Result(){
            

        }

        public Result(string title, string link){
            Title = title;
            Link = link;
        }


    }
}
