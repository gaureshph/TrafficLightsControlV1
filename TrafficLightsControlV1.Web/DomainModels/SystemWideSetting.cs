using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrafficLightsControlV1.Web.DomainModels
{
    public class SystemWideSetting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public int Signal1Time { get; set; }
        [Required]
        public int Signal2Time { get; set; }
        [Required]
        public int Signal3Time { get; set; }
        [Required]
        public int Signal4Time { get; set; }
    }
}