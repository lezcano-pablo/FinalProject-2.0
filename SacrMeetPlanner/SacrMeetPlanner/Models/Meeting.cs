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
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Conducting { get; set; }
        public string Presiding { get; set; }
        [Display(Name = "First Himn Title")]
        public string FirstHimnTitle { get; set; }
        [Display(Name = "First Himn Number")]
        public int FirstHimnNum { get; set; }
        [Display(Name = "First Prayer")]
        public string FirstPrayer { get; set; }
        public string Subject { get; set; }
        public string Announcements { get; set; }
        [Display(Name = "First Speaker")]
        public string FirstSpeaker { get; set; }
        [Display(Name = "Second Speaker")]
        public string SecondSpeaker { get; set; }
        [Display(Name = "Sacrament Himn Title")]
        public string SecondHimnTitle { get; set; }
        [Display(Name = "Sacrament Himn Number")]
        public int SecondHimnNum { get; set; }
        [Display(Name = "Third Speaker")]
        public string ThirdSpeaker { get; set; }
        [Display(Name = "Last Himn Title")]
        public string LastHimnTitle { get; set; }
        [Display(Name = "Last Himn Number")]
        public int LastHimnNum { get; set; }
        [Display(Name = "Last Prayer")]
        public string LastPrayer { get; set; }
    }
}
