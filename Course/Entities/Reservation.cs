using System;
using Course.Entities.Exception;
namespace Course.Entities
{
	public class Reservation
	{
		public int RoomNumber { get; set; }
		public DateTime Checkin { get; set; }
		public DateTime Checkout { get; set; }

		public Reservation()
		{
		}

		public Reservation(int roomNumber, DateTime checkin, DateTime checkout)

		{
			if (Checkout <= Checkout)
			{
				throw new DomainException("Check-out date must be after check-in date");
			}

			RoomNumber = roomNumber;
			Checkin = checkin;
			Checkout = checkout;
		}

		public int Duration()
		{
			TimeSpan durantion = Checkout.Subtract(Checkin);
			return (int)durantion.TotalDays;
		}

		public void UpdateDates(DateTime checkin, DateTime checkout)
		{
			DateTime now = DateTime.Now;
			if (checkin < now || checkout < now)
			{
				throw new DomainException("erro na reserva, tem que ser datas futuras");
			}
			if (checkout <= checkin)
			{
				throw new DomainException("erro na reserva, data errada");
			}
			Checkin = checkin;
			Checkout = checkout;
		}
		public override string ToString()
		{
			return $"Room: {RoomNumber}, check-in: {Checkin.ToString("dd/MM/yyyy")}, checkout: {Checkout.ToString("dd/MM/yyyy")}, {Duration()} Nights.";
		}
	}
}


