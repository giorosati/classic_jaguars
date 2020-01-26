using System;
using System.Collections.Generic;

//added these using statements after looknig at Quoc & David's project
using System.ComponentModel.DataAnnotations;
using System.Linq;

//added to tweak the display of enums - had to add this to references in the solution explorer
using System.Runtime.Serialization;
using System.Web;
using System.Web.UI.WebControls;

namespace Classic_Jaguar_MVC_App.Models
{
    public class car
    {
        [Key]
        public int ModelId { get; set; }

        [Required]
        public string ModelName { get; set; }

        public int? FirstYear { get; set; }
        public int? LastYear { get; set; }

        public int? UnitsProduced { get; set; }

        [Required]
        public string Description { get; set; }

        public string Synopsis { get; set; }
        public string ImgUrl { get; set; }
        public DateTime? DateDeleted { get; set; }
        public DateTime DateCreated { get; set; }

        //virtual lists
        public virtual List<transaction> Transactions { get; set; }
    }
}