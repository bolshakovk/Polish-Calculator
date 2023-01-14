
namespace Calculator
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
            this.submitButton = new System.Windows.Forms.Button();
            this.answeLabel = new System.Windows.Forms.Label();
            this.polishLabel = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(332, 303);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Посчитать";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // answeLabel
            // 
            this.answeLabel.AutoSize = true;
            this.answeLabel.Location = new System.Drawing.Point(337, 224);
            this.answeLabel.Name = "answeLabel";
            this.answeLabel.Size = new System.Drawing.Size(70, 13);
            this.answeLabel.TabIndex = 1;
            this.answeLabel.Text = "Поле ответа";
            // 
            // polishLabel
            // 
            this.polishLabel.AutoSize = true;
            this.polishLabel.Location = new System.Drawing.Point(316, 260);
            this.polishLabel.Name = "polishLabel";
            this.polishLabel.Size = new System.Drawing.Size(123, 13);
            this.polishLabel.TabIndex = 2;
            this.polishLabel.Text = "Поле польской записи";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(12, 171);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(776, 20);
            this.inputText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.polishLabel);
            this.Controls.Add(this.answeLabel);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label answeLabel;
        private System.Windows.Forms.Label polishLabel;
        private System.Windows.Forms.TextBox inputText;
    }
}

