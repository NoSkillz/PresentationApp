using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PresentationApp.Models
{
    public class Presentation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        [DisplayName("Date presented")]
        public DateTime Date { get; set; }

        [DisplayName("Int32")]
        public int someNumber { get; set; }
    }
}