using MadMagnets.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadMagnets.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MadMagnetsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MadMagnetsContext>>()))
            {
                // Look for any Magnets.
                if (context.Magnet.Any())
                {
                    return;   // DB has been seeded
                }

                context.Magnet.AddRange(
                    new Magnet
                    {
                        Type = "Natural Permanent Magnets",
                        Material = "lodestone ",
                        Use = "Modern technology devices",
                        Strength = "Mega Gauss Oersteds",
                        DiscoveryDate = DateTime.Parse("1689-2-12"),
                        Rating = 3
                    },
                    new Magnet
                    {
                        Type = "Artificial Permanent Magnets",
                        Material = "Soft iron ",
                        Use = "Electric Motors and Generators",
                        Strength = "1.0 to 1.4 Tesla",
                        DiscoveryDate = DateTime.Parse("1930-08-06"),
                        Rating = 2
                    },
                      new Magnet
                      {
                          Type = "Temporary Magnets",
                          Material = "Soft iron ",
                          Use = "Magnetic Sorting in Recycling",
                          Strength = "Generally weaker than their counterparts",
                          DiscoveryDate = DateTime.Parse("1963-4-19"),
                          Rating = 4
                      },
                        new Magnet
                        {
                            Type = "Electromagnets",
                            Material = "Soft iron ",
                            Use = "Magnetic Resonance Imaging",
                            Strength = "Number of Turns in the Coil",
                            DiscoveryDate = DateTime.Parse("1820-12-06"),
                            Rating = 1
                        },
                          new Magnet
                          {
                              Type = "Superconducting Magnets",
                              Material = "Superconducting materials ",
                              Use = "electron beams in synchrotrons",
                              Strength = "Brightness , Current",
                              DiscoveryDate = DateTime.Parse("1911-6-24"),
                              Rating = 2
                          },
                           new Magnet
                           {
                               Type = "Ferromagnetic Magnets",
                               Material = "Iron, cobalt, and nickel ",
                               Use = "flux multipliers forming",
                               Strength = "Strong Magnetization",
                               DiscoveryDate = DateTime.Parse("1589-5-12"),
                               Rating = 3
                           },
                           new Magnet
                           {
                               Type = "Alnico Magnets",
                               Material = "aluminum, nickel, and cobalt ",
                               Use = "guitar pickups and sensors",
                               Strength = "strong and temperature-stable",
                               DiscoveryDate = DateTime.Parse("1930-02-27"),
                               Rating = 2
                           },
                           new Magnet
                           {
                               Type = "Ceramic Magnets",
                               Material = "Iron oxide and barium ",
                               Use = "Refrigerator magnets ",
                               Strength = "good resistance to demagnetization",
                               DiscoveryDate = DateTime.Parse("1930-8-22"),
                               Rating = 1
                           },
                            new Magnet
                            {
                                Type = " Flexible Magnets",
                                Material = "ferrite powder and rubber or plastic",
                                Use = "applications where a flexible magnet is needed",
                                Strength = "flexible ",
                                DiscoveryDate = DateTime.Parse("1665-4-25"),
                                Rating = 5
                            },
                            new Magnet
                            {
                                Type = " Rare Earth Magnets",
                                Material = "neodymium magnets and samarium-cobalt magnets",
                                Use = "electronic devices, headphones",
                                Strength = "exceptionally strong magnetic fields",
                                DiscoveryDate = DateTime.Parse("1960-4-12"),
                                Rating = 3
                            });
                context.SaveChanges();
                }
            }
        }
    }

