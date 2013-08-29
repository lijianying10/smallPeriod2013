namespace smallPeriod2013.SubFunction
{
    partial class goodsManage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refreash = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "goods manage";
            // 
            // btn_refreash
            // 
            this.btn_refreash.Location = new System.Drawing.Point(23, 103);
            this.btn_refreash.Name = "btn_refreash";
            this.btn_refreash.Size = new System.Drawing.Size(75, 23);
            this.btn_refreash.TabIndex = 1;
            this.btn_refreash.Text = "refreash";
            this.btn_refreash.UseVisualStyleBackColor = true;
            this.btn_refreash.Click += new System.EventHandler(this.btn_refreash_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(23, 196);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 23);
            this.btn_find.TabIndex = 2;
            this.btn_find.Text = "find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // goodsManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_refreash);
            this.Controls.Add(this.label1);
            this.Name = "goodsManage";
            this.Size = new System.Drawing.Size(137, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refreash;
        private System.Windows.Forms.Button btn_find;
    }
}
