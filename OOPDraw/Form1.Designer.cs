namespace OOPDraw
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
            this.CreateDraw = new System.Windows.Forms.Button();
            this.DrawBox = new System.Windows.Forms.PictureBox();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateDraw
            // 
            this.CreateDraw.Location = new System.Drawing.Point(29, 606);
            this.CreateDraw.Name = "CreateDraw";
            this.CreateDraw.Size = new System.Drawing.Size(75, 23);
            this.CreateDraw.TabIndex = 1;
            this.CreateDraw.Text = "RandomDraw";
            this.CreateDraw.UseVisualStyleBackColor = true;
            this.CreateDraw.Click += new System.EventHandler(this.CreateDraw_Click);
            // 
            // DrawBox
            // 
            this.DrawBox.Location = new System.Drawing.Point(0, 3);
            this.DrawBox.Name = "DrawBox";
            this.DrawBox.Size = new System.Drawing.Size(1081, 597);
            this.DrawBox.TabIndex = 0;
            this.DrawBox.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(805, 606);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 641);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CreateDraw);
            this.Controls.Add(this.DrawBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateDraw;
        private System.Windows.Forms.PictureBox DrawBox;
        private System.Windows.Forms.Button ClearButton;
    }
}

