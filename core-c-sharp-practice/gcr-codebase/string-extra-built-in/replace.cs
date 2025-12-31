using System;
class ReplaceWord{
    static void Main(){
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        Console.WriteLine("Enter the word to replace:");
        string old = Console.ReadLine();
        Console.WriteLine("Enter the new word:");
        string nw = Console.ReadLine();
        string r = "";
        string temp = "";
        for (int i = 0; i < sentence.Length; i++){
            if (sentence[i] != ' '){
                temp += sentence[i];
            }
            else{
                if (temp == old)
                    r += nw + " ";
                else
                    r += temp + " ";

                temp = "";
            }
        }
        if (temp == old)
            r += nw;
        else
            r += temp;

        Console.WriteLine("Modified Sentence: " + r);
    }
}
