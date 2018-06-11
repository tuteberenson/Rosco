namespace Rosco
{
    partial class MainScreen
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
            this.btn_continue = new System.Windows.Forms.Button();
            this.team1Name = new System.Windows.Forms.TextBox();
            this.team2Name = new System.Windows.Forms.TextBox();
            this.team1Time = new System.Windows.Forms.TextBox();
            this.team2Time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_continue
            // 
            this.btn_continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btn_continue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_continue.Location = new System.Drawing.Point(21, 142);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(504, 168);
            this.btn_continue.TabIndex = 0;
            this.btn_continue.Text = "JUGAR";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // team1Name
            // 
            this.team1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.team1Name.Location = new System.Drawing.Point(21, 21);
            this.team1Name.Name = "team1Name";
            this.team1Name.Size = new System.Drawing.Size(229, 38);
            this.team1Name.TabIndex = 1;
            this.team1Name.Text = "EQUIPO 1";
            // 
            // team2Name
            // 
            this.team2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.team2Name.Location = new System.Drawing.Point(296, 21);
            this.team2Name.Name = "team2Name";
            this.team2Name.Size = new System.Drawing.Size(229, 38);
            this.team2Name.TabIndex = 2;
            this.team2Name.Text = "EQUIPO 2";
            // 
            // team1Time
            // 
            this.team1Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.team1Time.Location = new System.Drawing.Point(21, 76);
            this.team1Time.Name = "team1Time";
            this.team1Time.Size = new System.Drawing.Size(229, 38);
            this.team1Time.TabIndex = 3;
            this.team1Time.Text = "SEGUNDOS";
            this.team1Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // team2Time
            // 
            this.team2Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.team2Time.Location = new System.Drawing.Point(296, 76);
            this.team2Time.Name = "team2Time";
            this.team2Time.Size = new System.Drawing.Size(229, 38);
            this.team2Time.TabIndex = 4;
            this.team2Time.Text = "SEGUNDOS";
            this.team2Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(538, 339);
            this.Controls.Add(this.team2Time);
            this.Controls.Add(this.team1Time);
            this.Controls.Add(this.team2Name);
            this.Controls.Add(this.team1Name);
            this.Controls.Add(this.btn_continue);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.TextBox team1Name;
        private System.Windows.Forms.TextBox team2Name;
        private System.Windows.Forms.TextBox team1Time;
        private System.Windows.Forms.TextBox team2Time;
    }
}

