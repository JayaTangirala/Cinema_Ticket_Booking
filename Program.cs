using System;

namespace Ticket_Booking
{
    class Program
    {
        static void Main()
        {
            CinemaBooking booking = new CinemaBooking(3, 5);
            booking.printCurrentSeatStatus();

            string continueBooking = "yes";

            while (continueBooking == "yes")
            {
                booking.bookSeat();
                booking.printCurrentSeatStatus();

                Console.WriteLine("Do you want to book another seat? (yes/no)");
                //convert the input to lower case.
                continueBooking = Console.ReadLine().ToLower();
            }

            // Final seat layout
            Console.WriteLine("\nFinal seat status:");
            booking.printCurrentSeatStatus();
        }
    }
}

