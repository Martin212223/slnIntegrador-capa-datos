namespace Presentacion
{
    partial class FormPaciente
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
            this.gridFormPacnte = new System.Windows.Forms.DataGridView();
            this.btnElimPacnte = new System.Windows.Forms.Button();
            this.btnTodosPacnte = new System.Windows.Forms.Button();
            this.btnHistClinPacnte = new System.Windows.Forms.Button();
            this.btnModPacnte = new System.Windows.Forms.Button();
            this.btnRegPacnte = new System.Windows.Forms.Button();
            this.txtApellPacnte = new System.Windows.Forms.TextBox();
            this.txtDomicPacnte = new System.Windows.Forms.TextBox();
            this.txtTelPacnte = new System.Windows.Forms.TextBox();
            this.txtEmailPacnte = new System.Windows.Forms.TextBox();
            this.txtNroHistPacnte = new System.Windows.Forms.TextBox();
            this.txtIdPacnte = new System.Windows.Forms.TextBox();
            this.txtNombrePacnte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboPacientesMed = new System.Windows.Forms.ComboBox();
            this.comboPacientesHabit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormPacnte)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFormPacnte
            // 
            this.gridFormPacnte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFormPacnte.Location = new System.Drawing.Point(252, 8);
            this.gridFormPacnte.Name = "gridFormPacnte";
            this.gridFormPacnte.Size = new System.Drawing.Size(362, 220);
            this.gridFormPacnte.TabIndex = 43;
            // 
            // btnElimPacnte
            // 
            this.btnElimPacnte.Location = new System.Drawing.Point(545, 293);
            this.btnElimPacnte.Name = "btnElimPacnte";
            this.btnElimPacnte.Size = new System.Drawing.Size(84, 23);
            this.btnElimPacnte.TabIndex = 42;
            this.btnElimPacnte.Text = "Eliminar por Id";
            this.btnElimPacnte.UseVisualStyleBackColor = true;
            this.btnElimPacnte.Click += new System.EventHandler(this.btnElimPacnte_Click);
            // 
            // btnTodosPacnte
            // 
            this.btnTodosPacnte.Location = new System.Drawing.Point(423, 293);
            this.btnTodosPacnte.Name = "btnTodosPacnte";
            this.btnTodosPacnte.Size = new System.Drawing.Size(84, 23);
            this.btnTodosPacnte.TabIndex = 41;
            this.btnTodosPacnte.Text = "Ver todos";
            this.btnTodosPacnte.UseVisualStyleBackColor = true;
            this.btnTodosPacnte.Click += new System.EventHandler(this.btnTodosPacnte_Click);
            // 
            // btnHistClinPacnte
            // 
            this.btnHistClinPacnte.Location = new System.Drawing.Point(239, 293);
            this.btnHistClinPacnte.Name = "btnHistClinPacnte";
            this.btnHistClinPacnte.Size = new System.Drawing.Size(146, 23);
            this.btnHistClinPacnte.TabIndex = 40;
            this.btnHistClinPacnte.Text = "Buscar por Historia Clínica";
            this.btnHistClinPacnte.UseVisualStyleBackColor = true;
            this.btnHistClinPacnte.Click += new System.EventHandler(this.btnHistClinPacnte_Click);
            // 
            // btnModPacnte
            // 
            this.btnModPacnte.Location = new System.Drawing.Point(126, 293);
            this.btnModPacnte.Name = "btnModPacnte";
            this.btnModPacnte.Size = new System.Drawing.Size(75, 23);
            this.btnModPacnte.TabIndex = 39;
            this.btnModPacnte.Text = "Modificar";
            this.btnModPacnte.UseVisualStyleBackColor = true;
            this.btnModPacnte.Click += new System.EventHandler(this.btnModPacnte_Click);
            // 
            // btnRegPacnte
            // 
            this.btnRegPacnte.Location = new System.Drawing.Point(15, 293);
            this.btnRegPacnte.Name = "btnRegPacnte";
            this.btnRegPacnte.Size = new System.Drawing.Size(75, 23);
            this.btnRegPacnte.TabIndex = 38;
            this.btnRegPacnte.Text = "Registrar";
            this.btnRegPacnte.UseVisualStyleBackColor = true;
            this.btnRegPacnte.Click += new System.EventHandler(this.btnRegPacnte_Click);
            // 
            // txtApellPacnte
            // 
            this.txtApellPacnte.Location = new System.Drawing.Point(126, 66);
            this.txtApellPacnte.Name = "txtApellPacnte";
            this.txtApellPacnte.Size = new System.Drawing.Size(100, 20);
            this.txtApellPacnte.TabIndex = 37;
            // 
            // txtDomicPacnte
            // 
            this.txtDomicPacnte.Location = new System.Drawing.Point(126, 93);
            this.txtDomicPacnte.Name = "txtDomicPacnte";
            this.txtDomicPacnte.Size = new System.Drawing.Size(100, 20);
            this.txtDomicPacnte.TabIndex = 36;
            // 
            // txtTelPacnte
            // 
            this.txtTelPacnte.Location = new System.Drawing.Point(126, 120);
            this.txtTelPacnte.Name = "txtTelPacnte";
            this.txtTelPacnte.Size = new System.Drawing.Size(100, 20);
            this.txtTelPacnte.TabIndex = 35;
            // 
            // txtEmailPacnte
            // 
            this.txtEmailPacnte.Location = new System.Drawing.Point(126, 149);
            this.txtEmailPacnte.Name = "txtEmailPacnte";
            this.txtEmailPacnte.Size = new System.Drawing.Size(100, 20);
            this.txtEmailPacnte.TabIndex = 34;
            // 
            // txtNroHistPacnte
            // 
            this.txtNroHistPacnte.Location = new System.Drawing.Point(126, 184);
            this.txtNroHistPacnte.Name = "txtNroHistPacnte";
            this.txtNroHistPacnte.Size = new System.Drawing.Size(100, 20);
            this.txtNroHistPacnte.TabIndex = 32;
            // 
            // txtIdPacnte
            // 
            this.txtIdPacnte.Location = new System.Drawing.Point(126, 8);
            this.txtIdPacnte.Name = "txtIdPacnte";
            this.txtIdPacnte.Size = new System.Drawing.Size(100, 20);
            this.txtIdPacnte.TabIndex = 31;
            // 
            // txtNombrePacnte
            // 
            this.txtNombrePacnte.Location = new System.Drawing.Point(126, 41);
            this.txtNombrePacnte.Name = "txtNombrePacnte";
            this.txtNombrePacnte.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePacnte.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Historia Clínica Nro.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Domicilio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Médico:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Habitación:";
            // 
            // comboPacientesMed
            // 
            this.comboPacientesMed.FormattingEnabled = true;
            this.comboPacientesMed.Location = new System.Drawing.Point(120, 222);
            this.comboPacientesMed.Name = "comboPacientesMed";
            this.comboPacientesMed.Size = new System.Drawing.Size(121, 21);
            this.comboPacientesMed.TabIndex = 46;
            // 
            // comboPacientesHabit
            // 
            this.comboPacientesHabit.FormattingEnabled = true;
            this.comboPacientesHabit.Location = new System.Drawing.Point(120, 259);
            this.comboPacientesHabit.Name = "comboPacientesHabit";
            this.comboPacientesHabit.Size = new System.Drawing.Size(121, 21);
            this.comboPacientesHabit.TabIndex = 47;
            // 
            // FormPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 352);
            this.Controls.Add(this.comboPacientesHabit);
            this.Controls.Add(this.comboPacientesMed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gridFormPacnte);
            this.Controls.Add(this.btnElimPacnte);
            this.Controls.Add(this.btnTodosPacnte);
            this.Controls.Add(this.btnHistClinPacnte);
            this.Controls.Add(this.btnModPacnte);
            this.Controls.Add(this.btnRegPacnte);
            this.Controls.Add(this.txtApellPacnte);
            this.Controls.Add(this.txtDomicPacnte);
            this.Controls.Add(this.txtTelPacnte);
            this.Controls.Add(this.txtEmailPacnte);
            this.Controls.Add(this.txtNroHistPacnte);
            this.Controls.Add(this.txtIdPacnte);
            this.Controls.Add(this.txtNombrePacnte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPaciente";
            this.Text = "FormPaciente";
            this.Load += new System.EventHandler(this.FormPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFormPacnte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFormPacnte;
        private System.Windows.Forms.Button btnElimPacnte;
        private System.Windows.Forms.Button btnTodosPacnte;
        private System.Windows.Forms.Button btnHistClinPacnte;
        private System.Windows.Forms.Button btnModPacnte;
        private System.Windows.Forms.Button btnRegPacnte;
        private System.Windows.Forms.TextBox txtApellPacnte;
        private System.Windows.Forms.TextBox txtDomicPacnte;
        private System.Windows.Forms.TextBox txtTelPacnte;
        private System.Windows.Forms.TextBox txtEmailPacnte;
        private System.Windows.Forms.TextBox txtNroHistPacnte;
        private System.Windows.Forms.TextBox txtIdPacnte;
        private System.Windows.Forms.TextBox txtNombrePacnte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboPacientesMed;
        private System.Windows.Forms.ComboBox comboPacientesHabit;
    }
}