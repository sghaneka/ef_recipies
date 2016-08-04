using EF.DataAccess.Contexts;
using EF.DataAccess.MigrationsBaga;
using EF.DataAccess.Models.Baga;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console
{
    public static class Baga
    {
        public static void AccessLaDataBagaFluent()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BreakAwayContextFluent,
                EF.DataAccess.MigrationsBagaFluent.Configuration>());

            var destination = new EF.DataAccess.Models.Baga_Fluent.Destination
            {
                Country = "Indonesia",
                Description = "EcoTourism at its best in exquisite Bali",
                Name = "Bali"
            };

            using (var context = new BreakAwayContextFluent())
            {
                context.Destinations.Add(destination);
                context.SaveChanges();
            }

            var trip = new EF.DataAccess.Models.Baga_Fluent.Trip
            {
                CostUSD = 800,
                StartDate = new DateTime(2011, 9, 1),
                EndDate = new DateTime(2011, 9, 14)
            };
            using (var context = new BreakAwayContextFluent())
            {
                context.Trips.Add(trip);
                context.SaveChanges();
            }

            using (var context = new BreakAwayContextFluent())
            {
                context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
                var tmp = context.Trips.FirstOrDefault();
                tmp.CostUSD = 7551;
                context.SaveChanges();
            }

            // can't insert primary key again...
            //var person = new EF.DataAccess.Models.Baga_Fluent.Person
            //{
            //    FirstName = "Rowan",
            //    LastName = "Miller",
            //    SocialSecurityNumber = 123232309
            //};

            //using (var context = new BreakAwayContextFluent())
            //{
            //    context.People.Add(person);
            //    context.SaveChanges();
            //}
        }

        public static void AccessLaDataBaga()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<PoetryModelContext, Configuration>());
            //using (PoetryModelContext ctx = new PoetryModelContext())
            //{
            //    var Poets = ctx.Poets.ToList();
            //}

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BreakAwayContext, Configuration>());

            var destination = new Destination
            {
                Country = "Indonesia",
                Description = "EcoTourism at its best in exquisite Bali",
                Name = "Bali"
            };

            using (var context = new BreakAwayContext())
            {
                context.Destinations.Add(destination);
                context.SaveChanges();
            }

            var trip = new Trip
            {
                CostUSD = 800,
                StartDate = new DateTime(2011, 9, 1),
                EndDate = new DateTime(2011, 9, 14)
            };
            using (var context = new BreakAwayContext())
            {
                context.Trips.Add(trip);
                context.SaveChanges();
            }

            //var person = new Person
            //{
            //    FirstName = "Rowan",
            //    LastName = "Miller",
            //    SocialSecurityNumber = 123232309
            //};

            //using (var context = new BreakAwayContext())
            //{
            //    context.People.Add(person);
            //    context.SaveChanges();
            //}

            using (var context = new BreakAwayContext())
            {
                var tmp = context.Trips.FirstOrDefault();
                tmp.CostUSD = 750;
                context.SaveChanges();
            }

        }
    }
}
