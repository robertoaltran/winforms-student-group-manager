using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Solution
{
    public class Group
    {
        public string Name { get; set; }
        public GroupType Type { get; set; }
        public int Size { get; set; }
        private const decimal SchoolPrice = 5.0m;
        private const decimal TourPrice = 10.0m;
        private const int SchoolDiscountThreshold = 20;
        private const int TourDiscountThreshold = 5;
        private const decimal Discount = 0.2m;

        public decimal CalculateTotalPrice()
        {
            decimal basePrice = Type == GroupType.School ? SchoolPrice : TourPrice;
            decimal totalPrice = basePrice * Size;
            if ((Type == GroupType.School && Size >= SchoolDiscountThreshold) ||
                (Type == GroupType.Tour && Size >= TourDiscountThreshold))
            {
                totalPrice -= totalPrice * Discount; 
            }
            return totalPrice;
        }

        public decimal CalculateDiscountAmount()
        {
            decimal discountAmount = 0;

            
            decimal totalBeforeDiscount = Size * (Type == GroupType.School ? SchoolPrice : TourPrice);

            
            if ((Type == GroupType.School && Size >= SchoolDiscountThreshold) ||
                (Type == GroupType.Tour && Size >= TourDiscountThreshold))
            {
                
                discountAmount = totalBeforeDiscount * Discount;
            }

            return discountAmount; 
        }

    }
}
