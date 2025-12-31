using System;
class FormattingFixing{
    static void Main(){
        Console.WriteLine("enter a paragraph");
        string paragraph=Console.ReadLine(); 
        Display(paragraph);
    }

    public static int Count(string paragraph){
        int sentenceCount=0;
        for(int i=0;i<paragraph.Length;i++){
            if(paragraph[i]=='.' || paragraph[i]=='?' || paragraph[i]=='!') sentenceCount++;
        }
        return sentenceCount;
    }

    public static string[] StringArray(string paragraph){
        int totalSentences=Count(paragraph);
        string[] sentenceArray=new string[totalSentences];
        string currentSentence="";int index=0;

        for(int i=0;i<paragraph.Length;i++){
            if(paragraph[i]!='.'&&paragraph[i]!='?'&&paragraph[i]!='!'){
                currentSentence+=paragraph[i];
            }
            else{
                currentSentence+=paragraph[i];
                sentenceArray[index++]=currentSentence;
                currentSentence="";
            }
        }
        return sentenceArray;
    }

    public static string[] Trim(string paragraph){
        string[] sentences=StringArray(paragraph);
        string[] trimmedSentences=new string[sentences.Length];

        for(int i=0;i<sentences.Length;i++){
            int startIndex=0; 
            string sentence=sentences[i];

            while(startIndex<sentence.Length&&sentence[startIndex]==' '){
                startIndex++;
            }

            int lastIndex=sentence.Length-1;
            while(lastIndex>=0&&sentence[lastIndex]==' '){
                lastIndex--;
            }

            string newSentence="";
            for(int j=startIndex;j<=lastIndex;j++){
                newSentence+=sentence[j];
            }
            trimmedSentences[i]=newSentence;
        }
        return trimmedSentences;
    }

    public static void Display(string paragraph){
        string[] sentences=Trim(paragraph);
        string finalParagraph="";

        for(int i=0;i<sentences.Length;i++){
            string sentence=sentences[i];
            if(sentence.Length==0) continue;

            if(sentence[0]>='a'&&sentence[0]<='z') 
                finalParagraph+=(char)((int)sentence[0]-32);
            else 
                finalParagraph+=sentence[0];

            for(int j=1;j<sentence.Length;j++){
                if(sentence[j]!=' '||(sentence[j]==' '&&sentence[j+1]!=' ')){
                    if(sentence[j]>='A'&&sentence[j]<='Z') 
                        finalParagraph+=(char)((int)sentence[j]+32);
                    else 
                        finalParagraph+=sentence[j];
                }
            }
            finalParagraph+=' ';
        }
        Console.Write(finalParagraph);
    }
}
