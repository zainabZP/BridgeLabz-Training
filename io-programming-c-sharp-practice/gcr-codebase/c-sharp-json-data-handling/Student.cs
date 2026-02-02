using System;

class Student
{
    static void Main()
    {
        string name = "Luna";
        int age = 22;
        string[] subjects = { "Maths", "Science", "English" };

        // creating json manually
        string jsonData = "{\n" +
                          "  \"name\": \"" + name + "\",\n" +
                          "  \"age\": " + age + ",\n" +
                          "  \"subjects\": [\n" +
                          "    \"" + subjects[0] + "\",\n" +
                          "    \"" + subjects[1] + "\",\n" +
                          "    \"" + subjects[2] + "\"\n" +
                          "  ]\n" +
                          "}";

        Console.WriteLine(jsonData);
    }
}
