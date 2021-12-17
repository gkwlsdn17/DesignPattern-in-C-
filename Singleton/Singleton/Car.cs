using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Car
    {
        private static Car car;
        private static int carNum = 111111;

        public static Car getInstance()
        {
            if (car == null)
            {
                car = new Car();
            }
            return car;
        }

        public void setCarNum(int num)
        {
            carNum = num;
        }

        public int getCarNum()
        {
            return carNum;
        }
    }
}
