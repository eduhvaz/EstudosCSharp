using System;

namespace ExercioTresHerancaPolimorfismo.Entities
{
    class Company : TaxPayer
    {
        public int numberOfEmployees { get; set; }

        public Company()
        { }

        public Company(string name, double anuallncome, int numberOfEmployees) : base( name, anuallncome)
        {
            this.numberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (numberOfEmployees >= 10)
            {
                return Anuallncome * 0.14;
            }
            else
            {
                return Anuallncome * 0.16;
            }
         }
    }
}

