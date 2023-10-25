using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface ICartRepository
    {
       public  string AddCart(CartModel model);
      
      
        string RemoveCart(int CartId);
        string UpdateCart(CartModel model);
        List<CartModel> GetAllCarts();
        CartModel GetCart(int CartId);
    }
}
