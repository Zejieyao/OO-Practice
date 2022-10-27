using OOPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOPracticeTest
{
    public class CarTest
    {
        [Fact]
        public void Should_return_message_when_speed_up_given_car_name_and_speed()
        {
            //given
            Car car = new Car("Cool Car", 30);
            //when
            string msg = car.SpeedUp();
            //then
            Assert.Equal("Cool Car: speed up 30 km/h", msg);
        }

        [Fact]
        public void Should_return_message_when_speed_up_given_truck_name_and_speed()
        {
            //given
            Truck truck = new Truck("Big Truck", 10);
            //when
            string msg = truck.SpeedUp();
            //then
            Assert.Equal("Big Truck: speed up 10 km/h", msg);
        }

        [Fact]
        public void Should_return_message_when_speed_up_given_driver_car_name_and_speed()
        {
            //given
            Car vehicle = new Car("Cool Car", 30);
            Driver driver = new Driver(vehicle);
            //when
            string msg = driver.DriveVehicleShowMessage();
            //then
            Assert.Equal("Cool Car: speed up 30 km/h", msg);
        }

        [Fact]
        public void Should_return_message_when_speed_up_given_driver_truck_name_and_speed()
        {
            //given
            Truck vehicle = new Truck("Big Truck", 10);
            Driver driver = new Driver(vehicle);
            //when
            string msg = driver.DriveVehicleShowMessage();
            //then
            Assert.Equal("Big Truck: speed up 10 km/h", msg);
        }

        [Fact]
        public void Should_return_message_when_given_car_gasoline_engine()
        {
            //given
            Car car = new Car("Cool car", "gasoline");

            //when
            string msg = car.SpeedUpCar();
            //then
            Assert.Equal("Cool car: speed up 30 km/h", msg);
        }

        [Fact]
        public void Should_return_message_when_given_car_electric_engine()
        {
            //given
            Car car = new Car("Cool car", "electric");

            //when
            string msg = car.SpeedUpCar();
            //then
            Assert.Equal("Cool car: speed up 25 km/h", msg);
        }
    }
}
