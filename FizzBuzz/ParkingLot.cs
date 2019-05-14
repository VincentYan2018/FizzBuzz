using System.Collections.Generic;

namespace FizzBuzz
{
    public class ParkingLot
    {
        readonly int capacity;
        readonly Dictionary<Ticket, Car> parkedCars;

        public ParkingLot(int capacity)
        {
            this.capacity = capacity;
            parkedCars = new Dictionary<Ticket, Car>();
        }

        public Ticket Park(Car car)
        {
            if (GetAvailableParkingSpace() == 0)
            {
                throw new NoAvailableParkingSpaceException();
            }

            var ticket = new Ticket();
            parkedCars.Add(ticket, car);

            return ticket;
        }

        int GetAvailableParkingSpace()
        {
            return capacity - parkedCars.Count;
        }

        public Car GetCar(Ticket ticket)
        {
            return parkedCars.GetValueOrDefault(ticket);
        }
    }
}