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
            Assert.Equal(19, parkingLot.GetAvailableParkingSpace());
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
            var car1 = new Car();
            var car2 = new Car();
            var carTicket1 = parkingLot.Park(car1);
            var carTicket2 = parkingLot.Park(car2);
            Assert.Same(car2, parkingLot.GetCar(carTicket2));
        }
        
        
        [Fact]
        void should_get_parked_car_successfully_when_get_specific_car_with_park_another_car_later()
        {
            var parkingLot = new ParkingLot(20);
            var car1 = new Car();
            var car2 = new Car();
            var carTicket1 = parkingLot.Park(car1);
            var carTicket2 = parkingLot.Park(car2);
            Assert.Same(car1, parkingLot.GetCar(carTicket1));
        }
    }
}