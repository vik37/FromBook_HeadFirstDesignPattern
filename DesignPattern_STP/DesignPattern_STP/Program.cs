using DesignPattern_STP.Ducks;
using DesignPattern_STP.Ducks.Behaviours;
using System;

namespace DesignPattern_STP
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallar = new MallarDuck();
            mallar.Display();
            mallar.Swim();
            mallar.PerformQuack();
            mallar.PerformFly();
            Console.WriteLine("----------------------------");
            Duck readHead = new ReadHeadDuck();
            readHead.Display();
            readHead.Swim();
            readHead.PerformFly();
            readHead.PerformQuack();
            Console.WriteLine("----------------------------");
            Duck rubber = new RubberDuck();
            rubber.Display();
            rubber.Swim();
            rubber.PerformFly();
            rubber.PerformQuack();
            Console.WriteLine("-------------------------------");
            Duck decoy = new DecoyDuck();
            decoy.Display();
            decoy.Swim();
            decoy.PerformFly();
            decoy.PerformQuack();
            Console.WriteLine("--------------------------------");
            Duck model = new ModelDuck();
            model.Display();
            model.Swim();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPower());
            model.PerformFly();
          
            Console.ReadLine();
        }
    }
}
