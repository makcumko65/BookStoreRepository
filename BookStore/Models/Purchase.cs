﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{

    public class Purchase
    {
        public int PurchaseId { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string User { get; set; }
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        public string ContactPhone { get; set; }
        //[DataType(DataType.Time)]
        //public DateTime ReleaseDate { get; set; }

        public int BookId { get; set; } // ссылка на связанную модель Phone
        public Book Book { get; set; }
    }

}
