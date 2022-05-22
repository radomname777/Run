namespace Run
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Run = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Run.Location = new System.Drawing.Point(352, 177);
            this.Run.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Run.Name = "Run";
            this.Run.Padding = new System.Windows.Forms.Padding(2);
            this.Run.Size = new System.Drawing.Size(92, 38);
            this.Run.TabIndex = 0;
            this.Run.Text = "RuN";
            this.Run.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Run.MouseEnter += new System.EventHandler(this.Run_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Run);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label Run;
    }
}