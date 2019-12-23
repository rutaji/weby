using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            string input = "šiškasuper";//todo vem z databaze 
            hadane = Regex.Split(input, string.Empty);
            pocetpismen = (hadane.Length - 1);
        }
    }
}
