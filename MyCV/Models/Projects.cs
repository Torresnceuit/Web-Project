using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Models
{
    /*
     * Projects Model is used to describe the projects
     * that have been done
    */
    public class Projects
    {
        public  int     ID              { get; set; }
        [Display( Name ="Project Name")]
        public  string  ProjectName     { get; set; }
        public  string  Description     { get; set; }
        public  string  Period          { get; set; }
        [Display(Name ="Technologies Used")]
        public  string  Technologies    { get; set; }
        [Display(Name ="Programming Languages")]
        public  string  Languages       { get; set; }
    }
}
