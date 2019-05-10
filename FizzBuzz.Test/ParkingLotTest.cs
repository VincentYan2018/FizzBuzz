using Xunit;

namespace FizzBuzz.Test
{
    public class ParkingLotTest
    {
        [Fact]
        void should_generate_ticket_when_park_successfully()
        {
            var parkingLot = new ParkingLot(20);

            var ticket = parkingLot.Park();

            Assert.NotNull(ticket);
        }

        [Fact]
        void should_pick_up_car_successfully_when_use_valid_ticket()
        {
            var parkingLot = new ParkingLot(20);
            var ticket = parkingLot.Park();

            parkingLot.PickUpCar(ticket);

            Assert.Equal(20, parkingLot.GetParkingSpaceNum());
        }
    }
}