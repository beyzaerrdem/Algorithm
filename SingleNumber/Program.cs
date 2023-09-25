
namespace SingleNumber
{
    //https://leetcode.com/problems/single-number-iii/
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 1, 3, 2, 5 };
            Console.WriteLine(SingleNumber(nums));
        }

        public static int[] SingleNumber(int[] nums)
        {

            List<int> l = new List<int>(nums);
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = i+1; j < l.Count; j++)
                {
                    if (l[i] == l[j])
                    {
                        l.RemoveAll(x => x == l[i]);
                        i = 0;
                        break;
                    }
                    Console.WriteLine(l);
                }            
            }        
            return l.ToArray();
        }
    }
}


