using StrategyPattern.Fly;
using System;

namespace StrategyPattern
{
    public class DuckSimulator
    {
        static void Main(string[] args)
        {
            
            DuckSimulator d = new DuckSimulator();
            string question;
            Duck decoy = new DecoyDuck();
            Duck mallard = new MallardDuck();
            Duck model = new ModelDuck();
            Duck read = new RedheadDuck();
            Duck rubber = new RubberDuck();
            Duck duck;
            do
            {
                Console.Clear();
                int opc = 0;
                


                Console.WriteLine("Select a option of ducks:\n1.-DecoyDuck\n2.-MallardDuck\n3.-ModelDuck\n4.-RedheadDuck\n5.-RubberDuck");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        duck = decoy;
                        d.ChooseBehavior(duck);
                        break;
                    case 2:
                        duck = mallard;
                        d.ChooseBehavior(duck);
                        break;
                    case 3:
                        duck = model;
                        d.ChooseBehavior(duck);
                        break;
                    case 4:
                        duck = read;
                        d.ChooseBehavior(duck);
                        break;
                    case 5:
                        duck = rubber;
                        d.ChooseBehavior(duck);
                        break;
                    default:
                        Console.WriteLine("Choice one!!");

                        break;
                }
                Console.WriteLine("Do you want to close this program? (Y/N)");
                question = Console.ReadLine();
            } while (question!="Y");
            
            Console.ReadKey();
        }

        public void ChooseBehavior(Duck duck)
        {
            
            int opc = 0;
            string behavior;
            Console.WriteLine("Select a option of behavior:\n1.-Fly\n2.-Swim\n3.-Quack\n4.-What I know?");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    behavior = "fly";
                    ChooseSubBehavior(duck, behavior);
                    break;
                case 2:
                    behavior = "swim";
                    ChooseSubBehavior(duck, behavior);
                    break;
                case 3:
                    behavior = "quack";
                    ChooseSubBehavior(duck, behavior);
                    break;
                case 4:
                    duck.PerformFly();
                    duck.PerformSwim();
                    duck.PerformQuack();
                    break;
                default:
                    Console.WriteLine("Choice one!!");

                    break;
            }
        }
        public void ChooseSubBehavior(Duck duck, String Behavior)
        {
            int opc = 0;

            if(Behavior=="fly")
            {
                Console.WriteLine("Select a option of subbehavior:\n1.-FlyNoWay\n2.-FlyRocketPowered\n3.-FlyWithWings");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        duck.Display();
                        duck.SetFlyBehavior(new FlyNoWay());
                        duck.PerformFly();
                        break;
                    case 2:
                        duck.Display();
                        duck.SetFlyBehavior(new FlyRocketPowered());
                        duck.PerformFly();
                        break;
                    case 3:
                        duck.Display();
                        duck.SetFlyBehavior(new FlyWithWings());
                        duck.PerformFly();
                        break;
                    default:
                        Console.WriteLine("Choose one!!");
                        break;
                }
            }
            else if(Behavior == "swim")
            {
                Console.WriteLine("Select a option of subbehavior:\n1.-SwimFast\n2.-SwimFreestyle\n3.-SwimUnderwater");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        duck.Display();
                        duck.SetSwimBehavior(new SwimFast());
                        duck.PerformSwim();
                        break;
                    case 2:
                        duck.Display();
                        duck.SetSwimBehavior(new SwimFreestyle());
                        duck.PerformSwim();
                        break;
                    case 3:
                        duck.Display();
                        duck.SetSwimBehavior(new SwimUnderwater());
                        duck.PerformSwim();
                        break;
                    default:
                        Console.WriteLine("Choose one!!");
                        break;
                }
            }
            else if (Behavior == "quack")
            {
                Console.WriteLine("Select a option of subbehavior:\n1.-DuckQuack\n2.-MuteQuack\n3.-Squeak");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        duck.Display();
                        duck.SetQuackBehavior(new DuckQuack());
                        duck.PerformQuack();
                        break;
                    case 2:
                        duck.Display();
                        duck.SetQuackBehavior(new MuteQuack());
                        duck.PerformQuack();
                        break;
                    case 3:
                        duck.Display();
                        duck.SetQuackBehavior(new Squeak());
                        duck.PerformQuack();
                        break;
                    default:
                        Console.WriteLine("Choose one!!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error in the matrix");
            }
            
        }

    }
}