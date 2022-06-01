using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FactoryOfComputerFactory
    {
        public void createComputer(String type)
        {
            ComputerFactory computerFactory = null;
            switch (type)
            {
                case "LG":
                    computerFactory = new LGComputerFactory();
                    break;
                case "Samsung":
                    computerFactory = new SamsungComputerFactory();
                    break;
            }

            Keyboard keyboard = computerFactory.createKeyboard();
            Mouse mouse = computerFactory.createMouse();
            Console.WriteLine($"keyboard name = {keyboard.name}, serial = {keyboard.serial} \n" +
                              $"mouse name = {mouse.name}, serial = {mouse.serial}");
        }
    }
}
