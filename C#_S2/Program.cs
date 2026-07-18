namespace C_S2
{
    internal class Program

    {
        #region Question 1
        //public class Book
        //{
        //    public string? Title;
        //    public int Pages;

        //    //public override string ToString()
        //    //{
        //    //return $"Title: {Title}, Pages: {Pages}";
        //    //}
        //}


        //static void Main(string[] args)
        //{
        //    Book book = new Book { Title = "C# Tutorial", Pages = 209 };
        //    object obj = book;
        //    Console.WriteLine(obj);
        #endregion

        #region question 2
        //Console.WriteLine(book.ToString());
        //Console.WriteLine(book.Equals(book));
        //Console.WriteLine(book.GetHashCode());
        //Console.WriteLine(book.GetType());
        #endregion

          #region question 3
        //int pages = "464"; compile error
        string pages = "464";
        #endregion

        #region question 4
        //try
        //{
        //    int zero = 0;
        //    int result = 10 / zero;
        //}
        //catch (DivideByZeroException)
        //{
        //    Console.WriteLine(" ERROR : Cannot divide by zero ");
        //}
        //finally
        //{
        //  Console.WriteLine("Done");
        // }
        #endregion

        #region q5
        //int No_of_pages = 300;
        //double pagesAsDouble = No_of_pages;
        //Console.WriteLine(pagesAsDouble);
        #endregion
Console.WriteLine"_______________________________________________");

double price = 50.99;
int roundedPrice = (int)price;
Console.WriteLine(roundedPrice);

Console.WriteLine("_______________________________________________");

string pagesText = "464";
int no_pages = Convert.ToInt32(pagesText);
Console.WriteLine(no_pages);

Console.WriteLine("_______________________________________________");

string yearText = "2026";
int year = int.Parse(yearText);
Console.WriteLine(year);

string badText = "FGH";

if (int.TryParse(badText, out int Result))
{
    Console.WriteLine(Result);
}
else
{
    Console.WriteLine("Invalid number");
}

Console.WriteLine("_______________________________________________");

int pagesNo = 464;
string pagestext = pages.ToString();
Console.WriteLine(pagesText);
Console.WriteLine(pagesText.GetType());

Console.WriteLine("_______________________________________________");

int copies = 100;
object boxed = copies;
int unboxed = (int)boxed;
Console.WriteLine(boxed);
Console.WriteLine(unboxed);

Console.WriteLine("_______________________________________________");

int? year1 = null;
Console.WriteLine(year1.HasValue);

year1 = 2023;
Console.WriteLine(year1.Value);

Console.WriteLine("_______________________________________________");

string? reviewer = null;
Console.WriteLine(reviewer is null);

Console.WriteLine("_______________________________________________");

Book? book1 = null;
string? title = book1?.Title;
Console.WriteLine(title);

Console.WriteLine("_______________________________________________");

Console.WriteLine(title ?? "None");

title ??= "None";
Console.WriteLine(title);

Console.WriteLine("_______________________________________________");

string? name = "Ali";
string confirmedName = name!;
Console.WriteLine(confirmedName);

        }
    }
}
