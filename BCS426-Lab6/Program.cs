using System;
namespace LearnCSharp
{
    public class ComplexNumber
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }

        public ComplexNumber(double r = -1, double i = -1)
        {
            RealPart = r;
            ImaginaryPart = i;
        }
        public override string ToString() => $"{RealPart} + {ImaginaryPart}i";

        public static ComplexNumber operator + (ComplexNumber cn1, ComplexNumber cn2) 
        {
            return new ComplexNumber(cn1.RealPart + cn2.RealPart, cn1.ImaginaryPart + cn2.ImaginaryPart);
        }

        public static bool operator == (ComplexNumber cn1, ComplexNumber cn2)
        {
            if ((cn1.RealPart == cn2.RealPart) && (cn1.ImaginaryPart == cn2.ImaginaryPart))
                return(true);
            else
                return(false);
        }

        public static bool operator != (ComplexNumber cn1, ComplexNumber cn2)
        {
            return(!(cn1 == cn2));
        }
        
        public override int GetHashCode()
        {
            return (RealPart.GetHashCode() ^ ImaginaryPart.GetHashCode());
        }
    }

    class Program
    {
        static void Main()
        {
            var complexNumber1 = new ComplexNumber(10, 20);
            var complexNumber2 = new ComplexNumber(100, 200);
            ComplexNumber result;

            Console.WriteLine("First complex number is " + complexNumber1);
            Console.WriteLine("Second complex number is " + complexNumber2);

            result = complexNumber1 + complexNumber2;
            Console.WriteLine("Adding the two complex numbers we get " + result);

            if (complexNumber1 == complexNumber2)
            {
                Console.WriteLine("The two numbers are the SAME");
            }
            else
            {
                Console.WriteLine("The two numbers are NOT the SAME");
            }

            Console.WriteLine("Press any button to end program...");
            Console.ReadLine();
        }
    }
}