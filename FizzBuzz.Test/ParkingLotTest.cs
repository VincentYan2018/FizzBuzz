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
    }
}