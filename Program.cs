namespace CHALLENGE_3_1
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string s)
        {
            //compare the sting with its reversed version
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            return s == reversedString;
        }
        public static void Main(string[] args) 
        {
            Console.WriteLine(IsPalindrome("eye"));  //output: True
            Console.WriteLine(IsPalindrome("home")); //output: False

        }
    }
}
