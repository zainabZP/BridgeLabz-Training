using System;
class CopyArray{
	static void Main(){
        int[,] arr={{1,2,3},{4,5,6},{0,9,0}};
        int[] copy=new int[arr.GetLength(0)*arr.GetLength(1)];
        int idx=0;
        for(int i=0;i<arr.GetLength(0);i++){
            for(int j=0;j<arr.GetLength(1);j++){
                copy[idx]=arr[i,j];
                idx++;
            }
        }
        for(int i=0;i<copy.Length;i++){
            Console.WriteLine(copy[i]);
        }
	}
}