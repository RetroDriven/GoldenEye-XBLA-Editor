namespace GoldenEye_XBLA_Editor.Controls
{
    partial class SP_Setup_Converter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SP_Setup_Converter));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            openFileDialog1 = new OpenFileDialog();
            btnConvert = new Guna.UI2.WinForms.Guna2Button();
            SP_Map = new Guna.UI2.WinForms.Guna2ComboBox();
            textBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            btnBrowse2 = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            saveFileDialog1 = new SaveFileDialog();
            label1 = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            tableLayoutPanel1 = new TableLayoutPanel();
            Panel_Top = new Panel();
            Panel_Right = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label6 = new Label();
            guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            Panel_Left = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            Panel_Top.SuspendLayout();
            Panel_Right.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            Panel_Left.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "set";
            openFileDialog1.Filter = "Setup Files|*.set";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.RestoreDirectory = true;
            // 
            // btnConvert
            // 
            btnConvert.AutoRoundedCorners = true;
            btnConvert.BorderRadius = 21;
            btnConvert.Cursor = Cursors.Hand;
            btnConvert.CustomizableEdges = customizableEdges1;
            btnConvert.DisabledState.BorderColor = Color.DarkGray;
            btnConvert.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConvert.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConvert.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConvert.Enabled = false;
            btnConvert.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvert.ForeColor = Color.White;
            btnConvert.Location = new Point(169, 103);
            btnConvert.Margin = new Padding(75, 3, 3, 3);
            btnConvert.Name = "btnConvert";
            btnConvert.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnConvert.Size = new Size(88, 44);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "Convert";
            btnConvert.Click += btnConvert_Click;
            // 
            // SP_Map
            // 
            SP_Map.Anchor = AnchorStyles.Left;
            SP_Map.AutoRoundedCorners = true;
            SP_Map.BackColor = Color.Transparent;
            SP_Map.BorderRadius = 17;
            SP_Map.Cursor = Cursors.Hand;
            SP_Map.CustomizableEdges = customizableEdges3;
            SP_Map.DrawMode = DrawMode.OwnerDrawFixed;
            SP_Map.DropDownStyle = ComboBoxStyle.DropDownList;
            SP_Map.FillColor = Color.FromArgb(39, 44, 66);
            SP_Map.FocusedColor = Color.Empty;
            SP_Map.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            SP_Map.ForeColor = SystemColors.ControlLightLight;
            SP_Map.ItemHeight = 30;
            SP_Map.Items.AddRange(new object[] { "Archives", "Aztec", "Bunker 1", "Bunker 2", "Caverns", "Control", "Cradle", "Dam", "Depot", "Egyptian", "Facility", "Frigate", "Jungle", "Runway", "Silo", "Statue", "Streets", "Surface 1", "Surface 2", "Train" });
            SP_Map.ItemsAppearance.SelectedBackColor = Color.FromArgb(94, 148, 255);
            SP_Map.Location = new Point(138, 3);
            SP_Map.Name = "SP_Map";
            SP_Map.ShadowDecoration.CustomizableEdges = customizableEdges4;
            SP_Map.Size = new Size(218, 36);
            SP_Map.TabIndex = 4;
            SP_Map.SelectedIndexChanged += SP_Map_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left;
            textBox4.AutoRoundedCorners = true;
            textBox4.BackColor = Color.Transparent;
            textBox4.BorderRadius = 16;
            textBox4.Cursor = Cursors.IBeam;
            textBox4.CustomizableEdges = customizableEdges5;
            textBox4.DefaultText = "";
            textBox4.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBox4.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBox4.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBox4.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBox4.FillColor = Color.FromArgb(39, 44, 66);
            textBox4.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.ControlLightLight;
            textBox4.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox4.Location = new Point(98, 7);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '\0';
            textBox4.PlaceholderText = "";
            textBox4.ReadOnly = true;
            textBox4.SelectedText = "";
            textBox4.ShadowDecoration.CustomizableEdges = customizableEdges6;
            textBox4.Size = new Size(253, 35);
            textBox4.TabIndex = 7;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Left;
            btnBrowse.AutoRoundedCorners = true;
            btnBrowse.BorderRadius = 21;
            btnBrowse.Cursor = Cursors.Hand;
            btnBrowse.CustomizableEdges = customizableEdges7;
            btnBrowse.DisabledState.BorderColor = Color.DarkGray;
            btnBrowse.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBrowse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBrowse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBrowse.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(3, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnBrowse.Size = new Size(88, 44);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Xex File";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Anchor = AnchorStyles.Left;
            btnBrowse2.AutoRoundedCorners = true;
            btnBrowse2.BorderRadius = 21;
            btnBrowse2.Cursor = Cursors.Hand;
            btnBrowse2.CustomizableEdges = customizableEdges9;
            btnBrowse2.DisabledState.BorderColor = Color.DarkGray;
            btnBrowse2.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBrowse2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBrowse2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBrowse2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse2.ForeColor = Color.White;
            btnBrowse2.Location = new Point(3, 53);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnBrowse2.Size = new Size(88, 44);
            btnBrowse2.TabIndex = 1;
            btnBrowse2.Text = "Set File";
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 7;
            label2.Text = "Singleplayer Map";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(textBox5, 1, 1);
            tableLayoutPanel2.Controls.Add(textBox4, 1, 0);
            tableLayoutPanel2.Controls.Add(btnBrowse, 0, 0);
            tableLayoutPanel2.Controls.Add(btnBrowse2, 0, 1);
            tableLayoutPanel2.Controls.Add(btnConvert, 1, 2);
            tableLayoutPanel2.Location = new Point(3, 111);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(355, 150);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left;
            textBox5.AutoRoundedCorners = true;
            textBox5.BackColor = Color.Transparent;
            textBox5.BorderRadius = 16;
            textBox5.Cursor = Cursors.IBeam;
            textBox5.CustomizableEdges = customizableEdges11;
            textBox5.DefaultText = "";
            textBox5.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBox5.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBox5.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBox5.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBox5.FillColor = Color.FromArgb(39, 44, 66);
            textBox5.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = SystemColors.ControlLightLight;
            textBox5.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox5.Location = new Point(98, 57);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '\0';
            textBox5.PlaceholderText = "";
            textBox5.ReadOnly = true;
            textBox5.SelectedText = "";
            textBox5.ShadowDecoration.CustomizableEdges = customizableEdges12;
            textBox5.Size = new Size(253, 35);
            textBox5.TabIndex = 8;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "bin";
            saveFileDialog1.Filter = "\"Bin Files|*.bin\"";
            saveFileDialog1.InitialDirectory = "C:\\";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 19, 0, 0);
            label1.Size = new Size(274, 44);
            label1.TabIndex = 4;
            label1.Text = "Singleplayer Setup Converter";
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(3, 47);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(275, 10);
            guna2Separator1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(SP_Map, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 63);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(359, 42);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // Panel_Top
            // 
            Panel_Top.AutoSize = true;
            Panel_Top.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Panel_Top.Controls.Add(Panel_Right);
            Panel_Top.Controls.Add(Panel_Left);
            Panel_Top.Dock = DockStyle.Fill;
            Panel_Top.Location = new Point(0, 0);
            Panel_Top.Name = "Panel_Top";
            Panel_Top.Size = new Size(863, 280);
            Panel_Top.TabIndex = 1;
            // 
            // Panel_Right
            // 
            Panel_Right.Controls.Add(flowLayoutPanel2);
            Panel_Right.Dock = DockStyle.Fill;
            Panel_Right.Location = new Point(384, 0);
            Panel_Right.Name = "Panel_Right";
            Panel_Right.Padding = new Padding(66, 0, 0, 0);
            Panel_Right.Size = new Size(479, 280);
            Panel_Right.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Controls.Add(guna2Separator4);
            flowLayoutPanel2.Controls.Add(guna2TextBox4);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(38, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(0, 19, 0, 0);
            flowLayoutPanel2.Size = new Size(438, 248);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 19);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 5;
            label6.Text = "Usage Info";
            // 
            // guna2Separator4
            // 
            guna2Separator4.Location = new Point(3, 47);
            guna2Separator4.Name = "guna2Separator4";
            guna2Separator4.Size = new Size(108, 10);
            guna2Separator4.TabIndex = 3;
            // 
            // guna2TextBox4
            // 
            guna2TextBox4.BorderRadius = 22;
            guna2TextBox4.CustomizableEdges = customizableEdges13;
            guna2TextBox4.DefaultText = resources.GetString("guna2TextBox4.DefaultText");
            guna2TextBox4.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox4.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox4.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox4.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox4.FillColor = Color.FromArgb(39, 44, 66);
            guna2TextBox4.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            guna2TextBox4.ForeColor = SystemColors.ControlLightLight;
            guna2TextBox4.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox4.Location = new Point(4, 64);
            guna2TextBox4.Margin = new Padding(4);
            guna2TextBox4.Multiline = true;
            guna2TextBox4.Name = "guna2TextBox4";
            guna2TextBox4.PasswordChar = '\0';
            guna2TextBox4.PlaceholderText = "";
            guna2TextBox4.ReadOnly = true;
            guna2TextBox4.SelectedText = "";
            guna2TextBox4.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2TextBox4.Size = new Size(430, 180);
            guna2TextBox4.TabIndex = 6;
            // 
            // Panel_Left
            // 
            Panel_Left.Controls.Add(flowLayoutPanel1);
            Panel_Left.Dock = DockStyle.Left;
            Panel_Left.Location = new Point(0, 0);
            Panel_Left.Name = "Panel_Left";
            Panel_Left.Size = new Size(384, 280);
            Panel_Left.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(guna2Separator1);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(365, 264);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // SP_Setup_Converter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(59, 62, 78);
            Controls.Add(Panel_Top);
            ForeColor = SystemColors.ControlLightLight;
            Name = "SP_Setup_Converter";
            Size = new Size(863, 280);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            Panel_Top.ResumeLayout(false);
            Panel_Right.ResumeLayout(false);
            Panel_Right.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            Panel_Left.ResumeLayout(false);
            Panel_Left.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public OpenFileDialog openFileDialog1;
        public Guna.UI2.WinForms.Guna2Button btnConvert;
        public Guna.UI2.WinForms.Guna2ComboBox SP_Map;
        public Guna.UI2.WinForms.Guna2TextBox textBox4;
        public Guna.UI2.WinForms.Guna2Button btnBrowse;
        public Guna.UI2.WinForms.Guna2Button btnBrowse2;
        private Label label2;
        public TableLayoutPanel tableLayoutPanel2;
        public Guna.UI2.WinForms.Guna2TextBox textBox5;
        public SaveFileDialog saveFileDialog1;
        private Label label1;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public TableLayoutPanel tableLayoutPanel1;
        public Panel Panel_Top;
        private Panel Panel_Left;
        public FlowLayoutPanel flowLayoutPanel1;
        public FlowLayoutPanel flowLayoutPanel2;
        private Label label6;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Panel Panel_Right;
    }
}
