using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day35Concepts.GenericQueueConcepts
{
    public class GenericQueueConcept
    {
        public void QueueConceptsExamples()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Task1");
            queue.Enqueue("Task2");
            queue.Enqueue("Task3");

            var task = queue.Dequeue();

            var peekedATask = queue.Peek();

            queue.Clear();
        }

        public void MovieBookingSytemExample()
        {
            MovieTicketBookingSystem bookingSystem = new MovieTicketBookingSystem();
            bookingSystem.AddToQueue(new Customer { Name = "John", age = 20 });
            bookingSystem.AddToQueue(new Customer { Name = "Martin", age = 9 });
            bookingSystem.AddToQueue(new Customer { Name = "Sam", age = 25 });

            Console.ReadKey();
            bookingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("\nBooking Process Started");
            bookingSystem.ProceBooking();
            bookingSystem.ProceBooking();

            Console.ReadKey();
            bookingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("Adding More Customers to Queue");
            bookingSystem.AddToQueue(new Customer { Name = "Juli", age = 16 });
            bookingSystem.AddToQueue(new Customer { Name = "Cristin", age = 8 });

            Console.ReadKey();
            bookingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("\nBooking Process Started");
            bookingSystem.ProceBooking();
            bookingSystem.ProceBooking();

            Console.ReadKey();
            bookingSystem.ShowQueue();

            Console.ReadLine();
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public int age { get; set; }
    }

    class MovieTicketBookingSystem
    {
        Queue<Customer> _queue;

        public MovieTicketBookingSystem()
        {
            _queue = new Queue<Customer>();
        }

        public void AddToQueue(Customer customer)
        {
            _queue.Enqueue(customer);
            Thread.Sleep(1000);

            Console.WriteLine($"Added to Queue: {customer.Name}");
        }

        public void ProceBooking()
        {
            if (_queue.Any())
            {
                var customer = _queue.Dequeue();
                Thread.Sleep(1000);

                Console.WriteLine($"Processed Booking for: {customer.Name}");
            }
        }

        public void ShowQueue()
        {
            Console.WriteLine("\n\tCurrent Queue");
            Console.WriteLine("\t----------");

            foreach (var customer in _queue)
            {
                Thread.Sleep(1000);
                Console.WriteLine("\t" + customer.Name);
            }
        }
    }
}
