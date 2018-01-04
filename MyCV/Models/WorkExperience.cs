using System;
using System.ComponentModel.DataAnnotations;

namespace MyCV.Models
{
    /*This class is used to fill in 
        Work Experience and responsibilities
        Include:
        Job ID
        Title
        Job Type
        Company
        Period: From - To
        Project Description
        Responsibilities

    */

    public class WorkExperience
    {
        public int      ID { get; set; }
        public string   Title { get; set; }
        [Display(Name = "Job Type")]
        public string   Job_Type { get; set; }
        public string   Company { get; set; }
        [Display(Name = "From")]
        [DataType(DataType.Date)]
        public DateTime FromDate { get; set; }
        [Display(Name = "To")]
        [DataType(DataType.Date)]
        public DateTime ToDate { get; set; }
        public string   Description { get; set; }
        public string   Responsibilities { get; set; }
    }

}
