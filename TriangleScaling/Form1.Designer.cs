namespace TriangleScaling
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
            pictureBox1 = new PictureBox();
            btnGenerateOriginal = new Button();
            btnScale = new Button();
            lblOriginalCoordinates = new Label();
            lblScalingFactor = new Label();
            lblScaledCoordinates = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1052, 782);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnGenerateOriginal
            // 
            btnGenerateOriginal.Location = new Point(1432, 699);
            btnGenerateOriginal.Name = "btnGenerateOriginal";
            btnGenerateOriginal.Size = new Size(183, 95);
            btnGenerateOriginal.TabIndex = 1;
            btnGenerateOriginal.Text = "Generare triunghi";
            btnGenerateOriginal.UseVisualStyleBackColor = true;
            btnGenerateOriginal.Click += btnGenerateOriginal_Click;
            // 
            // btnScale
            // 
            btnScale.Location = new Point(1432, 564);
            btnScale.Name = "btnScale";
            btnScale.Size = new Size(183, 94);
            btnScale.TabIndex = 2;
            btnScale.Text = "Scalare triunghi";
            btnScale.UseVisualStyleBackColor = true;
            btnScale.Click += btnScale_Click;
            // 
            // lblOriginalCoordinates
            // 
            lblOriginalCoordinates.AutoSize = true;
            lblOriginalCoordinates.Location = new Point(1089, 12);
            lblOriginalCoordinates.Name = "lblOriginalCoordinates";
            lblOriginalCoordinates.Size = new Size(0, 25);
            lblOriginalCoordinates.TabIndex = 3;
            // 
            // lblScalingFactor
            // 
            lblScalingFactor.AutoSize = true;
            lblScalingFactor.Location = new Point(1089, 121);
            lblScalingFactor.Name = "lblScalingFactor";
            lblScalingFactor.Size = new Size(0, 25);
            lblScalingFactor.TabIndex = 4;
            // 
            // lblScaledCoordinates
            // 
            lblScaledCoordinates.AutoSize = true;
            lblScaledCoordinates.Location = new Point(1089, 236);
            lblScaledCoordinates.Name = "lblScaledCoordinates";
            lblScaledCoordinates.Size = new Size(0, 25);
            lblScaledCoordinates.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1978, 806);
            Controls.Add(lblScaledCoordinates);
            Controls.Add(lblScalingFactor);
            Controls.Add(lblOriginalCoordinates);
            Controls.Add(btnScale);
            Controls.Add(btnGenerateOriginal);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnGenerateOriginal;
        private Button btnScale;
        private Label lblOriginalCoordinates;
        private Label lblScalingFactor;
        private Label lblScaledCoordinates;
    }
}