using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Gym_Entity.Concrete;

namespace Gym_Entity.Concrete
{
	public class ExercisesList
	{
        [Key]
		public int ID { get; set; }

		public string ListName { get; set; }

		public string Work1 { get; set; }

        public string Work2 { get; set; }

        public string Work3 { get; set; }

        public string Work4 { get; set; }

        public string Work5 { get; set; }

        public DateTime ProgramStartDate { get; set; }

        public DateTime ProgramFinishDate { get; set; }

        public double CaloriBurnedTarget { get; set; }

        [ForeignKey("Target")]

        public int TargetID { get; set; }

        public Target Target { get; set; }
    }
}

