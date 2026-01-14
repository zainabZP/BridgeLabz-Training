using System;
class Find{
    public static void Main(){
        // int[] rotated={ 4, 5, 6, 6, 7, 1, 1, 2, 2, 3 };
        // int[] rotated={3,4,5,2};
        int[] rotated={1,2,3,4,5};
        int min=rotated[0];bool flag=false;
        for(int k=0;k<rotated.Length;k++) min=Math.Min(min,rotated[k]);
        int i=0,j=rotated.Length-1;
        while(i<=j){
            int mid=(i+j)/2;
            if(rotated[mid]==min){
                Console.WriteLine(mid);flag=true;break;
            }
            else if(rotated[mid]>min){
                if(mid<rotated.Length-1&&rotated[mid+1]<rotated[mid]){
                    Console.WriteLine(mid+1);flag=true;break;
                }
                else j=mid-1;
            }
        }
        if(flag==false) Console.WriteLine("Any point can be considered as point of rotation");
    }
}