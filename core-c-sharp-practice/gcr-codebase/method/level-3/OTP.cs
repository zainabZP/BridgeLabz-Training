using System;
class OTP{
    public static int SixDigitOTP(){
        Random rand=new Random();
        int otp=rand.Next(100000,1000000);
        return otp;
    }
    public static int[] OtpArray(){
        int[] a=new int[10];
        for(int i=0;i<10;i++){
            int x=SixDigitOTP();
            a[i]=x;
        }
        return a;
    }
    public static bool Unique(){
         int[] arr=OtpArray();
         Array.Sort(arr);
         for(int i=0;i<arr.Length-1;i++){
            if(arr[i]==arr[i+1]) return false;
         }
         return true;
    }
    static void Main(){
        int otp = SixDigitOTP();
        Console.WriteLine("6-digit OTP = " + otp);
        int[] otpArr = OtpArray();
        Console.WriteLine("10 OTPs are : ");
        for(int i=0;i<otpArr.Length;i++){
            Console.WriteLine(otpArr[i]);
        }
        if(Unique()) Console.WriteLine("All OTPs are unique");
        else Console.WriteLine("Some OTPs are repeated");
    }
}
