using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using weby2019.data;

namespace weby2019.service
{
    public class Service
    {
        public lednička dice = new lednička();
        public void Start()//TODO tady vytáhnuto to slovo z databáze
        {
            if ( dice.hadane == dice.uhodnute | dice.hadane[1] == null)
            {
                string input = "šiškasuper";//todo vem z databaze 
                dice.hadane = Regex.Split(input, string.Empty);
                dice.pocetpismen = (dice.hadane.Length-1);
            }
        }
        public void Kontrola(string pismenko)
        {

            for( int i = 1; i <= dice.pocetpismen; i++ )
            {
                if( pismenko == dice.hadane[i])
                {
                    dice.uhodnute[i] = pismenko;
                }
            }
        }
        public lednička vem()
        {
            return dice;
        }
    }
}
