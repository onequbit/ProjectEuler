﻿using CodeLibrary;

namespace ProjectEuler
{
    
    public class App
    {
        public App() { }
                
        public void Problem3()
        {
            var p3 = new Problem3(600851475143);
            p3.Answer.ToConsole();
        }

        public void Problem4()
        {
            var p4 = new Problem4();
            p4.Answer.ToConsole();            
        }

        public void Problem5()
        {
            var p5 = new Problem5(20);
            p5.Answer.ToConsole();
        }

        public void Problem6()
        {
            var p6 = new Problem6(100);
            p6.Answer.ToConsole();
        }

        public void Problem7()
        {
            var p7 = new Problem7(10001);
            p7.Answer.ToConsole();
        }

        public void Problem8()
        {
            var p8 = new Problem8();
            p8.Answer.ToConsole();
        }

        public void Problem9()
        {
            var p9 = new Problem9(1000);
            p9.Answer.ToConsole();
        }

        public void Problem10()
        {
            var p10 = new Problem10(2000000);
            p10.Answer.ToConsole();
        }

        public void Show(IPEProblem problem, long lsize)
        {
            problem.ShowAnswer(lsize);
            "Press enter to continue".KeyPrompt();
        }

        public void Go()
        {
            Show(new Problem1(), 1000);
            Show(new Problem2(), 4000000);
            Show(new Problem3(), 600851475143);
            //Problem3();
            //Problem4();
            //Problem5();
            //"Press enter to continue".KeyPrompt();
            //Problem6();
            //Problem7();
            //Problem8();
            //Problem9();
            // Problem10();
            

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            
            new App().Go();
        }

    }
}
