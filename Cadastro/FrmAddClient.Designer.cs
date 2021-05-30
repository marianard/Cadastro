
namespace Cadastro
{
    partial class FrmAddClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.ckHasInvestiment = new System.Windows.Forms.CheckBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdOther = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(14, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtName.Location = new System.Drawing.Point(118, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 16);
            this.txtName.TabIndex = 1;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBirthDate.Location = new System.Drawing.Point(12, 56);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(98, 15);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Data Nascimento";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMaritalStatus.Location = new System.Drawing.Point(14, 87);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(68, 15);
            this.lblMaritalStatus.TabIndex = 6;
            this.lblMaritalStatus.Text = "Estado Civil";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelephone.Location = new System.Drawing.Point(14, 118);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(51, 15);
            this.lblTelephone.TabIndex = 7;
            this.lblTelephone.Text = "Telefone";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCpf.Location = new System.Drawing.Point(14, 149);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(28, 15);
            this.lblCpf.TabIndex = 8;
            this.lblCpf.Text = "CPF";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.txtBirthDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.txtBirthDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.txtBirthDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.txtBirthDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.txtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBirthDate.Location = new System.Drawing.Point(118, 50);
            this.txtBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(100, 23);
            this.txtBirthDate.TabIndex = 10;
            // 
            // cbMaritalStatus
            // 
            this.cbMaritalStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.cbMaritalStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.cbMaritalStatus.FormattingEnabled = true;
            this.cbMaritalStatus.Location = new System.Drawing.Point(118, 87);
            this.cbMaritalStatus.Name = "cbMaritalStatus";
            this.cbMaritalStatus.Size = new System.Drawing.Size(182, 23);
            this.cbMaritalStatus.TabIndex = 11;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelephone.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTelephone.Location = new System.Drawing.Point(118, 118);
            this.txtTelephone.Mask = "(00) 00000-0000";
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(100, 16);
            this.txtTelephone.TabIndex = 12;
            // 
            // txtcpf
            // 
            this.txtcpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.txtcpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcpf.ForeColor = System.Drawing.SystemColors.Control;
            this.txtcpf.Location = new System.Drawing.Point(118, 149);
            this.txtcpf.Mask = "000,000,000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(100, 16);
            this.txtcpf.TabIndex = 13;
            // 
            // ckHasInvestiment
            // 
            this.ckHasInvestiment.AutoSize = true;
            this.ckHasInvestiment.Location = new System.Drawing.Point(21, 250);
            this.ckHasInvestiment.Name = "ckHasInvestiment";
            this.ckHasInvestiment.Size = new System.Drawing.Size(137, 19);
            this.ckHasInvestiment.TabIndex = 14;
            this.ckHasInvestiment.Text = "Possui investimento?";
            this.ckHasInvestiment.UseVisualStyleBackColor = true;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdOther);
            this.gbGender.Controls.Add(this.rdFemale);
            this.gbGender.Controls.Add(this.rdMale);
            this.gbGender.ForeColor = System.Drawing.SystemColors.Control;
            this.gbGender.Location = new System.Drawing.Point(14, 178);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(329, 66);
            this.gbGender.TabIndex = 15;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Sexo";
            // 
            // rdOther
            // 
            this.rdOther.AutoSize = true;
            this.rdOther.Location = new System.Drawing.Point(209, 22);
            this.rdOther.Name = "rdOther";
            this.rdOther.Size = new System.Drawing.Size(56, 19);
            this.rdOther.TabIndex = 2;
            this.rdOther.TabStop = true;
            this.rdOther.Text = "Outro";
            this.rdOther.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(108, 22);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(75, 19);
            this.rdFemale.TabIndex = 1;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Feminino";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(7, 23);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(80, 19);
            this.rdMale.TabIndex = 0;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Masculino";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btnAddOrUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddOrUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddOrUpdate.FlatAppearance.BorderSize = 0;
            this.btnAddOrUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnAddOrUpdate.Location = new System.Drawing.Point(14, 286);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(105, 39);
            this.btnAddOrUpdate.TabIndex = 17;
            this.btnAddOrUpdate.Text = "Cadastrar/Alterar";
            this.btnAddOrUpdate.UseVisualStyleBackColor = false;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btnDelete.Location = new System.Drawing.Point(142, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 39);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btnClean.Location = new System.Drawing.Point(736, 286);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(115, 39);
            this.btnClean.TabIndex = 19;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.dgvClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.GridColor = System.Drawing.Color.Black;
            this.dgvClient.Location = new System.Drawing.Point(12, 344);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.dgvClient.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClient.RowTemplate.Height = 25;
            this.dgvClient.Size = new System.Drawing.Size(848, 129);
            this.dgvClient.TabIndex = 20;
            this.dgvClient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseDoubleClick);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.txtId.Location = new System.Drawing.Point(466, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 21;
            this.txtId.Visible = false;
            // 
            // FrmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(894, 483);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.ckHasInvestiment);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.cbMaritalStatus);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblMaritalStatus);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.DateTimePicker txtBirthDate;
        private System.Windows.Forms.ComboBox cbMaritalStatus;
        private System.Windows.Forms.MaskedTextBox txtTelephone;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.CheckBox ckHasInvestiment;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdOther;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.TextBox txtId;
    }
}

