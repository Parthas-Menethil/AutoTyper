namespace AutoTyper
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
            this.components = new System.ComponentModel.Container();
            this.txtDemoBox = new System.Windows.Forms.TextBox();
            this.timerTyper = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtDemoBox
            // 
            this.txtDemoBox.Location = new System.Drawing.Point(46, 32);
            this.txtDemoBox.Multiline = true;
            this.txtDemoBox.Name = "txtDemoBox";
            this.txtDemoBox.Size = new System.Drawing.Size(684, 439);
            this.txtDemoBox.TabIndex = 0;
            // 
            // timerTyper
            // 
            this.timerTyper.Enabled = true;
            this.timerTyper.Interval = 200;
            this.timerTyper.Tick += new System.EventHandler(this.timerTyper_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 555);
            this.Controls.Add(this.txtDemoBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDemoBox;
        private System.Windows.Forms.Timer timerTyper;
    }
}

