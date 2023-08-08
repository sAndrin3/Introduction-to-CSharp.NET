using System;

// Hello World
    class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello @ The Jitu!");
        }
    }

//Predefined data types
class Program6 {
    static void Main()
    {
        byte myByte = 255;
        int myInt = 123456;

        Console.WriteLine(myByte);
        Console.WriteLine(myInt);
    }
}

//user-defined data types
class Person{
    public string Name {get; set; }
    public int Age {get; set; }

    public void SayHello(){
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old. ");
    }
}

class Program5 {
    static void Main(){
        Person person = new Person();
        person.Name = "Sandrine";
        person.Age = 22;

        person.SayHello();
    }
}

// String data type

class Program4{
    static void Main(){
        string ch = "Sandrine";
        var howManyBytes = ch.Length * sizeof(char);

        Console.WriteLine(ch);
        System.Console.WriteLine(howManyBytes);
    }
}

// Numeric data types without decimald

class Program3 {
    static void Main(){
        short num1 = 123;
        int num2 = 456;
        long num3 =789;

        System.Console.WriteLine($" short min value : {short.MinValue} and max value : {short.MaxValue}");
        System.Console.WriteLine($"short size:{sizeof(short)} Byte");
        System.Console.WriteLine($" int min value : {int.MinValue} and max value : {int.MaxValue}");
         System.Console.WriteLine($"int size:{sizeof(int)} Byte");
        System.Console.WriteLine($" long min value : {long.MinValue} and max value : {long.MaxValue}");
         System.Console.WriteLine($"long size:{sizeof(long)} Byte");
    }
}

//Implicit casting

class Program{
    static void Main(){
        // int myInt = 9;
        // double myDouble = myInt;

        byte myByte = 100;
        int myInt = myByte;

        System.Console.WriteLine(myInt);
        System.Console.WriteLine(myByte);
    }
}

// Explicit casting

class Program2{
    static void Main(){
        double myDouble = 9.78;
        int myInt = (int) myDouble;

        System.Console.WriteLine(myDouble);
        System.Console.WriteLine(myInt);
    }

// Type conversion

class Program1{
    static void Main(){
        int myInt = 10;
        double myDouble = 5.25;
        bool myBool = true;

        System.Console.WriteLine(Convert.ToString(myInt));
        System.Console.WriteLine(Convert.ToString(myInt));
        System.Console.WriteLine(Convert.ToInt32(myDouble));
        System.Console.WriteLine(Convert.ToString(myBool));
    }
}

}
