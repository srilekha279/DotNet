namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Day2Exercises day= new Day2Exercises();
            //day.Ternary();
            //day.Greatest();
            //day.GreatestSmallest3UsingIf();
            //day.Primes();
            //day.ExecuteOptions();
            //day.OddDigits();
            Arrays arrays = new Arrays();
            //arrays.DisplayArray();
            //arrays.OneDArray();
            //arrays.AddMatrices();
            //arrays.JaggedArray();
            JaggedArrays jagged = new JaggedArrays();
            // jagged.JaggedWithMultiDim();

            Strings s = new Strings();
            //s.StringFunctions();

            MyStringBuilder mysb = new MyStringBuilder();
          //  mysb.Methods();
          //  mysb.Session1();

            SimpleStruct ss = new SimpleStruct();
           // ss.AcceptAndPrint();

            SimpleInheritance si = new SimpleInheritance();
            //si.AcceptAndPrint();

            StringBuilderExercises sbe = new StringBuilderExercises();
            // sbe.CallMethods();

            MyCalculator mycal = new MyCalculator();
            // mycal.Implement();


            DynamicPoly dp = new DynamicPoly();
           // dp.AcceptAndPrint();

            Interfaces i = new Interfaces();
            //i.Display();

           AbstractClasses ac = new AbstractClasses();
            //ac.Display();

            // Singleton sin = Singleton.getInstance();

            FunctionParameters fp = new FunctionParameters();
           // fp.OutParam();

            AccessModPractice amd = new AccessModPractice();
            Derived amdDerived = new Derived();
            //Console.WriteLine($"public int: {amd.pubInt}, internal int: {amd.intInt}, protected internal int: {amd.protintInt}");
            //amd.public_member();
            ////amd.private_member();
            //amd.protected_internal_member();
            //amd.internal_member();
            //amdDerived.AccessFromDervied();




        }
    }
}
