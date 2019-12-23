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
           /* if ( dice.hadane == dice.uhodnute | dice.hadane[1] == null)
            {
                
            }*/
        }
        public void  Kontrola(string pismenko)
        {

            for( int i = 1; i <= dice.pocetpismen; i++ )
            {
                if( pismenko == dice.hadane[i])
                {
                    dice.uhodnute[i] = pismenko;
                }
            }
           // return dice;
        }
        public lednička vem()
        {
            return dice;
        }
    }
}
