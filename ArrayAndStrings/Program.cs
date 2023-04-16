namespace ArrayAndStringRotation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] names = new string[4] { "Venu", "Vikki", "Varun", "Vamsi" };
            //Accrssing Elements in Array
            foreach (string name in names)//Using Foreachloop
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("- - - - - - - ");
            for (int i = 0; i < names.Length; i++)//Using Forloop
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("- - - - -  -");
            Console.WriteLine("Enter String");
            string input = Console.ReadLine();// String reversing
            char[] arr = { ' ', ',', '\\', '/' };
            string[] words = input.Split(arr);
            string reverse = "";
            foreach (string word in words)
            {
                string result = " ";
                for (int i = 0; i <= (word.Length - 1); i++)
                {
                    result = word[i] + result;
                }
                Console.WriteLine(result);
                reverse = result + reverse;
            }
            Console.WriteLine(reverse);
        }
    }



}