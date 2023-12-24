namespace Extensions
{
    public static class BoolExtensions
    {
        public static bool CheckAnswer(this bool isTrue, string question)
        {
            Console.WriteLine(question);
            var answer = Console.ReadLine();
            var hasAnswer = answer?.ToLower().Equals("y");
            isTrue = hasAnswer.HasValue && hasAnswer.Value;
            return isTrue;
        }
    }
}