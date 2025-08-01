namespace GoldenEye_XBLA_Editor.Forms
{
    partial class Message_Box
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Button_Ok = new Guna.UI2.WinForms.Guna2Button();
            Panel_Top = new Panel();
            label1 = new Guna.UI2.WinForms.Guna2TextBox();
            Panel_Bottom = new Panel();
            Panel_Top.SuspendLayout();
            Panel_Bottom.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.BorderRadius = 10;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.ShadowColor = Color.FromArgb(94, 148, 255);
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // Button_Ok
            // 
            Button_Ok.AutoRoundedCorners = true;
            Button_Ok.BorderRadius = 22;
            Button_Ok.Cursor = Cursors.Hand;
            Button_Ok.CustomizableEdges = customizableEdges3;
            Button_Ok.DisabledState.BorderColor = Color.DarkGray;
            Button_Ok.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Ok.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Ok.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Ok.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Ok.ForeColor = Color.White;
            Button_Ok.Location = new Point(116, 6);
            Button_Ok.Margin = new Padding(0);
            Button_Ok.Name = "Button_Ok";
            Button_Ok.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Ok.Size = new Size(93, 46);
            Button_Ok.TabIndex = 0;
            Button_Ok.Text = "Ok";
            Button_Ok.Click += Button_Ok_Click;
            // 
            // Panel_Top
            // 
            Panel_Top.Controls.Add(label1);
            Panel_Top.Dock = DockStyle.Top;
            Panel_Top.Location = new Point(0, 0);
            Panel_Top.Name = "Panel_Top";
            Panel_Top.Size = new Size(318, 142);
            Panel_Top.TabIndex = 16;
            // 
            // label1
            // 
            label1.BorderColor = Color.FromArgb(24, 30, 52);
            label1.BorderThickness = 0;
            label1.CustomizableEdges = customizableEdges1;
            label1.DefaultText = "";
            label1.DisabledState.BorderColor = Color.FromArgb(24, 30, 52);
            label1.DisabledState.FillColor = Color.FromArgb(24, 30, 52);
            label1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            label1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            label1.Dock = DockStyle.Fill;
            label1.FillColor = Color.FromArgb(24, 30, 52);
            label1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.HideSelection = false;
            label1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            label1.ImeMode = ImeMode.Off;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4);
            label1.Multiline = true;
            label1.Name = "label1";
            label1.PasswordChar = '\0';
            label1.PlaceholderText = "";
            label1.ReadOnly = true;
            label1.SelectedText = "";
            label1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            label1.Size = new Size(318, 142);
            label1.TabIndex = 1;
            label1.TabStop = false;
            // 
            // Panel_Bottom
            // 
            Panel_Bottom.Controls.Add(Button_Ok);
            Panel_Bottom.Dock = DockStyle.Bottom;
            Panel_Bottom.Location = new Point(0, 168);
            Panel_Bottom.Name = "Panel_Bottom";
            Panel_Bottom.Size = new Size(318, 57);
            Panel_Bottom.TabIndex = 17;
            // 
            // Message_Box
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(24, 30, 52);
            ClientSize = new Size(318, 225);
            Controls.Add(Panel_Top);
            Controls.Add(Panel_Bottom);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Message_Box";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Message_Box";
            TopMost = true;
            Panel_Top.ResumeLayout(false);
            Panel_Bottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button Button_Ok;
        private Panel Panel_Top;
        private Panel Panel_Bottom;
        public Guna.UI2.WinForms.Guna2TextBox label1;
    }
}