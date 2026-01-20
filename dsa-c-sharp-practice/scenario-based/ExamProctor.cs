using System;
using System.Collections.Generic;

class OnlineExam
{
    Stack<int> navigationStack = new Stack<int>();
    Dictionary<int, string> answers = new Dictionary<int, string>();
    Dictionary<int, string> correctAnswers = new Dictionary<int, string>();
    public OnlineExam(){
        correctAnswers[1] = "A";
        correctAnswers[2] = "B";
        correctAnswers[3] = "C";
        correctAnswers[4] = "D";
    }
    public void GoToQuestion(int questionID){
        navigationStack.Push(questionID);
        Console.WriteLine("Visited Question: " + questionID);
    }
    public void SubmitAnswer(int questionID, string answer){
        answers[questionID] = answer;
        Console.WriteLine("Answer saved for Question " + questionID);
    }
    public int CalculateScore()
    {
        int score = 0;
        foreach (var item in answers)
        {
            int qid = item.Key;
            string ans = item.Value;

            if (correctAnswers.ContainsKey(qid) && correctAnswers[qid] == ans)
            {
                score++;
            }
        }
        return score;
    }
    public void LastVisited()
    {
        if (navigationStack.Count > 0)
            Console.WriteLine("Last visited question: " + navigationStack.Peek());
        else
            Console.WriteLine("No questions visited yet!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        OnlineExam exam = new OnlineExam();

        exam.GoToQuestion(1);
        exam.SubmitAnswer(1, "A");

        exam.GoToQuestion(2);
        exam.SubmitAnswer(2, "C");

        exam.GoToQuestion(3);
        exam.SubmitAnswer(3, "C");

        exam.LastVisited(); 

        int totalScore = exam.CalculateScore();
        Console.WriteLine("Your total score is: " + totalScore);
    }
}
