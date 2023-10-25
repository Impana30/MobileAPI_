using DAL.Repository;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class CartServices
    {
        public readonly ICartRepository _CartRepository;

        public CartServices(ICartRepository CartRepository)
        {
            _CartRepository = CartRepository;
        }
        public string AddCart(CartModel Model)
        {
            string result = _CartRepository.AddCart(Model);
            return "Added";


        }
        public string RemoveCart(int CartId)
            
        {
            string result = _CartRepository.RemoveCart(CartId);
            return "Removed";


        }
        public string UpdateCart(CartModel Model)
        {
            string result = _CartRepository.UpdateCart(Model);
            return "updated";


        }
        public List<CartModel> GetAllCarts()
        {
            List<CartModel> list = _CartRepository.GetAllCarts();
            return list;
        }
        public CartModel GetCart(int CartId)
        {
            CartModel Model = _CartRepository.GetCart(CartId);
            return Model;
        }

    }
}
