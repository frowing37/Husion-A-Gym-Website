using System;
using Microsoft.AspNetCore.Identity;

namespace Gym_Entity.Concrete
{
	public class AppUser : IdentityUser<int>
	{
        public string Name { get; set; }

        public string SecondName { get; set; }

        public string Surname { get; set; }

        public string Mail { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string ConfirmCod { get; set; }

        public string Gender { get; set; }
        
        public double Height { get; set; }

        public double Weight { get; set; }

        public double MussleWeight { get; set; }

        public string Experience { get; set; }

        public double BMI { get; set; }

        public bool Active { get; set; }

        public int MaxAdvisor { get; set; }
    }
}

