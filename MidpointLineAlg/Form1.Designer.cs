namespace MidpointLineAlg
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(14, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1231, 871);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(1311, 813);
            button1.Name = "button1";
            button1.Size = new Size(218, 69);
            button1.TabIndex = 1;
            button1.Text = "Desenare linie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Negru", "Albastru", "Rosu", "Verde", "Roz", "Mov" });
            comboBox1.Location = new Point(1353, 709);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 29);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Negru";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1311, 668);
            label2.Name = "label2";
            label2.Size = new Size(220, 21);
            label2.TabIndex = 5;
            label2.Text = "Selectati culoarea liniei:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 894);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "MidPoint Algorithm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
    }
}