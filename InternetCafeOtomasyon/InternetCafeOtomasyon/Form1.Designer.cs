namespace InternetCafeOtomasyon
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            yöneticiÇağırToolStripMenuItem = new ToolStripMenuItem();
            süresizMasaAçmaİsteğiGönderToolStripMenuItem = new ToolStripMenuItem();
            süreliMasaAçmaİsteğiGönderToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            toolStripMenuItem12 = new ToolStripMenuItem();
            masaDeğiştirmeİsteğiGönderToolStripMenuItem = new ToolStripMenuItem();
            ımageList1 = new ImageList(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            listView1 = new ListView();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Masa_ID = new DataGridViewTextBoxColumn();
            _Masa = new DataGridViewTextBoxColumn();
            AcilisTuru = new DataGridViewTextBoxColumn();
            BaslamaSaati = new DataGridViewTextBoxColumn();
            BitisSaati = new DataGridViewTextBoxColumn();
            Sure = new DataGridViewTextBoxColumn();
            Tutar = new DataGridViewTextBoxColumn();
            _Tarih = new DataGridViewTextBoxColumn();
            Hesapla = new DataGridViewButtonColumn();
            MasaKapat = new DataGridViewButtonColumn();
            cmbBosMasalar = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            radioButton7 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButtonSuresiz = new RadioButton();
            btnMasaAc = new Button();
            label2 = new Label();
            cmbSaatUcreti = new ComboBox();
            bindingSource1 = new BindingSource(components);
            HareketID = new ColumnHeader();
            KullaniciID = new ColumnHeader();
            _MasaID = new ColumnHeader();
            Masa_ = new ColumnHeader();
            IstekTuru_ = new ColumnHeader();
            Aciklama_ = new ColumnHeader();
            Tarih_ = new ColumnHeader();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ContextMenuStrip = contextMenuStrip1;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.ImageKey = "98.PNG";
            button1.ImageList = ımageList1;
            button1.Location = new Point(23, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 91);
            button1.TabIndex = 0;
            button1.Text = "MASA-1";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.MouseDown += SecileneGore;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { yöneticiÇağırToolStripMenuItem, süresizMasaAçmaİsteğiGönderToolStripMenuItem, süreliMasaAçmaİsteğiGönderToolStripMenuItem, masaDeğiştirmeİsteğiGönderToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(249, 92);
            // 
            // yöneticiÇağırToolStripMenuItem
            // 
            yöneticiÇağırToolStripMenuItem.Name = "yöneticiÇağırToolStripMenuItem";
            yöneticiÇağırToolStripMenuItem.Size = new Size(248, 22);
            yöneticiÇağırToolStripMenuItem.Text = "Yönetici Çağır";
            // 
            // süresizMasaAçmaİsteğiGönderToolStripMenuItem
            // 
            süresizMasaAçmaİsteğiGönderToolStripMenuItem.Name = "süresizMasaAçmaİsteğiGönderToolStripMenuItem";
            süresizMasaAçmaİsteğiGönderToolStripMenuItem.Size = new Size(248, 22);
            süresizMasaAçmaİsteğiGönderToolStripMenuItem.Text = "Süresiz Masa Açma İsteği Gönder";
            // 
            // süreliMasaAçmaİsteğiGönderToolStripMenuItem
            // 
            süreliMasaAçmaİsteğiGönderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7, toolStripMenuItem8, toolStripMenuItem9, toolStripMenuItem10, toolStripMenuItem11, toolStripMenuItem12 });
            süreliMasaAçmaİsteğiGönderToolStripMenuItem.Name = "süreliMasaAçmaİsteğiGönderToolStripMenuItem";
            süreliMasaAçmaİsteğiGönderToolStripMenuItem.Size = new Size(248, 22);
            süreliMasaAçmaİsteğiGönderToolStripMenuItem.Text = "Süreli Masa Açma İsteği Gönder";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(92, 22);
            toolStripMenuItem2.Text = "30";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(92, 22);
            toolStripMenuItem3.Text = "45";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(92, 22);
            toolStripMenuItem4.Text = "60";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(92, 22);
            toolStripMenuItem5.Text = "75";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(92, 22);
            toolStripMenuItem6.Text = "90";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(92, 22);
            toolStripMenuItem7.Text = "105";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(92, 22);
            toolStripMenuItem8.Text = "120";
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(92, 22);
            toolStripMenuItem9.Text = "135";
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(92, 22);
            toolStripMenuItem10.Text = "150";
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(92, 22);
            toolStripMenuItem11.Text = "165";
            // 
            // toolStripMenuItem12
            // 
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            toolStripMenuItem12.Size = new Size(92, 22);
            toolStripMenuItem12.Text = "180";
            // 
            // masaDeğiştirmeİsteğiGönderToolStripMenuItem
            // 
            masaDeğiştirmeİsteğiGönderToolStripMenuItem.Name = "masaDeğiştirmeİsteğiGönderToolStripMenuItem";
            masaDeğiştirmeİsteğiGönderToolStripMenuItem.Size = new Size(248, 22);
            masaDeğiştirmeİsteğiGönderToolStripMenuItem.Text = "Masa Değiştirme İsteği Gönder";
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "98.PNG");
            ımageList1.Images.SetKeyName(1, "images.png");
            ımageList1.Images.SetKeyName(2, "ht.jpg");
            // 
            // button2
            // 
            button2.ContextMenuStrip = contextMenuStrip1;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.ImageKey = "98.PNG";
            button2.ImageList = ımageList1;
            button2.Location = new Point(128, 28);
            button2.Name = "button2";
            button2.Size = new Size(75, 91);
            button2.TabIndex = 1;
            button2.Text = "MASA-2";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.MouseDown += SecileneGore;
            // 
            // button3
            // 
            button3.ContextMenuStrip = contextMenuStrip1;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.ImageKey = "98.PNG";
            button3.ImageList = ımageList1;
            button3.Location = new Point(242, 28);
            button3.Name = "button3";
            button3.Size = new Size(75, 91);
            button3.TabIndex = 2;
            button3.Text = "MASA-3";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.MouseDown += SecileneGore;
            // 
            // button4
            // 
            button4.ContextMenuStrip = contextMenuStrip1;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.ImageKey = "98.PNG";
            button4.ImageList = ımageList1;
            button4.Location = new Point(361, 28);
            button4.Name = "button4";
            button4.Size = new Size(75, 91);
            button4.TabIndex = 3;
            button4.Text = "MASA-4";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.MouseDown += SecileneGore;
            // 
            // button5
            // 
            button5.ContextMenuStrip = contextMenuStrip1;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.ImageKey = "98.PNG";
            button5.ImageList = ımageList1;
            button5.Location = new Point(482, 28);
            button5.Name = "button5";
            button5.Size = new Size(75, 91);
            button5.TabIndex = 4;
            button5.Text = "MASA-5";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.MouseDown += SecileneGore;
            // 
            // button6
            // 
            button6.ContextMenuStrip = contextMenuStrip1;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.ImageKey = "98.PNG";
            button6.ImageList = ımageList1;
            button6.Location = new Point(598, 28);
            button6.Name = "button6";
            button6.Size = new Size(75, 91);
            button6.TabIndex = 5;
            button6.Text = "MASA-6";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            button6.MouseDown += SecileneGore;
            // 
            // button7
            // 
            button7.ContextMenuStrip = contextMenuStrip1;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ImageAlign = ContentAlignment.TopCenter;
            button7.ImageKey = "98.PNG";
            button7.ImageList = ımageList1;
            button7.Location = new Point(714, 28);
            button7.Name = "button7";
            button7.Size = new Size(75, 91);
            button7.TabIndex = 6;
            button7.Text = "MASA-7";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            button7.MouseDown += SecileneGore;
            // 
            // button8
            // 
            button8.ContextMenuStrip = contextMenuStrip1;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ImageAlign = ContentAlignment.TopCenter;
            button8.ImageKey = "98.PNG";
            button8.ImageList = ımageList1;
            button8.Location = new Point(818, 28);
            button8.Name = "button8";
            button8.Size = new Size(75, 91);
            button8.TabIndex = 7;
            button8.Text = "MASA-8";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = true;
            button8.MouseDown += SecileneGore;
            // 
            // button9
            // 
            button9.ContextMenuStrip = contextMenuStrip1;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ImageAlign = ContentAlignment.TopCenter;
            button9.ImageKey = "98.PNG";
            button9.ImageList = ımageList1;
            button9.Location = new Point(920, 28);
            button9.Name = "button9";
            button9.Size = new Size(75, 91);
            button9.TabIndex = 8;
            button9.Text = "MASA-9";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = true;
            button9.MouseDown += SecileneGore;
            // 
            // button10
            // 
            button10.BackColor = Color.Transparent;
            button10.BackgroundImageLayout = ImageLayout.Center;
            button10.ContextMenuStrip = contextMenuStrip1;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ImageAlign = ContentAlignment.TopCenter;
            button10.ImageKey = "ht.jpg";
            button10.ImageList = ımageList1;
            button10.Location = new Point(1024, 28);
            button10.Name = "button10";
            button10.Size = new Size(75, 91);
            button10.TabIndex = 9;
            button10.Text = "MASA-10";
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.UseVisualStyleBackColor = false;
            button10.MouseDown += SecileneGore;
            // 
            // button12
            // 
            button12.ContextMenuStrip = contextMenuStrip1;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.ImageAlign = ContentAlignment.TopCenter;
            button12.ImageKey = "98.PNG";
            button12.ImageList = ımageList1;
            button12.Location = new Point(23, 485);
            button12.Name = "button12";
            button12.Size = new Size(75, 87);
            button12.TabIndex = 0;
            button12.Text = "MASA-11";
            button12.TextAlign = ContentAlignment.BottomCenter;
            button12.UseVisualStyleBackColor = true;
            button12.MouseDown += SecileneGore;
            // 
            // button13
            // 
            button13.ContextMenuStrip = contextMenuStrip1;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.ImageAlign = ContentAlignment.TopCenter;
            button13.ImageKey = "98.PNG";
            button13.ImageList = ımageList1;
            button13.Location = new Point(128, 485);
            button13.Name = "button13";
            button13.Size = new Size(75, 87);
            button13.TabIndex = 1;
            button13.Text = "MASA-12";
            button13.TextAlign = ContentAlignment.BottomCenter;
            button13.UseVisualStyleBackColor = true;
            button13.MouseDown += SecileneGore;
            // 
            // button14
            // 
            button14.ContextMenuStrip = contextMenuStrip1;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ImageAlign = ContentAlignment.TopCenter;
            button14.ImageKey = "98.PNG";
            button14.ImageList = ımageList1;
            button14.Location = new Point(242, 485);
            button14.Name = "button14";
            button14.Size = new Size(75, 87);
            button14.TabIndex = 2;
            button14.Text = "MASA-13";
            button14.TextAlign = ContentAlignment.BottomCenter;
            button14.UseVisualStyleBackColor = true;
            button14.MouseDown += SecileneGore;
            // 
            // button15
            // 
            button15.ContextMenuStrip = contextMenuStrip1;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.ImageAlign = ContentAlignment.TopCenter;
            button15.ImageKey = "98.PNG";
            button15.ImageList = ımageList1;
            button15.Location = new Point(361, 485);
            button15.Name = "button15";
            button15.Size = new Size(75, 87);
            button15.TabIndex = 3;
            button15.Text = "MASA-14";
            button15.TextAlign = ContentAlignment.BottomCenter;
            button15.UseVisualStyleBackColor = true;
            button15.MouseDown += SecileneGore;
            // 
            // button16
            // 
            button16.ContextMenuStrip = contextMenuStrip1;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.ImageAlign = ContentAlignment.TopCenter;
            button16.ImageKey = "98.PNG";
            button16.ImageList = ımageList1;
            button16.Location = new Point(482, 485);
            button16.Name = "button16";
            button16.Size = new Size(75, 87);
            button16.TabIndex = 4;
            button16.Text = "MASA-15";
            button16.TextAlign = ContentAlignment.BottomCenter;
            button16.UseVisualStyleBackColor = true;
            button16.MouseDown += SecileneGore;
            // 
            // button17
            // 
            button17.ContextMenuStrip = contextMenuStrip1;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.ImageAlign = ContentAlignment.TopCenter;
            button17.ImageKey = "98.PNG";
            button17.ImageList = ımageList1;
            button17.Location = new Point(598, 485);
            button17.Name = "button17";
            button17.Size = new Size(75, 87);
            button17.TabIndex = 5;
            button17.Text = "MASA-16";
            button17.TextAlign = ContentAlignment.BottomCenter;
            button17.UseVisualStyleBackColor = true;
            button17.MouseDown += SecileneGore;
            // 
            // button18
            // 
            button18.ContextMenuStrip = contextMenuStrip1;
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;
            button18.ImageAlign = ContentAlignment.TopCenter;
            button18.ImageKey = "98.PNG";
            button18.ImageList = ımageList1;
            button18.Location = new Point(714, 485);
            button18.Name = "button18";
            button18.Size = new Size(75, 87);
            button18.TabIndex = 6;
            button18.Text = "MASA-17";
            button18.TextAlign = ContentAlignment.BottomCenter;
            button18.UseVisualStyleBackColor = true;
            button18.MouseDown += SecileneGore;
            // 
            // button19
            // 
            button19.ContextMenuStrip = contextMenuStrip1;
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = FlatStyle.Flat;
            button19.ImageAlign = ContentAlignment.TopCenter;
            button19.ImageKey = "98.PNG";
            button19.ImageList = ımageList1;
            button19.Location = new Point(818, 485);
            button19.Name = "button19";
            button19.Size = new Size(75, 87);
            button19.TabIndex = 7;
            button19.Text = "MASA-18";
            button19.TextAlign = ContentAlignment.BottomCenter;
            button19.UseVisualStyleBackColor = true;
            button19.MouseDown += SecileneGore;
            // 
            // button20
            // 
            button20.ContextMenuStrip = contextMenuStrip1;
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatStyle = FlatStyle.Flat;
            button20.ImageAlign = ContentAlignment.TopCenter;
            button20.ImageKey = "98.PNG";
            button20.ImageList = ımageList1;
            button20.Location = new Point(920, 485);
            button20.Name = "button20";
            button20.Size = new Size(75, 87);
            button20.TabIndex = 8;
            button20.Text = "MASA-19";
            button20.TextAlign = ContentAlignment.BottomCenter;
            button20.UseVisualStyleBackColor = true;
            button20.MouseDown += SecileneGore;
            // 
            // button21
            // 
            button21.ContextMenuStrip = contextMenuStrip1;
            button21.FlatAppearance.BorderSize = 0;
            button21.FlatStyle = FlatStyle.Flat;
            button21.ImageAlign = ContentAlignment.TopCenter;
            button21.ImageKey = "98.PNG";
            button21.ImageList = ımageList1;
            button21.Location = new Point(1024, 485);
            button21.Name = "button21";
            button21.Size = new Size(75, 87);
            button21.TabIndex = 9;
            button21.Text = "MASA-20";
            button21.TextAlign = ContentAlignment.BottomCenter;
            button21.UseVisualStyleBackColor = true;
            button21.MouseDown += SecileneGore;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { HareketID, KullaniciID, _MasaID, Masa_, IstekTuru_, Aciklama_, Tarih_ });
            listView1.Location = new Point(23, 125);
            listView1.Name = "listView1";
            listView1.Size = new Size(981, 111);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Masa_ID, _Masa, AcilisTuru, BaslamaSaati, BitisSaati, Sure, Tutar, _Tarih, Hesapla, MasaKapat });
            dataGridView1.Location = new Point(23, 252);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(981, 195);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "SepetID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Masa_ID
            // 
            Masa_ID.DataPropertyName = "MasaID";
            Masa_ID.HeaderText = "Masa_ID";
            Masa_ID.Name = "Masa_ID";
            // 
            // _Masa
            // 
            _Masa.DataPropertyName = "Masa";
            _Masa.HeaderText = "_Masa";
            _Masa.Name = "_Masa";
            // 
            // AcilisTuru
            // 
            AcilisTuru.DataPropertyName = "AcilisTuru";
            AcilisTuru.HeaderText = "Açılış Türü";
            AcilisTuru.Name = "AcilisTuru";
            // 
            // BaslamaSaati
            // 
            BaslamaSaati.DataPropertyName = "Baslangic";
            BaslamaSaati.HeaderText = "Başlama Saati";
            BaslamaSaati.Name = "BaslamaSaati";
            // 
            // BitisSaati
            // 
            BitisSaati.HeaderText = "Btişi Saati";
            BitisSaati.Name = "BitisSaati";
            // 
            // Sure
            // 
            Sure.HeaderText = "Süre";
            Sure.Name = "Sure";
            // 
            // Tutar
            // 
            Tutar.HeaderText = "Tutar";
            Tutar.Name = "Tutar";
            // 
            // _Tarih
            // 
            _Tarih.DataPropertyName = "Tarih";
            _Tarih.HeaderText = "_Tarih";
            _Tarih.Name = "_Tarih";
            // 
            // Hesapla
            // 
            Hesapla.HeaderText = "Hesapla";
            Hesapla.Name = "Hesapla";
            Hesapla.Text = "Hesapla";
            Hesapla.ToolTipText = "Hesaplama yapar";
            Hesapla.UseColumnTextForButtonValue = true;
            // 
            // MasaKapat
            // 
            MasaKapat.HeaderText = "MasaKapat";
            MasaKapat.Name = "MasaKapat";
            MasaKapat.Text = "MasaKapat";
            MasaKapat.ToolTipText = "Masayı Kpatır";
            MasaKapat.UseColumnTextForButtonValue = true;
            // 
            // cmbBosMasalar
            // 
            cmbBosMasalar.FormattingEnabled = true;
            cmbBosMasalar.Location = new Point(1024, 217);
            cmbBosMasalar.Name = "cmbBosMasalar";
            cmbBosMasalar.Size = new Size(149, 23);
            cmbBosMasalar.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1024, 190);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 13;
            label1.Text = "Bos Masalar";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton7);
            panel1.Controls.Add(radioButton12);
            panel1.Controls.Add(radioButton6);
            panel1.Controls.Add(radioButton11);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton10);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton9);
            panel1.Controls.Add(radioButton8);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButtonSuresiz);
            panel1.Location = new Point(1027, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 159);
            panel1.TabIndex = 14;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(86, 3);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(37, 19);
            radioButton7.TabIndex = 6;
            radioButton7.TabStop = true;
            radioButton7.Text = "30";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += RadioButtonSeciliyeGore;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(86, 127);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(43, 19);
            radioButton12.TabIndex = 5;
            radioButton12.TabStop = true;
            radioButton12.Text = "180";
            radioButton12.UseVisualStyleBackColor = true;
            radioButton12.CheckedChanged += RadioButtonSeciliyeGore;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(3, 127);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(43, 19);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "165";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += RadioButtonSeciliyeGore;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(86, 102);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(43, 19);
            radioButton11.TabIndex = 4;
            radioButton11.TabStop = true;
            radioButton11.Text = "150";
            radioButton11.UseVisualStyleBackColor = true;
            radioButton11.CheckedChanged += RadioButtonSeciliyeGore;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(3, 102);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(43, 19);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "135";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += RadioButtonSeciliyeGore;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(86, 78);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(43, 19);
            radioButton10.TabIndex = 3;
            radioButton10.TabStop = true;
            radioButton10.Text = "120";
            radioButton10.UseVisualStyleBackColor = true;
            radioButton10.CheckedChanged += RadioButtonSeciliyeGore;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(3, 78);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(43, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "105";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += RadioButtonSeciliyeGore;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(86, 53);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(37, 19);
            radioButton9.TabIndex = 2;
            radioButton9.TabStop = true;
            radioButton9.Text = "90";
            radioButton9.UseVisualStyleBackColor = true;
            radioButton9.CheckedChanged += RadioButtonSeciliyeGore;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(86, 28);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(37, 19);
            radioButton8.TabIndex = 1;
            radioButton8.TabStop = true;
            radioButton8.Text = "60";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += RadioButtonSeciliyeGore;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(3, 53);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(37, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "75";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += RadioButtonSeciliyeGore;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 28);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(37, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "45";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += RadioButtonSeciliyeGore;
            // 
            // radioButtonSuresiz
            // 
            radioButtonSuresiz.AutoSize = true;
            radioButtonSuresiz.Location = new Point(3, 3);
            radioButtonSuresiz.Name = "radioButtonSuresiz";
            radioButtonSuresiz.Size = new Size(61, 19);
            radioButtonSuresiz.TabIndex = 0;
            radioButtonSuresiz.TabStop = true;
            radioButtonSuresiz.Text = "Süresiz";
            radioButtonSuresiz.UseVisualStyleBackColor = true;
            radioButtonSuresiz.CheckedChanged += RadioButtonSeciliyeGore;
            // 
            // btnMasaAc
            // 
            btnMasaAc.Location = new Point(1024, 411);
            btnMasaAc.Name = "btnMasaAc";
            btnMasaAc.Size = new Size(149, 78);
            btnMasaAc.TabIndex = 15;
            btnMasaAc.Text = "Masa Aç";
            btnMasaAc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1024, 133);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 17;
            label2.Text = "Saat Ücreti";
            // 
            // cmbSaatUcreti
            // 
            cmbSaatUcreti.FormattingEnabled = true;
            cmbSaatUcreti.Location = new Point(1024, 160);
            cmbSaatUcreti.Name = "cmbSaatUcreti";
            cmbSaatUcreti.Size = new Size(149, 23);
            cmbSaatUcreti.TabIndex = 16;
            cmbSaatUcreti.SelectedIndexChanged += cmbSaatUcreti_SelectedIndexChanged;
            // 
            // HareketID
            // 
            HareketID.Text = "İstek ID";
            // 
            // KullaniciID
            // 
            KullaniciID.Text = "KullanİCİ ID";
            // 
            // _MasaID
            // 
            _MasaID.Text = "Masa ID";
            // 
            // Masa_
            // 
            Masa_.Text = "Masa";
            // 
            // IstekTuru_
            // 
            IstekTuru_.Text = "İstek Türü";
            // 
            // Aciklama_
            // 
            Aciklama_.Text = "Açıklama";
            // 
            // Tarih_
            // 
            Tarih_.Text = "Tarih";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 584);
            Controls.Add(label2);
            Controls.Add(cmbSaatUcreti);
            Controls.Add(btnMasaAc);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(cmbBosMasalar);
            Controls.Add(dataGridView1);
            Controls.Add(listView1);
            Controls.Add(button21);
            Controls.Add(button10);
            Controls.Add(button20);
            Controls.Add(button9);
            Controls.Add(button19);
            Controls.Add(button8);
            Controls.Add(button18);
            Controls.Add(button7);
            Controls.Add(button17);
            Controls.Add(button6);
            Controls.Add(button16);
            Controls.Add(button5);
            Controls.Add(button15);
            Controls.Add(button4);
            Controls.Add(button14);
            Controls.Add(button3);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += SecileneGore;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private ListView listView1;
        private DataGridView dataGridView1;
        private ComboBox cmbBosMasalar;
        private Label label1;
        private Panel panel1;
        private RadioButton radioButton7;
        private RadioButton radioButton12;
        private RadioButton radioButton6;
        private RadioButton radioButton11;
        private RadioButton radioButton5;
        private RadioButton radioButton10;
        private RadioButton radioButton4;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButtonSuresiz;
        private Button btnMasaAc;
        private ImageList ımageList1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem yöneticiÇağırToolStripMenuItem;
        private ToolStripMenuItem süresizMasaAçmaİsteğiGönderToolStripMenuItem;
        private ToolStripMenuItem süreliMasaAçmaİsteğiGönderToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem masaDeğiştirmeİsteğiGönderToolStripMenuItem;
        private Label label2;
        private ComboBox cmbSaatUcreti;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Masa_ID;
        private DataGridViewTextBoxColumn _Masa;
        private DataGridViewTextBoxColumn AcilisTuru;
        private DataGridViewTextBoxColumn BaslamaSaati;
        private DataGridViewTextBoxColumn BitisSaati;
        private DataGridViewTextBoxColumn Sure;
        private DataGridViewTextBoxColumn Tutar;
        private DataGridViewTextBoxColumn _Tarih;
        private DataGridViewButtonColumn Hesapla;
        private DataGridViewButtonColumn MasaKapat;
        private ColumnHeader HareketID;
        private ColumnHeader KullaniciID;
        private ColumnHeader _MasaID;
        private ColumnHeader Masa_;
        private ColumnHeader IstekTuru_;
        private ColumnHeader Aciklama_;
        private ColumnHeader Tarih_;
    }
}
