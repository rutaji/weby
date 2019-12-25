using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using weby2019.data;
using weby2019.models;

namespace weby2019.service
{
    public class Service
    {
        public Random r = new Random();
        public lednička dice = new lednička();
        public void Start()//TODO tady vytáhnuto to slovo z databáze
        {
             //if ( dice.hadane == dice.uhodnute | dice.hadane[1] == null)
             //{
            var db = new MainDbContext();
            dice.početchyb = 0;
            Array.Clear(dice.uhodnute, 0, dice.uhodnute.Length);
            Array.Clear(dice.zkoušene, 0, dice.zkoušene.Length);
            int i = r.Next(50);
            foreach (var s in db.Slova.ToList())
                 {
                     if (s.Id == i)
                     {
                         string input = s.Name;//todo vem z databaze 

                         dice.hadane = Regex.Split(input, string.Empty);

                         dice.pocetpismen = (dice.hadane.Length - 1);
                     }
                 }
             //}
            ;
        }
        public void  Kontrola(string pismenko)
        {
            bool f = true;
            for(int y = 1; true; y++)
            {
                if (dice.zkoušene[y] == null)
                {
                    
                    dice.zkoušene[y] = pismenko;
                    for (int i = 1; i <= dice.pocetpismen; i++)
                    {
                        if (pismenko == dice.hadane[i])
                        {
                            dice.uhodnute[i] = pismenko;
                            f = false;
                        }
                    }
                    if (f) { dice.početchyb++; }
                    break; 
                }
                if (dice.zkoušene[y] == pismenko)
                {
                    break;
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
