namespace WheelOfFortune
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rotationTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxWheel = new System.Windows.Forms.PictureBox();
            this.spinButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rotationTimer
            // 
            this.rotationTimer.Interval = 4;
            this.rotationTimer.Tick += new System.EventHandler(this.rotationTimer_Tick);
            // 
            // pictureBoxWheel
            // 
            this.pictureBoxWheel.Location = new System.Drawing.Point(9, 18);
            this.pictureBoxWheel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxWheel.Name = "pictureBoxWheel";
            this.pictureBoxWheel.Size = new System.Drawing.Size(361, 373);
            this.pictureBoxWheel.TabIndex = 0;
            this.pictureBoxWheel.TabStop = false;
            this.pictureBoxWheel.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxWheel_Paint);
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(470, 186);
            this.spinButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(80, 30);
            this.spinButton.TabIndex = 1;
            this.spinButton.Text = "button1";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.Location = new System.Drawing.Point(182, 364);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 39);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.pictureBoxWheel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer rotationTimer;
        private System.Windows.Forms.PictureBox pictureBoxWheel;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

