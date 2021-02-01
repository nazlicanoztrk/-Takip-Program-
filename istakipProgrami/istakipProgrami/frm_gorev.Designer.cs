namespace istakipProgrami
{
    partial class frm_gorev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_gorev));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_kaydet = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cmb_gorevli = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txt_baslik = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Görevli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(162, 215);
            this.txt_aciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(471, 132);
            this.txt_aciklama.TabIndex = 5;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.btn_kaydet);
            this.bunifuGradientPanel1.Controls.Add(this.cmb_gorevli);
            this.bunifuGradientPanel1.Controls.Add(this.txt_baslik);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.txt_aciklama);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-4, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(660, 483);
            this.bunifuGradientPanel1.TabIndex = 7;
            this.bunifuGradientPanel1.Click += new System.EventHandler(this.bunifuGradientPanel1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(144, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 52);
            this.panel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 52);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.AllowAnimations = true;
            this.btn_kaydet.AllowMouseEffects = true;
            this.btn_kaydet.AllowToggling = false;
            this.btn_kaydet.AnimationSpeed = 200;
            this.btn_kaydet.AutoGenerateColors = false;
            this.btn_kaydet.AutoRoundBorders = false;
            this.btn_kaydet.AutoSizeLeftIcon = true;
            this.btn_kaydet.AutoSizeRightIcon = true;
            this.btn_kaydet.BackColor = System.Drawing.Color.Transparent;
            this.btn_kaydet.BackColor1 = System.Drawing.Color.SeaGreen;
            this.btn_kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.BackgroundImage")));
            this.btn_kaydet.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_kaydet.ButtonText = "Kaydet";
            this.btn_kaydet.ButtonTextMarginLeft = 0;
            this.btn_kaydet.ColorContrastOnClick = 45;
            this.btn_kaydet.ColorContrastOnHover = 45;
            this.btn_kaydet.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_kaydet.CustomizableEdges = borderEdges1;
            this.btn_kaydet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_kaydet.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_kaydet.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_kaydet.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_kaydet.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_kaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_kaydet.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_kaydet.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_kaydet.IconMarginLeft = 11;
            this.btn_kaydet.IconPadding = 10;
            this.btn_kaydet.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_kaydet.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_kaydet.IconSize = 25;
            this.btn_kaydet.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.btn_kaydet.IdleBorderRadius = 10;
            this.btn_kaydet.IdleBorderThickness = 5;
            this.btn_kaydet.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_kaydet.IdleIconLeftImage = null;
            this.btn_kaydet.IdleIconRightImage = null;
            this.btn_kaydet.IndicateFocus = false;
            this.btn_kaydet.Location = new System.Drawing.Point(290, 387);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_kaydet.OnDisabledState.BorderRadius = 10;
            this.btn_kaydet.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_kaydet.OnDisabledState.BorderThickness = 5;
            this.btn_kaydet.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_kaydet.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_kaydet.OnDisabledState.IconLeftImage = null;
            this.btn_kaydet.OnDisabledState.IconRightImage = null;
            this.btn_kaydet.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_kaydet.onHoverState.BorderRadius = 10;
            this.btn_kaydet.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_kaydet.onHoverState.BorderThickness = 5;
            this.btn_kaydet.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_kaydet.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_kaydet.onHoverState.IconLeftImage = null;
            this.btn_kaydet.onHoverState.IconRightImage = null;
            this.btn_kaydet.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_kaydet.OnIdleState.BorderRadius = 10;
            this.btn_kaydet.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_kaydet.OnIdleState.BorderThickness = 5;
            this.btn_kaydet.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_kaydet.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_kaydet.OnIdleState.IconLeftImage = null;
            this.btn_kaydet.OnIdleState.IconRightImage = null;
            this.btn_kaydet.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_kaydet.OnPressedState.BorderRadius = 10;
            this.btn_kaydet.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_kaydet.OnPressedState.BorderThickness = 5;
            this.btn_kaydet.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_kaydet.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_kaydet.OnPressedState.IconLeftImage = null;
            this.btn_kaydet.OnPressedState.IconRightImage = null;
            this.btn_kaydet.Size = new System.Drawing.Size(227, 51);
            this.btn_kaydet.TabIndex = 31;
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_kaydet.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_kaydet.TextMarginLeft = 0;
            this.btn_kaydet.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_kaydet.UseDefaultRadiusAndThickness = true;
            this.btn_kaydet.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // cmb_gorevli
            // 
            this.cmb_gorevli.BackColor = System.Drawing.Color.Transparent;
            this.cmb_gorevli.BackgroundColor = System.Drawing.Color.White;
            this.cmb_gorevli.BorderColor = System.Drawing.Color.Silver;
            this.cmb_gorevli.BorderRadius = 1;
            this.cmb_gorevli.Color = System.Drawing.Color.Silver;
            this.cmb_gorevli.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmb_gorevli.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_gorevli.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmb_gorevli.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_gorevli.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmb_gorevli.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmb_gorevli.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_gorevli.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmb_gorevli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gorevli.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_gorevli.FillDropDown = true;
            this.cmb_gorevli.FillIndicator = false;
            this.cmb_gorevli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_gorevli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_gorevli.ForeColor = System.Drawing.Color.Black;
            this.cmb_gorevli.FormattingEnabled = true;
            this.cmb_gorevli.Icon = null;
            this.cmb_gorevli.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_gorevli.IndicatorColor = System.Drawing.Color.Gray;
            this.cmb_gorevli.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_gorevli.ItemBackColor = System.Drawing.Color.White;
            this.cmb_gorevli.ItemBorderColor = System.Drawing.Color.White;
            this.cmb_gorevli.ItemForeColor = System.Drawing.Color.Black;
            this.cmb_gorevli.ItemHeight = 26;
            this.cmb_gorevli.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmb_gorevli.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmb_gorevli.ItemTopMargin = 3;
            this.cmb_gorevli.Location = new System.Drawing.Point(262, 139);
            this.cmb_gorevli.Name = "cmb_gorevli";
            this.cmb_gorevli.Size = new System.Drawing.Size(371, 32);
            this.cmb_gorevli.TabIndex = 30;
            this.cmb_gorevli.Text = null;
            this.cmb_gorevli.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_gorevli.TextLeftMargin = 5;
            // 
            // txt_baslik
            // 
            this.txt_baslik.AcceptsReturn = false;
            this.txt_baslik.AcceptsTab = false;
            this.txt_baslik.AnimationSpeed = 200;
            this.txt_baslik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_baslik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_baslik.BackColor = System.Drawing.Color.Transparent;
            this.txt_baslik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_baslik.BackgroundImage")));
            this.txt_baslik.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_baslik.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_baslik.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_baslik.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_baslik.BorderRadius = 25;
            this.txt_baslik.BorderThickness = 1;
            this.txt_baslik.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_baslik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_baslik.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_baslik.DefaultText = "";
            this.txt_baslik.FillColor = System.Drawing.Color.White;
            this.txt_baslik.HideSelection = true;
            this.txt_baslik.IconLeft = null;
            this.txt_baslik.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_baslik.IconPadding = 10;
            this.txt_baslik.IconRight = null;
            this.txt_baslik.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_baslik.Lines = new string[0];
            this.txt_baslik.Location = new System.Drawing.Point(144, 49);
            this.txt_baslik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_baslik.MaxLength = 32767;
            this.txt_baslik.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_baslik.Modified = false;
            this.txt_baslik.Multiline = false;
            this.txt_baslik.Name = "txt_baslik";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_baslik.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_baslik.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_baslik.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_baslik.OnIdleState = stateProperties4;
            this.txt_baslik.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_baslik.PasswordChar = '\0';
            this.txt_baslik.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_baslik.PlaceholderText = "Başlık";
            this.txt_baslik.ReadOnly = false;
            this.txt_baslik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_baslik.SelectedText = "";
            this.txt_baslik.SelectionLength = 0;
            this.txt_baslik.SelectionStart = 0;
            this.txt_baslik.ShortcutsEnabled = true;
            this.txt_baslik.Size = new System.Drawing.Size(503, 52);
            this.txt_baslik.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_baslik.TabIndex = 28;
            this.txt_baslik.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_baslik.TextMarginBottom = 0;
            this.txt_baslik.TextMarginLeft = 45;
            this.txt_baslik.TextMarginTop = 0;
            this.txt_baslik.TextPlaceholder = "Başlık";
            this.txt_baslik.UseSystemPasswordChar = false;
            this.txt_baslik.WordWrap = true;
            // 
            // frm_gorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 485);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_gorev";
            this.Text = "frm_gorev";
            this.Load += new System.EventHandler(this.frm_gorev_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_aciklama;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuTextBox txt_baslik;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_gorevli;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_kaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}