using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationApp.Models
{
    public class DataTypesExample : IExample
    {
        public int Id { get; set; }
        public int? FirstInteger { get; set; }
        public int? SecondInteger { get; set; }
        public double? FirstDouble { get; set; }
        public double? SecondDouble { get; set; }
        public float? FirstFloat { get; set; }
        public float? SecondFloat { get; set; }
        public char? FirstChar { get; set; }
        public char? SecondChar { get; set; }
        
        // FK to Presentations
        public int PresentationId { get; set; }
    }
}