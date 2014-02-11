using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class House
    {
        [Key]
        [ScaffoldColumn(false)]
        public int HouseID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string HouseName { get; set; }

        [Required, StringLength(10000), Display(Name = "House Description"),
    DataType(DataType.MultilineText)]
        public string HouseDescription { get; set; }


        public int docID { get; set; }
    }
}