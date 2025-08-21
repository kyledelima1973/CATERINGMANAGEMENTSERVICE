namespace CATERINGMANAGEMENTSERVICE.Models
{
    public class Menu
    {
        public string FoodId { get; set; } // Primary Key 

        public string FoodName { get; set; }

        public string FoodDescription { get; set; }

        public decimal Foodprice { get; set; }
        public int FoodQuantity { get; set; }
    }
}
