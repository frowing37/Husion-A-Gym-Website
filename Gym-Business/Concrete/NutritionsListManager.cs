using System;
using Gym_Business.Abstract;
using Gym_Data.Abstract;
using Gym_Entity.Concrete;

namespace Gym_Business.Concrete
{
    public class NutritionsListManager : INutritionsListService
    {
        public INutritionsListDAL _nutritionsListDal;

        public NutritionsListManager(INutritionsListDAL nutritionsListDal)
        {
            _nutritionsListDal = nutritionsListDal;
        }

        public void SDelete(NutritionsList s)
        {
            _nutritionsListDal.Delete(s);
        }

        public NutritionsList SGetByID(int ID)
        {
            return _nutritionsListDal.GetByID(ID);
        }

        public List<NutritionsList> SGetList()
        {
            return _nutritionsListDal.GetList();
        }

        public void SInsert(NutritionsList s)
        {
            _nutritionsListDal.Insert(s);
        }

        public void SUpdate(NutritionsList s)
        {
            _nutritionsListDal.Update(s);
        }
    }
}

