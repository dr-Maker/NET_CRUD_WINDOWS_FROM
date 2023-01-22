namespace FRAMEWORK_WINDOWS_FORM
{
    partial class Layout
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.TBUser = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.Btn = new System.Windows.Forms.Button();
            this.LUser = new System.Windows.Forms.Label();
            this.LPass = new System.Windows.Forms.Label();
            this.DatosBd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DatosBd)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Titulo.Location = new System.Drawing.Point(217, 38);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(122, 18);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Este es el Titulo";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBUser
            // 
            this.TBUser.Location = new System.Drawing.Point(202, 112);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(160, 20);
            this.TBUser.TabIndex = 1;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(202, 181);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(160, 20);
            this.TBPass.TabIndex = 2;
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(264, 207);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(75, 23);
            this.Btn.TabIndex = 3;
            this.Btn.Text = "Ingresar";
            this.Btn.UseVisualStyleBackColor = true;
            // 
            // LUser
            // 
            this.LUser.AutoSize = true;
            this.LUser.Location = new System.Drawing.Point(261, 84);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(43, 13);
            this.LUser.TabIndex = 4;
            this.LUser.Text = "Usuario";
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Location = new System.Drawing.Point(261, 154);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(61, 13);
            this.LPass.TabIndex = 5;
            this.LPass.Text = "Contraseña";
            // 
            // DatosBd
            // 
            this.DatosBd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosBd.Location = new System.Drawing.Point(22, 262);
            this.DatosBd.Name = "DatosBd";
            this.DatosBd.Size = new System.Drawing.Size(505, 150);
            this.DatosBd.TabIndex = 6;
            this.DatosBd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Layout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.DatosBd);
            this.Controls.Add(this.LPass);
            this.Controls.Add(this.LUser);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.Titulo);
            this.Name = "Layout";
            this.Text = "Layout";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosBd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.DataGridView DatosBd;
    }
}

