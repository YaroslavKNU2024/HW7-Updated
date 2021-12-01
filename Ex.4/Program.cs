using System;

namespace task4
{
    // After
    interface IAnyItem
    {
        void SetPrice(double price);
    }

    interface IDiscountItem
    {
        void ApplyDiscount(string discount);
    }

    interface IPromocodeItem
    {
        void ApplyPromocode(string promocode);
    }

    interface ISize
    {
        void SetSize(byte size);
    }

    interface IColor
    {
        void SetColor(byte color);
    }

    class Books: IAnyItem, IPromocodeItem, IDiscountItem
    {
        public void SetPrice(double price) { }
        public void ApplyDiscount(string discount) { }
        public void ApplyPromocode(string promocode) { }
    }

    class Clothes: IAnyItem, ISize, IColor, IPromocodeItem, IDiscountItem
    {
        public void SetPrice(double price) { }
        public void ApplyDiscount(string discount) { }
        public void ApplyPromocode(string promocode) { }
        public void SetColor(byte color) { }
        public void SetSize(byte size) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
