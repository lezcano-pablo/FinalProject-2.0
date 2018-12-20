using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacrMeetPlanner.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacrMeetPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacrMeetPlannerContext>>()))
            {
                // Look for any movies.
                if (context.Meeting.Any())
                {
                    return;   // DB has been seeded
                }

                context.Meeting.AddRange(
                    new Meeting
                    {
                        Date = DateTime.Parse("1989-2-12"),
                        Conducting = "Yo solo",
                        Presiding = "Romantic Comedy",
                        FirstHimnTitle = "Hello",
                        FirstHimnNum = 2,
                        FirstPrayer= "Elias",
                        Subject= "Prayer",
                        Announcements= "Marriage",
                        FirstSpeaker= "Bishop",
                        SecondSpeaker= "Vos",
                        SecondHimnTitle= "Yo sé",
                        SecondHimnNum= 43,
                        ThirdSpeaker= "President",
                        LastHimnTitle= "No se",
                        LastHimnNum= 3,
                        LastPrayer= "Eddie"
                        
                    },

                    new Meeting
                    {
                        Date = DateTime.Parse("1989-2-12"),
                        Conducting = "Yo solo",
                        Presiding = "Romantic Comedy",
                        FirstHimnTitle = "Hello",
                        FirstHimnNum = 2,
                        FirstPrayer = "Elias",
                        Subject = "Prayer",
                        Announcements = "Marriage",
                        FirstSpeaker = "Bishop",
                        SecondSpeaker = "Vos",
                        SecondHimnTitle = "Yo sé",
                        SecondHimnNum = 43,
                        ThirdSpeaker = "President",
                        LastHimnTitle = "No se",
                        LastHimnNum = 3,
                        LastPrayer = "Eddie"
                    }

                   
                );
                context.SaveChanges();
            }
        }
    }
}
