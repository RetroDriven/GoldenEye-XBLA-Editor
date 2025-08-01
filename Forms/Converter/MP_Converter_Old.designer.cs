
namespace GoldenEye_XBLA_Editor
{
    partial class MP_Converter_Old
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP_Converter_Old));
            comboBox2 = new ComboBox();
            btnConvert = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            btnBrowse = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnBrowse2 = new Button();
            comboBox1 = new ComboBox();
            lblMapMP = new Label();
            lblMPLocation = new Label();
            lblUnique = new Label();
            txtUnique = new TextBox();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            comboBox2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Archives", "Basement", "Bunker", "Caverns", "Caves", "Complex", "Dam", "Depot", "Egyptian", "Facility", "Frigate", "Library", "Stack", "Temple" });
            comboBox2.Location = new Point(87, 41);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(141, 24);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // btnConvert
            // 
            btnConvert.Enabled = false;
            btnConvert.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvert.Location = new Point(168, 159);
            btnConvert.Margin = new Padding(2, 3, 2, 3);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(69, 34);
            btnConvert.TabIndex = 12;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "bin";
            saveFileDialog1.Filter = "\"Bin Files|*.bin\"";
            saveFileDialog1.InitialDirectory = "C:\\";
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "set";
            openFileDialog1.Filter = "Setup Files|*.set";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.RestoreDirectory = true;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.Location = new Point(12, 103);
            btnBrowse.Margin = new Padding(2, 3, 2, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(71, 22);
            btnBrowse.TabIndex = 8;
            btnBrowse.Text = "Xex File";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(88, 103);
            textBox4.Margin = new Padding(2, 3, 2, 3);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.RightToLeft = RightToLeft.No;
            textBox4.Size = new Size(248, 22);
            textBox4.TabIndex = 9;
            textBox4.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(89, 131);
            textBox5.Margin = new Padding(2, 3, 2, 3);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.RightToLeft = RightToLeft.No;
            textBox5.Size = new Size(247, 22);
            textBox5.TabIndex = 11;
            textBox5.TabStop = false;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse2.Location = new Point(12, 131);
            btnBrowse2.Margin = new Padding(2, 3, 2, 3);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(71, 22);
            btnBrowse2.TabIndex = 10;
            btnBrowse2.Text = "Set File";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Archives", "Aztec", "Basement", "Bunker", "Caverns", "Caves", "Complex", "Control", "Cradle", "Dam", "Depot", "Egyptian", "Facility", "Frigate", "Jungle", "Library", "Runway", "Silo", "Stack", "Statue", "Streets", "Surface 1", "Surface 2", "Temple", "Train" });
            comboBox1.Location = new Point(87, 13);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 24);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblMapMP
            // 
            lblMapMP.AutoSize = true;
            lblMapMP.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMapMP.Location = new Point(24, 16);
            lblMapMP.Margin = new Padding(2, 0, 2, 0);
            lblMapMP.Name = "lblMapMP";
            lblMapMP.Size = new Size(58, 16);
            lblMapMP.TabIndex = 45;
            lblMapMP.Text = "MP Map";
            // 
            // lblMPLocation
            // 
            lblMPLocation.AutoSize = true;
            lblMPLocation.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMPLocation.Location = new Point(25, 44);
            lblMPLocation.Margin = new Padding(2, 0, 2, 0);
            lblMPLocation.Name = "lblMPLocation";
            lblMPLocation.Size = new Size(56, 16);
            lblMPLocation.TabIndex = 4;
            lblMPLocation.Text = "MP Slot";
            // 
            // lblUnique
            // 
            lblUnique.AutoSize = true;
            lblUnique.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnique.Location = new Point(13, 75);
            lblUnique.Margin = new Padding(2, 0, 2, 0);
            lblUnique.Name = "lblUnique";
            lblUnique.Size = new Size(101, 16);
            lblUnique.TabIndex = 6;
            lblUnique.Text = "System Link ID";
            // 
            // txtUnique
            // 
            txtUnique.Enabled = false;
            txtUnique.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnique.Location = new Point(121, 72);
            txtUnique.Margin = new Padding(2, 3, 2, 3);
            txtUnique.MaxLength = 16;
            txtUnique.Name = "txtUnique";
            txtUnique.Size = new Size(141, 22);
            txtUnique.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(267, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 50000;
            toolTip1.InitialDelay = 500;
            toolTip1.IsBalloon = true;
            toolTip1.ReshowDelay = 100;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "System Link ID";
            // 
            // MP_Converter
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(409, 204);
            Controls.Add(pictureBox1);
            Controls.Add(txtUnique);
            Controls.Add(lblUnique);
            Controls.Add(comboBox2);
            Controls.Add(lblMPLocation);
            Controls.Add(lblMapMP);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(btnBrowse2);
            Controls.Add(textBox4);
            Controls.Add(btnBrowse);
            Controls.Add(btnConvert);
            Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MP_Converter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "N64 Map(Setup) Converter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox comboBox2;
        public Button btnConvert;
        public SaveFileDialog saveFileDialog1;
        public OpenFileDialog openFileDialog1;
        public Button btnBrowse;
        public TextBox textBox4;
        public TextBox textBox5;
        public Button btnBrowse2;
        public ComboBox comboBox1;
        public Label lblMapMP;
        public Label lblMPLocation;
        public Label lblUnique;
        public TextBox txtUnique;
        public PictureBox pictureBox1;
        public ToolTip toolTip1;
    }
}

