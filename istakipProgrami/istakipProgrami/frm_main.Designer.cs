namespace istakipProgrami
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.list_todo = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_progress = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list_done = new System.Windows.Forms.ListBox();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tahmin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_gecen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_seciliProje = new System.Windows.Forms.GroupBox();
            this.lbl_kullanici = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_projeYarat = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_projeler = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btn_gorevliEkle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_gorevEkle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_hareket = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // list_todo
            // 
            this.list_todo.BackColor = System.Drawing.SystemColors.Control;
            this.list_todo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_todo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_todo.FormattingEnabled = true;
            this.list_todo.ItemHeight = 16;
            this.list_todo.Location = new System.Drawing.Point(4, 19);
            this.list_todo.Margin = new System.Windows.Forms.Padding(4);
            this.list_todo.Name = "list_todo";
            this.list_todo.Size = new System.Drawing.Size(456, 784);
            this.list_todo.TabIndex = 1;
            this.list_todo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_todo_MouseDoubleClick);
            this.list_todo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_todo_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_todo);
            this.groupBox1.Location = new System.Drawing.Point(351, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(464, 807);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To Do";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_progress);
            this.groupBox2.Location = new System.Drawing.Point(845, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(464, 807);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "In Progress";
            // 
            // list_progress
            // 
            this.list_progress.AllowDrop = true;
            this.list_progress.BackColor = System.Drawing.SystemColors.Control;
            this.list_progress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_progress.FormattingEnabled = true;
            this.list_progress.ItemHeight = 16;
            this.list_progress.Location = new System.Drawing.Point(4, 19);
            this.list_progress.Margin = new System.Windows.Forms.Padding(4);
            this.list_progress.Name = "list_progress";
            this.list_progress.Size = new System.Drawing.Size(456, 784);
            this.list_progress.TabIndex = 1;
            this.list_progress.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_progress_DragDrop);
            this.list_progress.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_progress_DragEnter);
            this.list_progress.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_progress_MouseDoubleClick);
            this.list_progress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_progress_MouseDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.list_done);
            this.groupBox3.Location = new System.Drawing.Point(1317, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(464, 807);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Done";
            // 
            // list_done
            // 
            this.list_done.BackColor = System.Drawing.SystemColors.Control;
            this.list_done.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_done.FormattingEnabled = true;
            this.list_done.ItemHeight = 16;
            this.list_done.Location = new System.Drawing.Point(4, 19);
            this.list_done.Margin = new System.Windows.Forms.Padding(4);
            this.list_done.Name = "list_done";
            this.list_done.Size = new System.Drawing.Size(456, 784);
            this.list_done.TabIndex = 1;
            this.list_done.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_done_DragDrop);
            this.list_done.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_done_DragEnter);
            this.list_done.DoubleClick += new System.EventHandler(this.list_done_DoubleClick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.btn_hareket);
            this.bunifuGradientPanel1.Controls.Add(this.btn_gorevEkle);
            this.bunifuGradientPanel1.Controls.Add(this.btn_gorevliEkle);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_projeler);
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.btn_projeYarat);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_kullanici);
            this.bunifuGradientPanel1.Controls.Add(this.grp_seciliProje);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.groupBox4);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(320, 849);
            this.bunifuGradientPanel1.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_gecen);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lbl_tahmin);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(21, 477);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(295, 145);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Süre Hesaplama (DAKİKA)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tahmini Süre:";
            // 
            // lbl_tahmin
            // 
            this.lbl_tahmin.AutoSize = true;
            this.lbl_tahmin.Location = new System.Drawing.Point(121, 44);
            this.lbl_tahmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tahmin.Name = "lbl_tahmin";
            this.lbl_tahmin.Size = new System.Drawing.Size(20, 17);
            this.lbl_tahmin.TabIndex = 1;
            this.lbl_tahmin.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Geçen Süre:";
            // 
            // lbl_gecen
            // 
            this.lbl_gecen.AutoSize = true;
            this.lbl_gecen.Location = new System.Drawing.Point(120, 90);
            this.lbl_gecen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gecen.Name = "lbl_gecen";
            this.lbl_gecen.Size = new System.Drawing.Size(20, 17);
            this.lbl_gecen.TabIndex = 3;
            this.lbl_gecen.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Projelerim";
            // 
            // grp_seciliProje
            // 
            this.grp_seciliProje.Enabled = false;
            this.grp_seciliProje.Location = new System.Drawing.Point(22, 211);
            this.grp_seciliProje.Margin = new System.Windows.Forms.Padding(4);
            this.grp_seciliProje.Name = "grp_seciliProje";
            this.grp_seciliProje.Padding = new System.Windows.Forms.Padding(4);
            this.grp_seciliProje.Size = new System.Drawing.Size(295, 145);
            this.grp_seciliProje.TabIndex = 8;
            this.grp_seciliProje.TabStop = false;
            this.grp_seciliProje.Text = "Seçili Projeye;";
            // 
            // lbl_kullanici
            // 
            this.lbl_kullanici.AutoSize = true;
            this.lbl_kullanici.Location = new System.Drawing.Point(94, 55);
            this.lbl_kullanici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kullanici.Name = "lbl_kullanici";
            this.lbl_kullanici.Size = new System.Drawing.Size(46, 17);
            this.lbl_kullanici.TabIndex = 0;
            this.lbl_kullanici.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 852);
            this.panel1.TabIndex = 0;
            // 
            // btn_projeYarat
            // 
            this.btn_projeYarat.AllowAnimations = true;
            this.btn_projeYarat.AllowMouseEffects = true;
            this.btn_projeYarat.AllowToggling = false;
            this.btn_projeYarat.AnimationSpeed = 200;
            this.btn_projeYarat.AutoGenerateColors = false;
            this.btn_projeYarat.AutoRoundBorders = false;
            this.btn_projeYarat.AutoSizeLeftIcon = true;
            this.btn_projeYarat.AutoSizeRightIcon = true;
            this.btn_projeYarat.BackColor = System.Drawing.Color.Transparent;
            this.btn_projeYarat.BackColor1 = System.Drawing.Color.SeaGreen;
            this.btn_projeYarat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_projeYarat.BackgroundImage")));
            this.btn_projeYarat.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_projeYarat.ButtonText = "Yeni Proje Yarat";
            this.btn_projeYarat.ButtonTextMarginLeft = 0;
            this.btn_projeYarat.ColorContrastOnClick = 45;
            this.btn_projeYarat.ColorContrastOnHover = 45;
            this.btn_projeYarat.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_projeYarat.CustomizableEdges = borderEdges4;
            this.btn_projeYarat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_projeYarat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_projeYarat.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_projeYarat.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_projeYarat.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_projeYarat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_projeYarat.ForeColor = System.Drawing.Color.White;
            this.btn_projeYarat.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_projeYarat.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_projeYarat.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_projeYarat.IconMarginLeft = 11;
            this.btn_projeYarat.IconPadding = 10;
            this.btn_projeYarat.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_projeYarat.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_projeYarat.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_projeYarat.IconSize = 25;
            this.btn_projeYarat.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.btn_projeYarat.IdleBorderRadius = 10;
            this.btn_projeYarat.IdleBorderThickness = 5;
            this.btn_projeYarat.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_projeYarat.IdleIconLeftImage = null;
            this.btn_projeYarat.IdleIconRightImage = null;
            this.btn_projeYarat.IndicateFocus = false;
            this.btn_projeYarat.Location = new System.Drawing.Point(39, 100);
            this.btn_projeYarat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_projeYarat.Name = "btn_projeYarat";
            this.btn_projeYarat.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_projeYarat.OnDisabledState.BorderRadius = 10;
            this.btn_projeYarat.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_projeYarat.OnDisabledState.BorderThickness = 5;
            this.btn_projeYarat.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_projeYarat.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_projeYarat.OnDisabledState.IconLeftImage = null;
            this.btn_projeYarat.OnDisabledState.IconRightImage = null;
            this.btn_projeYarat.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_projeYarat.onHoverState.BorderRadius = 10;
            this.btn_projeYarat.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_projeYarat.onHoverState.BorderThickness = 5;
            this.btn_projeYarat.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_projeYarat.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_projeYarat.onHoverState.IconLeftImage = null;
            this.btn_projeYarat.onHoverState.IconRightImage = null;
            this.btn_projeYarat.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_projeYarat.OnIdleState.BorderRadius = 10;
            this.btn_projeYarat.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_projeYarat.OnIdleState.BorderThickness = 5;
            this.btn_projeYarat.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_projeYarat.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_projeYarat.OnIdleState.IconLeftImage = null;
            this.btn_projeYarat.OnIdleState.IconRightImage = null;
            this.btn_projeYarat.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_projeYarat.OnPressedState.BorderRadius = 10;
            this.btn_projeYarat.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_projeYarat.OnPressedState.BorderThickness = 5;
            this.btn_projeYarat.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_projeYarat.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_projeYarat.OnPressedState.IconLeftImage = null;
            this.btn_projeYarat.OnPressedState.IconRightImage = null;
            this.btn_projeYarat.Size = new System.Drawing.Size(267, 44);
            this.btn_projeYarat.TabIndex = 33;
            this.btn_projeYarat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_projeYarat.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_projeYarat.TextMarginLeft = 0;
            this.btn_projeYarat.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_projeYarat.UseDefaultRadiusAndThickness = true;
            this.btn_projeYarat.Click += new System.EventHandler(this.btn_yarat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(40, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(47, 42);
            this.panel2.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 42);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_projeler
            // 
            this.cmb_projeler.BackColor = System.Drawing.Color.Transparent;
            this.cmb_projeler.BackgroundColor = System.Drawing.Color.White;
            this.cmb_projeler.BorderColor = System.Drawing.Color.Silver;
            this.cmb_projeler.BorderRadius = 1;
            this.cmb_projeler.Color = System.Drawing.Color.Silver;
            this.cmb_projeler.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmb_projeler.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_projeler.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmb_projeler.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_projeler.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmb_projeler.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmb_projeler.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_projeler.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmb_projeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_projeler.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_projeler.FillDropDown = true;
            this.cmb_projeler.FillIndicator = false;
            this.cmb_projeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_projeler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_projeler.ForeColor = System.Drawing.Color.Black;
            this.cmb_projeler.FormattingEnabled = true;
            this.cmb_projeler.Icon = null;
            this.cmb_projeler.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_projeler.IndicatorColor = System.Drawing.Color.Gray;
            this.cmb_projeler.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_projeler.ItemBackColor = System.Drawing.Color.White;
            this.cmb_projeler.ItemBorderColor = System.Drawing.Color.White;
            this.cmb_projeler.ItemForeColor = System.Drawing.Color.Black;
            this.cmb_projeler.ItemHeight = 26;
            this.cmb_projeler.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmb_projeler.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmb_projeler.ItemTopMargin = 3;
            this.cmb_projeler.Location = new System.Drawing.Point(40, 166);
            this.cmb_projeler.Name = "cmb_projeler";
            this.cmb_projeler.Size = new System.Drawing.Size(260, 32);
            this.cmb_projeler.TabIndex = 35;
            this.cmb_projeler.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_projeler.TextLeftMargin = 5;
            this.cmb_projeler.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown1_SelectedIndexChanged);
            // 
            // btn_gorevliEkle
            // 
            this.btn_gorevliEkle.AllowAnimations = true;
            this.btn_gorevliEkle.AllowMouseEffects = true;
            this.btn_gorevliEkle.AllowToggling = false;
            this.btn_gorevliEkle.AnimationSpeed = 200;
            this.btn_gorevliEkle.AutoGenerateColors = false;
            this.btn_gorevliEkle.AutoRoundBorders = false;
            this.btn_gorevliEkle.AutoSizeLeftIcon = true;
            this.btn_gorevliEkle.AutoSizeRightIcon = true;
            this.btn_gorevliEkle.BackColor = System.Drawing.Color.Transparent;
            this.btn_gorevliEkle.BackColor1 = System.Drawing.Color.SeaGreen;
            this.btn_gorevliEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_gorevliEkle.BackgroundImage")));
            this.btn_gorevliEkle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gorevliEkle.ButtonText = "Görevli Ekle";
            this.btn_gorevliEkle.ButtonTextMarginLeft = 0;
            this.btn_gorevliEkle.ColorContrastOnClick = 45;
            this.btn_gorevliEkle.ColorContrastOnHover = 45;
            this.btn_gorevliEkle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_gorevliEkle.CustomizableEdges = borderEdges3;
            this.btn_gorevliEkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_gorevliEkle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_gorevliEkle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_gorevliEkle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_gorevliEkle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_gorevliEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_gorevliEkle.ForeColor = System.Drawing.Color.White;
            this.btn_gorevliEkle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gorevliEkle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_gorevliEkle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_gorevliEkle.IconMarginLeft = 11;
            this.btn_gorevliEkle.IconPadding = 10;
            this.btn_gorevliEkle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_gorevliEkle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_gorevliEkle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_gorevliEkle.IconSize = 25;
            this.btn_gorevliEkle.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.btn_gorevliEkle.IdleBorderRadius = 10;
            this.btn_gorevliEkle.IdleBorderThickness = 5;
            this.btn_gorevliEkle.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_gorevliEkle.IdleIconLeftImage = null;
            this.btn_gorevliEkle.IdleIconRightImage = null;
            this.btn_gorevliEkle.IndicateFocus = false;
            this.btn_gorevliEkle.Location = new System.Drawing.Point(29, 377);
            this.btn_gorevliEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_gorevliEkle.Name = "btn_gorevliEkle";
            this.btn_gorevliEkle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_gorevliEkle.OnDisabledState.BorderRadius = 10;
            this.btn_gorevliEkle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gorevliEkle.OnDisabledState.BorderThickness = 5;
            this.btn_gorevliEkle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_gorevliEkle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_gorevliEkle.OnDisabledState.IconLeftImage = null;
            this.btn_gorevliEkle.OnDisabledState.IconRightImage = null;
            this.btn_gorevliEkle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_gorevliEkle.onHoverState.BorderRadius = 10;
            this.btn_gorevliEkle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gorevliEkle.onHoverState.BorderThickness = 5;
            this.btn_gorevliEkle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_gorevliEkle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_gorevliEkle.onHoverState.IconLeftImage = null;
            this.btn_gorevliEkle.onHoverState.IconRightImage = null;
            this.btn_gorevliEkle.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_gorevliEkle.OnIdleState.BorderRadius = 10;
            this.btn_gorevliEkle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gorevliEkle.OnIdleState.BorderThickness = 5;
            this.btn_gorevliEkle.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_gorevliEkle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_gorevliEkle.OnIdleState.IconLeftImage = null;
            this.btn_gorevliEkle.OnIdleState.IconRightImage = null;
            this.btn_gorevliEkle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_gorevliEkle.OnPressedState.BorderRadius = 10;
            this.btn_gorevliEkle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gorevliEkle.OnPressedState.BorderThickness = 5;
            this.btn_gorevliEkle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_gorevliEkle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_gorevliEkle.OnPressedState.IconLeftImage = null;
            this.btn_gorevliEkle.OnPressedState.IconRightImage = null;
            this.btn_gorevliEkle.Size = new System.Drawing.Size(267, 44);
            this.btn_gorevliEkle.TabIndex = 36;
            this.btn_gorevliEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_gorevliEkle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_gorevliEkle.TextMarginLeft = 0;
            this.btn_gorevliEkle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_gorevliEkle.UseDefaultRadiusAndThickness = true;
            this.btn_gorevliEkle.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // btn_gorevEkle
            // 
            this.btn_gorevEkle.AllowAnimations = true;
            this.btn_gorevEkle.AllowMouseEffects = true;
            this.btn_gorevEkle.AllowToggling = false;
            this.btn_gorevEkle.AnimationSpeed = 200;
            this.btn_gorevEkle.AutoGenerateColors = false;
            this.btn_gorevEkle.AutoRoundBorders = false;
            this.btn_gorevEkle.AutoSizeLeftIcon = true;
            this.btn_gorevEkle.AutoSizeRightIcon = true;
            this.btn_gorevEkle.BackColor = System.Drawing.Color.Transparent;
            this.btn_gorevEkle.BackColor1 = System.Drawing.Color.SeaGreen;
            this.btn_gorevEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_gorevEkle.BackgroundImage")));
            this.btn_gorevEkle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gorevEkle.ButtonText = "Görev Ekle";
            this.btn_gorevEkle.ButtonTextMarginLeft = 0;
            this.btn_gorevEkle.ColorContrastOnClick = 45;
            this.btn_gorevEkle.ColorContrastOnHover = 45;
            this.btn_gorevEkle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_gorevEkle.CustomizableEdges = borderEdges2;
            this.btn_gorevEkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_gorevEkle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_gorevEkle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_gorevEkle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_gorevEkle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_gorevEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_gorevEkle.ForeColor = System.Drawing.Color.White;
            this.btn_gorevEkle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gorevEkle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_gorevEkle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_gorevEkle.IconMarginLeft = 11;
            this.btn_gorevEkle.IconPadding = 10;
            this.btn_gorevEkle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_gorevEkle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_gorevEkle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_gorevEkle.IconSize = 25;
            this.btn_gorevEkle.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.btn_gorevEkle.IdleBorderRadius = 10;
            this.btn_gorevEkle.IdleBorderThickness = 5;
            this.btn_gorevEkle.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_gorevEkle.IdleIconLeftImage = null;
            this.btn_gorevEkle.IdleIconRightImage = null;
            this.btn_gorevEkle.IndicateFocus = false;
            this.btn_gorevEkle.Location = new System.Drawing.Point(28, 427);
            this.btn_gorevEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_gorevEkle.Name = "btn_gorevEkle";
            this.btn_gorevEkle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_gorevEkle.OnDisabledState.BorderRadius = 10;
            this.btn_gorevEkle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gorevEkle.OnDisabledState.BorderThickness = 5;
            this.btn_gorevEkle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_gorevEkle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_gorevEkle.OnDisabledState.IconLeftImage = null;
            this.btn_gorevEkle.OnDisabledState.IconRightImage = null;
            this.btn_gorevEkle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_gorevEkle.onHoverState.BorderRadius = 10;
            this.btn_gorevEkle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gorevEkle.onHoverState.BorderThickness = 5;
            this.btn_gorevEkle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_gorevEkle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_gorevEkle.onHoverState.IconLeftImage = null;
            this.btn_gorevEkle.onHoverState.IconRightImage = null;
            this.btn_gorevEkle.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_gorevEkle.OnIdleState.BorderRadius = 10;
            this.btn_gorevEkle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gorevEkle.OnIdleState.BorderThickness = 5;
            this.btn_gorevEkle.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_gorevEkle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_gorevEkle.OnIdleState.IconLeftImage = null;
            this.btn_gorevEkle.OnIdleState.IconRightImage = null;
            this.btn_gorevEkle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_gorevEkle.OnPressedState.BorderRadius = 10;
            this.btn_gorevEkle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_gorevEkle.OnPressedState.BorderThickness = 5;
            this.btn_gorevEkle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_gorevEkle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_gorevEkle.OnPressedState.IconLeftImage = null;
            this.btn_gorevEkle.OnPressedState.IconRightImage = null;
            this.btn_gorevEkle.Size = new System.Drawing.Size(267, 44);
            this.btn_gorevEkle.TabIndex = 37;
            this.btn_gorevEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_gorevEkle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_gorevEkle.TextMarginLeft = 0;
            this.btn_gorevEkle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_gorevEkle.UseDefaultRadiusAndThickness = true;
            this.btn_gorevEkle.Click += new System.EventHandler(this.bunifuButton1_Click_1);
            // 
            // btn_hareket
            // 
            this.btn_hareket.AllowAnimations = true;
            this.btn_hareket.AllowMouseEffects = true;
            this.btn_hareket.AllowToggling = false;
            this.btn_hareket.AnimationSpeed = 200;
            this.btn_hareket.AutoGenerateColors = false;
            this.btn_hareket.AutoRoundBorders = false;
            this.btn_hareket.AutoSizeLeftIcon = true;
            this.btn_hareket.AutoSizeRightIcon = true;
            this.btn_hareket.BackColor = System.Drawing.Color.Transparent;
            this.btn_hareket.BackColor1 = System.Drawing.Color.SeaGreen;
            this.btn_hareket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hareket.BackgroundImage")));
            this.btn_hareket.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_hareket.ButtonText = "Görev Hareketleri";
            this.btn_hareket.ButtonTextMarginLeft = 0;
            this.btn_hareket.ColorContrastOnClick = 45;
            this.btn_hareket.ColorContrastOnHover = 45;
            this.btn_hareket.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_hareket.CustomizableEdges = borderEdges1;
            this.btn_hareket.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_hareket.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_hareket.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_hareket.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_hareket.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_hareket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_hareket.ForeColor = System.Drawing.Color.White;
            this.btn_hareket.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hareket.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_hareket.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_hareket.IconMarginLeft = 11;
            this.btn_hareket.IconPadding = 10;
            this.btn_hareket.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hareket.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_hareket.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_hareket.IconSize = 25;
            this.btn_hareket.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.btn_hareket.IdleBorderRadius = 10;
            this.btn_hareket.IdleBorderThickness = 5;
            this.btn_hareket.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_hareket.IdleIconLeftImage = null;
            this.btn_hareket.IdleIconRightImage = null;
            this.btn_hareket.IndicateFocus = false;
            this.btn_hareket.Location = new System.Drawing.Point(5, 658);
            this.btn_hareket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hareket.Name = "btn_hareket";
            this.btn_hareket.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_hareket.OnDisabledState.BorderRadius = 10;
            this.btn_hareket.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_hareket.OnDisabledState.BorderThickness = 5;
            this.btn_hareket.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_hareket.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_hareket.OnDisabledState.IconLeftImage = null;
            this.btn_hareket.OnDisabledState.IconRightImage = null;
            this.btn_hareket.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_hareket.onHoverState.BorderRadius = 10;
            this.btn_hareket.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_hareket.onHoverState.BorderThickness = 5;
            this.btn_hareket.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_hareket.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_hareket.onHoverState.IconLeftImage = null;
            this.btn_hareket.onHoverState.IconRightImage = null;
            this.btn_hareket.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_hareket.OnIdleState.BorderRadius = 10;
            this.btn_hareket.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_hareket.OnIdleState.BorderThickness = 5;
            this.btn_hareket.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_hareket.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_hareket.OnIdleState.IconLeftImage = null;
            this.btn_hareket.OnIdleState.IconRightImage = null;
            this.btn_hareket.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_hareket.OnPressedState.BorderRadius = 10;
            this.btn_hareket.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_hareket.OnPressedState.BorderThickness = 5;
            this.btn_hareket.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_hareket.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_hareket.OnPressedState.IconLeftImage = null;
            this.btn_hareket.OnPressedState.IconRightImage = null;
            this.btn_hareket.Size = new System.Drawing.Size(295, 50);
            this.btn_hareket.TabIndex = 38;
            this.btn_hareket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_hareket.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_hareket.TextMarginLeft = 0;
            this.btn_hareket.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_hareket.UseDefaultRadiusAndThickness = true;
            this.btn_hareket.Click += new System.EventHandler(this.bunifuButton1_Click_2);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 852);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_main_FormClosed);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox list_todo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_progress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox list_done;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbl_kullanici;
        private System.Windows.Forms.GroupBox grp_seciliProje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_gecen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_tahmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_projeYarat;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_projeler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_gorevliEkle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_gorevEkle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_hareket;
    }
}