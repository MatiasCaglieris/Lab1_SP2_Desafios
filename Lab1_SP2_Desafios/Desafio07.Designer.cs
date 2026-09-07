namespace Lab1_SP2_Desafios
{
    partial class Desafio07
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Button cmdConfirmar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.gpbturno = new System.Windows.Forms.GroupBox();
            this.optManana = new System.Windows.Forms.RadioButton();
            this.optTarde = new System.Windows.Forms.RadioButton();
            this.optNoche = new System.Windows.Forms.RadioButton();
            this.gpbasistencia = new System.Windows.Forms.GroupBox();
            this.optPresencial = new System.Windows.Forms.RadioButton();
            this.optVirtual = new System.Windows.Forms.RadioButton();
            this.optMixta = new System.Windows.Forms.RadioButton();
            this.gpbturno.SuspendLayout();
            this.gpbasistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTurno.Location = new System.Drawing.Point(25, 30);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(39, 15);
            this.lblTurno.TabIndex = 0;
            this.lblTurno.Text = "Turno";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModalidad.Location = new System.Drawing.Point(225, 30);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(64, 15);
            this.lblModalidad.TabIndex = 1;
            this.lblModalidad.Text = "Modalidad";
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.Location = new System.Drawing.Point(40, 205);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(390, 25);
            this.lblSeleccion.TabIndex = 9;
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Location = new System.Drawing.Point(40, 160);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(110, 30);
            this.cmdConfirmar.TabIndex = 8;
            this.cmdConfirmar.Text = "Confirmar";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // gpbturno
            // 
            this.gpbturno.Controls.Add(this.optManana);
            this.gpbturno.Controls.Add(this.optTarde);
            this.gpbturno.Controls.Add(this.optNoche);
            this.gpbturno.Location = new System.Drawing.Point(12, 54);
            this.gpbturno.Name = "gpbturno";
            this.gpbturno.Size = new System.Drawing.Size(200, 100);
            this.gpbturno.TabIndex = 10;
            this.gpbturno.TabStop = false;
            // 
            // optManana
            // 
            this.optManana.AutoSize = true;
            this.optManana.Location = new System.Drawing.Point(68, 19);
            this.optManana.Name = "optManana";
            this.optManana.Size = new System.Drawing.Size(64, 17);
            this.optManana.TabIndex = 5;
            this.optManana.Text = "Manana";
            this.optManana.UseVisualStyleBackColor = true;
            this.optManana.CheckedChanged += new System.EventHandler(this.optmana_CheckedChanged);
            // 
            // optTarde
            // 
            this.optTarde.AutoSize = true;
            this.optTarde.Location = new System.Drawing.Point(68, 42);
            this.optTarde.Name = "optTarde";
            this.optTarde.Size = new System.Drawing.Size(53, 17);
            this.optTarde.TabIndex = 6;
            this.optTarde.Text = "Tarde";
            this.optTarde.UseVisualStyleBackColor = true;
            this.optTarde.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // optNoche
            // 
            this.optNoche.AutoSize = true;
            this.optNoche.Location = new System.Drawing.Point(68, 72);
            this.optNoche.Name = "optNoche";
            this.optNoche.Size = new System.Drawing.Size(57, 17);
            this.optNoche.TabIndex = 7;
            this.optNoche.Text = "Noche";
            this.optNoche.UseVisualStyleBackColor = true;
            this.optNoche.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // gpbasistencia
            // 
            this.gpbasistencia.Controls.Add(this.optPresencial);
            this.gpbasistencia.Controls.Add(this.optVirtual);
            this.gpbasistencia.Controls.Add(this.optMixta);
            this.gpbasistencia.Location = new System.Drawing.Point(248, 54);
            this.gpbasistencia.Name = "gpbasistencia";
            this.gpbasistencia.Size = new System.Drawing.Size(200, 100);
            this.gpbasistencia.TabIndex = 11;
            this.gpbasistencia.TabStop = false;
            this.gpbasistencia.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // optPresencial
            // 
            this.optPresencial.AutoSize = true;
            this.optPresencial.Location = new System.Drawing.Point(63, 12);
            this.optPresencial.Name = "optPresencial";
            this.optPresencial.Size = new System.Drawing.Size(74, 17);
            this.optPresencial.TabIndex = 8;
            this.optPresencial.Text = "Presencial";
            this.optPresencial.UseVisualStyleBackColor = true;
            this.optPresencial.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // optVirtual
            // 
            this.optVirtual.AutoSize = true;
            this.optVirtual.Location = new System.Drawing.Point(63, 42);
            this.optVirtual.Name = "optVirtual";
            this.optVirtual.Size = new System.Drawing.Size(54, 17);
            this.optVirtual.TabIndex = 9;
            this.optVirtual.Text = "Virtual";
            this.optVirtual.UseVisualStyleBackColor = true;
            // 
            // optMixta
            // 
            this.optMixta.AutoSize = true;
            this.optMixta.Location = new System.Drawing.Point(63, 72);
            this.optMixta.Name = "optMixta";
            this.optMixta.Size = new System.Drawing.Size(50, 17);
            this.optMixta.TabIndex = 10;
            this.optMixta.Text = "Mixta";
            this.optMixta.UseVisualStyleBackColor = true;
            // 
            // Desafio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 250);
            this.Controls.Add(this.gpbasistencia);
            this.Controls.Add(this.gpbturno);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblModalidad);
            this.Controls.Add(this.cmdConfirmar);
            this.Controls.Add(this.lblSeleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Desafio07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desafio 07 - Botones de opcion";
            this.gpbturno.ResumeLayout(false);
            this.gpbturno.PerformLayout();
            this.gpbasistencia.ResumeLayout(false);
            this.gpbasistencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.GroupBox gpbturno;
        private System.Windows.Forms.RadioButton optManana;
        private System.Windows.Forms.RadioButton optTarde;
        private System.Windows.Forms.RadioButton optNoche;
        private System.Windows.Forms.GroupBox gpbasistencia;
        private System.Windows.Forms.RadioButton optPresencial;
        private System.Windows.Forms.RadioButton optVirtual;
        private System.Windows.Forms.RadioButton optMixta;
    }
}
