namespace tiled_transporter {
    interface IValidator<T>
    {
        public bool test(T x, T y);
        public void check(T x, T y);
    }
}