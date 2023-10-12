using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MadMagnets.Models
{
    public class Magnet
    {

        //Properties  of magnet with their getters and setters
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Type { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string Material { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string Use { get; set; }
       
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]

        public string Strength { get; set; }


        [Display(Name = "Discovery Date")]
        [DataType(DataType.Date)]
        public DateTime DiscoveryDate { get; set; }

    }
}
