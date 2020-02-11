using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet4.Web.Data.Entities
{
    public class PetType
    {
        public int Id { get; set; }

        [Display(Name = "Pet Type")]
        [MaxLength(50, ErrorMessage = "The {0} fiel can not have more than {1} characters")]
        [Required(ErrorMessage = "The fiel {0} is mandatory.")]
        public string Name { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
