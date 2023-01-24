using System;
class vars
{
    public int ECsum;
    public int ECaverage;
    public int EClargest;
}
class Program
{
    static void Main(string[] args)
    {
        var EClist = new List<int> { };
        int ECnumber;
        do
        {
            Console.WriteLine("What is your number?:");
            string ECuserInput = Console.ReadLine();
            ECnumber = int.Parse(ECuserInput);
            EClist.Add(ECnumber);
        } while (ECnumber != 0);




        foreach (int ECline in EClist)
        {
            ECsum += ECline;
            if (ECline > EClargest)
            {
                EClargest = ECline;
            }
        }
    }
}