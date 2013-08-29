namespace smallPeriod2013
{
    partial class systemFunc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_switch_user = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_add_P = new System.Windows.Forms.Button();
            this.btn_good = new System.Windows.Forms.Button();
            this.btn_system = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_switch_user
            // 
            this.btn_switch_user.Location = new System.Drawing.Point(3, 15);
            this.btn_switch_user.Name = "btn_switch_user";
            this.btn_switch_user.Size = new System.Drawing.Size(120, 23);
            this.btn_switch_user.TabIndex = 0;
            this.btn_switch_user.Text = "switch user";
            this.btn_switch_user.UseVisualStyleBackColor = true;
            this.btn_switch_user.Click += new System.EventHandler(this.btn_switch_user_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 0);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_add_P
            // 
            this.btn_add_P.Location = new System.Drawing.Point(3, 142);
            this.btn_add_P.Name = "btn_add_P";
            this.btn_add_P.Size = new System.Drawing.Size(120, 23);
            this.btn_add_P.TabIndex = 4;
            this.btn_add_P.Text = "persion manage";
            this.btn_add_P.UseVisualStyleBackColor = true;
            this.btn_add_P.Click += new System.EventHandler(this.btn_add_P_Click);
            // 
            // btn_good
            // 
            this.btn_good.Location = new System.Drawing.Point(3, 269);
            this.btn_good.Name = "btn_good";
            this.btn_good.Size = new System.Drawing.Size(120, 23);
            this.btn_good.TabIndex = 5;
            this.btn_good.Text = "goods manage";
            this.btn_good.UseVisualStyleBackColor = true;
            this.btn_good.Click += new System.EventHandler(this.btn_good_Click);
            // 
            // btn_system
            // 
            this.btn_system.Location = new System.Drawing.Point(3, 396);
            this.btn_system.Name = "btn_system";
            this.btn_system.Size = new System.Drawing.Size(120, 23);
            this.btn_system.TabIndex = 6;
            this.btn_system.Text = "system manage";
            this.btn_system.UseVisualStyleBackColor = true;
            this.btn_system.Click += new System.EventHandler(this.btn_system_Click);
            // 
            // systemFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_system);
            this.Controls.Add(this.btn_good);
            this.Controls.Add(this.btn_add_P);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_switch_user);
            this.Name = "systemFunc";
            this.Size = new System.Drawing.Size(137, 442);
            this.Load += new System.EventHandler(this.systemFunc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_switch_user;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_add_P;
        private System.Windows.Forms.Button btn_good;
        private System.Windows.Forms.Button btn_system;
    }
}
