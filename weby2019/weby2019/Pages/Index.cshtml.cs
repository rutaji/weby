using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using weby2019.service;
using weby2019.data;
using System.ComponentModel.DataAnnotations;

namespace weby2019.Pages
{
    public class IndexModel : PageModel
    {
        public Service Servisak { get; set; }

        public  lednička dice { get; set; }

        public void OnGetKamen()
        {
            Servisak.Start();
            dice = Servisak.vem();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
               
                Servisak.Kontrola(Input.pismeno);

            }
            dice = Servisak.vem();
            return Page();
        }

        public IndexModel(Service servisak)
        {
            Servisak = servisak;
        }
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [StringLength(1)]
            public string pismeno { get; set; }
        }
        public void OnGet()
        {
            Input = new InputModel();
            dice = Servisak.vem();
            Servisak.Start();

        }

    }
}
