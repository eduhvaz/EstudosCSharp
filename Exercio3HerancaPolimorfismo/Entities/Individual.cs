using System;
namespace ExercioTresHerancaPolimorfismo.Entities
{
    class Individual : TaxPayer
    {
        public double healthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anuallncome, double healthExpenditures) : base(name, anuallncome)
        {
            healthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (Anuallncome <= 20000.00)
            {
                double tax = Anuallncome * 0.15;
                return (Anuallncome * 0.15) - (tax * 0.50);
            }
            else
            {
                double tax = Anuallncome * 0.25;
                return (Anuallncome * 0.25) - (tax * 0.50);
            }
        }
    }
}