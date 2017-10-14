using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TrafficLightsControlV1.Web.Enums;

namespace TrafficLightsControlV1.Web.DomainModels
{
    public class TrafficSignal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [ForeignKey("TrafficJunction")]
        public int TrafficJunction_Id { get; set; }

        public virtual TrafficJunction TrafficJunction { get; set; }

        public ExitDirection ExitDirection { get; set; }

        public bool IsGreen { get; set; }
    }
}