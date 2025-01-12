using Course.Entities.Exception;
using System.Globalization;
using Course.Entities;


namespace Course
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Room number: ");
                int Room = int.Parse(Console.ReadLine());
                Console.Write("Check -in date(dd / MM / yyyy): ");
                DateTime checkin = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Check -out date(dd / MM / yyyy): ");
                DateTime checkout = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Reservation reservation = new Reservation(Room, checkin, checkout);
                Console.WriteLine("reservation" + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check -in date(dd / MM / yyyy): ");
                checkin = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Check -out date(dd / MM / yyyy): ");
                checkout = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);


                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("reservation" + reservation);

            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}


