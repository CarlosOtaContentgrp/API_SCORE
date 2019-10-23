using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API.Models
{
    /// <summary></summary>
    public class Points
    {
        /// <summary>Gets or sets the poin identifier.</summary>
        /// <value>The poin identifier.</value>
        public int Poin_Id { get; set; }
        /// <summary>Gets or sets the poin date.</summary>
        /// <value>The poin date.</value>
        public DateTime Poin_Date { get; set; }
        /// <summary>Gets or sets the quantity points.</summary>
        /// <value>The quantity points.</value>
        public int Quantity_Points { get; set; }
        /// <summary>Gets or sets the user identifier.</summary>
        /// <value>The user identifier.</value>
        public string User_Id { get; set; }
        /// <summary>Gets or sets the ty po identifier.</summary>
        /// <value>The ty po identifier.</value>
        public int TyPo_Id { get; set; }
    }
}