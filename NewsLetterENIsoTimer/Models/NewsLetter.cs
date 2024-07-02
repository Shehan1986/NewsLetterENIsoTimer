﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsLetterENIsoTimer.Models
{
    public class NewsLetter
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string Category4 { get; set; }
        public string Status { get; set; }
        public bool IsTermsAndConditions { get; set; }
        public DateTime Created { get; set; }

        [NotMapped]
        public string Body { get; set; }
    }
}
