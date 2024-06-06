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

            bool stateChanged;
            int iterations = 0;

            do
            {
                stateChanged = false;
                iterations++;

                for (int i = 0; i < size; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < size; j++)
                    {
                        sum += weights[i, j] * flatInput[j];
                    }

                    int newValue = sum >= 0 ? 1 : 0;
                    if (flatInput[i] != newValue)
                    {
                        flatInput[i] = newValue;
                        stateChanged = true;
                    }
                }
            } while (stateChanged && iterations < maxIterations);

            return Matrix.ReshapeArray(flatInput, lines, collumns);
        }

        public int CalculateHammingDistance(Matrix pattern1, Matrix pattern2)
        {
            if (
                pattern1.GetMatrixLineOrHeight() != pattern2.GetMatrixLineOrHeight()
                    ||
                pattern1.GetMatrixCollumnOrWidth() != pattern2.GetMatrixCollumnOrWidth()
            )
            {
                throw new ArgumentException("Patterns must have the same dimensions.");
            }

            int distance = 0;
            int lines = pattern1.GetMatrixLineOrHeight();
            int collumns = pattern1.GetMatrixCollumnOrWidth();

            for (int line = 0; line < lines; line++)
            {
                for (int collumn = 0; collumn < collumns; collumn++)
                {
                    if (pattern1.GetValueAt(line, collumn) != pattern2.GetValueAt(line, collumn))
                    {
                        distance++;
                    }
                }
            }

            return distance;
        }

        public double CalculateEnergy(Matrix pattern)
        {
            int[] flatPattern = Matrix.FlattenMatrix(pattern);
            int size = flatPattern.Length;
            double energy = 0.0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    energy -= weights[i, j] * flatPattern[i] * flatPattern[j];
                }
            }

            return 0.5 * energy;
        }

    }
}
