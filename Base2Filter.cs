using System;

namespace tiled_transporter
{
    class Base2Filter<T> : IValidator<T> where T : IConvertible
    {
        public void check(T x, T y)
        {
            if(!test(x,y))
            {
                throw new System.ArgumentOutOfRangeException("ERR_FILTER_BASE2");
            }
        }

        public bool test(T x, T y)
        {
            return this.isBase2(x) && this.isBase2(y);
        }

        private bool isBase2(T a)
        {
            var dblA = Convert.ToDouble(a);
            return Math.Ceiling(Math.Log2(dblA)) == Math.Floor(Math.Log2(dblA));
        }
    }
}