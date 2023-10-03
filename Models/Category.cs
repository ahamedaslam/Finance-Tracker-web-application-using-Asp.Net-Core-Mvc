using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]

        [Required(ErrorMessage = "Title is required.")] //Validation
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; } = "Expense";   //Type expense

        
        //Merging the Icon and Title
        
        [NotMapped]
        public string? TitleWithIcon {
            get
            {
                return this.Icon + " " + this.Title;
            }
                
        }

    }
}
