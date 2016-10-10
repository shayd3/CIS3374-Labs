namespace Lab3
{
    partial class frmEdit
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlphaEdit = new System.Windows.Forms.TextBox();
            this.comboVariationEdit = new System.Windows.Forms.ComboBox();
            this.txtNoteEdit = new System.Windows.Forms.TextBox();
            this.txtPictureEdit = new System.Windows.Forms.TextBox();
            this.comboConditionEdit = new System.Windows.Forms.ComboBox();
            this.txtPriceEdit = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSeriesEdit = new System.Windows.Forms.TextBox();
            this.errorEdit = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Price Paid:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Condition:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Picture URL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Note:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Variation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Alpha Model Letter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Series Identifier (1-75):";
            // 
            // txtAlphaEdit
            // 
            this.txtAlphaEdit.Location = new System.Drawing.Point(128, 40);
            this.txtAlphaEdit.Name = "txtAlphaEdit";
            this.txtAlphaEdit.Size = new System.Drawing.Size(172, 20);
            this.txtAlphaEdit.TabIndex = 1;
            // 
            // comboVariationEdit
            // 
            this.comboVariationEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVariationEdit.FormattingEnabled = true;
            this.comboVariationEdit.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Red",
            "White",
            "Black",
            "Yellow",
            "Brown",
            "Silver",
            "Orange",
            "Indigo",
            "Violet"});
            this.comboVariationEdit.Location = new System.Drawing.Point(128, 65);
            this.comboVariationEdit.Name = "comboVariationEdit";
            this.comboVariationEdit.Size = new System.Drawing.Size(172, 21);
            this.comboVariationEdit.TabIndex = 2;
            // 
            // txtNoteEdit
            // 
            this.txtNoteEdit.Location = new System.Drawing.Point(128, 117);
            this.txtNoteEdit.Multiline = true;
            this.txtNoteEdit.Name = "txtNoteEdit";
            this.txtNoteEdit.Size = new System.Drawing.Size(172, 54);
            this.txtNoteEdit.TabIndex = 4;
            // 
            // txtPictureEdit
            // 
            this.txtPictureEdit.Location = new System.Drawing.Point(128, 91);
            this.txtPictureEdit.Name = "txtPictureEdit";
            this.txtPictureEdit.Size = new System.Drawing.Size(172, 20);
            this.txtPictureEdit.TabIndex = 3;
            // 
            // comboConditionEdit
            // 
            this.comboConditionEdit.AutoCompleteCustomSource.AddRange(new string[] {
            "Poor",
            "Fair",
            "Good",
            "Minor Damage",
            "Perfect"});
            this.comboConditionEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboConditionEdit.FormattingEnabled = true;
            this.comboConditionEdit.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Good",
            "Minor Damage",
            "Perfect"});
            this.comboConditionEdit.Location = new System.Drawing.Point(128, 177);
            this.comboConditionEdit.Name = "comboConditionEdit";
            this.comboConditionEdit.Size = new System.Drawing.Size(172, 21);
            this.comboConditionEdit.TabIndex = 5;
            // 
            // txtPriceEdit
            // 
            this.txtPriceEdit.Location = new System.Drawing.Point(128, 204);
            this.txtPriceEdit.Name = "txtPriceEdit";
            this.txtPriceEdit.Size = new System.Drawing.Size(172, 20);
            this.txtPriceEdit.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(224, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(143, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSeriesEdit
            // 
            this.txtSeriesEdit.Location = new System.Drawing.Point(127, 13);
            this.txtSeriesEdit.Name = "txtSeriesEdit";
            this.txtSeriesEdit.Size = new System.Drawing.Size(172, 20);
            this.txtSeriesEdit.TabIndex = 0;
            // 
            // errorEdit
            // 
            this.errorEdit.ContainerControl = this;
            // 
            // frmEdit
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(312, 286);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboConditionEdit);
            this.Controls.Add(this.comboVariationEdit);
            this.Controls.Add(this.txtNoteEdit);
            this.Controls.Add(this.txtPriceEdit);
            this.Controls.Add(this.txtPictureEdit);
            this.Controls.Add(this.txtSeriesEdit);
            this.Controls.Add(this.txtAlphaEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEdit";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtAlphaEdit;
        public System.Windows.Forms.ComboBox comboVariationEdit;
        public System.Windows.Forms.TextBox txtNoteEdit;
        public System.Windows.Forms.TextBox txtPictureEdit;
        public System.Windows.Forms.ComboBox comboConditionEdit;
        public System.Windows.Forms.TextBox txtPriceEdit;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtSeriesEdit;
        private System.Windows.Forms.ErrorProvider errorEdit;
    }
}