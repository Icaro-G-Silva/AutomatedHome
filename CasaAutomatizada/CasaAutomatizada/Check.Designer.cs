namespace CasaAutomatizada
{
    partial class Check
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_Response = new System.Windows.Forms.Label();
            this.btn_Test = new System.Windows.Forms.Button();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(3, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(50, 50);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Main.Controls.Add(this.btn_Test);
            this.pnl_Main.Controls.Add(this.lbl_Response);
            this.pnl_Main.Controls.Add(this.btn_Close);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(861, 509);
            this.pnl_Main.TabIndex = 1;
            // 
            // lbl_Response
            // 
            this.lbl_Response.AutoSize = true;
            this.lbl_Response.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Response.Location = new System.Drawing.Point(209, 150);
            this.lbl_Response.Name = "lbl_Response";
            this.lbl_Response.Size = new System.Drawing.Size(407, 38);
            this.lbl_Response.TabIndex = 1;
            this.lbl_Response.Text = "Clique no botão para começar...";
            this.lbl_Response.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Test
            // 
            this.btn_Test.BackColor = System.Drawing.Color.Transparent;
            this.btn_Test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Test.FlatAppearance.BorderSize = 0;
            this.btn_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Test.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Test.Location = new System.Drawing.Point(294, 298);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(232, 65);
            this.btn_Test.TabIndex = 2;
            this.btn_Test.Text = "Testar";
            this.btn_Test.UseVisualStyleBackColor = false;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 509);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check";
            this.Load += new System.EventHandler(this.Check_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Label lbl_Response;
    }
}