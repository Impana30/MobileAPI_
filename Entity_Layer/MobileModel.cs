using System.ComponentModel.DataAnnotations;

namespace Entity_Layer
{
    public class MobileModel
    {
        [Key]
        public int MobileId { get; set; }
        public string MobileName { get; set; }
        public int MobilePrice { get; set; }
        public int MobileManufactured { get; set; }
       

         


    }
}