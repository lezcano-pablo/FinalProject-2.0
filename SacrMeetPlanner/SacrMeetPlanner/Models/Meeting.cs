using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SacrMeetPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [StringLength(60, MinimumLength = 5)]
        [Required]
        public string Conducting { get; set; }
        [StringLength(60, MinimumLength = 5)]
        [Required]
        public string Presiding { get; set; }
        [StringLength(150, MinimumLength = 5)]
        [Required]
        [Display(Name = "First Himn Title")]
        public string FirstHimnTitle { get; set; }
        [Range(1, 209)]
        [Required]
        [Display(Name = "First Himn Number")]
        public int FirstHimnNum { get; set; }
        [Display(Name = "First Prayer")]
        [StringLength(150, MinimumLength = 5)]
        [Required]
        public string FirstPrayer { get; set; }
        [StringLength(25, MinimumLength = 5)]
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Announcements { get; set; }
        [Display(Name = "First Speaker")]
        [StringLength(150, MinimumLength = 5)]
        [Required]
        public string FirstSpeaker { get; set; }
        [Display(Name = "Second Speaker")]
        [StringLength(150, MinimumLength = 5)]
        [Required]
        public string SecondSpeaker { get; set; }
        [Display(Name = "Sacrament Himn Title")]
        [StringLength(150, MinimumLength = 5)]
        [Required]
        public string SecondHimnTitle { get; set; }
        [Display(Name = "Sacrament Himn Number")]
        [Range(1, 209)]
        [Required]
        public int SecondHimnNum { get; set; }
        [Display(Name = "Third Speaker")]
        [StringLength(150, MinimumLength = 5)]
        [Required]
        public string ThirdSpeaker { get; set; }
        [Display(Name = "Last Himn Title")]
        [StringLength(150, MinimumLength = 5)]
        [Required]
        public string LastHimnTitle { get; set; }
        [Display(Name = "Last Himn Number")]
        [Range(1, 209)]
        [Required]
        public int LastHimnNum { get; set; }
        [Display(Name = "Last Prayer")]
        [StringLength(150, MinimumLength = 5)]
        [Required]
        public string LastPrayer { get; set; }
    }
}
