namespace LineCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LineComparession lineCompProblem = new LineComparession(1, 2, 3, 4);
            double line1 = lineCompProblem.CalculateLength();
            Console.WriteLine("length of the first line" + line1);
            LineComparession lineCompProblem2 = new LineComparession(1, 2, 3, 4);
            double line2 = lineCompProblem2.CalculateLength();
            Console.WriteLine("length of the first line" + line2);
            if (line1 == line2)
            {
                Console.WriteLine("line1 is equal to line2");
            }
            else
            {
                Console.WriteLine("line1 is not equal to line2");
            }
        }
    }
}