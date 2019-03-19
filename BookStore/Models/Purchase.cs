using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{

    public class Purchase
    {
        public int PurchaseId { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Invalid name")]
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The length of the string must be from 3 to 50 characters.")]
        public string User { get; set; }
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone")]
        public string ContactPhone { get; set; }
        //[DataType(DataType.Time)]
        //public DateTime ReleaseDate { get; set; }

        public int BookId { get; set; } // ссылка на связанную модель Phone
        public Book Book { get; set; }
    }

}
