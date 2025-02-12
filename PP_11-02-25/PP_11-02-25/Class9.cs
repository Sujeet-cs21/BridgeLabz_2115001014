using System;

namespace PP_11_02_25
{
    class Ticket
    {
        public int TicketID;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public string BookingTime;
        public Ticket Next;

        public Ticket(int ticketID, string customerName, string movieName, string seatNumber, string bookingTime)
        {
            TicketID = ticketID;
            CustomerName = customerName;
            MovieName = movieName;
            SeatNumber = seatNumber;
            BookingTime = bookingTime;
        }
    }

    class Class9
    {
        private Ticket head;

        public void AddReservation(int ticketID, string customerName, string movieName, string seatNumber, string bookingTime)
        {
            Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber, bookingTime);
            if (head == null)
            {
                head = newTicket;
                head.Next = head;
            }
            else
            {
                Ticket temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newTicket;
                newTicket.Next = head;
            }
        }

        public void RemoveReservation(int ticketID)
        {
            if (head == null)
            {
                Console.WriteLine("No Reservations Available");
                return;
            }

            if (head.Next == head && head.TicketID == ticketID)
            {
                head = null;
                return;
            }

            if (head.TicketID == ticketID)
            {
                Ticket tail = head;
                while (tail.Next != head)
                {
                    tail = tail.Next;
                }

                tail.Next = head.Next;
                head = head.Next;
                return;
            }

            Ticket temp = head;
            while (temp.Next != head)
            {
                if (temp.Next.TicketID == ticketID)
                {
                    temp.Next = temp.Next.Next;
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Reservation not found.");
        }


        public void DisplayReservations()
        {
            if (head == null)
            {
                Console.WriteLine("No reservations available.");
                return;
            }

            Ticket temp = head;
            while (temp.Next != head)
            {
                Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
                temp = temp.Next;
            }
            Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
        }

        public void SearchReservation(string searchQuery)
        {
            if (head == null) return;

            Ticket temp = head;
            do
            {
                if (temp.CustomerName == searchQuery || temp.MovieName == searchQuery)
                {
                    Console.WriteLine($"Found: Ticket ID: {temp.TicketID}");
                }
                temp = temp.Next;
            } while (temp != head);
        }

        public int CountReservations()
        {
            if (head == null) return 0;

            int count = 0;
            Ticket temp = head;
            do
            {
                count++;
                temp = temp.Next;
            } while (temp != head);

            return count;
        }

        public static void Main9()
        {
            Class9 system = new Class9();
            system.AddReservation(1, "Customer1", "Movie1", "A1", "20-02-25");
            system.AddReservation(2, "Customer2", "Movie2", "B2", "17-02-25");
            system.AddReservation(3, "Customer3", "Movie3", "C3", "01-03-25");

            system.DisplayReservations();
            system.RemoveReservation(2);
            system.DisplayReservations();
            system.SearchReservation("Titanic");
            Console.WriteLine("Total Reservations: " + system.CountReservations());
        }
    }
}
