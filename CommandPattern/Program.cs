using CommandPattern.Commands;
using CommandPattern.Device;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //RemoteControl remoteControl = new RemoteControl();
            //Light livingRoomLight = new Light("Living Room");
            //Light kitchenLight = new Light("Kitchen");
            //CeilingFan ceilingFan = new CeilingFan("Living Room");
            //GarageDoor garageDoor = new GarageDoor();
            //Stereo stereo = new Stereo("Living Room");
            //LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            //LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            //LightOnCommand kitchenLighOn = new LightOnCommand(kitchenLight);
            //LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            //CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            //CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            //GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            //GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            //StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            //StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            //remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            //remoteControl.SetCommand(1, kitchenLighOn, kitchenLightOff);
            //remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            //remoteControl.SetCommand(3, stereoOnWithCd, stereoOff);

            //Console.WriteLine(remoteControl);

            //remoteControl.UndoButtonWasPushed();
            //remoteControl.OnButtonWasPushed(0);
            //remoteControl.OffButtonWasPushed(0);
            //remoteControl.OnButtonWasPushed(1);
            //remoteControl.OffButtonWasPushed(1);
            //remoteControl.OnButtonWasPushed(2);
            //remoteControl.OffButtonWasPushed(2);
            //remoteControl.OnButtonWasPushed(3);
            //remoteControl.OffButtonWasPushed(3);
            //Console.WriteLine(remoteControl);
            //remoteControl.UndoButtonWasPushed();

            RemoteControl remote = new RemoteControl();
            CeilingFan ceilingFan = new CeilingFan("Living Room");

            CeilingFanMediumCommand ceilingFanMediumCommand = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

            remote.SetCommand(0, ceilingFanMediumCommand, ceilingFanOffCommand);
            remote.SetCommand(1, ceilingFanHighCommand, ceilingFanOffCommand);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            Console.WriteLine(remote);
            remote.UndoButtonWasPushed();

            remote.OnButtonWasPushed(1);
            Console.WriteLine(remote);
            remote.UndoButtonWasPushed();
            Console.ReadLine();
        }
    }
}
