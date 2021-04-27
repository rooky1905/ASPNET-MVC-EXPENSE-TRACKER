using System.ComponentModel.DataAnnotations;

namespace ASPNET_MVC_2._0.Models
{
    public class Item
    {
    
    [Key]
     public int Id { get; set; }  

     public string Borrower { get; set; }
     public string Lender { get; set; }
     public string Item_Name { get; set; }

    }
}