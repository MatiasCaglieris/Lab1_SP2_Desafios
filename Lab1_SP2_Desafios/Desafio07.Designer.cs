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
            this.optMixta = new System.Windows.Forms.RadioButton();
            this.optVirtual = new System.Windows.Forms.RadioButton();
            this.optPresencial = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
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
            // optMixta
            // 
            this.optMixta.AutoSize = true;
            this.optMixta.Location = new System.Drawing.Point(240, 120);
            this.optMixta.Name = "optMixta";
            this.optMixta.Size = new System.Drawing.Size(50, 17);
            this.optMixta.TabIndex = 7;
            this.optMixta.Text = "Mixta";
            this.optMixta.UseVisualStyleBackColor = true;
            // 
            // optVirtual
            // 
            this.optVirtual.AutoSize = true;
            this.optVirtual.Location = new System.Drawing.Point(240, 90);
            this.optVirtual.Name = "optVirtual";
            this.optVirtual.Size = new System.Drawing.Size(54, 17);
            this.optVirtual.TabIndex = 6;
            this.optVirtual.Text = "Virtual";
            this.optVirtual.UseVisualStyleBackColor = true;
            // 
            // optPresencial
            // 
            this.optPresencial.AutoSize = true;
            this.optPresencial.Location = new System.Drawing.Point(240, 60);
            this.optPresencial.Name = "optPresencial";
            this.optPresencial.Size = new System.Drawing.Size(74, 17);
            this.optPresencial.TabIndex = 5;
            this.optPresencial.Text = "Presencial";
            this.optPresencial.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(68, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "Manana";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(68, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Tarde";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(68, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "Noche";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Desafio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 250);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblModalidad);
            this.Controls.Add(this.optPresencial);
            this.Controls.Add(this.optVirtual);
            this.Controls.Add(this.optMixta);
            this.Controls.Add(this.cmdConfirmar);
            this.Controls.Add(this.lblSeleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Desafio07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desafio 07 - Botones de opcion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.RadioButton optMixta;
        private System.Windows.Forms.RadioButton optVirtual;
        private System.Windows.Forms.RadioButton optPresencial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}
