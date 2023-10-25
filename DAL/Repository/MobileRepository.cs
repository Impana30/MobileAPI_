using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL;
using DAL.Repository;

namespace DAL.Repository
{
    //RepositorPattern
    // DI Pattern (Dependency injection)
    public class MobileRepository : IMobileRepository
    {
        private readonly MobileDbContext _MobileDbContext;
        public MobileRepository(MobileDbContext MobileDbContext)
        {
            _MobileDbContext = MobileDbContext;
        }
        public string AddMobile(MobileModel Mobile)
        {
            _MobileDbContext.MobileModels.Add(Mobile);
            _MobileDbContext.SaveChanges();
            return "Added";

        }




        public string DeleteMobile(int MobileId)
        {
            MobileModel MobileModel = _MobileDbContext.MobileModels.Find(MobileId);
            _MobileDbContext.MobileModels.Remove(MobileModel);
            _MobileDbContext.SaveChanges();
            return "Deleted";
        }

        public string DeleteMobile(int v, object MobileId)
        {
            throw new NotImplementedException();
        }

        public List<MobileModel> GetAllMobiles()
        {
            List<MobileModel> list = _MobileDbContext.MobileModels.ToList();
            return list;

        }

        public MobileModel GetMobile(int MobileId)
        {
            MobileModel Mobile= _MobileDbContext.MobileModels.Find(MobileId);
            return Mobile;
        }

        public string UpdateMobile(MobileModel Mobile)
           
        {
            _MobileDbContext.Entry(Mobile).State = EntityState.Modified;
            _MobileDbContext.SaveChanges();
            return "update";
        }
    }



}
