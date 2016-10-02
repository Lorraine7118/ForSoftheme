using System.IO;

namespace MaxWayOfTriangle
{
    class TriangleToMatrix
    {
        StreamReader _StreamReader;
        double[][] Matrix;
        int MatrixLength;
        string ElementsString;
        string[] ElementsOfTriangleString;
        public TriangleToMatrix()
        {            
        }

        public double[][] Convert(string Path)
        {
            if (File.Exists(Path))
            {
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
    }
}
