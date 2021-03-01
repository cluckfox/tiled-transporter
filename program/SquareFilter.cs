using System;
namespace tiled_transporter
{

    public class SquareFilter<T> : IValidator<T> where T : IComparable
    {
        public bool test(T x, T y)
        {
            return x.CompareTo(0) > 0 && x.Equals(y);
        }

        public void check(T x, T y)
        {
            if (!this.test(x, y))
            {
                throw new System.ArgumentException("ERR_SQUARE_FILTER");
            }
        }
    }

}