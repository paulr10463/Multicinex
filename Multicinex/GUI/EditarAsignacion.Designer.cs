namespace Multicinex.GUI
{
    partial class EditarAsignacion
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
            this.tbCodigoSala = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.dtAsignacion = new System.Windows.Forms.DateTimePicker();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cbSucursal = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.tbCC = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.SuspendLayout();
            // 
            // tbCodigoSala
            // 
            this.tbCodigoSala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCodigoSala.BorderRadius = 20;
            this.tbCodigoSala.DefaultText = "";
            this.tbCodigoSala.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCodigoSala.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCodigoSala.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCodigoSala.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCodigoSala.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCodigoSala.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCodigoSala.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCodigoSala.Location = new System.Drawing.Point(491, 308);
            this.tbCodigoSala.Name = "tbCodigoSala";
            this.tbCodigoSala.PasswordChar = '\0';
            this.tbCodigoSala.PlaceholderText = "";
            this.tbCodigoSala.SelectedText = "";
            this.tbCodigoSala.Size = new System.Drawing.Size(200, 36);
            this.tbCodigoSala.TabIndex = 58;
            // 
            // siticoneHtmlLabel7
            // 
            this.siticoneHtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel7.Location = new System.Drawing.Point(206, 126);
            this.siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            this.siticoneHtmlLabel7.Size = new System.Drawing.Size(34, 17);
            this.siticoneHtmlLabel7.TabIndex = 57;
            this.siticoneHtmlLabel7.Text = "Fecha";
            // 
            // dtAsignacion
            // 
            this.dtAsignacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtAsignacion.CustomFormat = "dd/MM/yyyy";
            this.dtAsignacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAsignacion.Location = new System.Drawing.Point(491, 119);
            this.dtAsignacion.Name = "dtAsignacion";
            this.dtAsignacion.Size = new System.Drawing.Size(200, 23);
            this.dtAsignacion.TabIndex = 56;
            this.dtAsignacion.Value = new System.DateTime(2023, 3, 2, 8, 20, 0, 0);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneButton1.BorderRadius = 15;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.DarkRed;
            this.siticoneButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(331, 441);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton1.TabIndex = 55;
            this.siticoneButton1.Text = "Eliminar";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // cbSucursal
            // 
            this.cbSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSucursal.BackColor = System.Drawing.Color.Transparent;
            this.cbSucursal.BorderRadius = 15;
            this.cbSucursal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucursal.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSucursal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSucursal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSucursal.ItemHeight = 30;
            this.cbSucursal.Items.AddRange(new object[] {
            "Quito-Norte",
            "Quito-Sur"});
            this.cbSucursal.Location = new System.Drawing.Point(491, 244);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(200, 36);
            this.cbSucursal.TabIndex = 54;
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(206, 244);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(47, 17);
            this.siticoneHtmlLabel3.TabIndex = 53;
            this.siticoneHtmlLabel3.Text = "Sucursal";
            // 
            // siticoneHtmlLabel6
            // 
            this.siticoneHtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel6.Location = new System.Drawing.Point(206, 308);
            this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            this.siticoneHtmlLabel6.Size = new System.Drawing.Size(114, 24);
            this.siticoneHtmlLabel6.TabIndex = 52;
            this.siticoneHtmlLabel6.Text = "Codigo Sala";
            // 
            // tbCC
            // 
            this.tbCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCC.BorderRadius = 20;
            this.tbCC.DefaultText = "";
            this.tbCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCC.Location = new System.Drawing.Point(491, 176);
            this.tbCC.Name = "tbCC";
            this.tbCC.PasswordChar = '\0';
            this.tbCC.PlaceholderText = "";
            this.tbCC.SelectedText = "";
            this.tbCC.Size = new System.Drawing.Size(200, 36);
            this.tbCC.TabIndex = 51;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(206, 188);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(19, 17);
            this.siticoneHtmlLabel1.TabIndex = 50;
            this.siticoneHtmlLabel1.Text = "CC";
            // 
            // EditarAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 578);
            this.Controls.Add(this.tbCodigoSala);
            this.Controls.Add(this.siticoneHtmlLabel7);
            this.Controls.Add(this.dtAsignacion);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Controls.Add(this.siticoneHtmlLabel6);
            this.Controls.Add(this.tbCC);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Name = "EditarAsignacion";
            this.Text = "EditarAsignacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbCodigoSala;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
        private DateTimePicker dtAsignacion;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSucursal;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbCC;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
    }
}