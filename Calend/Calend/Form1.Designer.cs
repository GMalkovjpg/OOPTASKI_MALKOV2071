namespace ООП_4_Календарь
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
            this.labelyear = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data1 = new System.Windows.Forms.Button();
            this.datalabelY = new System.Windows.Forms.Label();
            this.labelm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.daytext = new System.Windows.Forms.TextBox();
            this.monthtext = new System.Windows.Forms.TextBox();
            this.yeartext = new System.Windows.Forms.TextBox();
            this.vpered = new System.Windows.Forms.Button();
            this.datalabelD = new System.Windows.Forms.Label();
            this.datalabelM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelyear
            // 
            this.labelyear.AutoSize = true;
            this.labelyear.Location = new System.Drawing.Point(164, 1);
            this.labelyear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelyear.Name = "labelyear";
            this.labelyear.Size = new System.Drawing.Size(25, 13);
            this.labelyear.TabIndex = 8;
            this.labelyear.Text = "Год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(189, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 10;
            // 
            // data1
            // 
            this.data1.BackColor = System.Drawing.Color.White;
            this.data1.Location = new System.Drawing.Point(11, 11);
            this.data1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(69, 35);
            this.data1.TabIndex = 12;
            this.data1.Text = "SetDATA";
            this.data1.UseVisualStyleBackColor = false;
            this.data1.Click += new System.EventHandler(this.data1_Click);
            // 
            // datalabelY
            // 
            this.datalabelY.AutoSize = true;
            this.datalabelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.datalabelY.Location = new System.Drawing.Point(129, 62);
            this.datalabelY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datalabelY.Name = "datalabelY";
            this.datalabelY.Size = new System.Drawing.Size(60, 26);
            this.datalabelY.TabIndex = 19;
            this.datalabelY.Text = "2000";
            // 
            // labelm
            // 
            this.labelm.AutoSize = true;
            this.labelm.Location = new System.Drawing.Point(118, 1);
            this.labelm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelm.Name = "labelm";
            this.labelm.Size = new System.Drawing.Size(40, 13);
            this.labelm.TabIndex = 6;
            this.labelm.Text = "Месяц";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "День";
            // 
            // daytext
            // 
            this.daytext.Location = new System.Drawing.Point(84, 26);
            this.daytext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.daytext.Name = "daytext";
            this.daytext.Size = new System.Drawing.Size(33, 20);
            this.daytext.TabIndex = 21;
            // 
            // monthtext
            // 
            this.monthtext.Location = new System.Drawing.Point(121, 26);
            this.monthtext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monthtext.Name = "monthtext";
            this.monthtext.Size = new System.Drawing.Size(31, 20);
            this.monthtext.TabIndex = 22;
            // 
            // yeartext
            // 
            this.yeartext.Location = new System.Drawing.Point(166, 26);
            this.yeartext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yeartext.Name = "yeartext";
            this.yeartext.Size = new System.Drawing.Size(40, 20);
            this.yeartext.TabIndex = 23;
            // 
            // vpered
            // 
            this.vpered.BackColor = System.Drawing.Color.Red;
            this.vpered.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vpered.Location = new System.Drawing.Point(11, 90);
            this.vpered.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vpered.Name = "vpered";
            this.vpered.Size = new System.Drawing.Size(289, 265);
            this.vpered.TabIndex = 25;
            this.vpered.Text = "ПЕРЕВЕРНУТЬ";
            this.vpered.UseVisualStyleBackColor = false;
            this.vpered.Click += new System.EventHandler(this.vpered_Click_1);
            // 
            // datalabelD
            // 
            this.datalabelD.AutoSize = true;
            this.datalabelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.datalabelD.Location = new System.Drawing.Point(32, 62);
            this.datalabelD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datalabelD.Name = "datalabelD";
            this.datalabelD.Size = new System.Drawing.Size(24, 26);
            this.datalabelD.TabIndex = 27;
            this.datalabelD.Text = "1";
            // 
            // datalabelM
            // 
            this.datalabelM.AutoSize = true;
            this.datalabelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.datalabelM.Location = new System.Drawing.Point(82, 62);
            this.datalabelM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datalabelM.Name = "datalabelM";
            this.datalabelM.Size = new System.Drawing.Size(24, 26);
            this.datalabelM.TabIndex = 28;
            this.datalabelM.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 366);
            this.Controls.Add(this.datalabelM);
            this.Controls.Add(this.datalabelD);
            this.Controls.Add(this.vpered);
            this.Controls.Add(this.yeartext);
            this.Controls.Add(this.monthtext);
            this.Controls.Add(this.daytext);
            this.Controls.Add(this.datalabelY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelyear);
            this.Controls.Add(this.labelm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelyear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button data1;
        private System.Windows.Forms.Label datalabelY;
        private System.Windows.Forms.Label labelm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox daytext;
        private System.Windows.Forms.TextBox monthtext;
        private System.Windows.Forms.TextBox yeartext;
        private System.Windows.Forms.Button vpered;
        private System.Windows.Forms.Label datalabelD;
        private System.Windows.Forms.Label datalabelM;
    }
}

