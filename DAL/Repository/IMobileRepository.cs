using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IMobileRepository
    {
        string AddMobile(MobileModel Mobile);
            
        string UpdateMobile(MobileModel Mobile);
        string DeleteMobile(int MobileId);
        MobileModel GetMobile(int MobileId);
        List<MobileModel> GetAllMobiles();
        string DeleteMobile(int v, object MobileId);
    }
    


}