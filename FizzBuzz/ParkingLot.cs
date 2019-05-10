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


        public Ticket Park()
        {
            AvailableParkingSpaceNum--;
            return new Ticket();
        }

        public int PickUpCar(Ticket ticket)
        {
            return ++AvailableParkingSpaceNum;
        }

        public int GetParkingSpaceNum()
        {
            return AvailableParkingSpaceNum;
        }
    }
}