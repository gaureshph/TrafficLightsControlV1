using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrafficLightsControlV1.Web.ViewModels
{
    public class SystemWideSettingViewModel
    {
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