using System;
class MatrixOps{
    static void Main(){
        int[,] a = MakeMatrix(2,2);
        int[,] b = MakeMatrix(2,2);

        Console.WriteLine("Matrix a:");
        Show(a);
        Console.WriteLine("Matrix b:");
        Show(b);

        Console.WriteLine("a + b:");
        Show(Add(a,b));

        Console.WriteLine("Transpose of a:");
        Show(Transpose(a));

        Console.WriteLine("Determinant of a = " + Det2x2(a));
    }
    static int[,] MakeMatrix(int r,int c){
        int[,] m = new int[r,c];
        Random rand = new Random();
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                m[i,j] = rand.Next(1,10);
            }
        }
        return m;
    }
    static int[,] Add(int[,] x,int[,] y){
        int[,] res = new int[2,2];
        for(int i=0;i<2;i++){
            for(int j=0;j<2;j++){
                res[i,j] = x[i,j] + y[i,j];
            }
        }
        return res;
    }
    static int[,] Transpose(int[,] x){
        int[,] t = new int[2,2];
        for(int i=0;i<2;i++){
            for(int j=0;j<2;j++){
                t[j,i] = x[i,j];
            }
        }
        return t;
    }
    static int Det2x2(int[,] m){
        return m[0,0]*m[1,1] - m[0,1]*m[1,0];
    }
    static void Show(int[,] m){
        for(int i=0;i<m.GetLength(0);i++){
            for(int j=0;j<m.GetLength(1);j++){
                Console.Write(m[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}
