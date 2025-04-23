namespace Exam1;

public class Q1_Add
{
    public int First { get; set; }
     public int Second { get; set; }

    public Q1_Add(int first, int second)
    {
        First = first;
        Second=second;
    }

    public static int Add(int first, int second)
    {
        return  first+second;
    }
}

// public class Basics
// {
//     public int First { get; set; }
//     public int Second { get; set; }   
//     public Basics(int first, int second)
//     {
//         First = first;
//         Second=second;
//     }

//     public static int Q2MultiplyAndReset(int first, int second)
//     {
//         int v = first*second;
//         int f = 1;
//         return v;
//         return f;
//     }
// }

public class Q4Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Q4Person(string name, int age)
    {
        Name =name;
        Age = age;
    }
    public string Introduce()
    {
        return $"Hello, my name is {Name} and I am {Age} years old.";
    }
}

// public class Q6Temperature
// {
//     public double Celsius { get; set; }
//     public double Fahrenheit { get; set; }
//     // public Q6Temperature(double celsius,double fahrenheit )
//     // {
//     //     Celsius = celsius;
//     //     Fahrenheit = fahrenheit;
//     // }
     
//      public double ctof(double celsius)
//      {
//         return 1.8*(32-celsius);
//      }

//      public double ctoc(double c)
//      {
//         return c;
//      }

//      public double ftoc(double f)
//      {
//         return 32+(f*1.8);
//      }

//      public double ftof(double f)
//      {return f;}
// }




// public interface IShape
// {
//     public double GetArea();
//     public double GetPerimeter();
// }

// public class Q7Rectangle:IShape
// {
//     public double L;
//     public double W;

//     public Q7Rectangle(double ll, double ww)
//     {
//         L = ll;
//         W = ww;
//     }

//     public double GetArea()
//     {
//         return L*W;
//     }

//     public double GetPerimeter()
//     {
//         return 2*(L+W);
//     }
// }

// public class Q7Circle:IShape
// {
//     public double Radius;

//     public Q7Circle(double r)
//     {
//         Radius = r;
//     }

//     public double GetArea()
//     {
//         return Math.PI*Radius*Radius;
//     }

//     public double GetPerimeter()
//     {
//         return Math.PI*2*Radius;
//     }
// }