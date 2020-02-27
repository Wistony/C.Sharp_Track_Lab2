using System;
using System.Threading;

namespace Lab2
{
    public abstract class Human
    { 
        public int Age { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public string Name { get; set; }

        public abstract float GetDailyKCal();
    }

    public class Male : Human
    {
        public Male(int age, float weight, float height, string name)
        {
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
            this.Name = name;
        }

        public override float GetDailyKCal()
        {
            return this.Weight * 1 * 24;
        }
    }

    public class Female : Human
    {
        public Female(int age, float weight, float height, string name)
        {
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
            this.Name = name;
        }

        public override float GetDailyKCal()
        {
            return this.Weight * 0.9f * 24; 
        }
    }
    
}