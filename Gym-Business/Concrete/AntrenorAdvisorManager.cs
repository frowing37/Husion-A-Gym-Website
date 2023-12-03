using System;
using Gym_Business.Abstract;
using Gym_Data.Abstract;
using Gym_Entity.Concrete;

namespace Gym_Business.Concrete
{
    public class AntrenorAdvisorManager : IAntrenorAdvisorService
    {
        public IAntrenorAdvisorDAL _antrenorAdvisorDal;

        public AntrenorAdvisorManager(IAntrenorAdvisorDAL antrenorAdvisorDal)
        {
            _antrenorAdvisorDal = antrenorAdvisorDal;
        }

        public void SDelete(AntrenorAdvisor s)
        {
            _antrenorAdvisorDal.Delete(s);
        }

        public AntrenorAdvisor SGetByID(int ID)
        {
            return _antrenorAdvisorDal.GetByID(ID);
        }

        public List<AntrenorAdvisor> SGetList()
        {
            return _antrenorAdvisorDal.GetList();
        }

        public void SInsert(AntrenorAdvisor s)
        {
            _antrenorAdvisorDal.Insert(s);
        }

        public void SUpdate(AntrenorAdvisor s)
        {
            _antrenorAdvisorDal.Update(s);
        }
    }
}

