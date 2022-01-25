using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Device
{
    public class GarageDoor
    {
        
        public void Up()
        {
            Console.WriteLine("Garage Door Up");
        }
        public void Down()
        {
            Console.WriteLine("Garage Door Down");
        }
        public void Stop()
        {
            Console.WriteLine("Garage Door is stop");
        }
        public void LightOn()
        {
            Console.WriteLine("The Garage Door Lights came on");
        }
        public void LightOff()
        {
            Console.WriteLine("The Garage Door Lights came off");
        }
    }
}
