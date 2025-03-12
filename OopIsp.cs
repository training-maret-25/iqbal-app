using System;
using System.Linq; 
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using Serilog;
using System.Security.Cryptography.X509Certificates;


class OopIsp
{
    public interface IWorker
    {
        void Work();
    }

    public interface IMahlukHidup
    {
        void Eat();

    }

    public class HumanWorker : IWorker, IMahlukHidup
    {
        public void Work()
        {
            Console.WriteLine("Human is working...");
        }

        public void Eat()
        {
            Console.WriteLine("Human is eating...");
        }
    }

    public class RobotWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working...");
        }

        //public void Eat()
        //{
        //    throw new NotImplementedException(); // ❌ Robot tidak makan!
        //}
    }

    static void Main()
    {
        IWorker manusia = new HumanWorker();
        IMahlukHidup makan = new HumanWorker();
        IWorker robot = new RobotWorker();

        manusia.Work(); // Panggilan method yang benar
        robot.Work();
        makan.Eat();

    }


}