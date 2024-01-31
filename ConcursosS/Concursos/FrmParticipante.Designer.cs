namespace Concursos
{
    partial class FrmParticipante
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
            this.GlgPersonalData = new System.Windows.Forms.GroupBox();
            this.TxtName = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtSurName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.GlpContactData = new System.Windows.Forms.GroupBox();
            this.TxtPersonalEmail = new System.Windows.Forms.Label();
            this.TxtInstitutionalEmail = new System.Windows.Forms.Label();
            this.TxtPhoneNumber = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.GlgSchoolData = new System.Windows.Forms.GroupBox();
            this.LblDateOfAdmission = new System.Windows.Forms.Label();
            this.LblSemester = new System.Windows.Forms.Label();
            this.LblCareer = new System.Windows.Forms.Label();
            this.DtpAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.CbCarrer = new System.Windows.Forms.ComboBox();
            this.NmrSemester = new System.Windows.Forms.NumericUpDown();
            this.GlgPersonalData.SuspendLayout();
            this.GlpContactData.SuspendLayout();
            this.GlgSchoolData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrSemester)).BeginInit();
            this.SuspendLayout();
            // 
            // GlgPersonalData
            // 
            this.GlgPersonalData.Controls.Add(this.textBox3);
            this.GlgPersonalData.Controls.Add(this.TxtSurName);
            this.GlgPersonalData.Controls.Add(this.textBox2);
            this.GlgPersonalData.Controls.Add(this.TbName);
            this.GlgPersonalData.Controls.Add(this.TxtLastName);
            this.GlgPersonalData.Controls.Add(this.TxtName);
            this.GlgPersonalData.Location = new System.Drawing.Point(12, 12);
            this.GlgPersonalData.Name = "GlgPersonalData";
            this.GlgPersonalData.Size = new System.Drawing.Size(312, 100);
            this.GlgPersonalData.TabIndex = 0;
            this.GlgPersonalData.TabStop = false;
            this.GlgPersonalData.Text = "Datos Personales";
            // 
            // TxtName
            // 
            this.TxtName.AutoSize = true;
            this.TxtName.Location = new System.Drawing.Point(6, 25);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(44, 13);
            this.TxtName.TabIndex = 2;
            this.TxtName.Text = "Nombre";
            this.TxtName.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtLastName
            // 
            this.TxtLastName.AutoSize = true;
            this.TxtLastName.Location = new System.Drawing.Point(6, 48);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(84, 13);
            this.TxtLastName.TabIndex = 3;
            this.TxtLastName.Text = "Apellido Paterno";
            this.TxtLastName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(96, 22);
            this.TbName.MaxLength = 15;
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(173, 20);
            this.TbName.TabIndex = 4;
            this.TbName.TextChanged += new System.EventHandler(this.TbName_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 45);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtSurName
            // 
            this.TxtSurName.AutoSize = true;
            this.TxtSurName.Location = new System.Drawing.Point(6, 73);
            this.TxtSurName.Name = "TxtSurName";
            this.TxtSurName.Size = new System.Drawing.Size(86, 13);
            this.TxtSurName.TabIndex = 6;
            this.TxtSurName.Text = "Apellido Materno";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(98, 70);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 20);
            this.textBox3.TabIndex = 7;
            // 
            // GlpContactData
            // 
            this.GlpContactData.Controls.Add(this.textBox6);
            this.GlpContactData.Controls.Add(this.textBox5);
            this.GlpContactData.Controls.Add(this.textBox4);
            this.GlpContactData.Controls.Add(this.TxtPhoneNumber);
            this.GlpContactData.Controls.Add(this.TxtInstitutionalEmail);
            this.GlpContactData.Controls.Add(this.TxtPersonalEmail);
            this.GlpContactData.Location = new System.Drawing.Point(12, 118);
            this.GlpContactData.Name = "GlpContactData";
            this.GlpContactData.Size = new System.Drawing.Size(312, 100);
            this.GlpContactData.TabIndex = 1;
            this.GlpContactData.TabStop = false;
            this.GlpContactData.Text = "Datos de Contacto";
            this.GlpContactData.Enter += new System.EventHandler(this.GlpContactData_Enter);
            // 
            // TxtPersonalEmail
            // 
            this.TxtPersonalEmail.AutoSize = true;
            this.TxtPersonalEmail.Location = new System.Drawing.Point(6, 25);
            this.TxtPersonalEmail.Name = "TxtPersonalEmail";
            this.TxtPersonalEmail.Size = new System.Drawing.Size(76, 13);
            this.TxtPersonalEmail.TabIndex = 3;
            this.TxtPersonalEmail.Text = "Email Personal";
            // 
            // TxtInstitutionalEmail
            // 
            this.TxtInstitutionalEmail.AutoSize = true;
            this.TxtInstitutionalEmail.Location = new System.Drawing.Point(6, 48);
            this.TxtInstitutionalEmail.Name = "TxtInstitutionalEmail";
            this.TxtInstitutionalEmail.Size = new System.Drawing.Size(91, 13);
            this.TxtInstitutionalEmail.TabIndex = 4;
            this.TxtInstitutionalEmail.Text = "Email Institucional";
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.AutoSize = true;
            this.TxtPhoneNumber.Location = new System.Drawing.Point(6, 70);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(104, 13);
            this.TxtPhoneNumber.TabIndex = 7;
            this.TxtPhoneNumber.Text = "Numero de Telefono";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 25);
            this.textBox4.MaxLength = 150;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 45);
            this.textBox5.MaxLength = 150;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(116, 67);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(153, 20);
            this.textBox6.TabIndex = 10;
            // 
            // GlgSchoolData
            // 
            this.GlgSchoolData.Controls.Add(this.NmrSemester);
            this.GlgSchoolData.Controls.Add(this.CbCarrer);
            this.GlgSchoolData.Controls.Add(this.DtpAdmissionDate);
            this.GlgSchoolData.Controls.Add(this.LblDateOfAdmission);
            this.GlgSchoolData.Controls.Add(this.LblSemester);
            this.GlgSchoolData.Controls.Add(this.LblCareer);
            this.GlgSchoolData.Location = new System.Drawing.Point(12, 224);
            this.GlgSchoolData.Name = "GlgSchoolData";
            this.GlgSchoolData.Size = new System.Drawing.Size(312, 100);
            this.GlgSchoolData.TabIndex = 2;
            this.GlgSchoolData.TabStop = false;
            this.GlgSchoolData.Text = "Datos Escolares";
            // 
            // LblDateOfAdmission
            // 
            this.LblDateOfAdmission.AutoSize = true;
            this.LblDateOfAdmission.Location = new System.Drawing.Point(6, 77);
            this.LblDateOfAdmission.Name = "LblDateOfAdmission";
            this.LblDateOfAdmission.Size = new System.Drawing.Size(89, 13);
            this.LblDateOfAdmission.TabIndex = 7;
            this.LblDateOfAdmission.Text = "Fecha de ingreso";
            // 
            // LblSemester
            // 
            this.LblSemester.AutoSize = true;
            this.LblSemester.Location = new System.Drawing.Point(6, 48);
            this.LblSemester.Name = "LblSemester";
            this.LblSemester.Size = new System.Drawing.Size(51, 13);
            this.LblSemester.TabIndex = 4;
            this.LblSemester.Text = "Semestre";
            // 
            // LblCareer
            // 
            this.LblCareer.AutoSize = true;
            this.LblCareer.Location = new System.Drawing.Point(6, 25);
            this.LblCareer.Name = "LblCareer";
            this.LblCareer.Size = new System.Drawing.Size(41, 13);
            this.LblCareer.TabIndex = 3;
            this.LblCareer.Text = "Carrera";
            // 
            // DtpAdmissionDate
            // 
            this.DtpAdmissionDate.Location = new System.Drawing.Point(100, 74);
            this.DtpAdmissionDate.Name = "DtpAdmissionDate";
            this.DtpAdmissionDate.Size = new System.Drawing.Size(200, 20);
            this.DtpAdmissionDate.TabIndex = 3;
            // 
            // CbCarrer
            // 
            this.CbCarrer.FormattingEnabled = true;
            this.CbCarrer.Items.AddRange(new object[] {
            "Ingeniería en Software",
            "Ingeniería en Seguridad Informática y Redes",
            "Ingeniería en Industrial y Rentabilidad de Negocios",
            "Ingeniería en Mecatrónica",
            "Ingeniería en Diseño Industrial",
            "Diseño y Negocios de la Moda",
            "Diseño Digital",
            "Lenguas Extranjeras",
            "Arquitectura e Interiorismo",
            "Administración e Innovación de Negocios",
            "Comercio Exterior y Derecho Aduanero",
            "Negocios Turísticos",
            "Mercadotecnia",
            "Finanzas, Banca e Inversiones Estratégicas",
            "Imagen y Relaciones Públicas",
            "Comunicación y Multimedia",
            "Derecho"});
            this.CbCarrer.Location = new System.Drawing.Point(100, 22);
            this.CbCarrer.Name = "CbCarrer";
            this.CbCarrer.Size = new System.Drawing.Size(200, 21);
            this.CbCarrer.TabIndex = 11;
            // 
            // NmrSemester
            // 
            this.NmrSemester.Location = new System.Drawing.Point(100, 49);
            this.NmrSemester.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NmrSemester.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmrSemester.Name = "NmrSemester";
            this.NmrSemester.Size = new System.Drawing.Size(120, 20);
            this.NmrSemester.TabIndex = 11;
            this.NmrSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmrSemester.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // FrmParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.GlgSchoolData);
            this.Controls.Add(this.GlpContactData);
            this.Controls.Add(this.GlgPersonalData);
            this.Name = "FrmParticipante";
            this.Text = "FrmParticipante";
            this.Load += new System.EventHandler(this.FrmParticipante_Load);
            this.GlgPersonalData.ResumeLayout(false);
            this.GlgPersonalData.PerformLayout();
            this.GlpContactData.ResumeLayout(false);
            this.GlpContactData.PerformLayout();
            this.GlgSchoolData.ResumeLayout(false);
            this.GlgSchoolData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrSemester)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GlgPersonalData;
        private System.Windows.Forms.Label TxtName;
        private System.Windows.Forms.Label TxtLastName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label TxtSurName;
        private System.Windows.Forms.GroupBox GlpContactData;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label TxtPhoneNumber;
        private System.Windows.Forms.Label TxtInstitutionalEmail;
        private System.Windows.Forms.Label TxtPersonalEmail;
        private System.Windows.Forms.GroupBox GlgSchoolData;
        private System.Windows.Forms.Label LblDateOfAdmission;
        private System.Windows.Forms.Label LblSemester;
        private System.Windows.Forms.Label LblCareer;
        private System.Windows.Forms.DateTimePicker DtpAdmissionDate;
        private System.Windows.Forms.ComboBox CbCarrer;
        private System.Windows.Forms.NumericUpDown NmrSemester;
    }
}