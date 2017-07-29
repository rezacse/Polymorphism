

namespace Polymorphism
{
    public class Cayman: CalculatorBase
    {
        protected override double CalculateBalance(double unitPrice, int numberOfItems)
        {
            return unitPrice * numberOfItems;
        }

        //protected override double CalculateTax(double balance)
        //{
        //   return base.CalculateTax(balance);
        //}
    }
}
