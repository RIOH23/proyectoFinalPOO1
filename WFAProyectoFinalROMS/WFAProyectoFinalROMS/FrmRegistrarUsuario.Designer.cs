
namespace WFAProyectoFinalROMS
{
    partial class FrmRegistrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarUsuario));
            this.grpRegistrarUsuario = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApelidos = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpRegistrarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegistrarUsuario
            // 
            this.grpRegistrarUsuario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grpRegistrarUsuario.Controls.Add(this.comboBox1);
            this.grpRegistrarUsuario.Controls.Add(this.btnConfirmar);
            this.grpRegistrarUsuario.Controls.Add(this.textBox1);
            this.grpRegistrarUsuario.Controls.Add(this.lblConfirmarContraseña);
            this.grpRegistrarUsuario.Controls.Add(this.txtApellidos);
            this.grpRegistrarUsuario.Controls.Add(this.lblApelidos);
            this.grpRegistrarUsuario.Controls.Add(this.txtContraseña);
            this.grpRegistrarUsuario.Controls.Add(this.lblContraseña);
            this.grpRegistrarUsuario.Controls.Add(this.txtCorreoElectronico);
            this.grpRegistrarUsuario.Controls.Add(this.lblCorreoElectronico);
            this.grpRegistrarUsuario.Controls.Add(this.txtNombre);
            this.grpRegistrarUsuario.Controls.Add(this.lblNombre);
            this.grpRegistrarUsuario.Location = new System.Drawing.Point(227, 64);
            this.grpRegistrarUsuario.Name = "grpRegistrarUsuario";
            this.grpRegistrarUsuario.Size = new System.Drawing.Size(573, 449);
            this.grpRegistrarUsuario.TabIndex = 0;
            this.grpRegistrarUsuario.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "@gmail.com",
            "@un.edu.mx",
            "@outlook.com",
            "@yahoo.com.mx",
            "@yahoo.com"});
            this.comboBox1.Location = new System.Drawing.Point(353, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 36);
            this.comboBox1.TabIndex = 11;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnConfirmar.Location = new System.Drawing.Point(190, 371);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(160, 40);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 34);
            this.textBox1.TabIndex = 9;
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(17, 294);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(228, 28);
            this.lblConfirmarContraseña.TabIndex = 8;
            this.lblConfirmarContraseña.Text = "Confirme su contraseña";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(21, 122);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(496, 34);
            this.txtApellidos.TabIndex = 7;
            // 
            // lblApelidos
            // 
            this.lblApelidos.AutoSize = true;
            this.lblApelidos.Location = new System.Drawing.Point(17, 97);
            this.lblApelidos.Name = "lblApelidos";
            this.lblApelidos.Size = new System.Drawing.Size(96, 28);
            this.lblApelidos.TabIndex = 6;
            this.lblApelidos.Text = "Apellidos";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(21, 252);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(496, 34);
            this.txtContraseña.TabIndex = 5;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(17, 228);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(114, 28);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(21, 186);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(310, 34);
            this.txtCorreoElectronico.TabIndex = 3;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(17, 162);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(178, 28);
            this.lblCorreoElectronico.TabIndex = 2;
            this.lblCorreoElectronico.Text = "Correo Electronico";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(496, 34);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(110, 28);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre(s)";
            // 
            // FrmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 590);
            this.Controls.Add(this.grpRegistrarUsuario);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistrarUsuario";
            this.Text = "FrmRegistrarUsuario";
            this.grpRegistrarUsuario.ResumeLayout(false);
            this.grpRegistrarUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegistrarUsuario;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApelidos;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}