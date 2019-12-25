using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace weby2019.models
{
    public class Slovo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int skore { get; set; }
        [Required]
        public string Name { get; set; }

        public override string ToString()
        {
            return (Name);
        }
    }
}
