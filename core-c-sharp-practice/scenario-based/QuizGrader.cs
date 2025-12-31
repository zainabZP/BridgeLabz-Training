using System;
// making admin class
static class QuizGraderAdmin{
    // making score, questions and answers private 
    private static int score=0;
    private static string[] question={
        "What is the capital of India?",
        "Who is known as the Father of the Indian Constitution?",
        "Which planet is called the Red Planet?",
        "What is the national animal of India?",
        "Which is the longest river in India?",
        "Who invented the telephone?",
        "What is the largest ocean in the world?",
        "Which gas do plants use for photosynthesis?",
        "Who was the first Prime Minister of India?",
        "How many continents are there in the world?"
    };
    private static string[] answer={
        "Delhi","B.R. Ambedkar","Mars","Tiger","Indus River","Alexander Graham Bell","Pacific Ocean","Carbon Dioxide","Jawahar Lal Nehru","Seven"
    };
    // setting up getter method for question
    public static string[] GetQuestions(){
        return question;
    }
    public static void Main(){
        QuizGraderUser user1=new QuizGraderUser();
        string[] userAnswers=user1.AnswerArray(GetQuestions());
        // calculating score
        for(int i=0;i<userAnswers.Length;i++){
            if(userAnswers[i].Equals(QuizGraderAdmin.answer[i])) score++;
        }
        Console.WriteLine("SCORE : "+score);
    }
}
//user class to provide users answer to admin class
class QuizGraderUser{
    internal string[] AnswerArray(string[] questions){
        string[] userAnswer=new string[questions.Length];
        Console.WriteLine("GAME STARTS NOW");
        for(int i=0;i<questions.Length;i++){
            Console.WriteLine(questions[i]);
            userAnswer[i]=Console.ReadLine();
        }
        return userAnswer;
    }
}