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
        public void Should_return_message_when_speed_up_gien_car_name_and_speed()
        {
            //given
            Car car = new Car("Cool Car", 30);
            //when
            string msg = car.SpeedUp();
            //then
            Assert.Equal("Cool Car: speed up 30 km/h", msg);
        }
    }
}
