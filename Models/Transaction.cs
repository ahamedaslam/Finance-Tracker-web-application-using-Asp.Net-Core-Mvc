using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //category Id
        [Range(1, int.MaxValue,ErrorMessage = "Please select a Category.")]  //Validation
        
        public int CategoryId { get; set; }
        public Category? Category { get; set; }  //Assign a foreign key between 2 tables 

        [Range(1, int.MaxValue, ErrorMessage = "Amount should be greater than 0.")]  //Validation

        public int Amount { get; set; }
        
        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }    //Nullable string
        public DateTime Date { get; set; } = DateTime. Now;


        [NotMapped]
        public string? CategoryTitleWithIcon
        {
            get
            {
                return Category==null? "": Category.Icon + " " + Category.Title;
            }
        }

        [NotMapped]
        public string? FormattedAmount
        {
            get
            {
                return ((Category == null || Category.Type == "Expense") ? "-" : "+") + Amount.ToString("C0");
            }
        }


    }
}
