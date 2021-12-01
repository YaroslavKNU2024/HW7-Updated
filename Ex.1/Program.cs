using System;
using System.Collections.Generic;

namespace _30._11
{
    // After
    class Item { }
    class Order {
        private List<Item> itemList;
        internal List<Item> ItemList {
            get{return itemList;}
            set{itemList = value;}
        }
    }
    class OrderRepository
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }
    class OrderPrintManager
    {
        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}
    }
    class OrderGetInfo
    {
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
