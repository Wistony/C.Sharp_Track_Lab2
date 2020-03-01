namespace Lab2
{
    public abstract class Human
    { 
        public int Age { get; protected set; }
        public float Weight { get; protected set; }
        public float Height { get; protected set; }

        public abstract float GetDailyKCal();
    }

    public class Male : Human
    {
        public Male(int age, float weight, float height)
        {
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
        }

        public override float GetDailyKCal()
        {
            return this.Weight * 1 * 24;
        }
    }

    public class Female : Human
    {
        public Female(int age, float weight, float height)
        {
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
        }

        public override float GetDailyKCal()
        {
            return this.Weight * 0.9f * 24; 
        }
    }
    
}