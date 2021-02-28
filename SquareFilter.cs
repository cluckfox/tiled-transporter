using System;
namespace tiled_transporter
{

    class SquareFilter<T> : IValidator<T> where T : IComparable
    {
        public bool test(T x, T y)
        {
            return x.Equals(y);
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