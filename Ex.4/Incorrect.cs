using System;

namespace task42
{
    // порушено The Interface Segregation Principle
    //Before
    interface IItem
    {
        void ApplyDiscount(String discount);
        void ApplyPromocode(String promocode);
        void SetColor(byte color);
        void SetSize(byte size); 
        void SetPrice(double price);
    }
}
