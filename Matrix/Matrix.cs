using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldNumberRecognition
{
    internal class Matrix
    {
        int[,] matrix;
        readonly int size;
        private static Random random = new Random();

        /*****************************************************************************************************************************************/
        #region Constructors
        public Matrix(int sizeMatrix, int defaultValue = 0)
        {
            size = sizeMatrix;
            matrix = new int[size, size];
            if (defaultValue != 0)
            {
                SetMatrixDefaultValue(defaultValue);
            }
        }
        public Matrix(int[,] matrix)
        {
            size = matrix.GetLength(0);
            this.matrix = new int[size, size];
            Array.Copy(matrix, this.matrix, size * size);
        }
        public Matrix(string type)
        {
            Matrix tmpMatrix = Matrix_Generator.Generate(type);
            size = tmpMatrix.GetSize();
            matrix = new int[size, size];
            Array.Copy(tmpMatrix.GetMatrix(), matrix, size * size);
        }
        #endregion

        /*****************************************************************************************************************************************/
        #region Getters
        public int[,] GetMatrix()
        {
            return matrix;
        }
        public int GetSize()
        {
            return size;
        }
        public Color GetColorAt(int line, int collumn)
        {
            if (matrix[line, collumn] == 0)
            {
                return Color.FromArgb(255, 255, 255, 255);
            }
            return Color.FromArgb(255, 0, 0, 0);
        }
        public int GetValueAt(int line, int collumn)
        {
            return matrix[line, collumn];
        }
        public int GetMatrixLineOrHeight()
        {
            return matrix.GetLength(0);
        }
        public int GetMatrixCollumnOrWidth()
        {
            return matrix.GetLength(1);
        }
        #endregion

        /*****************************************************************************************************************************************/
        #region Setters
        private void SetMatrixDefaultValue(int valueDefault)
        {
            for (int line = 0; line < matrix.GetLength(0); line++)
            {
                for (int collumn = 0; collumn < matrix.GetLength(1); collumn++)
                {
                    matrix[line, collumn] = valueDefault;
                }
            }
        }
        public void SetValueAt(int line, int collumn, int value)
        {
            matrix[line, collumn] = value;
        }
        public void InvertValueAt(int line, int collumn)
        {
            if (matrix[line, collumn] == 0)
            {
                matrix[line, collumn] = 1;
            }
            else { matrix[line, collumn] = 0; }
        }
        #endregion

        /*****************************************************************************************************************************************/
        #region Operations
        public void Clear()
        {
            matrix = new int[size, size];
        }
        public void AddNoise(double noiseLevel)
        {
            int lines = matrix.GetLength(0);
            int collumns = matrix.GetLength(1);
            int[,] noisyMatrix = (int[,])matrix.Clone();

            int totalElements = lines * collumns;
            int numElementsToFlip = (int)(totalElements * noiseLevel);

            for (int n = 0; n < numElementsToFlip; n++)
            {
                int i = random.Next(lines);
                int j = random.Next(collumns);
                // Flip the value at (i, j)
                noisyMatrix[i, j] = noisyMatrix[i, j] == 0 ? 1 : 0;
            }

            matrix = noisyMatrix;
        }
        #endregion

        /*****************************************************************************************************************************************/
        #region Static operations
        public static int[] FlattenMatrix(Matrix matrix)
        {
            int lines = matrix.GetMatrixLineOrHeight();
            int collumns = matrix.GetMatrixCollumnOrWidth();
            int[] flatArray = new int[lines * collumns];

            for (int line = 0; line < lines; line++)
            {
                for (int collumn = 0; collumn < collumns; collumn++)
                {
                    flatArray[line * collumns + collumn] = matrix.GetValueAt(line, collumn);
                }
            }

            return flatArray;
        }
        public static Matrix ReshapeArray(int[] array, int lines, int collumns)
        {
            int[,] matrix = new int[lines, collumns];

            for (int line = 0; line < lines; line++)
            {
                for (int collumn = 0; collumn < collumns; collumn++)
                {
                    matrix[line, collumn] = array[line * collumns + collumn];
                }
            }

            return new Matrix(matrix);
        }
        #endregion
    }
}
