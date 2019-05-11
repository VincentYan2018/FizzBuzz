using System.Collections.Generic;

namespace FizzBuzz
{
    public class ParkingLot
    {
        readonly int capacity;
        Dictionary<CarTicket, Car> cars;

        public ParkingLot(int capacity)
        {
            this.capacity = capacity;
            cars = new Dictionary<CarTicket, Car>();
        }

        public CarTicket Park(Car car)
        {
            
            if (GetAvailableParkingSpace() == 0)
            {
                throw new NoAvailableParkingSpaceException();
            }

            CarTicket carTicket = new CarTicket();
            cars.Add(carTicket, car);
            
            return carTicket;
        }

        public int GetAvailableParkingSpace()
        {
            return capacity - cars.Count;
        }

        public Car GetCar(CarTicket carTicket)
        {
            return cars.GetValueOrDefault(carTicket);
        }
    }
}