namespace Ex1
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
            this.btnIT = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIT
            // 
            this.btnIT.Location = new System.Drawing.Point(60, 65);
            this.btnIT.Name = "btnIT";
            this.btnIT.Size = new System.Drawing.Size(98, 53);
            this.btnIT.TabIndex = 0;
            this.btnIT.Text = "Add Item";
            this.btnIT.UseVisualStyleBackColor = true;
            this.btnIT.Click += new System.EventHandler(this.btnIT_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(217, 65);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(98, 53);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "Add Agent";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(377, 65);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(98, 53);
            this.btnO.TabIndex = 2;
            this.btnO.Text = "Add Order";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 174);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnIT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnIT;
        private Button btnA;
        private Button btnO;
    }
}