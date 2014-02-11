using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalProject.Models
{
    public class HouseDatabaseInitializer :
    DropCreateDatabaseIfModelChanges<HouseContext>
    {
        protected override void Seed
        (HouseContext context)
        {

            GetHouses().ForEach(
            p => context.House.Add(p));
        }

        private static List<House> GetHouses()
        {
            var houses = new List<House> {
            new House {
            HouseID = 1,
            HouseName = "Test House 1",
            HouseDescription = "One of the best industrial buildings in the world",
            docID = 1
            }
            };


            return houses;
        }
    }
}