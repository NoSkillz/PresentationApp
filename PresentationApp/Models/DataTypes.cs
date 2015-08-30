using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PresentationApp.Models
{
    public class DataTypes : IExample
    {
        public int Id { get; set; }
        public int? Integer { get; set; }
        public double? Double { get; set; }
        public float? Float { get; set; }
        public decimal? Decimal { get; set; }
        [Column(TypeName = "Money")]
        public decimal? Money { get; set; }
      
        // FK to Presentations
        public int PresentationId { get; set; }
    }
}