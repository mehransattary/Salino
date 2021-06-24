﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Salino.Models
{
    public class Mojavez
    {
        [Key]
   
        public int Id { get; set; }
        [Display(Name = "لیست خدمات")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string ListKhadamat { get; set; }
        [Display(Name = "تصویراول")]
        public string Img1 { get; set; }
        [Display(Name = "تصویردوم")]
        public string Img2 { get; set; }
        [Display(Name = "تصویرسوم")]
        public string Img3 { get; set; }
    }
}