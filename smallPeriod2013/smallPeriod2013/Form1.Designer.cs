namespace smallPeriod2013
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
            this.p_sysfunc = new System.Windows.Forms.Panel();
            this.p_function = new System.Windows.Forms.Panel();
            this.lbl_login_status = new System.Windows.Forms.Label();
            this.p_subsection = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // p_sysfunc
            // 
            this.p_sysfunc.Location = new System.Drawing.Point(12, 42);
            this.p_sysfunc.Name = "p_sysfunc";
            this.p_sysfunc.Size = new System.Drawing.Size(137, 442);
            this.p_sysfunc.TabIndex = 0;
            // 
            // p_function
            // 
            this.p_function.Location = new System.Drawing.Point(298, 42);
            this.p_function.Name = "p_function";
            this.p_function.Size = new System.Drawing.Size(730, 442);
            this.p_function.TabIndex = 2;
            // 
            // lbl_login_status
            // 
            this.lbl_login_status.AutoSize = true;
            this.lbl_login_status.Location = new System.Drawing.Point(12, 18);
            this.lbl_login_status.Name = "lbl_login_status";
            this.lbl_login_status.Size = new System.Drawing.Size(0, 12);
            this.lbl_login_status.TabIndex = 3;
            // 
            // p_subsection
            // 
            this.p_subsection.Location = new System.Drawing.Point(155, 42);
            this.p_subsection.Name = "p_subsection";
            this.p_subsection.Size = new System.Drawing.Size(137, 442);
            this.p_subsection.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 496);
            this.Controls.Add(this.p_subsection);
            this.Controls.Add(this.lbl_login_status);
            this.Controls.Add(this.p_function);
            this.Controls.Add(this.p_sysfunc);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_sysfunc;
        private System.Windows.Forms.Panel p_function;
        private System.Windows.Forms.Label lbl_login_status;
        private System.Windows.Forms.Panel p_subsection;

    }
}

