 using System;
 
 class DataType
 {
	 static void Main(){
	 
		// primitive datatypes -
		
		 int a=5; // integer datatype
		 byte b=25; // byte datatype
		 short sho=3200; //short datatype
		 long l=123569988; //long datatype
		 float f=10.3f; // float datatype
		 double x=2.23; // double datatype
		 decimal d=124.45m; // decimal datatype
		 char ch='a'; // characters datatype
		 bool IsTrue=true; // boolean datatype
		 
		 Console.WriteLine(a.GetType());
		 Console.WriteLine(b.GetType());
		 Console.WriteLine(sho.GetType());
		 Console.WriteLine(l.GetType());
		 Console.WriteLine(f.GetType());
		 Console.WriteLine(x.GetType());
		 Console.WriteLine(d.GetType());
		 Console.WriteLine(ch.GetType());
		 Console.WriteLine(IsTrue.GetType());
		 
		 // non primitive datatype
		 
		 String s="Capgemini";
		 Console.WriteLine(s.GetType());
	 }
 }