namespace ejemplo_3eventos
{
    partial class Form1
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbxMavel = new System.Windows.Forms.CheckBox();
            this.rbIronMan = new System.Windows.Forms.RadioButton();
            this.rbCap = new System.Windows.Forms.RadioButton();
            this.rbThor = new System.Windows.Forms.RadioButton();
            this.gbAvenges = new System.Windows.Forms.GroupBox();
            this.cbxSagas = new System.Windows.Forms.ComboBox();
            this.lbSagas = new System.Windows.Forms.Label();
            this.nupCopas = new System.Windows.Forms.NumericUpDown();
            this.lbCopas = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbAvenges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCopas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTitulo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(376, 38);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(132, 22);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Completé El Perfil";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbNombre.Location = new System.Drawing.Point(76, 79);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNombre.Location = new System.Drawing.Point(228, 76);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(547, 20);
            this.txtbNombre.TabIndex = 0;
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbFechaNacimiento.Location = new System.Drawing.Point(76, 111);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lbFechaNacimiento.TabIndex = 3;
            this.lbFechaNacimiento.Text = "FechaNacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(228, 105);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(547, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // cbxMavel
            // 
            this.cbxMavel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxMavel.AutoSize = true;
            this.cbxMavel.Location = new System.Drawing.Point(424, 147);
            this.cbxMavel.Name = "cbxMavel";
            this.cbxMavel.Size = new System.Drawing.Size(108, 17);
            this.cbxMavel.TabIndex = 2;
            this.cbxMavel.Text = "Te Gustá Mavel?";
            this.cbxMavel.UseVisualStyleBackColor = true;
            // 
            // rbIronMan
            // 
            this.rbIronMan.AutoSize = true;
            this.rbIronMan.Checked = true;
            this.rbIronMan.Location = new System.Drawing.Point(29, 48);
            this.rbIronMan.Name = "rbIronMan";
            this.rbIronMan.Size = new System.Drawing.Size(67, 17);
            this.rbIronMan.TabIndex = 6;
            this.rbIronMan.TabStop = true;
            this.rbIronMan.Text = "Iron Man";
            this.rbIronMan.UseVisualStyleBackColor = true;
            // 
            // rbCap
            // 
            this.rbCap.AutoSize = true;
            this.rbCap.Location = new System.Drawing.Point(103, 48);
            this.rbCap.Name = "rbCap";
            this.rbCap.Size = new System.Drawing.Size(102, 17);
            this.rbCap.TabIndex = 7;
            this.rbCap.Text = "Capitan America";
            this.rbCap.UseVisualStyleBackColor = true;
            // 
            // rbThor
            // 
            this.rbThor.AutoSize = true;
            this.rbThor.Location = new System.Drawing.Point(221, 48);
            this.rbThor.Name = "rbThor";
            this.rbThor.Size = new System.Drawing.Size(47, 17);
            this.rbThor.TabIndex = 8;
            this.rbThor.Text = "Thor";
            this.rbThor.UseVisualStyleBackColor = true;
            // 
            // gbAvenges
            // 
            this.gbAvenges.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbAvenges.Controls.Add(this.rbIronMan);
            this.gbAvenges.Controls.Add(this.rbThor);
            this.gbAvenges.Controls.Add(this.rbCap);
            this.gbAvenges.Location = new System.Drawing.Point(327, 170);
            this.gbAvenges.Name = "gbAvenges";
            this.gbAvenges.Size = new System.Drawing.Size(331, 100);
            this.gbAvenges.TabIndex = 3;
            this.gbAvenges.TabStop = false;
            this.gbAvenges.Text = "Vengador Favorito";
            // 
            // cbxSagas
            // 
            this.cbxSagas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSagas.FormattingEnabled = true;
            this.cbxSagas.Location = new System.Drawing.Point(228, 287);
            this.cbxSagas.Name = "cbxSagas";
            this.cbxSagas.Size = new System.Drawing.Size(547, 21);
            this.cbxSagas.TabIndex = 4;
            // 
            // lbSagas
            // 
            this.lbSagas.AutoSize = true;
            this.lbSagas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSagas.Location = new System.Drawing.Point(76, 290);
            this.lbSagas.Name = "lbSagas";
            this.lbSagas.Size = new System.Drawing.Size(146, 13);
            this.lbSagas.TabIndex = 11;
            this.lbSagas.Text = "Seleccione su Saga Favorita:";
            // 
            // nupCopas
            // 
            this.nupCopas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nupCopas.Location = new System.Drawing.Point(228, 314);
            this.nupCopas.Name = "nupCopas";
            this.nupCopas.Size = new System.Drawing.Size(547, 20);
            this.nupCopas.TabIndex = 5;
            // 
            // lbCopas
            // 
            this.lbCopas.AutoSize = true;
            this.lbCopas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbCopas.Location = new System.Drawing.Point(76, 316);
            this.lbCopas.Name = "lbCopas";
            this.lbCopas.Size = new System.Drawing.Size(110, 13);
            this.lbCopas.TabIndex = 13;
            this.lbCopas.Text = "Cuantas copas tenes:";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnVerPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.Location = new System.Drawing.Point(228, 359);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(108, 23);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver &Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lbCopas);
            this.Controls.Add(this.nupCopas);
            this.Controls.Add(this.lbSagas);
            this.Controls.Add(this.cbxSagas);
            this.Controls.Add(this.gbAvenges);
            this.Controls.Add(this.cbxMavel);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lbFechaNacimiento);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbTitulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(907, 489);
            this.MinimumSize = new System.Drawing.Size(560, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAvenges.ResumeLayout(false);
            this.gbAvenges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCopas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox cbxMavel;
        private System.Windows.Forms.RadioButton rbIronMan;
        private System.Windows.Forms.RadioButton rbCap;
        private System.Windows.Forms.RadioButton rbThor;
        private System.Windows.Forms.GroupBox gbAvenges;
        private System.Windows.Forms.ComboBox cbxSagas;
        private System.Windows.Forms.Label lbSagas;
        private System.Windows.Forms.NumericUpDown nupCopas;
        private System.Windows.Forms.Label lbCopas;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

