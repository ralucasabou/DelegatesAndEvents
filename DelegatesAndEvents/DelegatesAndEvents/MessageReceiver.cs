using System;

namespace DelegatesAndEvents
{
    public class MessageReceiver
    {

        public void Receiver(string message)
        {
            Console.WriteLine($"MessageReceiver received message: {message}");
        }
    }
}
