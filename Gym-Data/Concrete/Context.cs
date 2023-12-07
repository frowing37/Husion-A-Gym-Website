using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Gym_Entity.Concrete;
using Azure.Identity;

namespace Gym_Data.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:ecmece.database.windows.net,1433;Initial Catalog=Husion;Persist Security Info=False;User ID=ecmece;Password=e6C3m2-otuZyedi;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=60;");
        }

        DbSet<AntrenorAdvisor> antrenorAdvisors { get; set; }

        DbSet<ExercisesList> exercisesLists { get; set; }

        DbSet<Message> messages { get; set; }

        DbSet<NutritionsList> nutritionsLists { get; set; }

        DbSet<Target> targets { get; set; }
    }
}

