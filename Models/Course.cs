namespace BigSchool.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;
    using System.Web.Mvc;

    [Table("Course")]
    public partial class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string LecturerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Place { get; set; }

        public DateTime DateTime { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; internal set; }

        //add List category
        public List<Category> ListGategory = new List<Category>();
   
       

        private ActionResult RedirectToAction(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
