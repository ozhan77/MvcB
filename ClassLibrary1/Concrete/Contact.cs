﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Concrete
{
    public class Contact
    {
        [Key]
        public int ContantID { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(100)]
        public string UserMail { get; set; }
        [StringLength(100)]
        public string Subject { get; set; }
        public string Message { get; set; }

    }
}
