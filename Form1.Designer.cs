namespace HopfieldNumberRecognition
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_ImageTrain1 = new Panel();
            pictureBox_ImageTrain1 = new PictureBox();
            panel_ImageTrain2 = new Panel();
            pictureBox_ImageTrain2 = new PictureBox();
            panel_ImageTrain3 = new Panel();
            pictureBox_ImageTrain3 = new PictureBox();
            panel_ImageTest = new Panel();
            pictureBox_ImageTest = new PictureBox();
            comboBox_MatrixType = new ComboBox();
            comboBox_MatrixIndex = new ComboBox();
            button_GenerateMatrix = new Button();
            button_Train = new Button();
            button_Predict = new Button();
            button_Clear = new Button();
            button_Noise = new Button();
            numericUpDown_Noise = new NumericUpDown();
            panel_ImageTrain1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ImageTrain1).BeginInit();
            panel_ImageTrain2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ImageTrain2).BeginInit();
            panel_ImageTrain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ImageTrain3).BeginInit();
            panel_ImageTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ImageTest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Noise).BeginInit();
            SuspendLayout();
            // 
            // panel_ImageTrain1
            // 
            panel_ImageTrain1.BorderStyle = BorderStyle.FixedSingle;
            panel_ImageTrain1.Controls.Add(pictureBox_ImageTrain1);
            panel_ImageTrain1.Location = new Point(12, 12);
            panel_ImageTrain1.Name = "panel_ImageTrain1";
            panel_ImageTrain1.Size = new Size(200, 200);
            panel_ImageTrain1.TabIndex = 1;
            // 
            // pictureBox_ImageTrain1
            // 
            pictureBox_ImageTrain1.BackColor = SystemColors.ButtonHighlight;
            pictureBox_ImageTrain1.Location = new Point(-1, -1);
            pictureBox_ImageTrain1.Name = "pictureBox_ImageTrain1";
            pictureBox_ImageTrain1.Size = new Size(200, 200);
            pictureBox_ImageTrain1.TabIndex = 0;
            pictureBox_ImageTrain1.TabStop = false;
            pictureBox_ImageTrain1.MouseClick += pictureBox_ImageTrain1_MouseClick;
            // 
            // panel_ImageTrain2
            // 
            panel_ImageTrain2.BorderStyle = BorderStyle.FixedSingle;
            panel_ImageTrain2.Controls.Add(pictureBox_ImageTrain2);
            panel_ImageTrain2.Location = new Point(218, 12);
            panel_ImageTrain2.Name = "panel_ImageTrain2";
            panel_ImageTrain2.Size = new Size(200, 200);
            panel_ImageTrain2.TabIndex = 2;
            // 
            // pictureBox_ImageTrain2
            // 
            pictureBox_ImageTrain2.BackColor = SystemColors.ButtonHighlight;
            pictureBox_ImageTrain2.Location = new Point(-1, -1);
            pictureBox_ImageTrain2.Name = "pictureBox_ImageTrain2";
            pictureBox_ImageTrain2.Size = new Size(200, 200);
            pictureBox_ImageTrain2.TabIndex = 0;
            pictureBox_ImageTrain2.TabStop = false;
            pictureBox_ImageTrain2.MouseClick += pictureBox_ImageTrain2_MouseClick;
            // 
            // panel_ImageTrain3
            // 
            panel_ImageTrain3.BorderStyle = BorderStyle.FixedSingle;
            panel_ImageTrain3.Controls.Add(pictureBox_ImageTrain3);
            panel_ImageTrain3.Location = new Point(424, 12);
            panel_ImageTrain3.Name = "panel_ImageTrain3";
            panel_ImageTrain3.Size = new Size(200, 200);
            panel_ImageTrain3.TabIndex = 3;
            // 
            // pictureBox_ImageTrain3
            // 
            pictureBox_ImageTrain3.BackColor = SystemColors.ButtonHighlight;
            pictureBox_ImageTrain3.Location = new Point(-1, -1);
            pictureBox_ImageTrain3.Name = "pictureBox_ImageTrain3";
            pictureBox_ImageTrain3.Size = new Size(200, 200);
            pictureBox_ImageTrain3.TabIndex = 0;
            pictureBox_ImageTrain3.TabStop = false;
            pictureBox_ImageTrain3.MouseClick += pictureBox_ImageTrain3_MouseClick;
            // 
            // panel_ImageTest
            // 
            panel_ImageTest.BorderStyle = BorderStyle.FixedSingle;
            panel_ImageTest.Controls.Add(pictureBox_ImageTest);
            panel_ImageTest.Location = new Point(218, 276);
            panel_ImageTest.Name = "panel_ImageTest";
            panel_ImageTest.Size = new Size(200, 200);
            panel_ImageTest.TabIndex = 7;
            // 
            // pictureBox_ImageTest
            // 
            pictureBox_ImageTest.BackColor = SystemColors.ButtonHighlight;
            pictureBox_ImageTest.Location = new Point(-1, -1);
            pictureBox_ImageTest.Name = "pictureBox_ImageTest";
            pictureBox_ImageTest.Size = new Size(200, 200);
            pictureBox_ImageTest.TabIndex = 0;
            pictureBox_ImageTest.TabStop = false;
            pictureBox_ImageTest.MouseClick += pictureBox_ImageTest_MouseClick;
            // 
            // comboBox_MatrixType
            // 
            comboBox_MatrixType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_MatrixType.FormattingEnabled = true;
            comboBox_MatrixType.Items.AddRange(new object[] { "0", "1", "2", "3" });
            comboBox_MatrixType.Location = new Point(424, 219);
            comboBox_MatrixType.Name = "comboBox_MatrixType";
            comboBox_MatrixType.Size = new Size(119, 23);
            comboBox_MatrixType.TabIndex = 4;
            // 
            // comboBox_MatrixIndex
            // 
            comboBox_MatrixIndex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_MatrixIndex.FormattingEnabled = true;
            comboBox_MatrixIndex.Items.AddRange(new object[] { "gMatricesTrain[0]", "gMatricesTrain[1]", "gMatricesTrain[2]", "gMatrixTest" });
            comboBox_MatrixIndex.Location = new Point(93, 218);
            comboBox_MatrixIndex.Name = "comboBox_MatrixIndex";
            comboBox_MatrixIndex.Size = new Size(119, 23);
            comboBox_MatrixIndex.TabIndex = 5;
            // 
            // button_GenerateMatrix
            // 
            button_GenerateMatrix.Location = new Point(343, 218);
            button_GenerateMatrix.Name = "button_GenerateMatrix";
            button_GenerateMatrix.Size = new Size(75, 23);
            button_GenerateMatrix.TabIndex = 6;
            button_GenerateMatrix.Text = "Generate";
            button_GenerateMatrix.UseVisualStyleBackColor = true;
            button_GenerateMatrix.Click += button_GenerateMatrix_Click;
            // 
            // button_Train
            // 
            button_Train.Location = new Point(218, 247);
            button_Train.Name = "button_Train";
            button_Train.Size = new Size(75, 23);
            button_Train.TabIndex = 8;
            button_Train.Text = "Train";
            button_Train.UseVisualStyleBackColor = true;
            button_Train.Click += button_Train_Click;
            // 
            // button_Predict
            // 
            button_Predict.Location = new Point(343, 247);
            button_Predict.Name = "button_Predict";
            button_Predict.Size = new Size(75, 23);
            button_Predict.TabIndex = 9;
            button_Predict.Text = "Predict";
            button_Predict.UseVisualStyleBackColor = true;
            button_Predict.Click += button_Predict_Click;
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(218, 218);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(75, 23);
            button_Clear.TabIndex = 10;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // button_Noise
            // 
            button_Noise.Location = new Point(424, 247);
            button_Noise.Name = "button_Noise";
            button_Noise.Size = new Size(75, 23);
            button_Noise.TabIndex = 11;
            button_Noise.Text = "Noise";
            button_Noise.UseVisualStyleBackColor = true;
            button_Noise.Click += button_Noise_Click;
            // 
            // numericUpDown_Noise
            // 
            numericUpDown_Noise.DecimalPlaces = 1;
            numericUpDown_Noise.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown_Noise.Location = new Point(505, 247);
            numericUpDown_Noise.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Noise.Name = "numericUpDown_Noise";
            numericUpDown_Noise.Size = new Size(38, 23);
            numericUpDown_Noise.TabIndex = 12;
            numericUpDown_Noise.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 488);
            Controls.Add(numericUpDown_Noise);
            Controls.Add(button_Noise);
            Controls.Add(button_Clear);
            Controls.Add(button_Predict);
            Controls.Add(button_Train);
            Controls.Add(panel_ImageTest);
            Controls.Add(button_GenerateMatrix);
            Controls.Add(comboBox_MatrixIndex);
            Controls.Add(comboBox_MatrixType);
            Controls.Add(panel_ImageTrain3);
            Controls.Add(panel_ImageTrain2);
            Controls.Add(panel_ImageTrain1);
            Name = "Form1";
            Text = "Form1";
            panel_ImageTrain1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_ImageTrain1).EndInit();
            panel_ImageTrain2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_ImageTrain2).EndInit();
            panel_ImageTrain3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_ImageTrain3).EndInit();
            panel_ImageTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_ImageTest).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Noise).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_ImageTrain1;
        private Panel panel_ImageTrain2;
        private Panel panel_ImageTrain3;
        private Panel panel_ImageTest;
        private PictureBox pictureBox_ImageTrain1;
        private PictureBox pictureBox_ImageTrain2;
        private PictureBox pictureBox_ImageTrain3;
        private PictureBox pictureBox_ImageTest;
        private ComboBox comboBox_MatrixType;
        private ComboBox comboBox_MatrixIndex;
        private Button button_GenerateMatrix;
        private Button button_Train;
        private Button button_Predict;
        private Button button_Clear;
        private Button button_Noise;
        private NumericUpDown numericUpDown_Noise;
    }
}
