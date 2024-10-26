namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumEvensInt(7);
            SumEvensVoid(5);
            string name = "  Code  Acacemy   ";
            name = StringEdit(name);
            Console.WriteLine(name);
            
        }

        #region task1

        static int SumEvensInt(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i+=2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            return sum;
        }
        static void SumEvensVoid(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        #endregion

        #region task2

        static string StringEdit(string name)
        {
            string newName = "";
            for (int i = 0; i < name.Length; i++)
            {
                
                if (name[i] == ' ')
                {
                    continue;
                }
                newName += name[i];
            }
           return newName;
        }

        #endregion
    }
}
