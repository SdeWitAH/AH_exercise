using AHExercise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHExercise.DAL
{
    public class DatabaseContext_ : DbContext
    {

        // TODO 2 : Fill in the missing code : 

        public DbSet<Company> Companies { get; set; }
        public DatabaseContext_(DbContextOptions<DatabaseContext_> options) : base(options)
        {
        }


        public void CreateTestData()
        {
            // Create company test data
            List<Company> Companys = new List<Company>();
            Company c1 = new Company
            {
                Id = 1,
                Name = "AH- Automatisering"
            };
            Company c2 = new Company
            {
                Id = 1,
                Name = "Test bedrijf"
            };
            Companys.Add(c1);
            Companys.Add(c2);

            this.Add(Companys);
            this.SaveChanges();
            /////////////////////////////




        }
    }
}
