using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBatch carbatches = new CarBatch();

            carbatches.createcarLot("Toyota", "Camry", "black", "sedan");
            carbatches.createcarLot("Acura", "TL", "red", "sedan");
            carbatches.createcarLot("Nissan", "Maxima", "white", "sedan");
            carbatches.createcarLot("Ford", "Escape", "blue", "SUV");
            carbatches.createcarLot("Ford", "F150", "grey", "truck");
            carbatches.createcarLot("BMW", "750i", "white", "sedan");
            carbatches.createcarLot("Mercedes", "AMG", "black", "sedan");
            carbatches.createcarLot("Infiniti", "QX", "black", "SUV");
            carbatches.createcarLot("Honda", "Civic", "blue", "Sedan");
            carbatches.createcarLot("Honda", "CRV", "black", "SUV");
            carbatches.createcarLot("Harley Davidson", "MS", "black", "motorcycle");
            carbatches.createcarLot("Jeep", "Wrangler", "green", "SUV");
            carbatches.createcarLot("Toyota", "Tundra", "black", "truck");
            carbatches.createcarLot("Nissan", "Armada", "black", "SUV");
            carbatches.createcarLot("Honda", "Accord", "blue", "Sedan");
            carbatches.createcarLot("Lexus", "250", "white", "Sedan");
            carbatches.createcarLot("Volkswagen", "Jetta", "black", "Sedan");
            carbatches.createcarLot("Volkwagen", "Toureg", "silver", "SUV");
            carbatches.createcarLot("Volvo", "240", "black", "SUV");
            carbatches.createcarLot("Kia", "Spectra", "red", "Sedan");

            int a;

            for(a=1; a<= carbatches.CarCount; a++)
            {
                Console.WriteLine(" "+ carbatches.batches[a-1].carMake+ " "+carbatches.batches[a-1].carModel+ " "+carbatches.batches[a-1].carColor+ " "+carbatches.batches[a-1].carType);
            }
            Console.ReadKey();
        }
    }
}
