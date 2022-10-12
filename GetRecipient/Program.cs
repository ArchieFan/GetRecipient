namespace GetRecipient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message = "@User_One @UserABC! Have you seen this from @Userxyz?";
            Solution solution = new Solution();
            var x = solution.GetRecipient(message, 1); 
            //GetRecipient(message, 2) = "UserABC";
            //GetRecipient(message, 3) = "Userxyz";
            //GetRecipient(message, 4) = "";
        }
    }
}