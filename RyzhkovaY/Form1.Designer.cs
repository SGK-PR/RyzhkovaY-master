namespace RyzhkovaY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbFormula = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbVoltage = new System.Windows.Forms.TextBox();
            this.lbVoltage = new System.Windows.Forms.Label();
            this.lbVolt = new System.Windows.Forms.Label();
            this.tbResistance = new System.Windows.Forms.TextBox();
            this.lbResistance = new System.Windows.Forms.Label();
            this.lbOm = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.lbAmperage = new System.Windows.Forms.Label();
            this.tbAmperage = new System.Windows.Forms.TextBox();
            this.lbAmper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFormula
            // 
            this.tbFormula.Location = new System.Drawing.Point(174, 28);
            this.tbFormula.Multiline = true;
            this.tbFormula.Name = "tbFormula";
            this.tbFormula.Size = new System.Drawing.Size(205, 60);
            this.tbFormula.TabIndex = 0;
            this.tbFormula.Text = "Сила тока в проводнике прямо пропорциональна напряжению и обратно пропорциональна" +
    " сопротивлению.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbVoltage
            // 
            this.tbVoltage.Location = new System.Drawing.Point(217, 108);
            this.tbVoltage.Multiline = true;
            this.tbVoltage.Name = "tbVoltage";
            this.tbVoltage.Size = new System.Drawing.Size(118, 29);
            this.tbVoltage.TabIndex = 2;
            // 
            // lbVoltage
            // 
            this.lbVoltage.AutoSize = true;
            this.lbVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVoltage.Location = new System.Drawing.Point(90, 111);
            this.lbVoltage.Name = "lbVoltage";
            this.lbVoltage.Size = new System.Drawing.Size(119, 18);
            this.lbVoltage.TabIndex = 3;
            this.lbVoltage.Text = "Напряжение (U)";
            // 
            // lbVolt
            // 
            this.lbVolt.AutoSize = true;
            this.lbVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVolt.Location = new System.Drawing.Point(351, 113);
            this.lbVolt.Name = "lbVolt";
            this.lbVolt.Size = new System.Drawing.Size(43, 15);
            this.lbVolt.TabIndex = 4;
            this.lbVolt.Text = "Вольт";
            // 
            // tbResistance
            // 
            this.tbResistance.Location = new System.Drawing.Point(217, 158);
            this.tbResistance.Multiline = true;
            this.tbResistance.Name = "tbResistance";
            this.tbResistance.Size = new System.Drawing.Size(118, 29);
            this.tbResistance.TabIndex = 5;
            // 
            // lbResistance
            // 
            this.lbResistance.AutoSize = true;
            this.lbResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbResistance.Location = new System.Drawing.Point(67, 158);
            this.lbResistance.Name = "lbResistance";
            this.lbResistance.Size = new System.Drawing.Size(142, 18);
            this.lbResistance.TabIndex = 6;
            this.lbResistance.Text = "Сопротивление (R)";
            // 
            // lbOm
            // 
            this.lbOm.AutoSize = true;
            this.lbOm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOm.Location = new System.Drawing.Point(354, 162);
            this.lbOm.Name = "lbOm";
            this.lbOm.Size = new System.Drawing.Size(25, 15);
            this.lbOm.TabIndex = 7;
            this.lbOm.Text = "Ом";
            // 
            // btCalculate
            // 
            this.btCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btCalculate.Location = new System.Drawing.Point(230, 206);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(91, 38);
            this.btCalculate.TabIndex = 8;
            this.btCalculate.Text = "Рассчитать";
            this.btCalculate.UseVisualStyleBackColor = false;
            this.btCalculate.Click += new System.EventHandler(this.BtCalculate_Click);
            // 
            // lbAmperage
            // 
            this.lbAmperage.AutoSize = true;
            this.lbAmperage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAmperage.Location = new System.Drawing.Point(102, 279);
            this.lbAmperage.Name = "lbAmperage";
            this.lbAmperage.Size = new System.Drawing.Size(97, 18);
            this.lbAmperage.TabIndex = 9;
            this.lbAmperage.Text = "Сила тока (I)";
            // 
            // tbAmperage
            // 
            this.tbAmperage.Location = new System.Drawing.Point(217, 279);
            this.tbAmperage.Multiline = true;
            this.tbAmperage.Name = "tbAmperage";
            this.tbAmperage.Size = new System.Drawing.Size(118, 29);
            this.tbAmperage.TabIndex = 10;
         
            // 
            // lbAmper
            // 
            this.lbAmper.AutoSize = true;
            this.lbAmper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAmper.Location = new System.Drawing.Point(354, 282);
            this.lbAmper.Name = "lbAmper";
            this.lbAmper.Size = new System.Drawing.Size(44, 15);
            this.lbAmper.TabIndex = 11;
            this.lbAmper.Text = "Ампер";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAmper);
            this.Controls.Add(this.tbAmperage);
            this.Controls.Add(this.lbAmperage);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.lbOm);
            this.Controls.Add(this.lbResistance);
            this.Controls.Add(this.tbResistance);
            this.Controls.Add(this.lbVolt);
            this.Controls.Add(this.lbVoltage);
            this.Controls.Add(this.tbVoltage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbFormula);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbVoltage;
        private System.Windows.Forms.Label lbVoltage;
        private System.Windows.Forms.Label lbVolt;
        private System.Windows.Forms.TextBox tbResistance;
        private System.Windows.Forms.Label lbResistance;
        private System.Windows.Forms.Label lbOm;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label lbAmperage;
        private System.Windows.Forms.TextBox tbAmperage;
        private System.Windows.Forms.Label lbAmper;
    }
}

