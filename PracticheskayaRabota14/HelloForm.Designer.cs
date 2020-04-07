namespace PracticheskayaRabota14
{
    partial class HelloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloForm));
            this.DialogButton = new System.Windows.Forms.Button();
            this.NoDialogButton = new System.Windows.Forms.Button();
            this.Calc = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DialogButton
            // 
            this.DialogButton.Location = new System.Drawing.Point(12, 12);
            this.DialogButton.Name = "DialogButton";
            this.DialogButton.Size = new System.Drawing.Size(159, 23);
            this.DialogButton.TabIndex = 0;
            this.DialogButton.Text = "DialogButton";
            this.DialogButton.UseVisualStyleBackColor = true;
            this.DialogButton.Click += new System.EventHandler(this.DialogButton_Click);
            // 
            // NoDialogButton
            // 
            this.NoDialogButton.Location = new System.Drawing.Point(12, 55);
            this.NoDialogButton.Name = "NoDialogButton";
            this.NoDialogButton.Size = new System.Drawing.Size(159, 23);
            this.NoDialogButton.TabIndex = 1;
            this.NoDialogButton.Text = "NoDialogButton";
            this.NoDialogButton.UseVisualStyleBackColor = true;
            this.NoDialogButton.Click += new System.EventHandler(this.NoDialogButton_Click);
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(12, 102);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(159, 23);
            this.Calc.TabIndex = 2;
            this.Calc.Text = "Калькулятор";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(407, 29);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(152, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход из приложения";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.NoDialogButton);
            this.Controls.Add(this.DialogButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelloForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HelloForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DialogButton;
        private System.Windows.Forms.Button NoDialogButton;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Button ExitButton;
    }
}

