using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            GarageDoor garage = new GarageDoor();
            LightCommand lightOn = new LightCommand(light);
            GarageDoorCommand garageOpen = new GarageDoorCommand(garage);
            remote.SetCommant(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommant(garageOpen);
            remote.ButtonWasPressed();
            Console.ReadLine();
        }
    }
}
