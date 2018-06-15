namespace VPV_GUI
{
    partial class Task
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
            this.editSourcePath = new System.Windows.Forms.TextBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.editInputPath = new System.Windows.Forms.TextBox();
            this.buttonSource = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.openSource = new System.Windows.Forms.OpenFileDialog();
            this.openInput = new System.Windows.Forms.OpenFileDialog();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.editName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editSourcePath
            // 
            this.editSourcePath.Location = new System.Drawing.Point(12, 84);
            this.editSourcePath.Name = "editSourcePath";
            this.editSourcePath.Size = new System.Drawing.Size(423, 20);
            this.editSourcePath.TabIndex = 0;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSource.Location = new System.Drawing.Point(12, 66);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(134, 15);
            this.labelSource.TabIndex = 2;
            this.labelSource.Text = "Файл исходного кода:";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput.Location = new System.Drawing.Point(9, 120);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(137, 15);
            this.labelInput.TabIndex = 3;
            this.labelInput.Text = "Файл входных данных";
            // 
            // editInputPath
            // 
            this.editInputPath.Location = new System.Drawing.Point(12, 138);
            this.editInputPath.Name = "editInputPath";
            this.editInputPath.Size = new System.Drawing.Size(423, 20);
            this.editInputPath.TabIndex = 4;
            // 
            // buttonSource
            // 
            this.buttonSource.Location = new System.Drawing.Point(441, 82);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(75, 23);
            this.buttonSource.TabIndex = 5;
            this.buttonSource.Text = "Выбрать";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(441, 138);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 6;
            this.buttonInput.Text = "Выбрать";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // openSource
            // 
            this.openSource.Filter = "C++|*.cpp";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(441, 167);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 7;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // editName
            // 
            this.editName.Location = new System.Drawing.Point(12, 28);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(501, 20);
            this.editName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Имя для теста:";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editName);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.buttonSource);
            this.Controls.Add(this.editInputPath);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.editSourcePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Test";
            this.Text = "Создать тест";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editSourcePath;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox editInputPath;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.Button buttonInput;
        internal System.Windows.Forms.OpenFileDialog openSource;
        private System.Windows.Forms.OpenFileDialog openInput;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.Label label1;
    }
}