namespace CSLT.Bonus
{
    internal class note
    {
        public static void Main(string[] args)
        {
            //Div();
            OneDimArray();
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
        public static void OneDimArray()
        {
            Console.Write("Nhap so phan tu trong mang: ");
            int n = yeucaunhapInt();
            int[] a = new int[n];
            Nhapthucong(a,n);
            //AutoCr(a, n);  
            Inmang(a,n);
            Console.Write("Nhap so can tim: ");
            int x = yeucaunhapInt();
            if (!Timvitri(a, x))
            {
                Console.WriteLine($"Trong mang khong co {x}.");
            }
        }
        static int yeucaunhapInt()
        {
            int n;
            do
            {
                if (int.TryParse(Console.ReadLine(), out n))
                { break; }
                else Console.WriteLine("Ban can nhap mot so Nguyen!!");
            }
            while (true);
            return n;
        }
        static int[] Nhapthucong(int []a,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"element a[{i}]: ");
                a[i] = yeucaunhapInt();
            }
            return a;
        }
        static void Inmang(int[]a,int n)
        {
            Console.WriteLine("In mang: ");
            for (int i = 0;i < n; i++)
                Console.Write(a[i]+"\t");
            Console.WriteLine();
        }
        static bool Timvitri(int[]a,int n)
        {
            bool kt = false;
            for (int i = 0; i < a.Length;i++)
            {
                if (a[i] == n)
                {
                    Console.WriteLine($"{n} xuat hien o vi tri a[{i}].");
                    kt = true;
                }
            }    
            return kt;
        }
        static int[] AutoCr(int[]a,int n)
        {
            Random random = new Random();
            for (int i = 0;i<n ; i++)
            {
                a[i] = random.Next(1,100);
            }   
            return a;  
        }
    }
}
