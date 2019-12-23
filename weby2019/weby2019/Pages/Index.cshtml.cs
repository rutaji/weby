using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using weby2019.service;
using weby2019.data;

namespace weby2019.Pages
{
    public class IndexModel : PageModel
    {
        public Service Servisak { get; set; }

        public  lednička dice { get; set; }

        public void OnGetKamen(string s)
        {
            dice = Servisak.vem();
            
            Servisak.Kontrola(s);
            
        }

        public IndexModel(Service servisak)
        {
            Servisak = servisak;
        }
        public void OnGet()
        {

            dice = Servisak.vem();
        }

    }
}
