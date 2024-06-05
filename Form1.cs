using System.Drawing.Drawing2D;

namespace HopfieldNumberRecognition
{
    public partial class Form1 : Form
    {
        const string gAppName = "Hopfield Number Recognition";

        HopfieldNetwork hopfieldNetwork;

        const int SIZE_MATRIX = 10;
        const int NR_MATRIX_TRAIN = 3;
        Matrix[] gMatricesTrain = new Matrix[NR_MATRIX_TRAIN];
        Matrix gMatrixTest;

        int gScalingX, gScalingY;

        public Form1()
        {
            InitializeComponent();
            this.Text = gAppName;
            // Training matrices init
            for (int i = 0; i < NR_MATRIX_TRAIN; i++)
            {
                gMatricesTrain[i] = new Matrix(SIZE_MATRIX);
            }
            // Testing matrix init
            gMatrixTest = new Matrix(SIZE_MATRIX);

            gScalingX = pictureBox_ImageTrain1.Width / SIZE_MATRIX;
            gScalingY = pictureBox_ImageTrain1.Height / SIZE_MATRIX;
        }

        /*****************************************************************************************************************************************/
        #region Picture events & operations
        private void pictureBox_ImageTrain1_MouseClick(object sender, MouseEventArgs e)
        {
            OnClick(gMatricesTrain[0], sender, e);
        }
        private void pictureBox_ImageTrain2_MouseClick(object sender, MouseEventArgs e)
        {
            OnClick(gMatricesTrain[1], sender, e);
        }
        private void pictureBox_ImageTrain3_MouseClick(object sender, MouseEventArgs e)
        {
            OnClick(gMatricesTrain[2], sender, e);
        }
        private void pictureBox_ImageTest_MouseClick(object sender, MouseEventArgs e)
        {
            OnClick(gMatrixTest, sender, e);
        }
        private void OnClick(Matrix matrix, object sender, MouseEventArgs e)
        {
            int line = e.Y / gScalingY;
            int collumn = e.X / gScalingX;
            matrix.InvertValueAt(line, collumn);
            UpdatePictureBox((PictureBox)sender, matrix);
        }
        void UpdatePictureBox(PictureBox pictureBox, Matrix matrix)
        {
            Bitmap BMP = new Bitmap(pictureBox.Width, pictureBox.Height);
            for (int line = 0; line < SIZE_MATRIX; line++)
            {
                for (int collumn = 0; collumn < SIZE_MATRIX; collumn++)
                {
                    Color color = matrix.GetColorAt(line, collumn);

                    for (int lineBMP = line * gScalingY; lineBMP < (line + 1) * gScalingY; lineBMP++)
                    {
                        for (int collumnBMP = collumn * gScalingX; collumnBMP < (collumn + 1) * gScalingX; collumnBMP++)
                        {
                            BMP.SetPixel(collumnBMP, lineBMP, color);
                        }
                    }
                }
            }
            pictureBox.Image = BMP;
        }
        #endregion

        /*****************************************************************************************************************************************/
        #region Matrix operations buttons
        private void button_GenerateMatrix_Click(object sender, EventArgs e)
        {
            if (comboBox_MatrixIndex.SelectedIndex == -1)
            {
                MessageBox.Show("Select which Matrix to generate!", gAppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox_MatrixType.SelectedIndex == -1)
            {
                MessageBox.Show("Select type of Matrix to generate!", gAppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string type = comboBox_MatrixType.Text;
            // Training matrices generate
            if (comboBox_MatrixIndex.SelectedIndex != 3)
            {
                int index = comboBox_MatrixIndex.SelectedIndex;
                gMatricesTrain[index] = new Matrix(type);
                switch (index)
                {
                    case 0:
                        UpdatePictureBox(pictureBox_ImageTrain1, gMatricesTrain[index]);
                        break;
                    case 1:
                        UpdatePictureBox(pictureBox_ImageTrain2, gMatricesTrain[index]);
                        break;
                    case 2:
                        UpdatePictureBox(pictureBox_ImageTrain3, gMatricesTrain[index]);
                        break;
                }
                return;
            }
            // Testing matrix generate
            gMatrixTest = new Matrix(type);
            UpdatePictureBox(pictureBox_ImageTest, gMatrixTest);
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            if (comboBox_MatrixIndex.SelectedIndex == -1)
            {
                MessageBox.Show("Select which Matrix to clear!", gAppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Training matrices clear
            if (comboBox_MatrixIndex.SelectedIndex != 3)
            {
                int index = comboBox_MatrixIndex.SelectedIndex;
                gMatricesTrain[index].Clear();
                switch (index)
                {
                    case 0:
                        UpdatePictureBox(pictureBox_ImageTrain1, gMatricesTrain[index]);
                        break;
                    case 1:
                        UpdatePictureBox(pictureBox_ImageTrain2, gMatricesTrain[index]);
                        break;
                    case 2:
                        UpdatePictureBox(pictureBox_ImageTrain3, gMatricesTrain[index]);
                        break;
                }
                return;
            }
            // Testing matrix clear
            gMatrixTest.Clear();
            UpdatePictureBox(pictureBox_ImageTest, gMatrixTest);
        }
        private void button_Noise_Click(object sender, EventArgs e)
        {
            if (comboBox_MatrixIndex.SelectedIndex == -1)
            {
                MessageBox.Show("Select which Matrix to add noise to!", gAppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double noiseLevel = (double)numericUpDown_Noise.Value;
            // Training matrices noise
            if (comboBox_MatrixIndex.SelectedIndex != 3)
            {
                int index = comboBox_MatrixIndex.SelectedIndex;
                gMatricesTrain[index].AddNoise(noiseLevel);
                switch (index)
                {
                    case 0:
                        UpdatePictureBox(pictureBox_ImageTrain1, gMatricesTrain[index]);
                        break;
                    case 1:
                        UpdatePictureBox(pictureBox_ImageTrain2, gMatricesTrain[index]);
                        break;
                    case 2:
                        UpdatePictureBox(pictureBox_ImageTrain3, gMatricesTrain[index]);
                        break;
                }
                return;
            }
            // Testing matrix noise
            gMatrixTest.AddNoise(noiseLevel);
            UpdatePictureBox(pictureBox_ImageTest, gMatrixTest);
        }
        #endregion

        /*****************************************************************************************************************************************/
        #region Hopfield Train & Predict buttons
        private void button_Train_Click(object sender, EventArgs e)
        {
            hopfieldNetwork = new HopfieldNetwork(SIZE_MATRIX, SIZE_MATRIX);
            hopfieldNetwork.Train(gMatricesTrain);
            MessageBox.Show("Hopfield Network train successful!", gAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button_Predict_Click(object sender, EventArgs e)
        {
            if (hopfieldNetwork == null)
            {
                MessageBox.Show("Train Hopfield Network first!", gAppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gMatrixTest = hopfieldNetwork.Predict(gMatrixTest);
            UpdatePictureBox(pictureBox_ImageTest, gMatrixTest);
            MessageBox.Show("Hopfield Network predict successful!", gAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
