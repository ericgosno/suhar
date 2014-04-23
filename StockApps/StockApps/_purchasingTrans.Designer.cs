namespace StockApps
{
    partial class _purchasingTrans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._dataSupTransaction = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity_Kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Package_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal_Dollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal_Rupiah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bpurPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._cbpurNama = new System.Windows.Forms.ComboBox();
            this._tpurKurs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._dtTransDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._tpurDescription = new System.Windows.Forms.TextBox();
            this._bpurDelete = new System.Windows.Forms.Button();
            this._lpurTotalPPNRupiah = new System.Windows.Forms.Label();
            this._lpurPPNRupiah = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this._lpurTotalPPNDollar = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this._lpurPPNDollar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._lpurDollar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._lpurRp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._cbpurKurs = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this._tpurNoteNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._tpurInvoice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dataSupTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataSupTransaction
            // 
            this._dataSupTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataSupTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataSupTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataSupTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity_Kg,
            this.Package_Quantity,
            this.Price_Kg,
            this.Subtotal_Dollar,
            this.Subtotal_Rupiah});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataSupTransaction.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataSupTransaction.Location = new System.Drawing.Point(15, 306);
            this._dataSupTransaction.Name = "_dataSupTransaction";
            this._dataSupTransaction.Size = new System.Drawing.Size(766, 238);
            this._dataSupTransaction.TabIndex = 22;
            this._dataSupTransaction.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataSupTransaction_CellEndEdit);
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // Quantity_Kg
            // 
            this.Quantity_Kg.HeaderText = "Quantity(Kgs)";
            this.Quantity_Kg.Name = "Quantity_Kg";
            // 
            // Package_Quantity
            // 
            this.Package_Quantity.HeaderText = "Package Quantity";
            this.Package_Quantity.Name = "Package_Quantity";
            this.Package_Quantity.ReadOnly = true;
            // 
            // Price_Kg
            // 
            this.Price_Kg.HeaderText = "Price Per Kg";
            this.Price_Kg.Name = "Price_Kg";
            this.Price_Kg.ReadOnly = true;
            // 
            // Subtotal_Dollar
            // 
            this.Subtotal_Dollar.HeaderText = "Subtotal(Dollar)";
            this.Subtotal_Dollar.Name = "Subtotal_Dollar";
            this.Subtotal_Dollar.ReadOnly = true;
            // 
            // Subtotal_Rupiah
            // 
            this.Subtotal_Rupiah.HeaderText = "Subtotal(Rupiah)";
            this.Subtotal_Rupiah.Name = "Subtotal_Rupiah";
            this.Subtotal_Rupiah.ReadOnly = true;
            // 
            // _bpurPay
            // 
            this._bpurPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bpurPay.Location = new System.Drawing.Point(638, 589);
            this._bpurPay.Name = "_bpurPay";
            this._bpurPay.Size = new System.Drawing.Size(143, 35);
            this._bpurPay.TabIndex = 21;
            this._bpurPay.Text = "PROCESS";
            this._bpurPay.UseVisualStyleBackColor = true;
            this._bpurPay.Click += new System.EventHandler(this._bpurPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Supplier Transaction";
            // 
            // _cbpurNama
            // 
            this._cbpurNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbpurNama.FormattingEnabled = true;
            this._cbpurNama.Location = new System.Drawing.Point(197, 90);
            this._cbpurNama.Name = "_cbpurNama";
            this._cbpurNama.Size = new System.Drawing.Size(466, 37);
            this._cbpurNama.TabIndex = 3;
            this._cbpurNama.SelectedIndexChanged += new System.EventHandler(this._cbpurNama_SelectedIndexChanged);
            // 
            // _tpurKurs
            // 
            this._tpurKurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tpurKurs.Location = new System.Drawing.Point(197, 173);
            this._tpurKurs.Name = "_tpurKurs";
            this._tpurKurs.Size = new System.Drawing.Size(142, 35);
            this._tpurKurs.TabIndex = 5;
            this._tpurKurs.Text = "0";
            this._tpurKurs.TextChanged += new System.EventHandler(this._tpurKurs_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kurs Rupiah";
            // 
            // _dtTransDate
            // 
            this._dtTransDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dtTransDate.Location = new System.Drawing.Point(197, 132);
            this._dtTransDate.Name = "_dtTransDate";
            this._dtTransDate.Size = new System.Drawing.Size(466, 35);
            this._dtTransDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "Description";
            // 
            // _tpurDescription
            // 
            this._tpurDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tpurDescription.Location = new System.Drawing.Point(197, 216);
            this._tpurDescription.Multiline = true;
            this._tpurDescription.Name = "_tpurDescription";
            this._tpurDescription.Size = new System.Drawing.Size(466, 84);
            this._tpurDescription.TabIndex = 40;
            // 
            // _bpurDelete
            // 
            this._bpurDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bpurDelete.Location = new System.Drawing.Point(638, 550);
            this._bpurDelete.Name = "_bpurDelete";
            this._bpurDelete.Size = new System.Drawing.Size(143, 35);
            this._bpurDelete.TabIndex = 41;
            this._bpurDelete.Text = "DELETE";
            this._bpurDelete.UseVisualStyleBackColor = true;
            this._bpurDelete.Click += new System.EventHandler(this._bpurDelete_Click);
            // 
            // _lpurTotalPPNRupiah
            // 
            this._lpurTotalPPNRupiah.AutoSize = true;
            this._lpurTotalPPNRupiah.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lpurTotalPPNRupiah.Location = new System.Drawing.Point(384, 628);
            this._lpurTotalPPNRupiah.Name = "_lpurTotalPPNRupiah";
            this._lpurTotalPPNRupiah.Size = new System.Drawing.Size(26, 29);
            this._lpurTotalPPNRupiah.TabIndex = 76;
            this._lpurTotalPPNRupiah.Text = "0";
            // 
            // _lpurPPNRupiah
            // 
            this._lpurPPNRupiah.AutoSize = true;
            this._lpurPPNRupiah.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lpurPPNRupiah.Location = new System.Drawing.Point(384, 592);
            this._lpurPPNRupiah.Name = "_lpurPPNRupiah";
            this._lpurPPNRupiah.Size = new System.Drawing.Size(26, 29);
            this._lpurPPNRupiah.TabIndex = 75;
            this._lpurPPNRupiah.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(322, 628);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 29);
            this.label11.TabIndex = 74;
            this.label11.Text = "Rp :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(252, 592);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 29);
            this.label13.TabIndex = 73;
            this.label13.Text = "PPN - Rp :";
            // 
            // _lpurTotalPPNDollar
            // 
            this._lpurTotalPPNDollar.AutoSize = true;
            this._lpurTotalPPNDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lpurTotalPPNDollar.Location = new System.Drawing.Point(128, 621);
            this._lpurTotalPPNDollar.Name = "_lpurTotalPPNDollar";
            this._lpurTotalPPNDollar.Size = new System.Drawing.Size(26, 29);
            this._lpurTotalPPNDollar.TabIndex = 72;
            this._lpurTotalPPNDollar.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(84, 621);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 29);
            this.label12.TabIndex = 71;
            this.label12.Text = "$ :";
            // 
            // _lpurPPNDollar
            // 
            this._lpurPPNDollar.AutoSize = true;
            this._lpurPPNDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lpurPPNDollar.Location = new System.Drawing.Point(128, 592);
            this._lpurPPNDollar.Name = "_lpurPPNDollar";
            this._lpurPPNDollar.Size = new System.Drawing.Size(26, 29);
            this._lpurPPNDollar.TabIndex = 70;
            this._lpurPPNDollar.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 592);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 29);
            this.label10.TabIndex = 69;
            this.label10.Text = "PPN - $ :";
            // 
            // _lpurDollar
            // 
            this._lpurDollar.AutoSize = true;
            this._lpurDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lpurDollar.Location = new System.Drawing.Point(128, 561);
            this._lpurDollar.Name = "_lpurDollar";
            this._lpurDollar.Size = new System.Drawing.Size(26, 29);
            this._lpurDollar.TabIndex = 68;
            this._lpurDollar.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 67;
            this.label6.Text = "Total - Rp :";
            // 
            // _lpurRp
            // 
            this._lpurRp.AutoSize = true;
            this._lpurRp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lpurRp.Location = new System.Drawing.Point(384, 558);
            this._lpurRp.Name = "_lpurRp";
            this._lpurRp.Size = new System.Drawing.Size(26, 29);
            this._lpurRp.TabIndex = 66;
            this._lpurRp.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 65;
            this.label3.Text = "Total - $ :";
            // 
            // _cbpurKurs
            // 
            this._cbpurKurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbpurKurs.FormattingEnabled = true;
            this._cbpurKurs.ItemHeight = 29;
            this._cbpurKurs.Location = new System.Drawing.Point(485, 176);
            this._cbpurKurs.Name = "_cbpurKurs";
            this._cbpurKurs.Size = new System.Drawing.Size(178, 37);
            this._cbpurKurs.TabIndex = 78;
            this._cbpurKurs.SelectedIndexChanged += new System.EventHandler(this._cbpurKurs_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(345, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 29);
            this.label9.TabIndex = 77;
            this.label9.Text = "Currency";
            // 
            // _tpurNoteNum
            // 
            this._tpurNoteNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tpurNoteNum.Location = new System.Drawing.Point(197, 49);
            this._tpurNoteNum.Name = "_tpurNoteNum";
            this._tpurNoteNum.Size = new System.Drawing.Size(142, 35);
            this._tpurNoteNum.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 29);
            this.label8.TabIndex = 79;
            this.label8.Text = "Note Number";
            // 
            // _tpurInvoice
            // 
            this._tpurInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tpurInvoice.Location = new System.Drawing.Point(485, 46);
            this._tpurInvoice.Name = "_tpurInvoice";
            this._tpurInvoice.Size = new System.Drawing.Size(178, 35);
            this._tpurInvoice.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(345, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 29);
            this.label14.TabIndex = 81;
            this.label14.Text = "Invoice";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(166, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 29);
            this.label15.TabIndex = 82;
            this.label15.Text = " :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(166, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 29);
            this.label16.TabIndex = 83;
            this.label16.Text = " :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(166, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 29);
            this.label17.TabIndex = 84;
            this.label17.Text = " :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(166, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 29);
            this.label18.TabIndex = 85;
            this.label18.Text = " :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(166, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 29);
            this.label19.TabIndex = 86;
            this.label19.Text = " :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(454, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 29);
            this.label20.TabIndex = 87;
            this.label20.Text = " :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(454, 179);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 29);
            this.label21.TabIndex = 88;
            this.label21.Text = " :";
            // 
            // _purchasingTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 660);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this._tpurInvoice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this._tpurNoteNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._cbpurKurs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._lpurTotalPPNRupiah);
            this.Controls.Add(this._lpurPPNRupiah);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this._lpurTotalPPNDollar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this._lpurPPNDollar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._lpurDollar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._lpurRp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._bpurDelete);
            this.Controls.Add(this._tpurDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._dtTransDate);
            this.Controls.Add(this._tpurKurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cbpurNama);
            this.Controls.Add(this._dataSupTransaction);
            this.Controls.Add(this._bpurPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "_purchasingTrans";
            this.Text = "CV. WARNA MURNI - PURCHASING";
            this.Load += new System.EventHandler(this._purchasingTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataSupTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataSupTransaction;
        private System.Windows.Forms.Button _bpurPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _cbpurNama;
        private System.Windows.Forms.TextBox _tpurKurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker _dtTransDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _tpurDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal_Dollar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal_Rupiah;
        public System.Windows.Forms.Button _bpurDelete;
        private System.Windows.Forms.Label _lpurTotalPPNRupiah;
        private System.Windows.Forms.Label _lpurPPNRupiah;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label _lpurTotalPPNDollar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label _lpurPPNDollar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label _lpurDollar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _lpurRp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cbpurKurs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _tpurNoteNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _tpurInvoice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;

    }
}