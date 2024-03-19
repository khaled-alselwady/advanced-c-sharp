namespace WinFormUI
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnMessageBoxDemo = new System.Windows.Forms.Button();
            this.btnTextBoxDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sub Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(561, 47);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(211, 35);
            this.txtSubTotal.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(561, 179);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(211, 35);
            this.txtTotal.TabIndex = 3;
            // 
            // btnMessageBoxDemo
            // 
            this.btnMessageBoxDemo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMessageBoxDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessageBoxDemo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageBoxDemo.Location = new System.Drawing.Point(92, 209);
            this.btnMessageBoxDemo.Name = "btnMessageBoxDemo";
            this.btnMessageBoxDemo.Size = new System.Drawing.Size(183, 79);
            this.btnMessageBoxDemo.TabIndex = 4;
            this.btnMessageBoxDemo.Text = "Message Box Demo";
            this.btnMessageBoxDemo.UseVisualStyleBackColor = false;
            this.btnMessageBoxDemo.Click += new System.EventHandler(this.btnMessageBoxDemo_Click);
            // 
            // btnTextBoxDemo
            // 
            this.btnTextBoxDemo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTextBoxDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextBoxDemo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextBoxDemo.Location = new System.Drawing.Point(313, 209);
            this.btnTextBoxDemo.Name = "btnTextBoxDemo";
            this.btnTextBoxDemo.Size = new System.Drawing.Size(183, 79);
            this.btnTextBoxDemo.TabIndex = 5;
            this.btnTextBoxDemo.Text = "Text Box Demo";
            this.btnTextBoxDemo.UseVisualStyleBackColor = false;
            this.btnTextBoxDemo.Click += new System.EventHandler(this.btnTextBoxDemo_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.btnTextBoxDemo);
            this.Controls.Add(this.btnMessageBoxDemo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnMessageBoxDemo;
        private System.Windows.Forms.Button btnTextBoxDemo;
    }
}

