﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Salino.Models
{
    public class SendForMajor
    {
        public int Id { get; set; }
        [Display(Name = "نام حمل")]
        [MaxLength(100, ErrorMessage = "لطفا نام حمل را واردکنید.")]
        public string NameHaml { get; set; }
        [Display(Name = "هزینه حمل")]
        [MaxLength(100, ErrorMessage = "لطفا هزینه حمل را واردکنید.")]
        public string PriceHaml { get; set; }
    }
}