using System;
class Find{
    public static void Main(){
        int[] arr={1,8,-3,0,9,56,-7};
        for(int i=0;i<arr.Length;i++){
            if(arr[i]<0){
                Console.WriteLine(arr[i]);break;
            }
        }
    }
}