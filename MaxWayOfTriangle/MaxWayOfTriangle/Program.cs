using System;
using System.Net;

namespace MaxWayOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {            
            WebClient webclient = new WebClient();          
            webclient.DownloadFile("https://dl.dropboxusercontent.com/u/28873424/tasks/simple_triangle.txt", "Triangle.txt");           
            Triangle triangle = new Triangle("Triangle");           
            Console.WriteLine("The max way of triangle is " + triangle.MaxWayOfTriangle());
            Console.ReadKey();
        }

        
    }
}
