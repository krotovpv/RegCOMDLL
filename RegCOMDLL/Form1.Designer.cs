namespace RegCOMDLL
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbReg = new System.Windows.Forms.RadioButton();
            this.rbUnreg = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DLL path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(69, 83);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(388, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(463, 81);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(28, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // rbReg
            // 
            this.rbReg.AutoSize = true;
            this.rbReg.Checked = true;
            this.rbReg.Location = new System.Drawing.Point(12, 119);
            this.rbReg.Name = "rbReg";
            this.rbReg.Size = new System.Drawing.Size(76, 17);
            this.rbReg.TabIndex = 4;
            this.rbReg.TabStop = true;
            this.rbReg.Text = "registration";
            this.rbReg.UseVisualStyleBackColor = true;
            // 
            // rbUnreg
            // 
            this.rbUnreg.AutoSize = true;
            this.rbUnreg.Location = new System.Drawing.Point(94, 119);
            this.rbUnreg.Name = "rbUnreg";
            this.rbUnreg.Size = new System.Drawing.Size(88, 17);
            this.rbUnreg.TabIndex = 5;
            this.rbUnreg.Text = "unregistration";
            this.rbUnreg.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(416, 113);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Lib files|*.dll";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 148);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbUnreg);
            this.Controls.Add(this.rbReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Регистрация COM библиотек";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbReg;
        private System.Windows.Forms.RadioButton rbUnreg;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

