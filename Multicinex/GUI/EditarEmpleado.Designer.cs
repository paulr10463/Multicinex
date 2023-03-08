namespace Multicinex.GUI
{
    partial class EditarEmpleado
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
            this.cbSucursal = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.tbAnadirApellido = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tbAnadirNombre = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tbAnadirEmpleado = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
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
            this.siticoneButton1.Location = new System.Drawing.Point(202, 458);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton1.TabIndex = 38;
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
            this.cbSucursal.Location = new System.Drawing.Point(473, 305);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(200, 36);
            this.cbSucursal.TabIndex = 37;
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(208, 305);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(77, 24);
            this.siticoneHtmlLabel3.TabIndex = 36;
            this.siticoneHtmlLabel3.Text = "Sucursal";
            // 
            // siticoneHtmlLabel6
            // 
            this.siticoneHtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel6.Location = new System.Drawing.Point(208, 240);
            this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            this.siticoneHtmlLabel6.Size = new System.Drawing.Size(77, 24);
            this.siticoneHtmlLabel6.TabIndex = 34;
            this.siticoneHtmlLabel6.Text = "Apellido";
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(208, 181);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(77, 24);
            this.siticoneHtmlLabel5.TabIndex = 33;
            this.siticoneHtmlLabel5.Text = "Nombre";
            // 
            // tbAnadirApellido
            // 
            this.tbAnadirApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAnadirApellido.BorderRadius = 20;
            this.tbAnadirApellido.DefaultText = "";
            this.tbAnadirApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAnadirApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAnadirApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAnadirApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAnadirApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAnadirApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAnadirApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAnadirApellido.Location = new System.Drawing.Point(473, 242);
            this.tbAnadirApellido.Name = "tbAnadirApellido";
            this.tbAnadirApellido.PasswordChar = '\0';
            this.tbAnadirApellido.PlaceholderText = "";
            this.tbAnadirApellido.SelectedText = "";
            this.tbAnadirApellido.Size = new System.Drawing.Size(200, 36);
            this.tbAnadirApellido.TabIndex = 32;
            // 
            // tbAnadirNombre
            // 
            this.tbAnadirNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAnadirNombre.BorderRadius = 20;
            this.tbAnadirNombre.DefaultText = "";
            this.tbAnadirNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAnadirNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAnadirNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAnadirNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAnadirNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAnadirNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAnadirNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAnadirNombre.Location = new System.Drawing.Point(473, 182);
            this.tbAnadirNombre.Name = "tbAnadirNombre";
            this.tbAnadirNombre.PasswordChar = '\0';
            this.tbAnadirNombre.PlaceholderText = "";
            this.tbAnadirNombre.SelectedText = "";
            this.tbAnadirNombre.Size = new System.Drawing.Size(200, 36);
            this.tbAnadirNombre.TabIndex = 31;
            // 
            // tbAnadirEmpleado
            // 
            this.tbAnadirEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAnadirEmpleado.BorderRadius = 20;
            this.tbAnadirEmpleado.DefaultText = "";
            this.tbAnadirEmpleado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAnadirEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAnadirEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAnadirEmpleado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAnadirEmpleado.Enabled = false;
            this.tbAnadirEmpleado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAnadirEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAnadirEmpleado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAnadirEmpleado.Location = new System.Drawing.Point(473, 127);
            this.tbAnadirEmpleado.Name = "tbAnadirEmpleado";
            this.tbAnadirEmpleado.PasswordChar = '\0';
            this.tbAnadirEmpleado.PlaceholderText = "";
            this.tbAnadirEmpleado.SelectedText = "";
            this.tbAnadirEmpleado.Size = new System.Drawing.Size(200, 36);
            this.tbAnadirEmpleado.TabIndex = 27;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(208, 127);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(33, 24);
            this.siticoneHtmlLabel1.TabIndex = 26;
            this.siticoneHtmlLabel1.Text = "CC";
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
            this.siticoneButton2.Location = new System.Drawing.Point(493, 458);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton2.TabIndex = 39;
            this.siticoneButton2.Text = "Eliminar";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // EditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 575);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Controls.Add(this.siticoneHtmlLabel6);
            this.Controls.Add(this.siticoneHtmlLabel5);
            this.Controls.Add(this.tbAnadirApellido);
            this.Controls.Add(this.tbAnadirNombre);
            this.Controls.Add(this.tbAnadirEmpleado);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Name = "EditarEmpleado";
            this.Text = "EditarEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSucursal;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbAnadirApellido;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbAnadirNombre;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbAnadirEmpleado;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
    }
}