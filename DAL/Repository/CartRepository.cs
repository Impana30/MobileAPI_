using Entity_Layer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly MobileDbContext _MobileDbContext;
        public CartRepository(MobileDbContext MobileDbContext)
        {
            _MobileDbContext = MobileDbContext;
        }
        public string AddCart(CartModel model)
        {
            _MobileDbContext.CartModels.Add(model);
            _MobileDbContext.SaveChanges();
            return "Added";

        }

        public string RemoveCart(int CartId)
        {
            CartModel CartModel = _MobileDbContext.CartModels.Find(CartId);
            _MobileDbContext.CartModels.Remove(CartModel);
            _MobileDbContext.SaveChanges();
            return "Removed";
        }

        
        public string UpdateCart(CartModel Model)

        {
            _MobileDbContext.Entry(Model).State = EntityState.Modified;
            _MobileDbContext.SaveChanges();
            return "update";
        }
        public List<CartModel> GetAllCarts()
        {
            List<CartModel> list = _MobileDbContext.CartModels.Include(o=>o.mobile).ToList();
            return list;

        }
        public CartModel GetCart(int CartId)
        {
            CartModel Model = _MobileDbContext.CartModels.Find(CartId);
            return Model;
        }
    }
}
