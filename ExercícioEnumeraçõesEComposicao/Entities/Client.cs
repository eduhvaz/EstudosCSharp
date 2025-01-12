using System;
namespace ExercícioProposto_EnumeraçõesEComposição_.Entities
{
	public class Client
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime birthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            birthDate = birthDate;
        }
        public override string ToString()
        {
            return Name
                + ", ("
                + birthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}

