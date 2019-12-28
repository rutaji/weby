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

        public void Start()
        {
             //if ( dice.hadane == dice.uhodnute | dice.hadane[1] == null)
             //{
            var db = new MainDbContext();
            int p = db.Slova.Count();
            dice.vyhra = false;
            dice.prohra = false;            
            dice.početchyb = 0;
            Array.Clear(dice.uhodnute, 0, dice.uhodnute.Length);
            Array.Clear(dice.zkoušene, 0, dice.zkoušene.Length);
            dice.id = r.Next(p + 1) ;
            foreach (var s in db.Slova.ToList())
            {
               if (s.Id == dice.id)
               {
                    string input = s.Name;//todo vem z databaze 
                    dice.hadane = Regex.Split(input, string.Empty);
                    dice.skore = s.skore;
                    dice.pocetpismen = (dice.hadane.Length - 1);
                     break;
               }
             }
             //}
            ;
        }
        public void  Kontrola(string pismenko)
        {
            //samotmá kontrola
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
            //kontrola vítěství/prohry
            
            if (dice.početchyb == 6) { dice.prohra = true; }
            int t = 1;
            dice.vyhra = true;
            while(t < dice.pocetpismen)
            {
                if (dice.uhodnute[t] != dice.hadane[t]) { dice.vyhra = false; }
                t++;
            }
            if (dice.vyhra)
            {
                if (dice.skore > dice.početchyb)
                {
                    var db = new MainDbContext();
                    foreach (var s in db.Slova.ToList())
                    {
                        if(s.Id == dice.id) { s.skore = dice.početchyb;
                            db.SaveChanges();
                        }

                    }
                }
            }
        }
        public lednička vem()
        {
            return dice;
        }
    }
}
