namespace Multicinex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pelicula1 = new Multicinex.GUI.Pelicula();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.funcion1 = new Multicinex.GUI.Funcion();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sala1 = new Multicinex.GUI.Sala();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.sala2 = new Multicinex.GUI.Sala();
            this.siticoneTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneTabControl1
            // 
            this.siticoneTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.siticoneTabControl1.Controls.Add(this.tabPage1);
            this.siticoneTabControl1.Controls.Add(this.tabPage2);
            this.siticoneTabControl1.Controls.Add(this.tabPage3);
            this.siticoneTabControl1.Controls.Add(this.tabPage4);
            this.siticoneTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneTabControl1.Name = "siticoneTabControl1";
            this.siticoneTabControl1.SelectedIndex = 0;
            this.siticoneTabControl1.Size = new System.Drawing.Size(1370, 734);
            this.siticoneTabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.siticoneTabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.siticoneTabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.siticoneTabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.TabIndex = 0;
            this.siticoneTabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pelicula1);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1182, 726);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pelicula";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pelicula1
            // 
            this.pelicula1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pelicula1.Location = new System.Drawing.Point(3, 3);
            this.pelicula1.Name = "pelicula1";
            this.pelicula1.Size = new System.Drawing.Size(1176, 720);
            this.pelicula1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.funcion1);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1182, 726);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Funcion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // funcion1
            // 
            this.funcion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funcion1.Location = new System.Drawing.Point(3, 3);
            this.funcion1.Name = "funcion1";
            this.funcion1.Size = new System.Drawing.Size(1176, 720);
            this.funcion1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.sala1);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1182, 726);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sala";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // sala1
            // 
            this.sala1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sala1.Location = new System.Drawing.Point(0, 0);
            this.sala1.Name = "sala1";
            this.sala1.Size = new System.Drawing.Size(1182, 726);
            this.sala1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.sala2);
            this.tabPage4.Location = new System.Drawing.Point(184, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1182, 726);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Empleado";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // sala2
            // 
            this.sala2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sala2.Location = new System.Drawing.Point(0, 0);
            this.sala2.Name = "sala2";
            this.sala2.Size = new System.Drawing.Size(1182, 726);
            this.sala2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 734);
            this.Controls.Add(this.siticoneTabControl1);
            this.Name = "Form1";
            this.Text = "Multicinex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.siticoneTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GUI.Pelicula pelicula1;
        private GUI.Funcion funcion1;
        private GUI.Sala sala1;
        private GUI.Sala sala2;
    }
}