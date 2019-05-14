using Xunit;

namespace FizzBuzz.Test
{
    public class ParkingLotTest
    {
        [Fact]
        void should_generate_ticket_and_refresh_available_parking_space_after_parking_successfully()
        {
            var parkingLot = new ParkingLot(20);
            var ticket = parkingLot.Park(new Car());

            Assert.NotNull(ticket);
        }

        [Fact]
        void should_failed_parking_when_parking_lot_is_full()
        {
            var parkingLot = new ParkingLot(20);
            for (int i = 0; i < 20; i++)
            {
                parkingLot.Park(new Car());
            }

            var exception = Assert.Throws<NoAvailableParkingSpaceException>(() => { parkingLot.Park(new Car()); });
            Assert.Equal("There are no available parking space!", exception.Message);
        }

        [Fact]
        void should_get_parked_car_successfully_when_get_car_given_ticket_is_valid()
        {
            var parkingLot = new ParkingLot(20);

            var parkedCar = new Car();
            var carTicket = parkingLot.Park(parkedCar);

            var car = parkingLot.GetCar(carTicket);

            Assert.Same(parkedCar, car);
        }

        [Fact]
        void should_get_parked_car_successfully_when_get_specific_car_with_existed_two_car()
        {
            var parkingLot = new ParkingLot(20);
            var firstCar = new Car();
            var secondCar = new Car();
            var firstCarTicket = parkingLot.Park(firstCar);
            var secondCarTicket = parkingLot.Park(secondCar);
            Assert.Same(secondCar, parkingLot.GetCar(secondCarTicket));
        }


        [Fact]
        void should_get_parked_car_successfully_when_get_specific_car_with_park_another_car_later()
        {
            var parkingLot = new ParkingLot(20);
            var firstCar = new Car();
            var secondCar = new Car();
            var firstCarTicket = parkingLot.Park(firstCar);
            var secondCarTicket = parkingLot.Park(secondCar);
            Assert.Same(firstCar, parkingLot.GetCar(firstCarTicket));
        }
    }
}