
namespace GoldenEye_XBLA_Editor
{
    partial class SP_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SP_Converter));
            this.btnConvert = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblMapSP = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(167, 101);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(69, 34);
            this.btnConvert.TabIndex = 12;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bin";
            this.saveFileDialog1.Filter = "\"Bin Files|*.bin\"";
            this.saveFileDialog1.InitialDirectory = "C:\\";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "set";
            this.openFileDialog1.Filter = "Setup Files|*.set";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(11, 45);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(71, 22);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Xex File";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(87, 45);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox4.Size = new System.Drawing.Size(248, 26);
            this.textBox4.TabIndex = 9;
            this.textBox4.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(88, 73);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox5.Size = new System.Drawing.Size(247, 26);
            this.textBox5.TabIndex = 11;
            this.textBox5.TabStop = false;
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse2.Location = new System.Drawing.Point(11, 73);
            this.btnBrowse2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(71, 22);
            this.btnBrowse2.TabIndex = 10;
            this.btnBrowse2.Text = "Set File";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Archives",
            "Aztec",
            "Bunker 1",
            "Bunker 2",
            "Caverns",
            "Control",
            "Cradle",
            "Dam",
            "Depot",
            "Egyptian",
            "Facility",
            "Frigate",
            "Jungle",
            "Runway",
            "Silo",
            "Statue",
            "Streets",
            "Surface 1",
            "Surface 2",
            "Train"});
            this.comboBox3.Location = new System.Drawing.Point(86, 9);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(141, 26);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblMapSP
            // 
            this.lblMapSP.AutoSize = true;
            this.lblMapSP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapSP.Location = new System.Drawing.Point(13, 9);
            this.lblMapSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMapSP.Name = "lblMapSP";
            this.lblMapSP.Size = new System.Drawing.Size(68, 19);
            this.lblMapSP.TabIndex = 2;
            this.lblMapSP.Text = "SP Map";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "System Link ID";
            // 
            // SP_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(416, 146);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.lblMapSP);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnConvert);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SP_Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N64 Map(Setup) Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnConvert;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Button btnBrowse;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.Button btnBrowse2;
        public System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.Label lblMapSP;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}

