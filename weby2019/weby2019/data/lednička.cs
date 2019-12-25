using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using weby2019.models;

namespace weby2019.data
{
    public class lednička
    {
        public string[] hadane = new string[40];
        public string[] uhodnute = new string[40];
        public string[] zkoušene = new string[200];
        public int pocetpismen;
        public int početchyb = 0;

        
        public lednička()
        {
            
        }
    }
}
