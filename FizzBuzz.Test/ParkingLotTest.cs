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

            Assert.Equal("ticket", ticket);
            Assert.Equal(19, parkingLot.GetParkingSpaceNum());
        }

        [Fact]
        void should_park_failure_when_there_no_available_parking_space()
        {
            var parkingLot = new ParkingLot(3);
            parkingLot.Park();
            parkingLot.Park();
            parkingLot.Park();

            var invalidOperationException = Assert.Throws<InvalidOperationException>(() => parkingLot.Park());

            Assert.Equal("There are no available parking space!", invalidOperationException.Message);
        }

        [Fact]
        void should_pick_up_car_successfully_when_use_valid_ticket()
        {
            var parkingLot = new ParkingLot(20);
            var ticket = parkingLot.Park();

            parkingLot.PickUpCar(ticket);

            Assert.Equal(20, parkingLot.GetParkingSpaceNum());
        }

        [Fact]
        void should_pick_up_car_failure_when_use_invalid_ticket()
        {
            var parkingLot = new ParkingLot(20);
            var ticket = "invalidTicket";

            var invalidOperationException = Assert.Throws<InvalidOperationException>(() => parkingLot.PickUpCar(ticket));

            Assert.Equal("Parking ticket invalid!", invalidOperationException.Message);
        }

        [Fact]
        void should_pick_up_car_failure_when_there_no_car_and_use_valid_ticket()
        {
            var parkingLot = new ParkingLot(20);

            var invalidOperationException = Assert.Throws<InvalidOperationException>(() => parkingLot.PickUpCar("ticket"));

            Assert.Equal("There is no such car!", invalidOperationException.Message);
        }

        [Fact]
        void should_pick_up_car_failure_when_no_ticket()
        {
            var parkingLot = new ParkingLot(20);

            var invalidOperationException = Assert.Throws<InvalidOperationException>(() => parkingLot.PickUpCar(null));

            Assert.Equal("Parking ticket is required!", invalidOperationException.Message);
        }
    }
}