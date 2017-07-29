using System;     

namespace Polymorphism
{
    public abstract class CalculatorBase
    {
        private double _balance;

        public void Execute(double unitPrice, int numberOfItems)
        {
            this._balance = this.CalculateBalance(unitPrice, numberOfItems);
            this._balance += this.CalculateTax(this._balance);
            Console.WriteLine($"{this._balance:N2}");

            //this._balance = 0;
            //this.CalculateBalanceWithTax(unitPrice, numberOfItems);
            //Console.WriteLine($"{this._balance:N2}");
        }    

        protected abstract double CalculateBalance(double unitPrice, int numberOfItems);

        protected virtual double CalculateTax(double balance)
        {
            return 0;
        }

        //protected virtual void CalculateBalanceWithTax(double unitPrice, int numberOfItems)
        //{
            
        //}
                        
    }
}
