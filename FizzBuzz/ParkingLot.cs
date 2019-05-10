namespace FizzBuzz
{
    public class ParkingLot
    {
        int ParkingSpaceNum { get; set; }

        public ParkingLot(int parkingSpaceNum)
        {
            ParkingSpaceNum = parkingSpaceNum;
        }


        public Ticket Park()
        {
            return new Ticket();
        }
    }
}