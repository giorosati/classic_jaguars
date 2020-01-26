using System;
using System.Collections.Generic;

//added these using statements after looknig at Quoc & David's project
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

//added to teak the display of enums - had to add this to references in the solution explorer
using System.Runtime.Serialization;
using System.Web;
using System.Web.UI.WebControls;

namespace Classic_Jaguar_MVC_App.Models
{
    public class transaction
    {
        [Required]
        public int TransactionId { get; set; }

        //[ForeignKey("ModelID")]
        public int ModelID { get; set; }

        public virtual car car { get; set; }

        public TransType TransType { get; set; }

        public int SalePrice { get; set; }

        public DateTime DateSold { get; set; }

        public string SellerName { get; set; }

        public string SellerCountry { get; set; }

        public string BuyerName { get; set; }

        public string BuyerCountry { get; set; }

        public int CarYear { get; set; }

        public string ExtColor { get; set; }

        public string IntColor { get; set; }

        public int CarMiles { get; set; }

        public bool NumsMatch { get; set; }

        public string notes { get; set; }
    };

    public enum TransType
    {
        Auction,
        Dealer,
        Private,
        Other
    };
}