using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldNumberRecognition
{
    internal class HopfieldNetwork
    {
        private int[,] weights;
        private int size;

        public HopfieldNetwork(int lines, int collumns)
        {
            size = lines * collumns;
            weights = new int[size, size];
        }

        public void Train(Matrix[] matricesTrain)
        {
            foreach (Matrix matrixTrain in matricesTrain)
            {
                int[] flatPattern = Matrix.FlattenMatrix(matrixTrain);

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (i != j)
                        {
                            weights[i, j] += (2 * flatPattern[i] - 1) * (2 * flatPattern[j] - 1);
                        }
                    }
                }
            }
        }

        public Matrix Predict(Matrix matrix, int maxIterations = 100)
        {
            int lines = matrix.GetMatrixLineOrHeight();
            int collumns = matrix.GetMatrixCollumnOrWidth();
            int[] flatInput = Matrix.FlattenMatrix(matrix);
            int[] output = new int[size];
            Array.Copy(flatInput, output, size);

            bool hasChanged;
            int iterations = 0;

            do
            {
                hasChanged = false;
                iterations++;

                for (int i = 0; i < size; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < size; j++)
                    {
                        sum += weights[i, j] * output[j];
                    }

                    int newValue = sum >= 0 ? 1 : 0;
                    if (output[i] != newValue)
                    {
                        output[i] = newValue;
                        hasChanged = true;
                    }
                }
            } while (hasChanged && iterations < maxIterations);

            return Matrix.ReshapeArray(output, lines, collumns);
        }

    }
}
