using System;

namespace Lab2
{
    public abstract class HumanDecorator : Human
    {
        public Human Human;
        public HumanDecorator(Human human)
        {
            this.Human = human;
        }
    }
}