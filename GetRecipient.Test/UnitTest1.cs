namespace GetRecipient.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        [TestCase("@User_One @UserABC! Have you seen this from @Userxyz?", 1, "User_One")]
        [TestCase("@User_One @UserABC! Have you seen this from @Userxyz?", 2, "UserABC")]
        [TestCase("@User_One @UserABC! Have you seen this from @Userxyz?", 3, "Userxyz")]
        [TestCase("@User_One @UserABC! Have you seen this from @Userxyz?", 4, "")]
        [TestCase("", 1, "")]
        [TestCase("@User_One @UserABC! Have you seen this from @Userxyz?", -1, "")]
        [TestCase("@User_One @UserABC! Have you seen this from archiefan@gmail.com?", 3, "")]
        public void TestGetValue1(string message, int position, string expected)
        {
            var solution = new Solution();
            Assert.That(solution.GetRecipient(message, position), Is.EqualTo(expected));
        }

    }
}