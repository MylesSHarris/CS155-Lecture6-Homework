using System;
namespace Homework
{
    public class Counter
    {
        private int count;

        //Include a getter method that returns the current count value and a method that outputs the count to the screen.
        public void ResetCounter()
        {
            count = 0;
        }

        public void IncreaseCount()
        {
            count++;
        }

        public void DecreaseCount()
        {
            if (count > 0) count--;
        }

        public int GetCount()
        {
            return count;
        }

        public void PrintCount()
        {
            Console.WriteLine(count);
        }

        public override string ToString()
        {
            return count.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
