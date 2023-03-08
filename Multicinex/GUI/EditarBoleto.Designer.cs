namespace Multicinex.GUI
{
    partial class EditarBoleto
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
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cbSucursal = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.tbCodigoBoleto = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.tbcodFuncion = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.LabelColumna = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.LabelFila = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.tbFila = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tbColumna = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.tbcodSala = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.SuspendLayout();
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
            this.siticoneButton2.Location = new System.Drawing.Point(570, 556);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton2.TabIndex = 41;
            this.siticoneButton2.Text = "Eliminar";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
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
            this.siticoneButton1.Location = new System.Drawing.Point(248, 556);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton1.TabIndex = 40;
            this.siticoneButton1.Text = "Actualizar";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
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
            this.cbSucursal.Location = new System.Drawing.Point(497, 98);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(200, 36);
            this.cbSucursal.TabIndex = 65;
            // 
            // siticoneHtmlLabel6
            // 
            this.siticoneHtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel6.Location = new System.Drawing.Point(306, 102);
            this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            this.siticoneHtmlLabel6.Size = new System.Drawing.Size(77, 24);
            this.siticoneHtmlLabel6.TabIndex = 64;
            this.siticoneHtmlLabel6.Text = "Sucursal";
            // 
            // tbCodigoBoleto
            // 
            this.tbCodigoBoleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCodigoBoleto.BorderRadius = 20;
            this.tbCodigoBoleto.DefaultText = "";
            this.tbCodigoBoleto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCodigoBoleto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCodigoBoleto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCodigoBoleto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCodigoBoleto.Enabled = false;
            this.tbCodigoBoleto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCodigoBoleto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCodigoBoleto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCodigoBoleto.Location = new System.Drawing.Point(497, 35);
            this.tbCodigoBoleto.Name = "tbCodigoBoleto";
            this.tbCodigoBoleto.PasswordChar = '\0';
            this.tbCodigoBoleto.PlaceholderText = "";
            this.tbCodigoBoleto.SelectedText = "";
            this.tbCodigoBoleto.Size = new System.Drawing.Size(200, 36);
            this.tbCodigoBoleto.TabIndex = 63;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(306, 41);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(133, 24);
            this.siticoneHtmlLabel1.TabIndex = 62;
            this.siticoneHtmlLabel1.Text = "Código Boleto";
            // 
            // tbcodFuncion
            // 
            this.tbcodFuncion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbcodFuncion.BorderRadius = 20;
            this.tbcodFuncion.DefaultText = "";
            this.tbcodFuncion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbcodFuncion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbcodFuncion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcodFuncion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcodFuncion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcodFuncion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbcodFuncion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcodFuncion.Location = new System.Drawing.Point(497, 224);
            this.tbcodFuncion.Name = "tbcodFuncion";
            this.tbcodFuncion.PasswordChar = '\0';
            this.tbcodFuncion.PlaceholderText = "";
            this.tbcodFuncion.SelectedText = "";
            this.tbcodFuncion.Size = new System.Drawing.Size(200, 36);
            this.tbcodFuncion.TabIndex = 61;
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(306, 224);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(148, 24);
            this.siticoneHtmlLabel3.TabIndex = 60;
            this.siticoneHtmlLabel3.Text = "Código Función";
            // 
            // LabelColumna
            // 
            this.LabelColumna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelColumna.BackColor = System.Drawing.Color.Transparent;
            this.LabelColumna.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelColumna.Location = new System.Drawing.Point(309, 346);
            this.LabelColumna.Name = "LabelColumna";
            this.LabelColumna.Size = new System.Drawing.Size(92, 24);
            this.LabelColumna.TabIndex = 67;
            this.LabelColumna.Text = "Columna: ";
            // 
            // LabelFila
            // 
            this.LabelFila.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelFila.BackColor = System.Drawing.Color.Transparent;
            this.LabelFila.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelFila.Location = new System.Drawing.Point(309, 285);
            this.LabelFila.Name = "LabelFila";
            this.LabelFila.Size = new System.Drawing.Size(41, 24);
            this.LabelFila.TabIndex = 66;
            this.LabelFila.Text = "Fila :";
            // 
            // tbFila
            // 
            this.tbFila.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFila.BorderRadius = 20;
            this.tbFila.DefaultText = "";
            this.tbFila.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFila.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFila.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFila.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFila.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFila.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFila.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFila.Location = new System.Drawing.Point(497, 287);
            this.tbFila.Name = "tbFila";
            this.tbFila.PasswordChar = '\0';
            this.tbFila.PlaceholderText = "";
            this.tbFila.SelectedText = "";
            this.tbFila.Size = new System.Drawing.Size(200, 36);
            this.tbFila.TabIndex = 68;
            // 
            // tbColumna
            // 
            this.tbColumna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbColumna.BorderRadius = 20;
            this.tbColumna.DefaultText = "";
            this.tbColumna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbColumna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbColumna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbColumna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbColumna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbColumna.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbColumna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbColumna.Location = new System.Drawing.Point(497, 350);
            this.tbColumna.Name = "tbColumna";
            this.tbColumna.PasswordChar = '\0';
            this.tbColumna.PlaceholderText = "";
            this.tbColumna.SelectedText = "";
            this.tbColumna.Size = new System.Drawing.Size(200, 36);
            this.tbColumna.TabIndex = 69;
            // 
            // dtFecha
            // 
            this.dtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtFecha.CustomFormat = "dd/MM/yyyy";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(506, 463);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 23);
            this.dtFecha.TabIndex = 73;
            this.dtFecha.Value = new System.DateTime(2023, 3, 2, 8, 20, 0, 0);
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(309, 468);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(61, 24);
            this.siticoneHtmlLabel5.TabIndex = 72;
            this.siticoneHtmlLabel5.Text = "Fecha ";
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(309, 407);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(47, 24);
            this.siticoneHtmlLabel4.TabIndex = 71;
            this.siticoneHtmlLabel4.Text = "Hora";
            // 
            // dtHora
            // 
            this.dtHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtHora.CustomFormat = "hh:mm:ss";
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(506, 413);
            this.dtHora.Name = "dtHora";
            this.dtHora.ShowUpDown = true;
            this.dtHora.Size = new System.Drawing.Size(200, 23);
            this.dtHora.TabIndex = 70;
            this.dtHora.Value = new System.DateTime(2023, 3, 2, 8, 20, 0, 0);
            // 
            // tbcodSala
            // 
            this.tbcodSala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbcodSala.BorderRadius = 20;
            this.tbcodSala.DefaultText = "";
            this.tbcodSala.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbcodSala.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbcodSala.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcodSala.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcodSala.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcodSala.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbcodSala.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcodSala.Location = new System.Drawing.Point(497, 161);
            this.tbcodSala.Name = "tbcodSala";
            this.tbcodSala.PasswordChar = '\0';
            this.tbcodSala.PlaceholderText = "";
            this.tbcodSala.SelectedText = "";
            this.tbcodSala.Size = new System.Drawing.Size(200, 36);
            this.tbcodSala.TabIndex = 75;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(306, 163);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(114, 24);
            this.siticoneHtmlLabel2.TabIndex = 74;
            this.siticoneHtmlLabel2.Text = "Código Sala";
            // 
            // EditarBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 663);
            this.Controls.Add(this.tbcodSala);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.siticoneHtmlLabel5);
            this.Controls.Add(this.siticoneHtmlLabel4);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.tbColumna);
            this.Controls.Add(this.tbFila);
            this.Controls.Add(this.LabelColumna);
            this.Controls.Add(this.LabelFila);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.siticoneHtmlLabel6);
            this.Controls.Add(this.tbCodigoBoleto);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.tbcodFuncion);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.siticoneButton1);
            this.Name = "EditarBoleto";
            this.Text = "EditarBoleto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSucursal;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbCodigoBoleto;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbcodFuncion;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel LabelColumna;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel LabelFila;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbFila;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbColumna;
        private DateTimePicker dtFecha;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private DateTimePicker dtHora;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbcodSala;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
    }
}