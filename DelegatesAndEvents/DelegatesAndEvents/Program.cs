using System;

namespace DelegatesAndEvents
{
    public delegate int Sum3Numbers(int a1, int a2, int a3);

    public delegate void MessageBrodcast(string message);

    class Program
    {
        static void Main(string[] args)
        {
            MessageReceiver receiver = new MessageReceiver();

            MessageBrodcast brodcaster = null;
            brodcaster += ReceiveMessage;
            brodcaster += receiver.Receive;


            // brodcaster("Test message");

            DoSomething(broadcaster);
        }


        private static void Example_DelegatesPointingToStaticFunctions()
        {
            Sum3Numbers func1 = Sum;

            int sum = func1(1, 2, 3);

            Console.WriteLine($"Sum={sum}");
        }


        private static void Example_DelegatesPointingToInstanceFunctions()
        {
            MathHelper helper = new MathHelper();
            Sum3Numbers func1 = helper.Sum;

            int sum = func1(1, 2, 3);

            Console.WriteLine($"Sum={sum}");
        }


        private static void Example_DelegatesWithAnonimousFunctions()
        {
            Sum3Numbers func1 = delegate (int a, int b, int c)
            {
                return a + b + c;
            };

            int sum = func1(1, 2, 3);

            Console.WriteLine($"Sum={sum}");
        }
    
        private static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        private static void ReceiveMessage(string message)
        {
            Console.WriteLine($"Program received message: {message}");
        }

        private static void DoSomething(MessageBrodcast broadcaster)
        {
            Console.WriteLine("Doing some processing...");
            broadcaster("Job Finished");
        }

    }
}
