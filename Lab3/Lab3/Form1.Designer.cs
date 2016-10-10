namespace Lab3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.comboCondition = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gridCars = new System.Windows.Forms.DataGridView();
            this.colSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlpha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVariation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.PictureURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPricePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.comboVariation = new System.Windows.Forms.ComboBox();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Series Identifier (1-75):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alpha Model Letter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Variation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Picture URL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Note:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Condition:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Price Paid:";
            // 
            // txtPicture
            // 
            this.txtPicture.Location = new System.Drawing.Point(143, 208);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(150, 20);
            this.txtPicture.TabIndex = 3;
            this.txtPicture.TextChanged += new System.EventHandler(this.txtPicture_TextChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(143, 234);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(150, 53);
            this.txtNote.TabIndex = 4;
            // 
            // comboCondition
            // 
            this.comboCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCondition.FormattingEnabled = true;
            this.comboCondition.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Good",
            "Minor Damage",
            "Perfect"});
            this.comboCondition.Location = new System.Drawing.Point(143, 294);
            this.comboCondition.Name = "comboCondition";
            this.comboCondition.Size = new System.Drawing.Size(150, 21);
            this.comboCondition.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(143, 321);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(218, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(142, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1099, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1099, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gridCars
            // 
            this.gridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSeries,
            this.colAlpha,
            this.colVariation,
            this.colPicture,
            this.PictureURL,
            this.colNote,
            this.colCondition,
            this.colPricePaid});
            this.gridCars.Location = new System.Drawing.Point(323, 23);
            this.gridCars.Name = "gridCars";
            this.gridCars.ReadOnly = true;
            this.gridCars.RowTemplate.Height = 75;
            this.gridCars.Size = new System.Drawing.Size(770, 346);
            this.gridCars.TabIndex = 5;
            this.gridCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colSeries
            // 
            this.colSeries.HeaderText = "Series #";
            this.colSeries.MaxInputLength = 2;
            this.colSeries.Name = "colSeries";
            this.colSeries.ReadOnly = true;
            // 
            // colAlpha
            // 
            this.colAlpha.HeaderText = "Alpha Code";
            this.colAlpha.MaxInputLength = 1;
            this.colAlpha.Name = "colAlpha";
            this.colAlpha.ReadOnly = true;
            // 
            // colVariation
            // 
            this.colVariation.HeaderText = "Variation";
            this.colVariation.Name = "colVariation";
            this.colVariation.ReadOnly = true;
            // 
            // colPicture
            // 
            this.colPicture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPicture.HeaderText = "Picture";
            this.colPicture.Name = "colPicture";
            this.colPicture.ReadOnly = true;
            this.colPicture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPicture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colPicture.Width = 99;
            // 
            // PictureURL
            // 
            this.PictureURL.HeaderText = "URL";
            this.PictureURL.Name = "PictureURL";
            this.PictureURL.ReadOnly = true;
            this.PictureURL.Visible = false;
            // 
            // colNote
            // 
            this.colNote.HeaderText = "Note";
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            // 
            // colCondition
            // 
            this.colCondition.HeaderText = "Condition";
            this.colCondition.Name = "colCondition";
            this.colCondition.ReadOnly = true;
            // 
            // colPricePaid
            // 
            this.colPricePaid.HeaderText = "Price Paid";
            this.colPricePaid.Name = "colPricePaid";
            this.colPricePaid.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 81);
            this.label8.TabIndex = 6;
            this.label8.Text = "Matchbox";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(143, 156);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(150, 20);
            this.txtAlpha.TabIndex = 1;
            // 
            // comboVariation
            // 
            this.comboVariation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVariation.FormattingEnabled = true;
            this.comboVariation.Items.AddRange(new object[] {
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
            this.comboVariation.Location = new System.Drawing.Point(143, 181);
            this.comboVariation.Name = "comboVariation";
            this.comboVariation.Size = new System.Drawing.Size(149, 21);
            this.comboVariation.TabIndex = 2;
            // 
            // txtSeries
            // 
            this.txtSeries.Location = new System.Drawing.Point(142, 130);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(150, 20);
            this.txtSeries.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(136, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 34);
            this.label9.TabIndex = 11;
            this.label9.Text = "Companion";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1208, 394);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboVariation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gridCars);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.comboCondition);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtPicture);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.txtAlpha);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Matchbox Companion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtPicture;
        public System.Windows.Forms.TextBox txtNote;
        public System.Windows.Forms.ComboBox comboCondition;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtAlpha;
        public System.Windows.Forms.ComboBox comboVariation;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.DataGridView gridCars;
        public System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlpha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariation;
        private System.Windows.Forms.DataGridViewImageColumn colPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn PictureURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPricePaid;
        private System.Windows.Forms.Label label9;
    }
}

