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
                        DiscoveryDate = DateTime.Parse("1689-2-12")
                    },
                    new Magnet
                    {
                        Type = "Artificial Permanent Magnets",
                        Material = "Soft iron ",
                        Use = "Electric Motors and Generators",
                        Strength = "1.0 to 1.4 Tesla",                       
                        DiscoveryDate = DateTime.Parse("1930-08-06")
                    },
                      new Magnet
                      {
                          Type = "Temporary Magnets",
                          Material = "Soft iron ",
                          Use = "Magnetic Sorting in Recycling",
                          Strength = "Generally weaker than their counterparts",
                          DiscoveryDate = DateTime.Parse("1963-4-19")
                      },
                        new Magnet
                        {
                            Type = "Electromagnets",
                            Material = "Soft iron ",
                            Use = "Magnetic Resonance Imaging",
                            Strength = "Number of Turns in the Coil",                            
                            DiscoveryDate = DateTime.Parse("1820-12-06")
                        },
                          new Magnet
                          {
                              Type = "Superconducting Magnets",
                              Material = "Superconducting materials ",
                              Use = "electron beams in synchrotrons",
                              Strength = "Brightness , Current",                            
                              DiscoveryDate = DateTime.Parse("1911-6-24")
                          }
                    );
                context.SaveChanges();
                }
            }
        }
    }

