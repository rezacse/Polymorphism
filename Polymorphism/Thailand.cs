

namespace Polymorphism
{
    public class Thailand : CalculatorBase
    {   

        protected override double CalculateBalance(double unitPrice, int numberOfItems)
        {
            return unitPrice * numberOfItems;
        }

        protected override double CalculateTax(double balance)
        {
            return balance * 0.07;
        }
    } 
}
