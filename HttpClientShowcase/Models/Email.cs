﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientShowcase.Models
{
    public class Email
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string EmailTemplate { get; set; } = "cnestudio";

    }
}
