namespace LineCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LineComparession lineCompProblem = new LineComparession(1, 2, 3, 4);
            lineCompProblem.CalculateLength();
        }
    }
}