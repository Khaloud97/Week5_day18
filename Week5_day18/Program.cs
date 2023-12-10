namespace Week5_day18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Implicit type of variable:
            //2 type of Implicit type of variable:
            //var key 

            // int x = 12345;
            //var y = 10;

            #region Extention-Method
            Console.WriteLine("Extention Method:");

            int x = 12345;
            Console.WriteLine("The number is =" + x);

            Console.WriteLine(IntegerMirror.Miror(x));
            Console.WriteLine(x.Miror());
            #endregion

            Console.WriteLine("------------------------------------");
            #region Anonymous dataType
            Console.WriteLine("Anonymous Type:");

            var emp1 = new { id = 1, Name = "khaloud", salary="2190" };
            var emp2 = new { Name = "Hamed", salary = "2190" };
            //var emp3 = new { id = 1, Name = "khaloud", salary = "2190" };//coby to do change 
           
            Console.WriteLine(emp1.GetType().Name);
            Console.WriteLine(emp2.GetType());

            #endregion

            Console.WriteLine("------------------------------------");
            #region LinQ 
            Console.WriteLine("LinQ Example:");

            List<int> lst = new List<int> { 1,2,3,4,5,6,7,8,9};
            List<int> result = Enumerable.Where(lst, x => x%2 !=0).ToList();//where LinQ operater ,result=odd number
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(result.GetType());

            //---------------------------------------------------------------------------------
            Console.WriteLine("---As Extention methd---"); 
            var res = lst.Where(x => x % 2 == 0).ToList();//even number
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(res.GetType());

            //---------------------------------------------------------------------------------
            Console.WriteLine("---SQL query---");
            var resSQl = from i in lst
                         where i%2 == 0
                         select i;

            foreach (var item in res)
            {
                Console.Write(item +", ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(resSQl.GetType());
            Console.WriteLine(resSQl);
            #endregion




           //---------------------------------------------------------------------------------
           Console.WriteLine("------------------------------------");
            List<int> lest2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var lnum = lest2.Where(x => x % 2 == 0); // is Enumerable type
            //var lnum = lest2.Where(x => x % 2 == 0).ToList(); //==> deffered exeution

            Console.WriteLine(lest2.GetType());

            lest2.Remove(2);
            lest2.AddRange(new int[] { 10, 11, 12, 13, 14 });

            foreach (var item in lnum)
            {
                Console.Write(item + ", ");
            }
            lest2.AddRange(new int[] { 15, 16, 17, 18, 19 });

            Console.WriteLine(" ");

          
            foreach (int i in lnum)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine(" ");




        }
    }
}