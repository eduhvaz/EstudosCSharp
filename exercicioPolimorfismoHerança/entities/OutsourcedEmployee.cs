namespace exercicioPolimorfismoHerança.entities
{
	public class OutsourcedEmployee : Employee
	{
        public double additionalCharga { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharga) : base (name, hours, valuePerHour)
        {
            this.additionalCharga = additionalCharga;
        }

        public override double payment()
        {
            return base.payment() + 1.1 * additionalCharga;
        }
    }
}

