namespace Multicinex.GUI
{
    partial class EditarSala
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
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.cbTipo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.numFila = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.numColumna = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.cbSucursal = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.tbcodigoSala = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.numFila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumna)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneButton1.BorderRadius = 15;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.SeaGreen;
            this.siticoneButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(205, 423);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton1.TabIndex = 53;
            this.siticoneButton1.Text = "Actualizar";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(227, 326);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(26, 17);
            this.siticoneHtmlLabel5.TabIndex = 52;
            this.siticoneHtmlLabel5.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipo.BackColor = System.Drawing.Color.Transparent;
            this.cbTipo.BorderRadius = 15;
            this.cbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTipo.ItemHeight = 30;
            this.cbTipo.Items.AddRange(new object[] {
            "SALA PLAY",
            "PALCO PREMIER",
            "IMAX",
            "3D",
            "2D",
            "SALA D-BOX"});
            this.cbTipo.Location = new System.Drawing.Point(512, 326);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(200, 36);
            this.cbTipo.TabIndex = 51;
            // 
            // numFila
            // 
            this.numFila.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numFila.BackColor = System.Drawing.Color.Transparent;
            this.numFila.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numFila.Location = new System.Drawing.Point(558, 187);
            this.numFila.Name = "numFila";
            this.numFila.Size = new System.Drawing.Size(95, 36);
            this.numFila.TabIndex = 50;
            // 
            // numColumna
            // 
            this.numColumna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numColumna.BackColor = System.Drawing.Color.Transparent;
            this.numColumna.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numColumna.Location = new System.Drawing.Point(558, 258);
            this.numColumna.Name = "numColumna";
            this.numColumna.Size = new System.Drawing.Size(95, 36);
            this.numColumna.TabIndex = 49;
            // 
            // cbSucursal
            // 
            this.cbSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSucursal.BackColor = System.Drawing.Color.Transparent;
            this.cbSucursal.BorderRadius = 15;
            this.cbSucursal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucursal.Enabled = false;
            this.cbSucursal.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSucursal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSucursal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSucursal.ItemHeight = 30;
            this.cbSucursal.Items.AddRange(new object[] {
            "Quito-Norte",
            "Quito-Sur"});
            this.cbSucursal.Location = new System.Drawing.Point(512, 115);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(200, 36);
            this.cbSucursal.TabIndex = 48;
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(227, 115);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(47, 17);
            this.siticoneHtmlLabel3.TabIndex = 47;
            this.siticoneHtmlLabel3.Text = "Sucursal";
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(227, 258);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(116, 17);
            this.siticoneHtmlLabel4.TabIndex = 46;
            this.siticoneHtmlLabel4.Text = "Capacidad Columnas";
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(227, 187);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(85, 17);
            this.siticoneHtmlLabel2.TabIndex = 45;
            this.siticoneHtmlLabel2.Text = "Capacidad Filas";
            // 
            // tbcodigoSala
            // 
            this.tbcodigoSala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbcodigoSala.BorderRadius = 20;
            this.tbcodigoSala.DefaultText = "";
            this.tbcodigoSala.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbcodigoSala.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbcodigoSala.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcodigoSala.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcodigoSala.Enabled = false;
            this.tbcodigoSala.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcodigoSala.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbcodigoSala.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcodigoSala.Location = new System.Drawing.Point(512, 47);
            this.tbcodigoSala.Name = "tbcodigoSala";
            this.tbcodigoSala.PasswordChar = '\0';
            this.tbcodigoSala.PlaceholderText = "";
            this.tbcodigoSala.SelectedText = "";
            this.tbcodigoSala.Size = new System.Drawing.Size(200, 36);
            this.tbcodigoSala.TabIndex = 44;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(227, 47);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(66, 17);
            this.siticoneHtmlLabel1.TabIndex = 43;
            this.siticoneHtmlLabel1.Text = "Código Sala";
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneButton2.BorderRadius = 15;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.FillColor = System.Drawing.Color.Firebrick;
            this.siticoneButton2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.Location = new System.Drawing.Point(501, 423);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton2.TabIndex = 70;
            this.siticoneButton2.Text = "Eliminar";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // EditarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 522);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.siticoneHtmlLabel5);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.numFila);
            this.Controls.Add(this.numColumna);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Controls.Add(this.siticoneHtmlLabel4);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.Controls.Add(this.tbcodigoSala);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Name = "EditarSala";
            this.Text = "EditarSala";
            ((System.ComponentModel.ISupportInitialize)(this.numFila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbTipo;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numFila;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numColumna;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSucursal;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbcodigoSala;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
    }
}