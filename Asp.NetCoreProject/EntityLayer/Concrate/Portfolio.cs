﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Portfolio
    {
        [Key]
        public int PortfolioID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Time{ get; set; }
        public string ProjectUrl { get; set; }
        public bool Status { get; set; }
    }
}
