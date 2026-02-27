using System;
using System.Text;
using System.Threading.Channels;

// README.md를 읽고 아래에 코드를 작성하세요.


//Person person = new Person();
//person.Name = "홍길동";
//person.Age = 25;
//person.Print();


//Hello hello = new Hello();
//hello.Hi();
//hello.Bye();

//int sum = Calculator.Add(10,20);
//int sub = Calculator.Substract(30, 10);
//int mul = Calculator.Multiply(10,3);
//Console.WriteLine($"덧셈 : {sum}");
//Console.WriteLine($"뺄셈 : {sub}");
//Console.WriteLine($"곱셈 : {mul}");


//string text = " Hello World ";
//Console.WriteLine(StringHelper.CleanAndUpper(text));
//Console.WriteLine(StringHelper.Reverse("Hello"));
//Console.WriteLine(StringHelper.IsNullOrEmpty(""));

//double sqrt = Math.Sqrt(16);
//double pow = Math.Pow(2, 3);
//int max = Math.Max(10, 20);
//int min = Math.Min(10, 20);

//Console.WriteLine($"제곱근 : {sqrt}");
//Console.WriteLine($"거듭제곱: {pow}");
//Console.WriteLine($"최댓값: {max}");
//Console.WriteLine($"최솟값: {min}");


//StringBuilder sb1 = new StringBuilder();
//sb1.Append("Hello");
//sb1.Append(" ");
//sb1.Append("World");
//string result1 = sb1.ToString();

//string result2 = new StringBuilder()
//    .Append("Hello")
//    .Append(" ")
//    .Append("World")
//    .ToString();

//Console.WriteLine(result1);
//Console.WriteLine(result2);

//string message = new MessageBuilder()
//   .AddText("안녕하세요!")
//   .AddNewLine()
//   .AddText("반갑습니다.")
//   .AddSpace()
//   .AddText("좋은 하루 되세요.")
//   .Build();

//Console.WriteLine(message);

//Point point = new Point(0, 0)
//    .MoveBy(10, 10)
//    .MoveBy(20, 20)
//    .MoveBy(30, 30);

//Console.WriteLine(point);

//string ms1 = " Hello World ";

//string result = ms1
//    .Trim()
//    .ToLower()
//    .Replace(" ", "_");
//Console.WriteLine(result);


//ImmutableCircle circle = new ImmutableCircle(10);
//Console.WriteLine($"원본 반지름: {circle.Radius}");

//ImmutableCircle circle2 = circle.WithRadius(20);
//Console.WriteLine($"새 원 반지름: {circle2.Radius}");
//Console.WriteLine($"원본 반지름: {circle.Radius}");

//Player player1 = new Player("용사", 1);
//Console.WriteLine($"player1: {player1.Name}, 레벨 {player1.Level}");
//Player player2 = player1.LevelUp("용사", 2);
//Console.WriteLine($"player2: {player2.Name}, 레벨 {player2.Level}");


string original = "Hello";
string modifed = original.ToUpper();

Console.WriteLine($"원본 {original}");
Console.WriteLine($"수정본 {modifed}");

public partial class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public partial class Person
{
    public void Print()
    {
        Console.WriteLine($"{Name}: {Age}");
    }
}


public partial class Hello
{
    public void Hi()
    {
        Console.WriteLine("안녕하세요!");
    }
    
}
public partial class Hello
{
    public void Bye()
    {
        Console.WriteLine("안녕히 가세요!");
    }
}

public static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Substract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

public static class StringHelper
{
    public static string CleanAndUpper(string input)
    {
        return input.Trim().ToUpper();
    }

    public static string Reverse(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
    public static bool IsNullOrEmpty(string input)
    {
        return string.IsNullOrEmpty(input);
    }
}

public class MessageBuilder
{
    private string _message = "";

    public MessageBuilder AddText(string text)
    {
        _message += text;
        return this;
    }

    public MessageBuilder AddSpace()
    {
        _message += " ";
        return this;
    }

    public MessageBuilder AddNewLine()
    {
        _message += "\n";
        return this;
    }

    public string Build()
    {
        return _message;
    }
}



public class Point
{
    public readonly int X;
    public readonly int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Point MoveBy(int dx ,int dy)
    {
        return new Point(X+ dx, Y+ dy);
    }
    public override string ToString()
    {
        return $"({X},{Y})";
    }
}


public class MutableCircle
{
    public int Radius { get; set; }

    public MutableCircle(int radius)
    {
        Radius = radius; 
    }
}

public class ImmutableCircle
{
    public int Radius { get; }

    public ImmutableCircle(int radius)
    {
        Radius = radius; 
    }
    public ImmutableCircle WithRadius(int newRadius)
    {
        return new ImmutableCircle(newRadius);
    }
}

public class Player
{
    public readonly string Name;
    public readonly int Level;

    public Player(string name, int level)
    {
        Name = name;
        Level = level;
    }


    public Player LevelUp(string uname, int ulevel)
    {
        return new Player(uname, ulevel);
    }
}

