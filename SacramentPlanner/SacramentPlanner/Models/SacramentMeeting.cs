using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class SacramentMeeting
    {
        public int Id { get; set; }

        [Display(Name = "Meeting Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MMMM dd, yyyy}")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime MeetingDate { get; set; }

        [Display(Name = "Presiding")]
        [StringLength(50, MinimumLength = 1,
            ErrorMessage = "Presider's name must be between 1 and 50 characters.")]
        [Required]
        public string Presiding { get; set; }

        [Display(Name = "Conducting")]
        [StringLength(50, MinimumLength = 1,
            ErrorMessage = "Conductor's name must be between 1 and 50 characters.")]
        [Required]
        public string Conducting { get; set; }

        [Display(Name = "Pianist")]
        [StringLength(50,
            ErrorMessage = "Pianist's name cannot be greater than 50 characters.")]
        public string Pianist { get; set; }

        [Display(Name = "Chorister")]
        [StringLength(50,
            ErrorMessage = "Chorister's name cannot be greater than 50 characters.")]
        public string Chorister { get; set; }

        [Display(Name = "Opening Hymn")]
        [StringLength(50, MinimumLength = 1,
            ErrorMessage = "Opening Hymn must be between 1 and 50 characters.")]
        [RegularExpression(@"(#?\d?\d?\d?\s)?[\w\s',;!?\-()]+",
            ErrorMessage = "Must be in one of the following formats:"
            + "\n  Title only: Praise to the Man"
            + "\n  Number, single space, title: 6 Redeemer of Israel"
            + "\n  #Number, single space, title: #204 Silent Night"
            + "\nOnly include these characters: \"# ' , ; ! ? - ( )\"")]
        [Required]
        public string OpeningHymn { get; set; }

        [Display(Name = "Invocation")]
        [StringLength(50, MinimumLength = 1,
            ErrorMessage = "Name must be between 1 and 50 characters.")]
        [Required]
        public string Invocation { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn")]
        [StringLength(50, MinimumLength = 1,
            ErrorMessage = "Sacrament Hymn must be between 1 and 50 characters.")]
        [RegularExpression(@"(#?\d?\d?\d?\s)?[\w\s',;!?\-()]+",
            ErrorMessage = "Must be in one of the following formats:"
            + "\n  Title only: Praise to the Man"
            + "\n  Number, single space, title: 6 Redeemer of Israel"
            + "\n  #Number, single space, title: #204 Silent Night"
            + "\nOnly include these characters: \"# ' , ; ! ? - ( )\"")]
        public string SacramentHymn { get; set; }

        // COLLECTION OF 0 OR MORE TALK STRINGS
        public ICollection<string> Talks { get; set; }

        [Display(Name = "Intermediate Hymn Position",
            Description = "After which speaker would you like the Intermediate Hymn? (1 = after the first speaker, 2 = after the second speaker, etc.)")]
        public int? IntermediateHymnIndex { get; set; }

        [Display(Name = "Intermediate Hymn")]
        [StringLength(50,
            ErrorMessage = "Intermediate Hymn cannot be greater than 50 characters.")]
        [RegularExpression(@"(#?\d?\d?\d?\s)?[\w\s',;!?\-()]+",
            ErrorMessage = "Must be in one of the following formats:"
            + "\n  Title only: Praise to the Man"
            + "\n  Number, single space, title: 6 Redeemer of Israel"
            + "\n  #Number, single space, title: #204 Silent Night"
            + "\nOnly include these characters: \"# ' , ; ! ? - ( )\"")]
        public string IntermediateHymn { get; set; }

        [Display(Name = "Closing Hymn")]
        [StringLength(50, MinimumLength = 1,
            ErrorMessage = "Closng Hymn must be between 1 and 50 characters.")]
        [RegularExpression(@"(#?\d?\d?\d?\s)?[\w\s',;!?\-()]+",
            ErrorMessage = "Must be in one of the following formats:"
            + "\n  Title only: Praise to the Man"
            + "\n  Number, single space, title: 6 Redeemer of Israel"
            + "\n  #Number, single space, title: #204 Silent Night"
            + "\nOnly include these characters: \"# ' , ; ! ? - ( )\"")]
        [Required]
        public string ClosingHymn { get; set; }

        [Display(Name = "Benediction")]
        [StringLength(50, MinimumLength = 1,
            ErrorMessage = "Name must be between 1 and 50 characters.")]
        [Required]
        public string Benediction { get; set; }

        public string Announcements { get; set; }
    }
}
