﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="این فیلد اجباری هست")]
        [MinLength(3, ErrorMessage = "حداقل طول نام،3 کاراکتر است")]
        [MaxLength(100, ErrorMessage ="حداکثر طول نام ، 100 کاراکتر است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری هست")]
        [EmailAddress(ErrorMessage ="مقدار وارد شده ایمیل صحیح نیست")]
        public string Email { get; set; }
        public string Message { get; set; }
        public int Service { get; set; }

        public SelectList Services { get; set; }
    }
}
