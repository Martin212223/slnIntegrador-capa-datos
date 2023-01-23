namespace Presentacion
{
    partial class formPresentacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.listClinicos = new System.Windows.Forms.ListBox();
            this.listHabitaciones = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFormMed = new System.Windows.Forms.Button();
            this.btnFormPacnte = new System.Windows.Forms.Button();
            this.btnDatHabitacion = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Médicos de la clínica:";
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Location = new System.Drawing.Point(15, 25);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.Size = new System.Drawing.Size(310, 145);
            this.gridMedicos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pacientes:";
            // 
            // gridPacientes
            // 
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Location = new System.Drawing.Point(15, 227);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.Size = new System.Drawing.Size(310, 139);
            this.gridPacientes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Médicos clínicos:";
            // 
            // listClinicos
            // 
            this.listClinicos.FormattingEnabled = true;
            this.listClinicos.Location = new System.Drawing.Point(364, 25);
            this.listClinicos.Name = "listClinicos";
            this.listClinicos.Size = new System.Drawing.Size(256, 147);
            this.listClinicos.TabIndex = 5;
            // 
            // listHabitaciones
            // 
            this.listHabitaciones.FormattingEnabled = true;
            this.listHabitaciones.Location = new System.Drawing.Point(364, 219);
            this.listHabitaciones.Name = "listHabitaciones";
            this.listHabitaciones.Size = new System.Drawing.Size(256, 147);
            this.listHabitaciones.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Habitaciones:";
            // 
            // btnFormMed
            // 
            this.btnFormMed.Location = new System.Drawing.Point(15, 176);
            this.btnFormMed.Name = "btnFormMed";
            this.btnFormMed.Size = new System.Drawing.Size(101, 23);
            this.btnFormMed.TabIndex = 8;
            this.btnFormMed.Text = "Registrar médico";
            this.btnFormMed.UseVisualStyleBackColor = true;
            this.btnFormMed.Click += new System.EventHandler(this.btnFormMed_Click);
            // 
            // btnFormPacnte
            // 
            this.btnFormPacnte.Location = new System.Drawing.Point(15, 376);
            this.btnFormPacnte.Name = "btnFormPacnte";
            this.btnFormPacnte.Size = new System.Drawing.Size(101, 23);
            this.btnFormPacnte.TabIndex = 9;
            this.btnFormPacnte.Text = "Registrar paciente";
            this.btnFormPacnte.UseVisualStyleBackColor = true;
            this.btnFormPacnte.Click += new System.EventHandler(this.btnFormPacnte_Click);
            // 
            // btnDatHabitacion
            // 
            this.btnDatHabitacion.Location = new System.Drawing.Point(364, 376);
            this.btnDatHabitacion.Name = "btnDatHabitacion";
            this.btnDatHabitacion.Size = new System.Drawing.Size(113, 23);
            this.btnDatHabitacion.TabIndex = 11;
            this.btnDatHabitacion.Text = "Datos habitaciones";
            this.btnDatHabitacion.UseVisualStyleBackColor = true;
            this.btnDatHabitacion.Click += new System.EventHandler(this.btnDatHabitacion_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(17, 417);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(106, 23);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar todo";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // formPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnDatHabitacion);
            this.Controls.Add(this.btnFormPacnte);
            this.Controls.Add(this.btnFormMed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listHabitaciones);
            this.Controls.Add(this.listClinicos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridPacientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridMedicos);
            this.Controls.Add(this.label1);
            this.Name = "formPresentacion";
            this.Text = "Windows Clínica";
            this.Load += new System.EventHandler(this.formPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listClinicos;
        private System.Windows.Forms.ListBox listHabitaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFormMed;
        private System.Windows.Forms.Button btnFormPacnte;
        private System.Windows.Forms.Button btnDatHabitacion;
        private System.Windows.Forms.Button btnActualizar;
    }
}

