
namespace VeritabaniProje2B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDegistir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBirimara = new System.Windows.Forms.ComboBox();
            this.chkBirim = new System.Windows.Forms.CheckBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbDyerara = new System.Windows.Forms.ComboBox();
            this.txtSoyadara = new System.Windows.Forms.TextBox();
            this.chkDyer = new System.Windows.Forms.CheckBox();
            this.chkSoyad = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblArananalan = new System.Windows.Forms.Label();
            this.txtHizliara = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radTel = new System.Windows.Forms.RadioButton();
            this.radAd = new System.Windows.Forms.RadioButton();
            this.radSoyad = new System.Windows.Forms.RadioButton();
            this.radTcno = new System.Windows.Forms.RadioButton();
            this.cmbAramaturu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güvenlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayrııntılıListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEkle,
            this.toolStripSeparator1,
            this.btnSil,
            this.toolStripSeparator2,
            this.btnDegistir,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 523);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1209, 55);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 52);
            this.btnEkle.Text = "Kayıt Ekle";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(86, 52);
            this.btnSil.Text = "Kayıt Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.Image")));
            this.btnDegistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(133, 52);
            this.btnDegistir.Text = "Kayıt Değiştir";
            this.btnDegistir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBirimara);
            this.groupBox1.Controls.Add(this.chkBirim);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.cmbDyerara);
            this.groupBox1.Controls.Add(this.txtSoyadara);
            this.groupBox1.Controls.Add(this.chkDyer);
            this.groupBox1.Controls.Add(this.chkSoyad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(837, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(356, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // cmbBirimara
            // 
            this.cmbBirimara.Enabled = false;
            this.cmbBirimara.FormattingEnabled = true;
            this.cmbBirimara.Location = new System.Drawing.Point(196, 124);
            this.cmbBirimara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBirimara.Name = "cmbBirimara";
            this.cmbBirimara.Size = new System.Drawing.Size(139, 33);
            this.cmbBirimara.TabIndex = 6;
            // 
            // chkBirim
            // 
            this.chkBirim.AutoSize = true;
            this.chkBirim.Location = new System.Drawing.Point(29, 129);
            this.chkBirim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBirim.Name = "chkBirim";
            this.chkBirim.Size = new System.Drawing.Size(77, 29);
            this.chkBirim.TabIndex = 5;
            this.chkBirim.Text = "Birim";
            this.chkBirim.UseVisualStyleBackColor = true;
            this.chkBirim.CheckedChanged += new System.EventHandler(this.chkBirim_CheckedChanged);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(121, 166);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(121, 41);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbDyerara
            // 
            this.cmbDyerara.Enabled = false;
            this.cmbDyerara.FormattingEnabled = true;
            this.cmbDyerara.Items.AddRange(new object[] {
            "Ankara",
            "Bolu",
            "İstanbul",
            "İzmir",
            "Kastamonu",
            "Zonguldak"});
            this.cmbDyerara.Location = new System.Drawing.Point(197, 81);
            this.cmbDyerara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDyerara.Name = "cmbDyerara";
            this.cmbDyerara.Size = new System.Drawing.Size(137, 33);
            this.cmbDyerara.TabIndex = 3;
            // 
            // txtSoyadara
            // 
            this.txtSoyadara.Enabled = false;
            this.txtSoyadara.Location = new System.Drawing.Point(197, 41);
            this.txtSoyadara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyadara.Name = "txtSoyadara";
            this.txtSoyadara.Size = new System.Drawing.Size(137, 30);
            this.txtSoyadara.TabIndex = 2;
            // 
            // chkDyer
            // 
            this.chkDyer.AutoSize = true;
            this.chkDyer.Location = new System.Drawing.Point(29, 86);
            this.chkDyer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDyer.Name = "chkDyer";
            this.chkDyer.Size = new System.Drawing.Size(136, 29);
            this.chkDyer.TabIndex = 1;
            this.chkDyer.Text = "Doğum Yeri";
            this.chkDyer.UseVisualStyleBackColor = true;
            this.chkDyer.CheckedChanged += new System.EventHandler(this.chkDyer_CheckedChanged);
            // 
            // chkSoyad
            // 
            this.chkSoyad.AutoSize = true;
            this.chkSoyad.Location = new System.Drawing.Point(29, 43);
            this.chkSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSoyad.Name = "chkSoyad";
            this.chkSoyad.Size = new System.Drawing.Size(91, 29);
            this.chkSoyad.TabIndex = 0;
            this.chkSoyad.Text = "Soyad";
            this.chkSoyad.UseVisualStyleBackColor = true;
            this.chkSoyad.CheckedChanged += new System.EventHandler(this.chkSoyad_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.lblArananalan);
            this.groupBox2.Controls.Add(this.txtHizliara);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cmbAramaturu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(837, 288);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(355, 276);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı Arama";
            // 
            // lblArananalan
            // 
            this.lblArananalan.AutoSize = true;
            this.lblArananalan.Location = new System.Drawing.Point(24, 224);
            this.lblArananalan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArananalan.Name = "lblArananalan";
            this.lblArananalan.Size = new System.Drawing.Size(76, 25);
            this.lblArananalan.TabIndex = 4;
            this.lblArananalan.Text = "Tc No :";
            // 
            // txtHizliara
            // 
            this.txtHizliara.Location = new System.Drawing.Point(145, 220);
            this.txtHizliara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHizliara.Name = "txtHizliara";
            this.txtHizliara.Size = new System.Drawing.Size(189, 30);
            this.txtHizliara.TabIndex = 3;
            this.txtHizliara.TextChanged += new System.EventHandler(this.txtHizliara_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox3.Controls.Add(this.radTel);
            this.groupBox3.Controls.Add(this.radAd);
            this.groupBox3.Controls.Add(this.radSoyad);
            this.groupBox3.Controls.Add(this.radTcno);
            this.groupBox3.Location = new System.Drawing.Point(28, 100);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(307, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // radTel
            // 
            this.radTel.AutoSize = true;
            this.radTel.Location = new System.Drawing.Point(168, 22);
            this.radTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTel.Name = "radTel";
            this.radTel.Size = new System.Drawing.Size(99, 29);
            this.radTel.TabIndex = 2;
            this.radTel.TabStop = true;
            this.radTel.Text = "Telefon";
            this.radTel.UseVisualStyleBackColor = true;
            this.radTel.CheckedChanged += new System.EventHandler(this.radTel_CheckedChanged);
            // 
            // radAd
            // 
            this.radAd.AutoSize = true;
            this.radAd.Location = new System.Drawing.Point(28, 63);
            this.radAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radAd.Name = "radAd";
            this.radAd.Size = new System.Drawing.Size(58, 29);
            this.radAd.TabIndex = 1;
            this.radAd.TabStop = true;
            this.radAd.Text = "Ad";
            this.radAd.UseVisualStyleBackColor = true;
            this.radAd.CheckedChanged += new System.EventHandler(this.radAd_CheckedChanged);
            // 
            // radSoyad
            // 
            this.radSoyad.AutoSize = true;
            this.radSoyad.Location = new System.Drawing.Point(168, 63);
            this.radSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSoyad.Name = "radSoyad";
            this.radSoyad.Size = new System.Drawing.Size(90, 29);
            this.radSoyad.TabIndex = 0;
            this.radSoyad.Text = "Soyad";
            this.radSoyad.UseVisualStyleBackColor = true;
            this.radSoyad.CheckedChanged += new System.EventHandler(this.radSoyad_CheckedChanged);
            // 
            // radTcno
            // 
            this.radTcno.AutoSize = true;
            this.radTcno.Checked = true;
            this.radTcno.Location = new System.Drawing.Point(28, 22);
            this.radTcno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTcno.Name = "radTcno";
            this.radTcno.Size = new System.Drawing.Size(86, 29);
            this.radTcno.TabIndex = 0;
            this.radTcno.TabStop = true;
            this.radTcno.Text = "Tc No";
            this.radTcno.UseVisualStyleBackColor = true;
            this.radTcno.CheckedChanged += new System.EventHandler(this.radTcno_CheckedChanged);
            // 
            // cmbAramaturu
            // 
            this.cmbAramaturu.FormattingEnabled = true;
            this.cmbAramaturu.Items.AddRange(new object[] {
            "İle Başlayan",
            "İle Biten",
            "İçeren"});
            this.cmbAramaturu.Location = new System.Drawing.Point(155, 44);
            this.cmbAramaturu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAramaturu.Name = "cmbAramaturu";
            this.cmbAramaturu.Size = new System.Drawing.Size(180, 33);
            this.cmbAramaturu.TabIndex = 1;
            this.cmbAramaturu.Text = "İle Başlayan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Türü";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlamalarToolStripMenuItem,
            this.güvenlikToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.birimTanımlamaToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // birimTanımlamaToolStripMenuItem
            // 
            this.birimTanımlamaToolStripMenuItem.Name = "birimTanımlamaToolStripMenuItem";
            this.birimTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.birimTanımlamaToolStripMenuItem.Text = "Birim Tanımlama";
            this.birimTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.birimTanımlamaToolStripMenuItem_Click);
            // 
            // güvenlikToolStripMenuItem
            // 
            this.güvenlikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıİşlemleriToolStripMenuItem});
            this.güvenlikToolStripMenuItem.Name = "güvenlikToolStripMenuItem";
            this.güvenlikToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.güvenlikToolStripMenuItem.Text = "Güvenlik";
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            this.kullanıcıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıİşlemleriToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelListesiToolStripMenuItem,
            this.kullanıcıListesiToolStripMenuItem});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // personelListesiToolStripMenuItem
            // 
            this.personelListesiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelListeToolStripMenuItem,
            this.ayrııntılıListeToolStripMenuItem});
            this.personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            this.personelListesiToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.personelListesiToolStripMenuItem.Text = "Personel Listesi";
            // 
            // genelListeToolStripMenuItem
            // 
            this.genelListeToolStripMenuItem.Name = "genelListeToolStripMenuItem";
            this.genelListeToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.genelListeToolStripMenuItem.Text = "Genel Liste";
            this.genelListeToolStripMenuItem.Click += new System.EventHandler(this.genelListeToolStripMenuItem_Click);
            // 
            // ayrııntılıListeToolStripMenuItem
            // 
            this.ayrııntılıListeToolStripMenuItem.Name = "ayrııntılıListeToolStripMenuItem";
            this.ayrııntılıListeToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.ayrııntılıListeToolStripMenuItem.Text = "Ayrııntılı Liste";
            this.ayrııntılıListeToolStripMenuItem.Click += new System.EventHandler(this.ayrııntılıListeToolStripMenuItem_Click);
            // 
            // kullanıcıListesiToolStripMenuItem
            // 
            this.kullanıcıListesiToolStripMenuItem.Name = "kullanıcıListesiToolStripMenuItem";
            this.kullanıcıListesiToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.kullanıcıListesiToolStripMenuItem.Text = "Kullanıcı Listesi";
            this.kullanıcıListesiToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıListesiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 578);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEkle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDegistir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoyadara;
        private System.Windows.Forms.CheckBox chkDyer;
        private System.Windows.Forms.CheckBox chkSoyad;
        private System.Windows.Forms.ComboBox cmbDyerara;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbBirimara;
        private System.Windows.Forms.CheckBox chkBirim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbAramaturu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblArananalan;
        private System.Windows.Forms.TextBox txtHizliara;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radSoyad;
        private System.Windows.Forms.RadioButton radTcno;
        private System.Windows.Forms.RadioButton radAd;
        private System.Windows.Forms.RadioButton radTel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güvenlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genelListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayrııntılıListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıListesiToolStripMenuItem;
    }
}

