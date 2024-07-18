namespace QuizConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of France?",
                    ["Paris","Berlin","London","Madrid"],
                    0
                ),
                new Question(
                    "What is 2+2?",
                    ["1","2","7","4"],
                    3
                )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
        }
    }
}