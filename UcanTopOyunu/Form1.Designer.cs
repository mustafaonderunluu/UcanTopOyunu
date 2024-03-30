namespace UcanTopOyunu
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            Kontrol = new Button();
            Ball = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.LimeGreen;
            label1.Location = new Point(-6, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 584);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Gold;
            label2.Location = new Point(30, 0);
            label2.Name = "label2";
            label2.Size = new Size(839, 32);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Location = new Point(974, 84);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 2;
            label3.Text = "3";
            // 
            // label5
            // 
            label5.BackColor = Color.LimeGreen;
            label5.Location = new Point(863, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 584);
            label5.TabIndex = 4;
            // 
            // Kontrol
            // 
            Kontrol.BackColor = SystemColors.ActiveCaption;
            Kontrol.Location = new Point(361, 555);
            Kontrol.Name = "Kontrol";
            Kontrol.Size = new Size(93, 29);
            Kontrol.TabIndex = 5;
            Kontrol.UseVisualStyleBackColor = false;
            // 
            // Ball
            // 
            Ball.BackColor = Color.Indigo;
            Ball.Location = new Point(373, 191);
            Ball.Name = "Ball";
            Ball.Size = new Size(22, 19);
            Ball.TabIndex = 6;
            Ball.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Location = new Point(947, 85);
            button1.Name = "button1";
            button1.Size = new Size(22, 19);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 626);
            Controls.Add(button1);
            Controls.Add(Ball);
            Controls.Add(Kontrol);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button Kontrol;
        private Button Ball;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}
