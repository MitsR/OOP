namespace Lab_15_OOP
{
    partial class Calculation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HeightLabel1 = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SpeedLabel2 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.TextBox();
            this.MassLabel3 = new System.Windows.Forms.Label();
            this.MassTextBox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.harvestSumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(226, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Обрахунок врожайності";
            // 
            // HeightLabel1
            // 
            this.HeightLabel1.AutoSize = true;
            this.HeightLabel1.Location = new System.Drawing.Point(158, 161);
            this.HeightLabel1.Name = "HeightLabel1";
            this.HeightLabel1.Size = new System.Drawing.Size(63, 16);
            this.HeightLabel1.TabIndex = 2;
            this.HeightLabel1.Text = "ВИСОТА";
            this.HeightLabel1.Click += new System.EventHandler(this.HeightLabel1_Click);
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(366, 161);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 22);
            this.Height.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // SpeedLabel2
            // 
            this.SpeedLabel2.AutoSize = true;
            this.SpeedLabel2.Location = new System.Drawing.Point(147, 202);
            this.SpeedLabel2.Name = "SpeedLabel2";
            this.SpeedLabel2.Size = new System.Drawing.Size(84, 16);
            this.SpeedLabel2.TabIndex = 2;
            this.SpeedLabel2.Text = "ШВИДКІСТЬ";
            this.SpeedLabel2.Click += new System.EventHandler(this.SpeedLabel2_Click);
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(366, 202);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(100, 22);
            this.Speed.TabIndex = 3;
            // 
            // MassLabel3
            // 
            this.MassLabel3.AutoSize = true;
            this.MassLabel3.Location = new System.Drawing.Point(167, 246);
            this.MassLabel3.Name = "MassLabel3";
            this.MassLabel3.Size = new System.Drawing.Size(45, 16);
            this.MassLabel3.TabIndex = 2;
            this.MassLabel3.Text = "МАСА";
            // 
            // MassTextBox
            // 
            this.MassTextBox.Location = new System.Drawing.Point(366, 246);
            this.MassTextBox.Name = "MassTextBox";
            this.MassTextBox.Size = new System.Drawing.Size(100, 22);
            this.MassTextBox.TabIndex = 3;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(403, 132);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(23, 16);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.Text = "С/І";
            this.valueLabel.Click += new System.EventHandler(this.valueLabel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 67);
            this.button2.TabIndex = 5;
            this.button2.Text = "Обрахувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(521, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 67);
            this.button3.TabIndex = 5;
            this.button3.Text = "Обнулити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // harvestSumLabel
            // 
            this.harvestSumLabel.AutoSize = true;
            this.harvestSumLabel.Location = new System.Drawing.Point(70, 289);
            this.harvestSumLabel.Name = "harvestSumLabel";
            this.harvestSumLabel.Size = new System.Drawing.Size(0, 16);
            this.harvestSumLabel.TabIndex = 2;
            // 
            // Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 478);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MassTextBox);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.harvestSumLabel);
            this.Controls.Add(this.MassLabel3);
            this.Controls.Add(this.SpeedLabel2);
            this.Controls.Add(this.HeightLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Calculation";
            this.Text = "Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HeightLabel1;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SpeedLabel2;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.Label MassLabel3;
        private System.Windows.Forms.TextBox MassTextBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label harvestSumLabel;
    }
}