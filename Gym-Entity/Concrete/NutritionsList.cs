using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym_Entity.Concrete
{
	public class NutritionsList
	{
        [Key]
        public int ID { get; set; }

        public string ListName { get; set; }

        public string MorningMeal { get; set; }

        public string Lunch { get; set; }

        public string EveningMeal { get; set; }

        public DateTime ProgramStartDate { get; set; }

        public DateTime ProgramFinishDate { get; set; }

        public double Calori { get; set; }

        [ForeignKey("Target")]

        public int TargetID { get; set; }

        public Target Target { get; set; }
    }
}

