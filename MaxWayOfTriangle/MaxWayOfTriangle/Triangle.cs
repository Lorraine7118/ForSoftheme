using System;
using System.IO;

namespace MaxWayOfTriangle
{
    class Triangle
    {
        private StreamReader _StreamReader;
        public double[][] Matrix;
        private int MatrixLength;
        private string ElementsString;
        private string[] ElementsOfTriangleString;

        
        public Triangle(string Path)
        {          
            Matrix = Convert(Path);
        }

        private double[][] Convert(string Path)
        {
            if (File.Exists(Path))
            {
                double[][] Matrix;
                _StreamReader = File.OpenText(Path);
                MatrixLength = File.ReadAllLines(Path).Length;
                Matrix = new double[MatrixLength][];
                int i = 0;
                while ((ElementsString = _StreamReader.ReadLine()) != null)
                {
                    char delimiter = ' ';
                    ElementsOfTriangleString = ElementsString.Split(delimiter);
                    Matrix[i] = new double[ElementsOfTriangleString.Length];
                    for (int j = 0; j < ElementsOfTriangleString.Length; j++)
                    {
                        Matrix[i][j] = double.Parse(ElementsOfTriangleString[j]);
                    }
                    i++;
                }
                return Matrix;
            }
            return null;
        }

        public double MaxWayOfTriangle()
        {
            return max(Matrix, 0, 0);
        }

        private double max(double[][] matrix, int i, int j)
        {
            return matrix[i][j] + Math.Max(
                i < matrix.Length - 1 ? max(matrix, i + 1, j) : 0,
                i < matrix.Length - 1 ? max(matrix, i + 1, j + 1) : 0
                );
        }
    }
}
