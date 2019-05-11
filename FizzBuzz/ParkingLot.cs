namespace FizzBuzz
{
    public class ParkingLot
    {
        public int AvailableParkingSpaceNum { get; set; }
        public int ParkingSpaceNum { get; }

        public ParkingLot(int parkingSpaceNum)
        {
            ParkingSpaceNum = parkingSpaceNum;
            AvailableParkingSpaceNum = parkingSpaceNum;
        }


        public string Park()
        {
            if (AvailableParkingSpaceNum == 0)
            {
                throw new InvalidOperationException("There are no available parking space!");
            }

            AvailableParkingSpaceNum--;
            return "ticket";
        }

        public void PickUpCar(string ticket)
        {
            VerifyTicket(ticket);

            VerifyParkingCar();

            ++AvailableParkingSpaceNum;
        }

        void VerifyParkingCar()
        {
            if (AvailableParkingSpaceNum == ParkingSpaceNum)
            {
                throw new InvalidOperationException("There is no such car!");
            }
        }

        static void VerifyTicket(string ticket)
        {
            if (ticket == null)
            {
                throw new InvalidOperationException("Parking ticket is required!");
            }

            if (!ticket.Equals("ticket"))
            {
                throw new InvalidOperationException("Parking ticket invalid!");
            }
        }

        public int GetParkingSpaceNum()
        {
            return AvailableParkingSpaceNum;
        }
    }
}