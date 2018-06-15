namespace VPV_GUI
{
    partial class StartTask
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelAvTime = new System.Windows.Forms.Label();
            this.labelDTime = new System.Windows.Forms.Label();
            this.labelDMemory = new System.Windows.Forms.Label();
            this.labelAvMemory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editTimePercent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editTimeValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editMemoryValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editMemoryPercent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(364, 23);
            this.progressBar.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(12, 35);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(146, 16);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Идет тестирование...";
            // 
            // labelAvTime
            // 
            this.labelAvTime.AutoSize = true;
            this.labelAvTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvTime.Location = new System.Drawing.Point(12, 61);
            this.labelAvTime.Name = "labelAvTime";
            this.labelAvTime.Size = new System.Drawing.Size(114, 16);
            this.labelAvTime.TabIndex = 2;
            this.labelAvTime.Tag = "";
            this.labelAvTime.Text = "Среднее время: ";
            // 
            // labelDTime
            // 
            this.labelDTime.AutoSize = true;
            this.labelDTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDTime.Location = new System.Drawing.Point(12, 87);
            this.labelDTime.Name = "labelDTime";
            this.labelDTime.Size = new System.Drawing.Size(94, 16);
            this.labelDTime.TabIndex = 3;
            this.labelDTime.Tag = "";
            this.labelDTime.Text = "Отклонение: ";
            // 
            // labelDMemory
            // 
            this.labelDMemory.AutoSize = true;
            this.labelDMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDMemory.Location = new System.Drawing.Point(12, 138);
            this.labelDMemory.Name = "labelDMemory";
            this.labelDMemory.Size = new System.Drawing.Size(94, 16);
            this.labelDMemory.TabIndex = 5;
            this.labelDMemory.Tag = "";
            this.labelDMemory.Text = "Отклонение: ";
            // 
            // labelAvMemory
            // 
            this.labelAvMemory.AutoSize = true;
            this.labelAvMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvMemory.Location = new System.Drawing.Point(12, 112);
            this.labelAvMemory.Name = "labelAvMemory";
            this.labelAvMemory.Size = new System.Drawing.Size(118, 16);
            this.labelAvMemory.TabIndex = 4;
            this.labelAvMemory.Tag = "";
            this.labelAvMemory.Text = "Средняя память: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 6;
            this.label1.Tag = "";
            this.label1.Text = "С вероятностью";
            // 
            // editTimePercent
            // 
            this.editTimePercent.Enabled = false;
            this.editTimePercent.FormattingEnabled = true;
            this.editTimePercent.Items.AddRange(new object[] {
            "90",
            "95",
            "99.5"});
            this.editTimePercent.Location = new System.Drawing.Point(131, 163);
            this.editTimePercent.Name = "editTimePercent";
            this.editTimePercent.Size = new System.Drawing.Size(57, 21);
            this.editTimePercent.TabIndex = 8;
            this.editTimePercent.Text = "95";
            this.editTimePercent.TextChanged += new System.EventHandler(this.editTimePercent_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 9;
            this.label2.Tag = "";
            this.label2.Text = "Время работы не превысит";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(194, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 10;
            this.label3.Tag = "";
            this.label3.Text = "%";
            // 
            // editTimeValue
            // 
            this.editTimeValue.Enabled = false;
            this.editTimeValue.Location = new System.Drawing.Point(204, 190);
            this.editTimeValue.Name = "editTimeValue";
            this.editTimeValue.Size = new System.Drawing.Size(59, 20);
            this.editTimeValue.TabIndex = 11;
            this.editTimeValue.TextChanged += new System.EventHandler(this.editTimeValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(269, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 12;
            this.label4.Tag = "";
            this.label4.Text = "Мс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(322, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 18;
            this.label5.Tag = "";
            this.label5.Text = "Кб";
            // 
            // editMemoryValue
            // 
            this.editMemoryValue.Enabled = false;
            this.editMemoryValue.Location = new System.Drawing.Point(257, 248);
            this.editMemoryValue.Name = "editMemoryValue";
            this.editMemoryValue.Size = new System.Drawing.Size(59, 20);
            this.editMemoryValue.TabIndex = 17;
            this.editMemoryValue.TextChanged += new System.EventHandler(this.editMemoryValue_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(194, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 16;
            this.label6.Tag = "";
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 16);
            this.label7.TabIndex = 15;
            this.label7.Tag = "";
            this.label7.Text = "Используемая память не превысит";
            // 
            // editMemoryPercent
            // 
            this.editMemoryPercent.Enabled = false;
            this.editMemoryPercent.FormattingEnabled = true;
            this.editMemoryPercent.Items.AddRange(new object[] {
            "90",
            "95",
            "99.5"});
            this.editMemoryPercent.Location = new System.Drawing.Point(131, 221);
            this.editMemoryPercent.Name = "editMemoryPercent";
            this.editMemoryPercent.Size = new System.Drawing.Size(57, 21);
            this.editMemoryPercent.TabIndex = 14;
            this.editMemoryPercent.Text = "95";
            this.editMemoryPercent.TextChanged += new System.EventHandler(this.editMemoryPercent_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 13;
            this.label8.Tag = "";
            this.label8.Text = "С вероятностью";
            // 
            // StartTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 288);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editMemoryValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editMemoryPercent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editTimeValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editTimePercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDMemory);
            this.Controls.Add(this.labelAvMemory);
            this.Controls.Add(this.labelDTime);
            this.Controls.Add(this.labelAvTime);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "StartTask";
            this.Text = "StartTask";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartTask_FormClosing);
            this.Load += new System.EventHandler(this.StartTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelAvTime;
        private System.Windows.Forms.Label labelDTime;
        private System.Windows.Forms.Label labelDMemory;
        private System.Windows.Forms.Label labelAvMemory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox editTimePercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editTimeValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editMemoryValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox editMemoryPercent;
        private System.Windows.Forms.Label label8;
    }
}