using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTotalAmountWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Array With Name and Marks Combinations:");
            String inputvalues = Convert.ToString(Console.ReadLine());
            String[] values = inputvalues.Split(',');
            var result = values.ToList();

            var objects = result.Where(x => !string.IsNullOrEmpty(x)).Select(x => x.Split(':')).GroupBy(a => a[0].Trim()).Select(a => new { name = a.Key + " " + Convert.ToString(a.ToList().Sum(s => Convert.ToDouble(s[1]))) });
            var finalResult = objects.Select(a => a.name).ToArray();
            var abc = string.Join(",", finalResult);

            Console.WriteLine(abc);
            Console.ReadKey();
        }
    }
}
