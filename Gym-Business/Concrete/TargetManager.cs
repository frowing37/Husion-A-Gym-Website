using System;
using Gym_Business.Abstract;
using Gym_Data.Abstract;
using Gym_Entity.Concrete;

namespace Gym_Business.Concrete
{
    public class TargetManager : ITargetService
    {
        public ITargetDAL _targetDal;

        public TargetManager(ITargetDAL targetDal)
        {
            _targetDal = targetDal;
        }

        public void SDelete(Target s)
        {
            _targetDal.Delete(s);
        }

        public Target SGetByID(int ID)
        {
            return _targetDal.GetByID(ID);
        }

        public List<Target> SGetList()
        {
            return _targetDal.GetList();
        }

        public void SInsert(Target s)
        {
            _targetDal.Insert(s);
        }

        public void SUpdate(Target s)
        {
            _targetDal.Update(s);
        }
    }
}

