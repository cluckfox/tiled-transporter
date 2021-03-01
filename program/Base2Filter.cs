using System;

namespace tiled_transporter
{
    public class Base2Filter<T> : IValidator<T> where T : IConvertible
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
            var bigA = Convert.ToUInt64(a);
            return (Math.Ceiling(Math.Log2(bigA)) == Math.Floor(Math.Log2(bigA)));
        }
    }
}