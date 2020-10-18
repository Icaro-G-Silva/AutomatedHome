namespace CasaAutomatizada
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.btn_Check = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Response = new System.Windows.Forms.Label();
            this.cmb_Ports = new System.Windows.Forms.ComboBox();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.Thistle;
            this.pnl_Main.Controls.Add(this.cmb_Ports);
            this.pnl_Main.Controls.Add(this.lbl_Response);
            this.pnl_Main.Controls.Add(this.btn_Close);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.Controls.Add(this.btn_Check);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1100, 692);
            this.pnl_Main.TabIndex = 0;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Transparent;
            this.btn_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Check.FlatAppearance.BorderSize = 0;
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(797, 631);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(291, 49);
            this.btn_Check.TabIndex = 0;
            this.btn_Check.Text = "Testar Microfone";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(287, 70);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(469, 41);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Programa da Casa Automatizada";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(1047, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(50, 50);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Response
            // 
            this.lbl_Response.AutoSize = true;
            this.lbl_Response.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Response.Location = new System.Drawing.Point(437, 282);
            this.lbl_Response.Name = "lbl_Response";
            this.lbl_Response.Size = new System.Drawing.Size(0, 37);
            this.lbl_Response.TabIndex = 3;
            this.lbl_Response.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Ports
            // 
            this.cmb_Ports.BackColor = System.Drawing.Color.White;
            this.cmb_Ports.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Ports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Ports.FormattingEnabled = true;
            this.cmb_Ports.Location = new System.Drawing.Point(12, 631);
            this.cmb_Ports.Name = "cmb_Ports";
            this.cmb_Ports.Size = new System.Drawing.Size(177, 36);
            this.cmb_Ports.TabIndex = 4;
            this.cmb_Ports.Text = "Selecione a Porta";
            this.cmb_Ports.SelectedIndexChanged += new System.EventHandler(this.cmb_Ports_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1100, 692);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casa automatizada";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Response;
        private System.Windows.Forms.ComboBox cmb_Ports;
    }
}

