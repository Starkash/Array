namespace Araay
{
    class Car
    {
        static void BMW()
        {
            Console.WriteLine("speed of BMW is 150Kmph");

        }
        static void HONDA()
        {
            Console.WriteLine("speed of HONDA is 120Kmph");

        }
        static void RUBYCOIN()
        {
            Console.WriteLine("speed of RUBYCOIN is 10Kmph");

        }
        static void MERCEDIES()
        {
            Console.WriteLine("speed of MERCEDIES is 300Kmph");

        }
        static void Main()
        {


            string[] Car = { "BMW", "HONDA", "RUBYCOIN", "MERCEDIES" };
            Console.Write("Please Enter your Favourite Car:");
            int car_number = Convert.ToInt32(Console.ReadLine());
            if (car_number == 0)
            {
                Console.Write(" Car " + car_number + " is " + Car[car_number]);
                Console.Write(" ");
                BMW();
            }
            else if (car_number == 1)c
            {

                Console.Write(" Car " + car_number + " is " + Car[car_number]);
                Console.Write(" ");
                HONDA();
            }

            else if (car_number == 2)
            {
                Console.Write(" Car " + car_number + " is " + Car[car_number]);
                Console.Write(" ");

                RUBYCOIN();
            }
            else if (car_number == 3)
            {
                Console.Write(" Car " + car_number + " is " + Car[car_number]);
                Console.Write(" ");
                MERCEDIES();
            }
            else
                Console.WriteLine("INVAILID");

            // Console.WriteLine(Car[]);
            Console.ReadLine();















        }
    }
}
