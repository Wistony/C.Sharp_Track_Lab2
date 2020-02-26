using System;

namespace Lab2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Human somePeople = new Human(19, 68, 183, Gender.Male, PhisActivity.VeryHigh, BodyType.Ectomorph);
            KilocaloriesCalculator calculator = new KilocaloriesCalculator();
            calculator.Calc(somePeople);
        }
    }
}
