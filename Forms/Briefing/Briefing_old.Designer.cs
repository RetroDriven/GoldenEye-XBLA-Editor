
namespace GoldenEye_XBLA_Editor
{
    partial class Briefing_old
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Briefing_old));
            this.label1 = new System.Windows.Forms.Label();
            this.Map = new System.Windows.Forms.ComboBox();
            this.btnXex = new System.Windows.Forms.Button();
            this.btnBrf = new System.Windows.Forms.Button();
            this.XexFile = new System.Windows.Forms.TextBox();
            this.BrfFile = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Map";
            // 
            // Map
            // 
            this.Map.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Map.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Map.FormattingEnabled = true;
            this.Map.Items.AddRange(new object[] {
            "Archives",
            "Aztec",
            "Bunker 1",
            "Bunker 2",
            "Caverns",
            "Control",
            "Cradle",
            "Cuba(End Credits)",
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
            this.Map.Location = new System.Drawing.Point(52, 23);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(140, 25);
            this.Map.Sorted = true;
            this.Map.TabIndex = 1;
            this.Map.SelectedIndexChanged += new System.EventHandler(this.Map_SelectedIndexChanged);
            // 
            // btnXex
            // 
            this.btnXex.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXex.Location = new System.Drawing.Point(12, 80);
            this.btnXex.Name = "btnXex";
            this.btnXex.Size = new System.Drawing.Size(72, 25);
            this.btnXex.TabIndex = 2;
            this.btnXex.Text = "Xex";
            this.btnXex.UseVisualStyleBackColor = true;
            this.btnXex.Click += new System.EventHandler(this.btnXex_Click);
            // 
            // btnBrf
            // 
            this.btnBrf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrf.Location = new System.Drawing.Point(12, 121);
            this.btnBrf.Name = "btnBrf";
            this.btnBrf.Size = new System.Drawing.Size(72, 25);
            this.btnBrf.TabIndex = 3;
            this.btnBrf.Text = "Brf";
            this.btnBrf.UseVisualStyleBackColor = true;
            this.btnBrf.Click += new System.EventHandler(this.btnBrf_Click);
            // 
            // XexFile
            // 
            this.XexFile.Location = new System.Drawing.Point(90, 82);
            this.XexFile.Name = "XexFile";
            this.XexFile.ReadOnly = true;
            this.XexFile.Size = new System.Drawing.Size(199, 25);
            this.XexFile.TabIndex = 4;
            // 
            // BrfFile
            // 
            this.BrfFile.Location = new System.Drawing.Point(90, 123);
            this.BrfFile.Name = "BrfFile";
            this.BrfFile.ReadOnly = true;
            this.BrfFile.Size = new System.Drawing.Size(199, 25);
            this.BrfFile.TabIndex = 5;
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(139, 166);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(72, 25);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Briefing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(357, 205);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.BrfFile);
            this.Controls.Add(this.XexFile);
            this.Controls.Add(this.btnBrf);
            this.Controls.Add(this.btnXex);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Briefing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Briefing Importer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Map;
        public System.Windows.Forms.Button btnXex;
        public System.Windows.Forms.Button btnBrf;
        public System.Windows.Forms.TextBox XexFile;
        public System.Windows.Forms.TextBox BrfFile;
        public System.Windows.Forms.Button btnImport;
    }
}