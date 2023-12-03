using System;
using System.ComponentModel.DataAnnotations;

namespace Gym_Entity.Concrete
{
	public class Target
	{
		[Key]
		public int ID { get; set; }

		public string TargetName { get; set; }

		public List<ExercisesList> ExercisesLists { get; set; }

		public List<NutritionsList> NutritionsLists { get; set; }
	}
}

