using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest.Models
{
    public class PersonneModel
    {
        [Required]
        public string Nom { get; set; }
        [Required]

        public string Prenom { get; set; }
        [Required]

        public int? Age { get; set; }
        
    }
}
