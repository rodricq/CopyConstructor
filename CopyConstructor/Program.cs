using System;

namespace CopyConstructor
{
    class Car
    {
        string brand;
        int price;
        int passengers;

        //constructor
        Car(string theBrand, int thePrice, int thePassengers)
        {
            brand = theBrand;
            price = thePrice;
            passengers = thePassengers;
        }

        /*Car(int thePrice)
        {
            price = thePrice;
        }
        Car(int thePassengers)
        {
            passengers = thePassengers;
        } */

        //copy constructor
        Car(Car c1)
        {
            brand = c1.brand;
            price = c1.price;
            passengers = c1.passengers;
        }
        static void Main(string[] args)
        {
            //call constructor
            Car car1 = new Car("Buggatti", 20000, 2);
            Car car2 = new Car("Ferrari", 30000, 2);

            Console.WriteLine("Brand of car1: " + car1.brand);
            Console.WriteLine("Price of car1: " + car1.price);
            Console.WriteLine("Passengers of car1: " + car1.passengers);
            Console.WriteLine("Brand of car3: " + car2.brand);
            Console.WriteLine("Price of car3: " + car2.price);
            Console.WriteLine("Passengers of car3: " + car2.passengers);


            // call the copy constructor
            Car car3 = new Car(car1);
            Console.WriteLine("Brand of car2: " + car2.brand);
            Console.WriteLine("Price of car2: " + car2.price);
            Console.WriteLine("Passengers of car2: " + car2.passengers);

            Car car4 = new Car(car3);
            Console.WriteLine("Brand of car4: " + car4.brand);
            Console.WriteLine("Price of car4: " + car4.price);
            Console.WriteLine("Passengers of car4: " + car4.passengers);

            Console.ReadLine();
        }
    }
}
