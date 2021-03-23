using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FireFlyFireworks.Data;

namespace FireFlyFireworks.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FireFlyFireworksContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FireFlyFireworksContext>>()))
            {
                // Look for any movies.
                if (context.Customer.Any())
                {
                    return;   // DB has been seeded
                }

                context.Customer.AddRange(
                    new Customer { FirstMidName = "Reba", LastName = "McEntire", OrderDate = DateTime.Parse("2020-12-11") },

                    new Customer { FirstMidName = "Buddy", LastName = "Holly", OrderDate = DateTime.Parse("2020-12-01") },

                    new Customer { FirstMidName = "Dolly", LastName = "Parton", OrderDate = DateTime.Parse("2020-11-01") },

                    new Customer { FirstMidName = "Megan", LastName = "TheeStallion", OrderDate = DateTime.Parse("2020-11-01") },

                    new Customer { FirstMidName = "Johnny", LastName = "Cash", OrderDate = DateTime.Parse("2020-12-01") },

                    new Customer { FirstMidName = "Tammy", LastName = "Wynette", OrderDate = DateTime.Parse("2020-11-01") },

                    new Customer { FirstMidName = "Doja", LastName = "Cat", OrderDate = DateTime.Parse("2020-12-01") },

                    new Customer { FirstMidName = "Stevie", LastName = "Nicks", OrderDate = DateTime.Parse("2020-09-01") },

                    new Customer { FirstMidName = "Cardi", LastName = "B", OrderDate = DateTime.Parse("2020-09-01") }
                );
                context.SaveChanges();

             



                context.Color.AddRange(


                new Color { ColorID = 6002, ColorName = "Rose Pink", Price = 25.55, ColorFamID = 1, ColorFamName = "Red" },
                new Color { ColorID = 6121, ColorName = "Saturn Orange", Price = 14.18, ColorFamID = 2, ColorFamName = "Orange" },
                new Color { ColorID = 6404, ColorName = "Vanadium", Price = 32.27, ColorFamID = 3, ColorFamName = "Yellow" },
                new Color { ColorID = 6166, ColorName = "Camel Beige", Price = 14.00, ColorFamID = 2, ColorFamName = "Orange" },
                new Color { ColorID = 6006, ColorName = "Deep Crimson", Price = 25.00, ColorFamID = 1, ColorFamName = "Red" },
                new Color { ColorID = 6020, ColorName = "Alumina Pink", Price = 14.45, ColorFamID = 1, ColorFamName = "Red" },
                new Color { ColorID = 6126, ColorName = "Hazelnut", Price = 17.27, ColorFamID = 2, ColorFamName = "Orange" }
               );
                context.SaveChanges();


                    

                context.Order.AddRange(

                new Order { ColorID = 6002, CustomerID = 0001 },
                new Order { ColorID = 6121, CustomerID = 0002 },
                new Order { ColorID = 6404, CustomerID = 0003 },
                new Order { ColorID = 6002, CustomerID = 0004 },
                new Order { ColorID = 6166, CustomerID = 0005 },
                new Order { ColorID = 6006, CustomerID = 0006 },
                new Order { ColorID = 6166, CustomerID = 0007 },
                new Order { ColorID = 6006, CustomerID = 0008 },
                new Order { ColorID = 6006, CustomerID = 0009 }

       );
                context.SaveChanges();



                context.Chem.AddRange(

               new Chem { ChemID = 101, ChemComp = "Chromium, Strontium", ChemAbbrev = "CrSn", ColorID = 6002, WarehouseLocationID = 1 },
               new Chem { ChemID = 102, ChemComp = "Chromium, Iron, Zinc, Aluminum, Silicon", ChemAbbrev = "CrFeZnAlSi", ColorID = 6404, WarehouseLocationID = 2 },
               new Chem { ChemID = 103, ChemComp = "Strontium, Vanadium", ChemAbbrev = "SnV", ColorID = 6404, WarehouseLocationID = 2 },
               new Chem { ChemID = 104, ChemComp = "Chromium, Iron, Zinc, Aluminum, Cobalt, Manganese", ChemAbbrev = "CrFeZnAlCoMn", ColorID = 6166, WarehouseLocationID = 3 },
               new Chem { ChemID = 105, ChemComp = "Manganese, Aluminum", ChemAbbrev = "MnAl", ColorID = 6020, WarehouseLocationID = 1 },
               new Chem { ChemID = 106, ChemComp = "Chromium, Iron, Zinc, Aluminum", ChemAbbrev = "CrFeZnAl", ColorID = 6126, WarehouseLocationID = 3 },
               new Chem { ChemID = 107, ChemComp = "Chromium, Strontium", ChemAbbrev = "CrSn", ColorID = 6006, WarehouseLocationID = 2 }
               );
                context.SaveChanges();

            }
        }
    }
}
    


