using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Enums;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2022,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2021,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                }
            };

            // Students
            modelBuilder.Entity<Student>().HasData(students);

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher {
                    Id=Guid.NewGuid(),
                    FirstName = "Kevin",
                    LastName = "Krumpli",
                    IsHeadTeacher=true,
                    BirthsDay = new DateTime(2005, 09, 18),
                    IsWoman = false
                },
                new Teacher
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Marcell",
                    LastName = "Matematika",
                    IsHeadTeacher=false,
                    BirthsDay = new DateTime(2005, 10, 10),
                    IsWoman=false
                }
            };
            modelBuilder.Entity<Teacher>().HasData(teachers);

            List<Parent> parents = new List<Parent>
            {
                new Parent
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Kevin",
                    LastName = "Bognár",
                    IsWoman = false,
                    Residence = "Bálint Sándor utca 4 1/2"
                },
                new Parent {
                    Id = Guid.NewGuid(),
                    FirstName = "Marcell",
                    LastName = "Szabó",
                    IsWoman = true,
                    Residence = "Újvidéki utca 45"
                }
            };
            modelBuilder.Entity<Parent>().HasData(parents);
            List<Admin> admins = new List<Admin>
            {
                new Admin
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Aladár",
                    LastName = "Admin",
                    IsWoman = false,
                    IssuesSolved = 20,
                    Pay = 400000,
                    Age = 24
                },
                new Admin
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Anna",
                    LastName = "Admin",
                    IsWoman = true,
                    IssuesSolved = 30,
                    Pay = 280000,
                    Age = 26
                }
            };
            modelBuilder.Entity<Admin>().HasData(admins);
            List<Driver> drivers = new List<Driver> {
                new Driver {
                    Id = Guid.NewGuid(),
                    FirstName = "Alattomos",
                    LastName = "Alabárd",
                    Trips = 100,
                    Rating = 3.2,
                    Balance = 150000,
                    AccountNumber = "564486-955645-842246",
                    IsAdmin = false,
                    IsWoman= false,
                },
                new Driver {
                    Id = Guid.NewGuid(),
                    FirstName = "Biztonságos",
                    LastName = "Balázs",
                    Trips = 140,
                    Rating = 5.0,
                    Balance = 300000,
                    AccountNumber = "777777-777777-777770",
                    IsWoman = false,
                    IsAdmin = true,
                }
            };
            modelBuilder.Entity<Driver>().HasData(drivers);
            List<Passenger> passengers = new List<Passenger> {
                new Passenger {
                    Id = Guid.NewGuid(),
                    FirstName = "Hangos",
                    LastName = "Henrik",
                    Trips = 10,
                    Balance = 15000,
                    IsWoman = false,
                    IsAdmin = false
                },
                new Passenger {
                    Id = Guid.NewGuid(),
                    FirstName = "Barátságos",
                    LastName = "Bernadett",
                    Trips = 140,
                    Balance = 30000,
                    IsWoman = true,
                    IsAdmin = false
                }
            };
            modelBuilder.Entity<Passenger>().HasData(passengers);
        }
    }
}
