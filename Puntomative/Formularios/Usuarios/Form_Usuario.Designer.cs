namespace Puntomative.Formularios.Usuarios
{
    partial class Form_Usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nickname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chk_administrador = new System.Windows.Forms.CheckBox();
            this.btn_AgregarEditar = new System.Windows.Forms.Button();
            this.lbl_IdUsuario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_IdUsuario);
            this.groupBox1.Controls.Add(this.btn_AgregarEditar);
            this.groupBox1.Controls.Add(this.chk_administrador);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Nickname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 390);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear/Editar";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(7, 51);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(268, 23);
            this.txt_Nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // txt_Nickname
            // 
            this.txt_Nickname.Location = new System.Drawing.Point(7, 109);
            this.txt_Nickname.Name = "txt_Nickname";
            this.txt_Nickname.Size = new System.Drawing.Size(268, 23);
            this.txt_Nickname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 23);
            this.textBox1.TabIndex = 5;
            // 
            // chk_administrador
            // 
            this.chk_administrador.AutoSize = true;
            this.chk_administrador.Location = new System.Drawing.Point(12, 212);
            this.chk_administrador.Name = "chk_administrador";
            this.chk_administrador.Size = new System.Drawing.Size(102, 19);
            this.chk_administrador.TabIndex = 7;
            this.chk_administrador.Text = "Administrador";
            this.chk_administrador.UseVisualStyleBackColor = true;
            // 
            // btn_AgregarEditar
            // 
            this.btn_AgregarEditar.Location = new System.Drawing.Point(17, 249);
            this.btn_AgregarEditar.Name = "btn_AgregarEditar";
            this.btn_AgregarEditar.Size = new System.Drawing.Size(114, 29);
            this.btn_AgregarEditar.TabIndex = 8;
            this.btn_AgregarEditar.Text = "Agregar";
            this.btn_AgregarEditar.UseVisualStyleBackColor = true;
            // 
            // lbl_IdUsuario
            // 
            this.lbl_IdUsuario.AutoSize = true;
            this.lbl_IdUsuario.Location = new System.Drawing.Point(110, 19);
            this.lbl_IdUsuario.Name = "lbl_IdUsuario";
            this.lbl_IdUsuario.Size = new System.Drawing.Size(38, 15);
            this.lbl_IdUsuario.TabIndex = 9;
            this.lbl_IdUsuario.Text = "label4";
            // 
            // Form_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Form_Usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_IdUsuario;
        private System.Windows.Forms.Button btn_AgregarEditar;
        private System.Windows.Forms.CheckBox chk_administrador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre;
    }
}