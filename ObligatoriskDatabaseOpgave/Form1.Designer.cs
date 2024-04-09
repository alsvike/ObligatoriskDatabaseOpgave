namespace ObligatoriskDatabaseOpgave
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            TextFindHoteller = new TextBox();
            ShowAllHoteller = new Button();
            FindHoteller = new Button();
            DeleteHoteller = new Button();
            UpdateHoteller = new Button();
            InsertHoteller = new Button();
            TextHotelAdresse = new TextBox();
            label3 = new Label();
            TextHotelNavn = new TextBox();
            label2 = new Label();
            TextHotelId = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            UpdateKunder = new Button();
            DeleteKunder = new Button();
            InsertKunder = new Button();
            TextFindKunder = new TextBox();
            FindKunder = new Button();
            ShowAllKunder = new Button();
            TextKundeID = new TextBox();
            label6 = new Label();
            TextKundeAdresse = new TextBox();
            label5 = new Label();
            TextKundeNavn = new TextBox();
            label4 = new Label();
            tabPage3 = new TabPage();
            DeleteVærelser = new Button();
            ShowAllVærelser = new Button();
            UpdateVærelser = new Button();
            FindVærelser = new Button();
            InsertVærelser = new Button();
            TextFindVærelser = new TextBox();
            TextVærelsesID = new TextBox();
            TextVHotelID = new TextBox();
            TextVærelsesNo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tabPage4 = new TabPage();
            TextResFind = new TextBox();
            ResShowAll = new Button();
            ResFind = new Button();
            ResDelete = new Button();
            ResUpdate = new Button();
            ResInsert = new Button();
            TjekUdDato = new DateTimePicker();
            TjekIndDato = new DateTimePicker();
            label14 = new Label();
            label13 = new Label();
            TextRVærelsesID = new TextBox();
            TextRKundeID = new TextBox();
            TextResID = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            tabPage5 = new TabPage();
            textBox7 = new TextBox();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label16 = new Label();
            label15 = new Label();
            tabPage6 = new TabPage();
            textBox10 = new TextBox();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            label18 = new Label();
            label17 = new Label();
            dataGridView1 = new DataGridView();
            ViewTables = new Button();
            button2 = new Button();
            button3 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(404, 413);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImageLayout = ImageLayout.None;
            tabPage1.Controls.Add(TextFindHoteller);
            tabPage1.Controls.Add(ShowAllHoteller);
            tabPage1.Controls.Add(FindHoteller);
            tabPage1.Controls.Add(DeleteHoteller);
            tabPage1.Controls.Add(UpdateHoteller);
            tabPage1.Controls.Add(InsertHoteller);
            tabPage1.Controls.Add(TextHotelAdresse);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(TextHotelNavn);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(TextHotelId);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(396, 385);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hoteller";
            // 
            // TextFindHoteller
            // 
            TextFindHoteller.Location = new Point(92, 325);
            TextFindHoteller.Name = "TextFindHoteller";
            TextFindHoteller.Size = new Size(298, 23);
            TextFindHoteller.TabIndex = 13;
            // 
            // ShowAllHoteller
            // 
            ShowAllHoteller.Location = new Point(6, 354);
            ShowAllHoteller.Name = "ShowAllHoteller";
            ShowAllHoteller.Size = new Size(384, 23);
            ShowAllHoteller.TabIndex = 12;
            ShowAllHoteller.Text = "Show All";
            ShowAllHoteller.UseVisualStyleBackColor = true;
            ShowAllHoteller.Click += ShowAllHoteller_Click;
            // 
            // FindHoteller
            // 
            FindHoteller.Location = new Point(6, 325);
            FindHoteller.Name = "FindHoteller";
            FindHoteller.Size = new Size(80, 23);
            FindHoteller.TabIndex = 11;
            FindHoteller.Text = "Find";
            FindHoteller.UseVisualStyleBackColor = true;
            FindHoteller.Click += FindHoteller_Click;
            // 
            // DeleteHoteller
            // 
            DeleteHoteller.Location = new Point(270, 297);
            DeleteHoteller.Name = "DeleteHoteller";
            DeleteHoteller.Size = new Size(120, 23);
            DeleteHoteller.TabIndex = 10;
            DeleteHoteller.Text = "Delete";
            DeleteHoteller.UseVisualStyleBackColor = true;
            DeleteHoteller.Click += DeleteHoteller_Click;
            // 
            // UpdateHoteller
            // 
            UpdateHoteller.Location = new Point(137, 297);
            UpdateHoteller.Name = "UpdateHoteller";
            UpdateHoteller.Size = new Size(120, 23);
            UpdateHoteller.TabIndex = 9;
            UpdateHoteller.Text = "Update";
            UpdateHoteller.UseVisualStyleBackColor = true;
            UpdateHoteller.Click += UpdateHoteller_Click;
            // 
            // InsertHoteller
            // 
            InsertHoteller.Location = new Point(6, 297);
            InsertHoteller.Name = "InsertHoteller";
            InsertHoteller.Size = new Size(120, 23);
            InsertHoteller.TabIndex = 8;
            InsertHoteller.Text = "Insert";
            InsertHoteller.UseVisualStyleBackColor = true;
            InsertHoteller.Click += InsertHoteller_Click;
            // 
            // TextHotelAdresse
            // 
            TextHotelAdresse.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextHotelAdresse.Location = new Point(118, 64);
            TextHotelAdresse.Name = "TextHotelAdresse";
            TextHotelAdresse.Size = new Size(272, 23);
            TextHotelAdresse.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 64);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 6;
            label3.Text = "Hotel Adresse";
            // 
            // TextHotelNavn
            // 
            TextHotelNavn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextHotelNavn.Location = new Point(118, 35);
            TextHotelNavn.Name = "TextHotelNavn";
            TextHotelNavn.Size = new Size(272, 23);
            TextHotelNavn.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 4;
            label2.Text = "Hotel Navn";
            // 
            // TextHotelId
            // 
            TextHotelId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextHotelId.Location = new Point(118, 6);
            TextHotelId.Name = "TextHotelId";
            TextHotelId.Size = new Size(272, 23);
            TextHotelId.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 0;
            label1.Text = "Hotel ID";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(UpdateKunder);
            tabPage2.Controls.Add(DeleteKunder);
            tabPage2.Controls.Add(InsertKunder);
            tabPage2.Controls.Add(TextFindKunder);
            tabPage2.Controls.Add(FindKunder);
            tabPage2.Controls.Add(ShowAllKunder);
            tabPage2.Controls.Add(TextKundeID);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(TextKundeAdresse);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(TextKundeNavn);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(396, 385);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kunder";
            // 
            // UpdateKunder
            // 
            UpdateKunder.Location = new Point(137, 297);
            UpdateKunder.Name = "UpdateKunder";
            UpdateKunder.Size = new Size(120, 23);
            UpdateKunder.TabIndex = 11;
            UpdateKunder.Text = "Update";
            UpdateKunder.UseVisualStyleBackColor = true;
            UpdateKunder.Click += UpdateKunder_Click;
            // 
            // DeleteKunder
            // 
            DeleteKunder.Location = new Point(270, 297);
            DeleteKunder.Name = "DeleteKunder";
            DeleteKunder.Size = new Size(120, 23);
            DeleteKunder.TabIndex = 10;
            DeleteKunder.Text = "Delete";
            DeleteKunder.UseVisualStyleBackColor = true;
            DeleteKunder.Click += DeleteKunder_Click;
            // 
            // InsertKunder
            // 
            InsertKunder.Location = new Point(6, 297);
            InsertKunder.Name = "InsertKunder";
            InsertKunder.Size = new Size(120, 23);
            InsertKunder.TabIndex = 9;
            InsertKunder.Text = "Insert";
            InsertKunder.UseVisualStyleBackColor = true;
            InsertKunder.Click += InsertKunder_Click;
            // 
            // TextFindKunder
            // 
            TextFindKunder.Location = new Point(92, 325);
            TextFindKunder.Name = "TextFindKunder";
            TextFindKunder.Size = new Size(298, 23);
            TextFindKunder.TabIndex = 8;
            // 
            // FindKunder
            // 
            FindKunder.Location = new Point(6, 325);
            FindKunder.Name = "FindKunder";
            FindKunder.Size = new Size(80, 23);
            FindKunder.TabIndex = 7;
            FindKunder.Text = "Find";
            FindKunder.UseVisualStyleBackColor = true;
            FindKunder.Click += FindKunder_Click;
            // 
            // ShowAllKunder
            // 
            ShowAllKunder.Location = new Point(6, 354);
            ShowAllKunder.Name = "ShowAllKunder";
            ShowAllKunder.Size = new Size(384, 23);
            ShowAllKunder.TabIndex = 6;
            ShowAllKunder.Text = "Show All";
            ShowAllKunder.UseVisualStyleBackColor = true;
            ShowAllKunder.Click += ShowAllKunder_Click;
            // 
            // TextKundeID
            // 
            TextKundeID.Location = new Point(118, 7);
            TextKundeID.Name = "TextKundeID";
            TextKundeID.Size = new Size(271, 23);
            TextKundeID.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 64);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 4;
            label6.Text = "Kunde Adresse";
            // 
            // TextKundeAdresse
            // 
            TextKundeAdresse.Location = new Point(118, 64);
            TextKundeAdresse.Name = "TextKundeAdresse";
            TextKundeAdresse.Size = new Size(271, 23);
            TextKundeAdresse.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 35);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 2;
            label5.Text = "Kunde Navn";
            // 
            // TextKundeNavn
            // 
            TextKundeNavn.Location = new Point(118, 35);
            TextKundeNavn.Name = "TextKundeNavn";
            TextKundeNavn.Size = new Size(271, 23);
            TextKundeNavn.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 6);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 0;
            label4.Text = "Kunde ID";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(DeleteVærelser);
            tabPage3.Controls.Add(ShowAllVærelser);
            tabPage3.Controls.Add(UpdateVærelser);
            tabPage3.Controls.Add(FindVærelser);
            tabPage3.Controls.Add(InsertVærelser);
            tabPage3.Controls.Add(TextFindVærelser);
            tabPage3.Controls.Add(TextVærelsesID);
            tabPage3.Controls.Add(TextVHotelID);
            tabPage3.Controls.Add(TextVærelsesNo);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(396, 385);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Værelser";
            // 
            // DeleteVærelser
            // 
            DeleteVærelser.Location = new Point(270, 297);
            DeleteVærelser.Name = "DeleteVærelser";
            DeleteVærelser.Size = new Size(120, 23);
            DeleteVærelser.TabIndex = 11;
            DeleteVærelser.Text = "Delete";
            DeleteVærelser.UseVisualStyleBackColor = true;
            DeleteVærelser.Click += DeleteVærelser_Click;
            // 
            // ShowAllVærelser
            // 
            ShowAllVærelser.Location = new Point(6, 354);
            ShowAllVærelser.Name = "ShowAllVærelser";
            ShowAllVærelser.Size = new Size(383, 23);
            ShowAllVærelser.TabIndex = 10;
            ShowAllVærelser.Text = "Show All";
            ShowAllVærelser.UseVisualStyleBackColor = true;
            ShowAllVærelser.Click += ShowAllVærelser_Click;
            // 
            // UpdateVærelser
            // 
            UpdateVærelser.Location = new Point(137, 297);
            UpdateVærelser.Name = "UpdateVærelser";
            UpdateVærelser.Size = new Size(120, 23);
            UpdateVærelser.TabIndex = 9;
            UpdateVærelser.Text = "Update";
            UpdateVærelser.UseVisualStyleBackColor = true;
            UpdateVærelser.Click += UpdateVærelser_Click;
            // 
            // FindVærelser
            // 
            FindVærelser.Location = new Point(6, 325);
            FindVærelser.Name = "FindVærelser";
            FindVærelser.Size = new Size(80, 23);
            FindVærelser.TabIndex = 8;
            FindVærelser.Text = "Find";
            FindVærelser.UseVisualStyleBackColor = true;
            FindVærelser.Click += FindVærelser_Click;
            // 
            // InsertVærelser
            // 
            InsertVærelser.Location = new Point(6, 297);
            InsertVærelser.Name = "InsertVærelser";
            InsertVærelser.Size = new Size(120, 23);
            InsertVærelser.TabIndex = 7;
            InsertVærelser.Text = "Insert";
            InsertVærelser.UseVisualStyleBackColor = true;
            InsertVærelser.Click += InsertVærelser_Click;
            // 
            // TextFindVærelser
            // 
            TextFindVærelser.Location = new Point(92, 325);
            TextFindVærelser.Name = "TextFindVærelser";
            TextFindVærelser.Size = new Size(297, 23);
            TextFindVærelser.TabIndex = 6;
            // 
            // TextVærelsesID
            // 
            TextVærelsesID.Location = new Point(118, 7);
            TextVærelsesID.Name = "TextVærelsesID";
            TextVærelsesID.Size = new Size(271, 23);
            TextVærelsesID.TabIndex = 5;
            // 
            // TextVHotelID
            // 
            TextVHotelID.Location = new Point(118, 35);
            TextVHotelID.Name = "TextVHotelID";
            TextVHotelID.Size = new Size(271, 23);
            TextVHotelID.TabIndex = 4;
            // 
            // TextVærelsesNo
            // 
            TextVærelsesNo.Location = new Point(118, 64);
            TextVærelsesNo.Name = "TextVærelsesNo";
            TextVærelsesNo.Size = new Size(271, 23);
            TextVærelsesNo.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 64);
            label9.Name = "label9";
            label9.Size = new Size(100, 21);
            label9.TabIndex = 2;
            label9.Text = "Værelses No.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 35);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 1;
            label8.Text = "Hotel ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 6);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 0;
            label7.Text = "Værelses ID";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(TextResFind);
            tabPage4.Controls.Add(ResShowAll);
            tabPage4.Controls.Add(ResFind);
            tabPage4.Controls.Add(ResDelete);
            tabPage4.Controls.Add(ResUpdate);
            tabPage4.Controls.Add(ResInsert);
            tabPage4.Controls.Add(TjekUdDato);
            tabPage4.Controls.Add(TjekIndDato);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(TextRVærelsesID);
            tabPage4.Controls.Add(TextRKundeID);
            tabPage4.Controls.Add(TextResID);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label10);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(396, 385);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Reservationer";
            // 
            // TextResFind
            // 
            TextResFind.Location = new Point(92, 325);
            TextResFind.Name = "TextResFind";
            TextResFind.Size = new Size(298, 23);
            TextResFind.TabIndex = 17;
            // 
            // ResShowAll
            // 
            ResShowAll.Location = new Point(6, 354);
            ResShowAll.Name = "ResShowAll";
            ResShowAll.Size = new Size(384, 23);
            ResShowAll.TabIndex = 16;
            ResShowAll.Text = "Show All";
            ResShowAll.UseVisualStyleBackColor = true;
            ResShowAll.Click += ResShowAll_Click;
            // 
            // ResFind
            // 
            ResFind.Location = new Point(6, 325);
            ResFind.Name = "ResFind";
            ResFind.Size = new Size(80, 23);
            ResFind.TabIndex = 15;
            ResFind.Text = "Find";
            ResFind.UseVisualStyleBackColor = true;
            // 
            // ResDelete
            // 
            ResDelete.Location = new Point(270, 297);
            ResDelete.Name = "ResDelete";
            ResDelete.Size = new Size(120, 23);
            ResDelete.TabIndex = 14;
            ResDelete.Text = "Delete";
            ResDelete.UseVisualStyleBackColor = true;
            // 
            // ResUpdate
            // 
            ResUpdate.Location = new Point(137, 297);
            ResUpdate.Name = "ResUpdate";
            ResUpdate.Size = new Size(120, 23);
            ResUpdate.TabIndex = 13;
            ResUpdate.Text = "Update";
            ResUpdate.UseVisualStyleBackColor = true;
            ResUpdate.Click += ResUpdate_Click;
            // 
            // ResInsert
            // 
            ResInsert.Location = new Point(6, 297);
            ResInsert.Name = "ResInsert";
            ResInsert.Size = new Size(120, 23);
            ResInsert.TabIndex = 12;
            ResInsert.Text = "Insert";
            ResInsert.UseVisualStyleBackColor = true;
            ResInsert.Click += ResInsert_Click;
            // 
            // TjekUdDato
            // 
            TjekUdDato.Format = DateTimePickerFormat.Short;
            TjekUdDato.Location = new Point(130, 124);
            TjekUdDato.Name = "TjekUdDato";
            TjekUdDato.Size = new Size(127, 23);
            TjekUdDato.TabIndex = 11;
            // 
            // TjekIndDato
            // 
            TjekIndDato.Format = DateTimePickerFormat.Short;
            TjekIndDato.Location = new Point(130, 94);
            TjekIndDato.Name = "TjekIndDato";
            TjekIndDato.Size = new Size(127, 23);
            TjekIndDato.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(6, 124);
            label14.Name = "label14";
            label14.Size = new Size(99, 21);
            label14.TabIndex = 7;
            label14.Text = "Tjek Ud Dato";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(6, 94);
            label13.Name = "label13";
            label13.Size = new Size(101, 21);
            label13.TabIndex = 6;
            label13.Text = "Tjek Ind Dato";
            // 
            // TextRVærelsesID
            // 
            TextRVærelsesID.Location = new Point(130, 64);
            TextRVærelsesID.Name = "TextRVærelsesID";
            TextRVærelsesID.Size = new Size(259, 23);
            TextRVærelsesID.TabIndex = 5;
            // 
            // TextRKundeID
            // 
            TextRKundeID.Location = new Point(130, 35);
            TextRKundeID.Name = "TextRKundeID";
            TextRKundeID.Size = new Size(259, 23);
            TextRKundeID.TabIndex = 4;
            // 
            // TextResID
            // 
            TextResID.Location = new Point(130, 7);
            TextResID.Name = "TextResID";
            TextResID.Size = new Size(259, 23);
            TextResID.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(6, 64);
            label12.Name = "label12";
            label12.Size = new Size(91, 21);
            label12.TabIndex = 2;
            label12.Text = "Værelses ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 35);
            label11.Name = "label11";
            label11.Size = new Size(73, 21);
            label11.TabIndex = 1;
            label11.Text = "Kunde ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(6, 6);
            label10.Name = "label10";
            label10.Size = new Size(118, 21);
            label10.TabIndex = 0;
            label10.Text = "Reservations ID";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(textBox7);
            tabPage5.Controls.Add(button12);
            tabPage5.Controls.Add(button11);
            tabPage5.Controls.Add(button10);
            tabPage5.Controls.Add(button9);
            tabPage5.Controls.Add(button8);
            tabPage5.Controls.Add(textBox6);
            tabPage5.Controls.Add(textBox5);
            tabPage5.Controls.Add(label16);
            tabPage5.Controls.Add(label15);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(396, 385);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Faciliteter";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(92, 325);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(298, 23);
            textBox7.TabIndex = 9;
            // 
            // button12
            // 
            button12.Location = new Point(6, 325);
            button12.Name = "button12";
            button12.Size = new Size(80, 23);
            button12.TabIndex = 8;
            button12.Text = "Find";
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(270, 297);
            button11.Name = "button11";
            button11.Size = new Size(120, 23);
            button11.TabIndex = 7;
            button11.Text = "Delete";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(6, 354);
            button10.Name = "button10";
            button10.Size = new Size(384, 23);
            button10.TabIndex = 6;
            button10.Text = "Show All";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(6, 297);
            button9.Name = "button9";
            button9.Size = new Size(120, 23);
            button9.TabIndex = 5;
            button9.Text = "Insert";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(137, 297);
            button8.Name = "button8";
            button8.Size = new Size(120, 23);
            button8.TabIndex = 4;
            button8.Text = "Update";
            button8.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(118, 35);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(272, 23);
            textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(118, 7);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(272, 23);
            textBox5.TabIndex = 2;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(6, 35);
            label16.Name = "label16";
            label16.Size = new Size(110, 21);
            label16.TabIndex = 1;
            label16.Text = "Facilitets Navn";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(6, 6);
            label15.Name = "label15";
            label15.Size = new Size(88, 21);
            label15.TabIndex = 0;
            label15.Text = "Facilitets ID";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(textBox10);
            tabPage6.Controls.Add(button17);
            tabPage6.Controls.Add(button16);
            tabPage6.Controls.Add(button15);
            tabPage6.Controls.Add(button14);
            tabPage6.Controls.Add(button13);
            tabPage6.Controls.Add(textBox9);
            tabPage6.Controls.Add(textBox8);
            tabPage6.Controls.Add(label18);
            tabPage6.Controls.Add(label17);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(396, 385);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Hotel Faciliteter";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(92, 325);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(298, 23);
            textBox10.TabIndex = 9;
            // 
            // button17
            // 
            button17.Location = new Point(6, 354);
            button17.Name = "button17";
            button17.Size = new Size(384, 23);
            button17.TabIndex = 8;
            button17.Text = "button17";
            button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(6, 325);
            button16.Name = "button16";
            button16.Size = new Size(80, 23);
            button16.TabIndex = 7;
            button16.Text = "button16";
            button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(270, 297);
            button15.Name = "button15";
            button15.Size = new Size(120, 23);
            button15.TabIndex = 6;
            button15.Text = "button15";
            button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(137, 297);
            button14.Name = "button14";
            button14.Size = new Size(120, 23);
            button14.TabIndex = 5;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(6, 297);
            button13.Name = "button13";
            button13.Size = new Size(120, 23);
            button13.TabIndex = 4;
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(118, 35);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(272, 23);
            textBox9.TabIndex = 3;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(118, 7);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(272, 23);
            textBox8.TabIndex = 2;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(6, 35);
            label18.Name = "label18";
            label18.Size = new Size(88, 21);
            label18.TabIndex = 1;
            label18.Text = "Facilitets ID";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(6, 6);
            label17.Name = "label17";
            label17.Size = new Size(66, 21);
            label17.TabIndex = 0;
            label17.Text = "Hotel ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(422, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(428, 360);
            dataGridView1.TabIndex = 1;
            // 
            // ViewTables
            // 
            ViewTables.FlatStyle = FlatStyle.Flat;
            ViewTables.Location = new Point(609, 402);
            ViewTables.Name = "ViewTables";
            ViewTables.Size = new Size(80, 23);
            ViewTables.TabIndex = 2;
            ViewTables.Text = "View Tables";
            ViewTables.UseVisualStyleBackColor = true;
            ViewTables.Click += ViewTables_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(770, 402);
            button2.Name = "button2";
            button2.Size = new Size(80, 23);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(422, 402);
            button3.Name = "button3";
            button3.Size = new Size(116, 23);
            button3.TabIndex = 4;
            button3.Text = "Check Connection";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 444);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(ViewTables);
            Controls.Add(dataGridView1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Database Applikation - Hoteller";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private DataGridView dataGridView1;
        private Button ViewTables;
        private Button button2;
        private Button button3;
        private TextBox TextHotelAdresse;
        private Label label3;
        private TextBox TextHotelNavn;
        private Label label2;
        private TextBox TextHotelId;
        private Label label1;
        private TextBox TextFindHoteller;
        private Button ShowAllHoteller;
        private Button FindHoteller;
        private Button DeleteHoteller;
        private Button UpdateHoteller;
        private Button InsertHoteller;
        private TextBox TextKundeNavn;
        private Label label4;
        private TextBox TextKundeID;
        private Label label6;
        private TextBox TextKundeAdresse;
        private Label label5;
        private Button ShowAllKunder;
        private Button UpdateKunder;
        private Button DeleteKunder;
        private Button InsertKunder;
        private TextBox TextFindKunder;
        private Button FindKunder;
        private TextBox TextVærelsesID;
        private TextBox TextVHotelID;
        private TextBox TextVærelsesNo;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox TextFindVærelser;
        private Button DeleteVærelser;
        private Button ShowAllVærelser;
        private Button UpdateVærelser;
        private Button FindVærelser;
        private Button InsertVærelser;
        private DateTimePicker TjekIndDato;
        private Label label14;
        private Label label13;
        private TextBox TextRVærelsesID;
        private TextBox TextRKundeID;
        private TextBox TextResID;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox TextResFind;
        private Button ResShowAll;
        private Button ResFind;
        private Button ResDelete;
        private Button ResUpdate;
        private Button ResInsert;
        private DateTimePicker TjekUdDato;
        private TextBox textBox7;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label16;
        private Label label15;
        private TextBox textBox10;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label18;
        private Label label17;
    }
}
