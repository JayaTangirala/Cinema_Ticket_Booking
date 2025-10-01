using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking
{
    internal class CinemaBooking
    {
        // Declare a 2D array for seats 
        string[,] seats;
        int rows, columns;

        //constructor to allocate memory for the seats
        public CinemaBooking(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            seats = new string[rows, columns];

            // Set all seats as Available
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    seats[i, j] = "Available";
                }
            }
        }
        public void printCurrentSeatStatus()
        {
            // Display seat layout
            Console.WriteLine("\nCurrent seat status:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("Row " + (i + 1) + ": ");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(seats[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void bookSeat()
        {
            // Prompt the user to select a seat
            Console.Write("\nEnter row number to book (1-"+rows+"): ");
            int rowNo = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("Enter seat number in that row (1-"+columns+"): ");
            int seatNo = Convert.ToInt32(Console.ReadLine()) - 1;

            // Check availability and book
            if (rowNo >= 0 && rowNo < rows && seatNo >= 0 && seatNo < columns)
            {
                if (seats[rowNo, seatNo] == "Available")
                {
                    seats[rowNo, seatNo] = "Booked";
                    Console.WriteLine("Seat successfully booked!");
                }
                else
                {
                    Console.WriteLine("Sorry, this seat is already booked.");
                }
            }
            else
            {
                Console.WriteLine("Invalid row or seat number.");
            }
        }
    }
}
