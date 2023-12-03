using System;
using Gym_Business.Abstract;
using Gym_Entity.Concrete;
using Gym_Data.Abstract;

namespace Gym_Business.Concrete
{
    public class ExercisesListManager : IExercisesListService
    {
        public IExercisesListDAL _exercisesList;

        public ExercisesListManager(IExercisesListDAL exercisesList)
        {
            _exercisesList = exercisesList;
        }

        public void SDelete(ExercisesList s)
        {
            _exercisesList.Delete(s);
        }

        public ExercisesList SGetByID(int ID)
        {
            return _exercisesList.GetByID(ID);
        }

        public List<ExercisesList> SGetList()
        {
            return _exercisesList.GetList();
        }

        public void SInsert(ExercisesList s)
        {
            _exercisesList.Insert(s);
        }

        public void SUpdate(ExercisesList s)
        {
            _exercisesList.Update(s);
        }
    }
}

