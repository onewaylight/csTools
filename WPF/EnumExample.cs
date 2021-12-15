using System;

namespace EnumTest
{
    public enum Fruits
    {
        Apple,
        Banana,
        Orange,
        Watermelon,
        Mango,
        Strawberry
    }

    enum Styles { Plaid = 0, Striped = 23, Tartan = 65, Corduroy = 78 };


    class Program
    {
        static void Main(string[] args)
        {
            foreach (string fruit in Enum.GetNames(typeof(Fruits)))
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("--------------------------------");

            foreach (int fruit in Enum.GetValues(typeof(Fruits)))
            {
                Console.WriteLine(fruit);
            }

        }
    }
}
