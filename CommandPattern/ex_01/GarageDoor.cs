using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Door Up");
        }
        public void Down()
        {
            Console.WriteLine("Door Down");
        }
        public void Stop()
        {
            Console.WriteLine("Stop the Door");
        }
        public void LightOn()
        {
            Console.WriteLine("Light On");
        }
        public void LightOff()
        {
            Console.WriteLine("Light Off");
        }
    }
}
