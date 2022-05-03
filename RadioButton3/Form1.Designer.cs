
namespace RadioButton3
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
            this.RB_Black = new System.Windows.Forms.RadioButton();
            this.Rb_White = new System.Windows.Forms.RadioButton();
            this.Rb_Blue = new System.Windows.Forms.RadioButton();
            this.Rb_Green = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RB_Black
            // 
            this.RB_Black.AutoSize = true;
            this.RB_Black.Location = new System.Drawing.Point(14, 29);
            this.RB_Black.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RB_Black.Name = "RB_Black";
            this.RB_Black.Size = new System.Drawing.Size(93, 33);
            this.RB_Black.TabIndex = 0;
            this.RB_Black.TabStop = true;
            this.RB_Black.Text = "Black";
            this.RB_Black.UseVisualStyleBackColor = true;
            this.RB_Black.CheckedChanged += new System.EventHandler(this.RB_Black_CheckedChanged);
            // 
            // Rb_White
            // 
            this.Rb_White.AutoSize = true;
            this.Rb_White.Location = new System.Drawing.Point(14, 72);
            this.Rb_White.Margin = new System.Windows.Forms.Padding(5);
            this.Rb_White.Name = "Rb_White";
            this.Rb_White.Size = new System.Drawing.Size(95, 33);
            this.Rb_White.TabIndex = 1;
            this.Rb_White.TabStop = true;
            this.Rb_White.Text = "White";
            this.Rb_White.UseVisualStyleBackColor = true;
            this.Rb_White.CheckedChanged += new System.EventHandler(this.Rb_White_CheckedChanged);
            // 
            // Rb_Blue
            // 
            this.Rb_Blue.AutoSize = true;
            this.Rb_Blue.Location = new System.Drawing.Point(14, 115);
            this.Rb_Blue.Margin = new System.Windows.Forms.Padding(5);
            this.Rb_Blue.Name = "Rb_Blue";
            this.Rb_Blue.Size = new System.Drawing.Size(83, 33);
            this.Rb_Blue.TabIndex = 2;
            this.Rb_Blue.TabStop = true;
            this.Rb_Blue.Text = "Blue";
            this.Rb_Blue.UseVisualStyleBackColor = true;
            this.Rb_Blue.CheckedChanged += new System.EventHandler(this.Rb_Blue_CheckedChanged);
            // 
            // Rb_Green
            // 
            this.Rb_Green.AutoSize = true;
            this.Rb_Green.Location = new System.Drawing.Point(14, 158);
            this.Rb_Green.Margin = new System.Windows.Forms.Padding(5);
            this.Rb_Green.Name = "Rb_Green";
            this.Rb_Green.Size = new System.Drawing.Size(101, 33);
            this.Rb_Green.TabIndex = 3;
            this.Rb_Green.TabStop = true;
            this.Rb_Green.Text = "Green";
            this.Rb_Green.UseVisualStyleBackColor = true;
            this.Rb_Green.CheckedChanged += new System.EventHandler(this.Rb_Green_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 362);
            this.Controls.Add(this.Rb_Green);
            this.Controls.Add(this.Rb_Blue);
            this.Controls.Add(this.Rb_White);
            this.Controls.Add(this.RB_Black);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RB_Black;
        private System.Windows.Forms.RadioButton Rb_White;
        private System.Windows.Forms.RadioButton Rb_Blue;
        private System.Windows.Forms.RadioButton Rb_Green;
    }
}

