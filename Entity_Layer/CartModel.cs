using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class CartModel
    {
        [Key]
        public int CartId { get; set; }
        
        [ForeignKey("mobile")]

        public int MobileId { get; set; }
        public MobileModel mobile { get; set; } 
        public int Quantity { get; set; }
        public int TotalPrice{ get; set; }

    }
}
