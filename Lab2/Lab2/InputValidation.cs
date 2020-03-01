using System.Text.RegularExpressions;

namespace Lab2
{
    using System;

    public static class InputValidation
    {
        public static bool AgeIsValid(string str)
        {
            var age = 0;
            if (int.TryParse(str, out age))
            {
                if (age > 0 && age <= 120)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool WeightIsValid(string str)
        {
            float weight = 0;
            if (float.TryParse(str, out weight))
            {
                if (weight > 0 && weight <= 200)
                {
                    return true;
                }
            }

            return false;
        }
        
        public static bool HeightIsValid(string str)
        {
            float height = 0;
            if (float.TryParse(str, out height))
            {
                if (height > 0 && height <= 300)
                {
                    return true;
                }
            }

            return false;
        }
    }
}