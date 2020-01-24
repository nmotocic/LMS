﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Domain.Models
{
    public partial class Loan
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        public DateTime? LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? LoanRenew { get; set; }

        public virtual Book Book { get; set; }
        public virtual Customer User { get; set; }
    }
}
