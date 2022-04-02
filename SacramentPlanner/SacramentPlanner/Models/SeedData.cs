using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentPlanner.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SacramentPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentPlannerContext(
                serviceProvider.GetRequiredService<DbContextOptions<SacramentPlannerContext>>()))
            {
                // looking for existing meetings
                if (context.SacramentMeeting.Any()) return;

                // constants
                string bishop = "Bishop John Doe";
                string pianist = "Jon Schmidt";
                string chorister = "Mack Wilberg";

                context.SacramentMeeting.AddRange(
                    new SacramentMeeting
                    {
                        MeetingDate = DateTime.Parse("2022/3/6"),
                        Presiding = bishop,
                        Conducting = bishop,
                        Pianist = pianist,
                        Chorister = chorister,
                        OpeningHymn = "#193 I Stand All Amazed",
                        Invocation = "Brother Jim Henson",
                        SacramentHymn = "#172 In Humility, Our Savior",
                        Talks = new List<string>()
                        {
                            "Moe Howard - Power of Prayer",
                            "Curly DeRita - The Word of Wisdom",
                            "Larry Fine - Follow the Prophet"
                        },
                        IntermediateHymnIndex = 2,
                        IntermediateHymn = "#27 Praise to the Man",
                        ClosingHymn = "#302 If You Could Hie to Kolob",
                        Benediction = "Sister Jane Nebel"
                    },
                    new SacramentMeeting
                    {
                        MeetingDate = DateTime.Parse("2022/3/13"),
                        Presiding = bishop,
                        Conducting = "Brother Joe Blow",
                        Pianist = pianist,
                        Chorister = chorister,
                        OpeningHymn = "#86 How Great Thou Art",
                        Invocation = "Brother Daniel Needleman",
                        SacramentHymn = "#142 Sweet Hour of Prayer",
                        Talks = new List<string>()
                        {
                            "Sister Celia Mae - Faith and Fiery Serpents",
                            "Brother James Sullivan - Fighting the Monster of Sin",
                            "Brother Mike Wazowski - An Eye Single to the Glory of God"
                        },
                        ClosingHymn = "#227 There Is Sunshine in My Soul Today",
                        Benediction = "Brother Stephen Smitty"
                    },
                    new SacramentMeeting
                    {
                        MeetingDate = DateTime.Parse("2022/3/20"),
                        Presiding = bishop,
                        Conducting = "Brother James Row",
                        Pianist = pianist,
                        Chorister = chorister,
                        OpeningHymn = "#19 We Thank Thee Oh God for a Prophet",
                        Invocation = "Brother Rick Dicker",
                        SacramentHymn = "#193 I Stand All Amazed",
                        Talks = new List<string>()
                        {
                            "Sister Violet Parr - Daughters in Zion",
                            "Brother Dash Parr - Preparing for a Mission",
                            "Sister Helen Truax-Parr - Mary the Mother of Jesus",
                            "Brother Bob Parr - Joseph Smith Was Incredible"
                        },
                        IntermediateHymnIndex = 2,
                        IntermediateHymn = "#301 I Am A Child of God",
                        ClosingHymn = "#85 How Firm A Foundation",
                        Benediction = "Brother Lucius Best",
                        Announcements = "Building Cleaning Assignments for this week\nNo Mutual this week\nWard Party on May 1st"
                    });
                context.SaveChanges();
            }
        }
    }
}
