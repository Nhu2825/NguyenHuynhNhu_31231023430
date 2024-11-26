namespace CSLT.Bonus
{
    internal class note
    {
        public static void Main(string[] args)
        {
            Div();
        }
        static double divi(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;    
        }
        public static void Div()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double res;
            try
            {
                res= divi(x, y);
                Console.WriteLine($"{x}/{y}={res}.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Nhap so khac 0.");
                Console.WriteLine(e.StackTrace);
            }


        }
    }
}
