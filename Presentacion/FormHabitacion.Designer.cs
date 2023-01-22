namespace Presentacion
{
    partial class FormHabitacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdHabit = new System.Windows.Forms.TextBox();
            this.txtNroHabit = new System.Windows.Forms.TextBox();
            this.comboEstHabit = new System.Windows.Forms.ComboBox();
            this.btnModHabit = new System.Windows.Forms.Button();
            this.btnRegHabit = new System.Windows.Forms.Button();
            this.gridFormHabit = new System.Windows.Forms.DataGridView();
            this.btnTodasHabit = new System.Windows.Forms.Button();
            this.btnEstHabit = new System.Windows.Forms.Button();
            this.btnEliminarHabit = new System.Windows.Forms.Button();
            this.btnIdHabit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormHabit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // txtIdHabit
            // 
            this.txtIdHabit.Location = new System.Drawing.Point(130, 30);
            this.txtIdHabit.Name = "txtIdHabit";
            this.txtIdHabit.Size = new System.Drawing.Size(100, 20);
            this.txtIdHabit.TabIndex = 3;
            // 
            // txtNroHabit
            // 
            this.txtNroHabit.Location = new System.Drawing.Point(130, 101);
            this.txtNroHabit.Name = "txtNroHabit";
            this.txtNroHabit.Size = new System.Drawing.Size(100, 20);
            this.txtNroHabit.TabIndex = 4;
            // 
            // comboEstHabit
            // 
            this.comboEstHabit.FormattingEnabled = true;
            this.comboEstHabit.Location = new System.Drawing.Point(126, 175);
            this.comboEstHabit.Name = "comboEstHabit";
            this.comboEstHabit.Size = new System.Drawing.Size(121, 21);
            this.comboEstHabit.TabIndex = 5;
            // 
            // btnModHabit
            // 
            this.btnModHabit.Location = new System.Drawing.Point(155, 257);
            this.btnModHabit.Name = "btnModHabit";
            this.btnModHabit.Size = new System.Drawing.Size(75, 23);
            this.btnModHabit.TabIndex = 19;
            this.btnModHabit.Text = "Modificar";
            this.btnModHabit.UseVisualStyleBackColor = true;
            this.btnModHabit.Click += new System.EventHandler(this.btnModHabit_Click);
            // 
            // btnRegHabit
            // 
            this.btnRegHabit.Location = new System.Drawing.Point(53, 257);
            this.btnRegHabit.Name = "btnRegHabit";
            this.btnRegHabit.Size = new System.Drawing.Size(75, 23);
            this.btnRegHabit.TabIndex = 18;
            this.btnRegHabit.Text = "Registrar";
            this.btnRegHabit.UseVisualStyleBackColor = true;
            this.btnRegHabit.Click += new System.EventHandler(this.btnRegHabit_Click);
            // 
            // gridFormHabit
            // 
            this.gridFormHabit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFormHabit.Location = new System.Drawing.Point(369, 46);
            this.gridFormHabit.Name = "gridFormHabit";
            this.gridFormHabit.Size = new System.Drawing.Size(240, 150);
            this.gridFormHabit.TabIndex = 20;
            // 
            // btnTodasHabit
            // 
            this.btnTodasHabit.Location = new System.Drawing.Point(269, 257);
            this.btnTodasHabit.Name = "btnTodasHabit";
            this.btnTodasHabit.Size = new System.Drawing.Size(75, 23);
            this.btnTodasHabit.TabIndex = 21;
            this.btnTodasHabit.Text = "Ver todos";
            this.btnTodasHabit.UseVisualStyleBackColor = true;
            this.btnTodasHabit.Click += new System.EventHandler(this.btnTodasHabit_Click);
            // 
            // btnEstHabit
            // 
            this.btnEstHabit.Location = new System.Drawing.Point(369, 257);
            this.btnEstHabit.Name = "btnEstHabit";
            this.btnEstHabit.Size = new System.Drawing.Size(93, 23);
            this.btnEstHabit.TabIndex = 22;
            this.btnEstHabit.Text = "Ver por estado";
            this.btnEstHabit.UseVisualStyleBackColor = true;
            this.btnEstHabit.Click += new System.EventHandler(this.btnEstHabit_Click);
            // 
            // btnEliminarHabit
            // 
            this.btnEliminarHabit.Location = new System.Drawing.Point(624, 257);
            this.btnEliminarHabit.Name = "btnEliminarHabit";
            this.btnEliminarHabit.Size = new System.Drawing.Size(84, 23);
            this.btnEliminarHabit.TabIndex = 24;
            this.btnEliminarHabit.Text = "Eliminar por Id";
            this.btnEliminarHabit.UseVisualStyleBackColor = true;
            this.btnEliminarHabit.Click += new System.EventHandler(this.btnEliminarHabit_Click);
            // 
            // btnIdHabit
            // 
            this.btnIdHabit.Location = new System.Drawing.Point(487, 257);
            this.btnIdHabit.Name = "btnIdHabit";
            this.btnIdHabit.Size = new System.Drawing.Size(84, 23);
            this.btnIdHabit.TabIndex = 23;
            this.btnIdHabit.Text = "Buscar por nro";
            this.btnIdHabit.UseVisualStyleBackColor = true;
            this.btnIdHabit.Click += new System.EventHandler(this.btnIdHabit_Click);
            // 
            // FormHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 333);
            this.Controls.Add(this.btnEliminarHabit);
            this.Controls.Add(this.btnIdHabit);
            this.Controls.Add(this.btnEstHabit);
            this.Controls.Add(this.btnTodasHabit);
            this.Controls.Add(this.gridFormHabit);
            this.Controls.Add(this.btnModHabit);
            this.Controls.Add(this.btnRegHabit);
            this.Controls.Add(this.comboEstHabit);
            this.Controls.Add(this.txtNroHabit);
            this.Controls.Add(this.txtIdHabit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHabitacion";
            this.Text = "FormHabitacion";
            this.Load += new System.EventHandler(this.FormHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFormHabit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdHabit;
        private System.Windows.Forms.TextBox txtNroHabit;
        private System.Windows.Forms.ComboBox comboEstHabit;
        private System.Windows.Forms.Button btnModHabit;
        private System.Windows.Forms.Button btnRegHabit;
        private System.Windows.Forms.DataGridView gridFormHabit;
        private System.Windows.Forms.Button btnTodasHabit;
        private System.Windows.Forms.Button btnEstHabit;
        private System.Windows.Forms.Button btnEliminarHabit;
        private System.Windows.Forms.Button btnIdHabit;
    }
}