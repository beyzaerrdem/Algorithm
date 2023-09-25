
namespace MajorityElement
{
    //https://leetcode.com/problems/majority-element/

    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] num = { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine(MajorityElement(num));
        }

        public static int MajorityElement(int[] nums)
        {
            int deger = nums.Length / 2;
            var tekrarEdenDeger = nums.GroupBy(x => x).Where(y => y.Count() > deger).Select(y => y.Key).ToList();
            return (tekrarEdenDeger.Count > 0) ? tekrarEdenDeger[0] : -1;
        }
    }
}

