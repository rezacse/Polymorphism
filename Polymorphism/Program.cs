using System;    

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            var readLine = Console.ReadLine();
            if (readLine == null)
                return;

            var input = readLine.Split(',');
            var instance = new Program();
            instance.Run(input[0], double.Parse(input[1]), int.Parse(input[2]));
        }

        private void Run(string className, double unitPrice, int numberOfItems)
        {
            //get the type of class under Polymorphism namespace
            var thisType = Type.GetType("Polymorphism." + className);
            if(thisType==null)
                return;

            // create instance of class
            var classIntance = Activator.CreateInstance(thisType, null);

            //get the "Execute" method
            var theMethod = thisType.GetMethod("Execute");
            if(theMethod==null)
                return;

            var parametersArray = new object[] { unitPrice, numberOfItems };
            theMethod.Invoke(classIntance, parametersArray);
        }
    }
}
