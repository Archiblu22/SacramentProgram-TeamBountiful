using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class SacramentMeeting
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Meeting Date")]
        public DateTime MeetingDate { get; set; }

        [Required]
        public string Presiding { get; set; }

        [Required]
        public string Conducting { get; set; }

        public string Pianist { get; set; }

        public string Chorister { get; set; }

        [Required]
        [Display(Name = "Opening Hymn")]
        public string OpeningHymn { get; set; }

        [Required]
        public string Invocation { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }

        [Required]
        public List<Talk> Talks { get; set; }

        public int IntermediateHymnIndex { get; set; }

        [Display(Name = "Intermediate Hymn")]
        public string IntermediateHymn { get; set; }

        [Required]
        [Display(Name = "Closing Hymn")]
        public string ClosingHymn { get; set; }

        [Required]
        public string Benediction { get; set; }

        public string Announcements { get; set; }
    }
}
