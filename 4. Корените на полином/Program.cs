using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter the polynomial coefficients separated by space: ");
        double[] coefficients = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        var roots = FindRoots(coefficients);
        Console.WriteLine("Roots: " + string.Join(", ", roots));
    }

    static double[] FindRoots(double[] coefficients)
    {
        int degree = coefficients.Length - 1;

        if (degree == 2)
        {
            return SolveQuadratic(coefficients[0], coefficients[1], coefficients[2]);
        }
        else if (degree == 3)
        {
            return SolveCubic(coefficients[0], coefficients[1], coefficients[2], coefficients[3]);
        }
        else
        {
            throw new NotImplementedException("Only quadratic and cubic polynomials are supported.");
        }
    }

    static double[] SolveQuadratic(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 =
