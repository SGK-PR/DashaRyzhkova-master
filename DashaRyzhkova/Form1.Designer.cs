namespace DashaRyzhkova
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
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lbHeight = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lbWeight = new System.Windows.Forms.Label();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.lbTerm = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.tbRezult = new System.Windows.Forms.TextBox();
            this.lbSm = new System.Windows.Forms.Label();
            this.lbKg = new System.Windows.Forms.Label();
            this.butStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(337, 76);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 0;
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(97, 76);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(86, 13);
            this.lbHeight.TabIndex = 1;
            this.lbHeight.Text = "Ваш рост, в см.";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(338, 102);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(99, 20);
            this.tbWeight.TabIndex = 2;
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(97, 105);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(169, 13);
            this.lbWeight.TabIndex = 3;
            this.lbWeight.Text = "Ваш вес до беременности, в кг.";
            // 
            // cbTerm
            // 
            this.cbTerm.FormattingEnabled = true;
            this.cbTerm.Location = new System.Drawing.Point(337, 128);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(99, 21);
            this.cbTerm.TabIndex = 4;
            // 
            // lbTerm
            // 
            this.lbTerm.AutoSize = true;
            this.lbTerm.Location = new System.Drawing.Point(97, 131);
            this.lbTerm.Name = "lbTerm";
            this.lbTerm.Size = new System.Drawing.Size(131, 13);
            this.lbTerm.TabIndex = 5;
            this.lbTerm.Text = "Ваш срок беременности";
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(118, 190);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(110, 29);
            this.butStart.TabIndex = 6;
            this.butStart.Text = "Рассчитать";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // tbRezult
            // 
            this.tbRezult.Location = new System.Drawing.Point(259, 190);
            this.tbRezult.Multiline = true;
            this.tbRezult.Name = "tbRezult";
            this.tbRezult.Size = new System.Drawing.Size(166, 57);
            this.tbRezult.TabIndex = 7;
            // 
            // lbSm
            // 
            this.lbSm.AutoSize = true;
            this.lbSm.Location = new System.Drawing.Point(443, 79);
            this.lbSm.Name = "lbSm";
            this.lbSm.Size = new System.Drawing.Size(24, 13);
            this.lbSm.TabIndex = 8;
            this.lbSm.Text = "см.";
            // 
            // lbKg
            // 
            this.lbKg.AutoSize = true;
            this.lbKg.Location = new System.Drawing.Point(446, 105);
            this.lbKg.Name = "lbKg";
            this.lbKg.Size = new System.Drawing.Size(21, 13);
            this.lbKg.TabIndex = 9;
            this.lbKg.Text = "кг.";
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(118, 234);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(110, 30);
            this.butStop.TabIndex = 10;
            this.butStop.Text = "Сброс";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.lbKg);
            this.Controls.Add(this.lbSm);
            this.Controls.Add(this.tbRezult);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.lbTerm);
            this.Controls.Add(this.cbTerm);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.tbHeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.ComboBox cbTerm;
        private System.Windows.Forms.Label lbTerm;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.TextBox tbRezult;
        private System.Windows.Forms.Label lbSm;
        private System.Windows.Forms.Label lbKg;
        private System.Windows.Forms.Button butStop;
    }
}

