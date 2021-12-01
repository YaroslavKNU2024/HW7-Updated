using System;

namespace task3
{
    // After
    interface IShape
    {
        int Width { get; set; }
        int Height { get; set; }
        int GetArea();
    }
    class Rectangle : IShape
    {
        int _height;
        int _width;
        public int Height { get => _height; set => _height = value; }
        public int Width { get => _width; set => _width = value; }

        public int GetArea() => _width * _height;
    }
    //квадрат наслідується від прямокутника!!!
    class Square : IShape
    {
        int _side;
        public int Width { get => _side; set => _side = value; }
        public int Height { get => _side; set => _side = value; }

        public int GetArea() => _side * _side;
    }

    class Program
    {
        static void Main(string[] args)
        {
            IShape rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 10;

            Console.WriteLine(rect.GetArea());
            Console.ReadKey();
        }
    }
}