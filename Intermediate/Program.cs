using System;
 namespace Intermediate
{

    public class vehicle
    {
        public virtual void Go()
        {
            Console.WriteLine("base class");
        }
    }
    public class bike : vehicle
    {
        public override void Go()
        {
            base.Go();
            Console.WriteLine("The bike is moving");
        }
    }
    public class car : vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving");
        }
    }
    public class truck : vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The truck is moving");
        }
    }

    public abstract class Shapes
    {
        public abstract void draw();
    }
    public class Circles : Shapes
    {
        public override void draw()
        {
            Console.WriteLine("Draw the circle!....");
        }
    }
    public class Rectangle : Shapes
    {
        public override void draw()
        {
            Console.WriteLine("Draw the rectangle!....");
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var calculator = new Calculator();
            // calculator.Add(new int[] { 1, 2, 3 });// here we calling Add function in calculator class without using params modifier.
            // calculator.Add(1,2,3,4,4,5); // here we calling Add function in calculator class with using params modifier.
            // var a = 1;
            // calculator.WithOutUsingReference( ref a); Reference modifier
            // Console.WriteLine(a);

            /*
            customer.orders.Add(new Order());
            customer.orders.Add(new Order());
            Console.WriteLine(customer.orders.Count);

            customer.Prompt();
            Console.WriteLine(customer.orders.Count);
            */

            // Person persons = new Person();
            // persons.SetBirthday(new DateTime(2000, 6, 16));
            // Console.WriteLine(persons.GetBirthday());

            /*
            Text text = new Text();
            text.Height = 50;
            text.duplicate();
            */

            /* var dbMigrater = new DbMigrater(new Logger()); 

             var logger = new Logger();
             var installer = new Installer(logger);

             dbMigrater.Migrate();
             installer.Install();
            */
            /*
             Circle circle = new Circle();
             Shape shape = circle; // implicit convert object reference circle to the class reference shape
                                   // both circle and shape are pointing to the same object in memory
             circle.Draw();
             shape.Draw();

             circle.Width = 200;
             shape.Width = 100;

             Console.WriteLine(circle.Width);
             Console.WriteLine(shape.Width);
            */

            /*
            vehicle v = new vehicle();
            bike b = new bike();
            car c = new car();
            truck t = new truck();

            vehicle[] vehicleArr = { b, c, t };
            foreach (vehicle ve in vehicleArr)
            {
                ve.Go();
            }
            */

            /*
            vehicle v = new bike();
            v.Go();

            Circles c = new Circles();
            c.draw();
            Rectangle r = new Rectangle();
            r.draw();
            */


            //Exercise Stopwatch
            /*
            Stopwatch sw = new Stopwatch();
            sw.StartWatch();
            Thread.Sleep(100);
            sw.StopWatch();

            Console.WriteLine("Total Time Interval between start and stop time is : "+sw.GetIntervals());
            */

            // Exercise stack program
            /*
            Stack stack = new Stack();
            stack.Push();
            stack.Push();
            stack.Push();
            stack.Push();
            stack.Push();

            stack.Pop();
            */

            // Interfaces 

            IDevice fan = new Fan();
            fan.TurnOn();
            fan.TurnOff();

            IDevice light = new Light();
            light.TurnOn();
            light.TurnOff();

        }
    }
}