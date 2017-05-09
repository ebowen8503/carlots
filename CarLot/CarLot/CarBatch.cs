using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class CarBatch
    {
        private List<Cars> carLot;

        public List<Cars> batches{
            get
            {
                return carLot;
            }

        }

        public int CarCount
        {
            get
            {
                return carLot.Count;
            }
        }

        public CarBatch()
        {
            carLot = new List<Cars>();
        }

        public void createcarLot(string carMake, string carModel, string carType, string carColor)
        {
            Cars car2 = new Cars();

            car2.carMake = carMake;
            car2.carModel = carModel;
            car2.carType = carType;
            car2.carColor = carColor;

            carLot.Add(car2);

        }
    }
}
