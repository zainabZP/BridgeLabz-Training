using System;
class ParagraphAnalyzer{
    static void Main(){
        Console.WriteLine("enter a paragraph");
        string paragraph=Console.ReadLine();

        if(paragraph==null || paragraph.Length==0){
            Console.WriteLine("word count = 0");
            Console.WriteLine("longest word = ");
            Console.WriteLine("result = ");
            return;
        }

        Console.WriteLine("word count = "+Count(paragraph));
        Console.WriteLine("longest word = "+Longest(paragraph));

        Console.WriteLine("enter word to replace");
        string oldWord=Console.ReadLine();
        Console.WriteLine("enter new word");
        string newWord=Console.ReadLine();

        string result=Replace(paragraph,oldWord,newWord);
        Console.WriteLine("result = "+result);
    }

    public static int Count(string paragraph){
        int count=0;
        bool inWord=false;

        for(int i=0;i<paragraph.Length;i++){
            if(paragraph[i]!=' ' && !inWord){
                count++;
                inWord=true;
            }
            if(paragraph[i]==' '){
                inWord=false;
            }
        }
        return count;
    }

    public static string Longest(string paragraph){
        string[] words=WordArray(paragraph);
        int maxLength=0;
        string longestWord="";

        for(int i=0;i<words.Length;i++){
            if(words[i].Length>maxLength){
                maxLength=words[i].Length;
                longestWord=words[i];
            }
        }
        return longestWord;
    }

    public static string[] WordArray(string paragraph){
        int totalWords=Count(paragraph);
        string[] wordArray=new string[totalWords];

        string currentWord="";
        int index=0;

        for(int i=0;i<paragraph.Length;i++){
            if(paragraph[i]!=' '){
                currentWord+=paragraph[i];
            }
            else if(currentWord.Length>0){
                wordArray[index++]=currentWord;
                currentWord="";
            }
        }

        if(currentWord.Length>0){
            wordArray[index]=currentWord;
        }

        return wordArray;
    }

    public static string Replace(string paragraph,string oldWord,string newWord){
        string result="";
        int i=0;

        while(i<paragraph.Length){
            bool match=true;

            if(i+oldWord.Length<=paragraph.Length){
                for(int j=0;j<oldWord.Length;j++){
                    char c1=paragraph[i+j];
                    char c2=oldWord[j];

                    if(c1>='A'&&c1<='Z') c1=(char)(c1+32);
                    if(c2>='A'&&c2<='Z') c2=(char)(c2+32);

                    if(c1!=c2){
                        match=false;
                        break;
                    }
                }
            }
            else{
                match=false;
            }

            if(match){
                for(int k=0;k<newWord.Length;k++){
                    result+=newWord[k];
                }
                i+=oldWord.Length;
            }
            else{
                result+=paragraph[i];
                i++;
            }
        }
        return result;
    }
}
