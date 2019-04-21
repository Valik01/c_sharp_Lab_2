namespace Lab_2
{
    partial class Form1
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
            this.rTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bCalculate1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTextBox1
            // 
            this.rTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rTextBox1.Location = new System.Drawing.Point(14, 14);
            this.rTextBox1.Name = "rTextBox1";
            this.rTextBox1.Size = new System.Drawing.Size(515, 380);
            this.rTextBox1.TabIndex = 0;
            this.rTextBox1.Text = "";
            // 
            // bCalculate1
            // 
            this.bCalculate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCalculate1.Location = new System.Drawing.Point(148, 400);
            this.bCalculate1.Name = "bCalculate1";
            this.bCalculate1.Size = new System.Drawing.Size(240, 38);
            this.bCalculate1.TabIndex = 1;
            this.bCalculate1.Text = "Calculate";
            this.bCalculate1.UseVisualStyleBackColor = true;
            this.bCalculate1.Click += new System.EventHandler(this.bCalculate1_Click);            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.bCalculate1);
            this.Controls.Add(this.rTextBox1);
            this.Name = "Form1";
            this.Text = "Matrix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.RichTextBox rTextBox1;
        private System.Windows.Forms.Button bCalculate1;
    }
}