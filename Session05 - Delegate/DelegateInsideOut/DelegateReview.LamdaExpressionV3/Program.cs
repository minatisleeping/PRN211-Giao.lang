namespace DelegateReview.LamdaExpressionV3;

// tính diện tích hcn, trả vè dt
delegate double TwoInputOneOutput(double a, double b);

class Program
{
    static void Main(string[] args)
    {
        TwoInputOneOutput f = GetArea;

        f = (width, length) => width * length;

        Console.WriteLine("Area: ", f(10, 10));

        //VIẾT HÀM X^Y

        f = (x, y) => Math.Pow(x, y);

        Console.WriteLine("Exponent: 2^10: ", f(2, 10));

        // HÀM CUỐI CÙNG
        // TÍNH CHU VI TAM GIÁC DỰA TRÊN A B C
        var fx = (double a, double b, double c) => a + b + c;4566

        Console.WriteLine("Chu vi tam giac - Perimeter: ", fx(3, 4, 5));

        Console.ReadLine();
    }

    static double GetExponent(double a, double b) => Math.Pow(a, b);
    

    static double GetArea(double width, double length)
    {
        return width * length;
    }
}

