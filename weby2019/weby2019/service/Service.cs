using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace weby2019.service
{
    public class Service
    {
        public string[] hadane =new string[40]  ;
        public string[] uhodnute = new string[40] ;
        public int pocetpismen;
        public void Start()//TODO tady vytáhnuto to slovo z databáze
        {
            if ( hadane == uhodnute | hadane[1] == null)
            {
                string input = "šiškasuper";//todo vem z databaze 
                hadane = Regex.Split(input, string.Empty);
                pocetpismen = (hadane.Length-1);
            }
        }
        public void Kontrola(string pismenko)
        {
            for( int i = 1; i <= pocetpismen; i++ )
            {
                if( pismenko == hadane[i])
                {
                    uhodnute[i] = pismenko;
                }
            }
        }
    }
}
