using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Linq_and_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task 1 link
            Car c1 = new Car("Ford", "Fiesta", "10D1234", 1028);
            Car c2 = new Car("Toyota", "Auris", "11D6025", 1600);
            Car c3 = new Car("Mazda", "2", "09D605", 1000);
            Car c4 = new Car("Chrysler", "500", "20G25", 2248);
            Car c5 = new Car("BMW", "Leguan", "18D6", 2001);
            Car c6 = new Car("Toyota", "Auris", "10D6025", 1600);
            Car c7 = new Car("Mazda", "Coupe", "19D6025", 998);
            Car c8 = new Car("Volkswagen", "Beetle", "87G100", 200);

            List<Car> Fleet = new List<Car>();
            Fleet.Add(c1);
            Fleet.Add(c2);
            Fleet.Add(c3);
            Fleet.Add(c4);
            Fleet.Add(c5);
            Fleet.Add(c6);
            Fleet.Add(c7);
            Fleet.Add(c8);

            //Write LINQ queries on the fleet to:
            //1.List all cars in ascending registration order
            //2.List the models for all Mazda cars in the fleet
            //3.List all cars in descending engine size order
            //4.List just the make and model for cars whose engine size is 1600 cc
            //5.Count the number of cars whose engine size is 1600 cc or less


            //1.List all cars in ascending registration order
            Console.WriteLine("\n---- Cars is Ascending Order ----");
            var ListAscending = Fleet.OrderBy(car => car.Registration).ThenBy(car => car.CC);
            foreach (Car ascCar in ListAscending)
            {
                Console.WriteLine(ascCar.ToString());
            }

            //2.List the models for all Mazda cars in the fleet
            Console.WriteLine("\n------ All Mazda Cars --------");
            var onlyMazdas = Fleet
                            .Where(fleet => fleet.Make == "Mazda");
            foreach (Car mazdaCar in onlyMazdas)
            {
                //Console.WriteLine(mazdaCar.ToString());
            }

            //3.List all cars in descending engine size order
            //Console.WriteLine("\n------ Cars in Descending Order -------");
            var descendinglist = Fleet.OrderByDescending(c => c.CC);
            foreach (Car descCar in descendinglist)
            {
                //Console.WriteLine(descCar.ToString());
            }

            //4.List just the make and model for cars whose engine size is 1600 cc
            //Console.WriteLine("\n----- All Cars with 1600cc -------");
            var ccList = Fleet.Where(car => car.CC == 1600).OrderByDescending(car => car.CC);
            foreach (Car discCC in ccList)
            {
               // Console.WriteLine(discCC.ToString());
            }

            //5.Count the number of cars whose engine size is 1600 cc or less
            var lowCCCount = Fleet.Count(car => car.CC <= 1600);
            Console.WriteLine("\nNumber of Cars less than 1600 CC = " + lowCCCount);
        }
    }
}
