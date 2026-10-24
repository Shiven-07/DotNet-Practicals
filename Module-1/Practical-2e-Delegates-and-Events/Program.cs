using System;

namespace DelegatesEvents
{
    // Declare a delegate
    public delegate void NotifyHandler(string message);

    class EventPublisher
    {
        // Declare an event using the delegate
        public event NotifyHandler OnDataProcessed;

        public void ProcessData(string data)
        {
            Console.WriteLine($"Processing data: {data}");
            // Raise the event
            OnDataProcessed?.Invoke($"Data '{data}' has been processed!");
        }
    }

    class EventSubscriber
    {
        public void HandleEvent(string message)
        {
            Console.WriteLine($"[Subscriber] Received: {message}");
        }
    }

    // Simple delegate demo
    delegate int MathOperation(int x, int y);

    class Program
    {

static int Multiply(int a, int b) => a * b;
        static int Add(int a, int b) => a + b;

        static void Main(string[] args)
        {
            Console.WriteLine("=== Delegates Demo ===");
            MathOperation op = Multiply;
            Console.WriteLine($"Multiply(4,5) = {op(4, 5)}");

            op = Add;
            Console.WriteLine($"Add(4,5) = {op(4, 5)}");

            Console.WriteLine("\n=== Events Demo ===");
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();

            // Subscribe to the event
            publisher.OnDataProcessed += subscriber.HandleEvent;
            publisher.OnDataProcessed += (msg) => Console.WriteLine($"[Lambda] {msg}");

            publisher.ProcessData("Student Record");
            publisher.ProcessData("Salary Data");

            Console.ReadKey();
        }
    }
}
