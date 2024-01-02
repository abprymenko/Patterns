namespace Patterns.Extensions
{
    public static class BoolExtenssion
    {
        public static bool CheckAnswer(this bool _, string question)
        {
            Console.WriteLine(question);
            var answer = Console.ReadLine();
            var hasAnswer = answer?.ToLower().Equals("y");
            return hasAnswer.HasValue && hasAnswer.Value;
        }
    }
}