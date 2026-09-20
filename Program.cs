using System;

namespace ConsoleApp1;

// ============================
// Q1: تعريف كلاس Book
// ============================
public class Book
{
public string Title { get; set; }
public int Pages { get; set; }
}

class Program
{
static void Main(string[] args)
{
    // =========================================================
    // Q1: عمل object من كلاس Book وتخزينه في متغير من نوع object
    // =========================================================
    Console.WriteLine("===== Q1: Book object =====");
    Book book = new Book { Title = "The Hobbit", Pages = 310 };
    object obj = book;
    Console.WriteLine(obj); // هيطبع اسم الكلاس لأننا مسويناش override لـ ToString()
    Console.WriteLine();

    // =========================================================
    // Q2: ToString(), Equals(), GetHashCode(), GetType()
    // =========================================================
    Console.WriteLine("===== Q2: Object methods =====");
    Console.WriteLine(book.ToString());
    Console.WriteLine(book.Equals(book));
    Console.WriteLine(book.GetHashCode());
    Console.WriteLine(book.GetType());
    Console.WriteLine();

    // =========================================================
    // Q3: compile-time error (متعلق - مش هيتشغل، اتقفلت كتعليق)
    // int pages3 = "464";  // Compile-time error: can't assign string to int
    // =========================================================
    Console.WriteLine("===== Q3: Compile-time error (see comment in code) =====");
    int pages3 = 464; // النسخة المصححة
    Console.WriteLine(pages3);
    Console.WriteLine();

    // =========================================================
    // Q4: Divide by zero - try/catch/finally
    // =========================================================
    Console.WriteLine("===== Q4: Divide by zero =====");
    try
    {
        int a = 10;
        int b = 0;
        int result = a / b;
        Console.WriteLine(result);
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
    }
    finally
    {
        Console.WriteLine("Done");
    }
    Console.WriteLine();

    // =========================================================
    // Q5: Implicit conversion (int -> double)
    // =========================================================
    Console.WriteLine("===== Q5: Implicit conversion =====");
    int pages5 = 300;
    double pagesAsDouble = pages5;
    Console.WriteLine(pagesAsDouble);
    Console.WriteLine();

    // =========================================================
    // Q6: Explicit conversion / cast (double -> int)
    // =========================================================
    Console.WriteLine("===== Q6: Explicit conversion (cast) =====");
    double price = 49.99;
    int priceAsInt = (int)price;
    Console.WriteLine(priceAsInt);
    Console.WriteLine();

    // =========================================================
    // Q7: Convert class (string -> int)
    // =========================================================
    Console.WriteLine("===== Q7: Convert class =====");
    string pagesText7 = "464";
    int pages7 = Convert.ToInt32(pagesText7);
    Console.WriteLine(pages7);
    Console.WriteLine();

    // =========================================================
    // Q8: int.Parse() and int.TryParse()
    // =========================================================
    Console.WriteLine("===== Q8: Parse and TryParse =====");
    string yearText = "2023";
    int year = int.Parse(yearText);
    Console.WriteLine(year);

    string badText = "abc";
    if (int.TryParse(badText, out int parsedResult))
    {
        Console.WriteLine(parsedResult);
    }
    else
    {
        Console.WriteLine("Invalid number");
    }
    Console.WriteLine();

    // =========================================================
    // Q9: int -> string, then check its type
    // =========================================================
    Console.WriteLine("===== Q9: int to string =====");
    int pages9 = 464;
    string pagesText9 = pages9.ToString();
    Console.WriteLine(pagesText9.GetType());
    Console.WriteLine();

    // =========================================================
    // Q10: Boxing and Unboxing
    // =========================================================
    Console.WriteLine("===== Q10: Boxing and Unboxing =====");
    int copies = 100;
    object boxed = copies;      // boxing
    int unboxed = (int)boxed;   // unboxing
    Console.WriteLine(boxed);
    Console.WriteLine(unboxed);
}
}
