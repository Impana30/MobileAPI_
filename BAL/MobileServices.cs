using DAL;
using DAL.Repository;
using Entity_Layer;
using Microsoft.EntityFrameworkCore;

namespace BAL
{
    public class MobileServices
    {
        public readonly IMobileRepository _MobileRepository;

        public MobileServices(IMobileRepository MobileRepository)
        {
            _MobileRepository = MobileRepository;
        }
        public string AddMobile(MobileModel Mobile)
        {
            string result = _MobileRepository.AddMobile(Mobile);
            return "Added";


        }
        public string DeleteMobile(int MobileId)
        {
            string result = _MobileRepository.DeleteMobile(MobileId);
            return "Deleted";


        }
        public List<MobileModel> GetAll()
        {
            List<MobileModel> list = _MobileRepository.GetAllMobiles();
            return list;
        }
        public MobileModel GetMobile(int MobileId)
        {
            MobileModel Mobile = _MobileRepository.GetMobile(MobileId);
            return Mobile;
        }

        public object GetMobile(object MobileId)
        {
            throw new NotImplementedException();
        }

        public string UpdateMobile(MobileModel Mobile)
        {
            string result = _MobileRepository.UpdateMobile(Mobile);
            return "Added";


        }











    }
}