namespace WoaModHarmInstallerGUI
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            Install_BTN = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            DOWNLOAD_PROG = new ProgressBar();
            VERIFYINTEGRITY_BTN = new Button();
            DEBUG_CHECK = new CheckBox();
            EXIT_BTN = new Button();
            Output = new RichTextBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Install_BTN
            // 
            Install_BTN.AccessibleDescription = "Installs the latest version of WoaModHarm";
            Install_BTN.AccessibleName = "Install";
            Install_BTN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Install_BTN.BackColor = Color.Black;
            Install_BTN.BackgroundImageLayout = ImageLayout.None;
            Install_BTN.Cursor = Cursors.Hand;
            Install_BTN.FlatStyle = FlatStyle.System;
            Install_BTN.ForeColor = Color.Transparent;
            Install_BTN.Location = new Point(4, 24);
            Install_BTN.Margin = new Padding(4, 3, 4, 3);
            Install_BTN.Name = "Install_BTN";
            Install_BTN.Size = new Size(198, 26);
            Install_BTN.TabIndex = 0;
            Install_BTN.Text = "Install";
            Install_BTN.UseVisualStyleBackColor = false;
            Install_BTN.Click += Install_BTN_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(DOWNLOAD_PROG);
            flowLayoutPanel1.Controls.Add(Install_BTN);
            flowLayoutPanel1.Controls.Add(VERIFYINTEGRITY_BTN);
            flowLayoutPanel1.Controls.Add(DEBUG_CHECK);
            flowLayoutPanel1.Controls.Add(EXIT_BTN);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(206, 651);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // DOWNLOAD_PROG
            // 
            DOWNLOAD_PROG.Location = new Point(4, 3);
            DOWNLOAD_PROG.Margin = new Padding(4, 3, 4, 3);
            DOWNLOAD_PROG.Name = "DOWNLOAD_PROG";
            DOWNLOAD_PROG.Size = new Size(194, 15);
            DOWNLOAD_PROG.Step = 1;
            DOWNLOAD_PROG.TabIndex = 4;
            // 
            // VERIFYINTEGRITY_BTN
            // 
            VERIFYINTEGRITY_BTN.AccessibleDescription = "Verifies mod installation";
            VERIFYINTEGRITY_BTN.AccessibleName = "Verify Integrity";
            VERIFYINTEGRITY_BTN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            VERIFYINTEGRITY_BTN.BackColor = Color.Black;
            VERIFYINTEGRITY_BTN.Cursor = Cursors.Hand;
            VERIFYINTEGRITY_BTN.FlatStyle = FlatStyle.System;
            VERIFYINTEGRITY_BTN.ForeColor = Color.Transparent;
            VERIFYINTEGRITY_BTN.Location = new Point(4, 56);
            VERIFYINTEGRITY_BTN.Margin = new Padding(4, 3, 4, 3);
            VERIFYINTEGRITY_BTN.Name = "VERIFYINTEGRITY_BTN";
            VERIFYINTEGRITY_BTN.Size = new Size(198, 26);
            VERIFYINTEGRITY_BTN.TabIndex = 1;
            VERIFYINTEGRITY_BTN.Text = "Verify Integrity";
            VERIFYINTEGRITY_BTN.UseVisualStyleBackColor = false;
            VERIFYINTEGRITY_BTN.Click += VERIFYINTEGRITY_BTN_Click;
            // 
            // DEBUG_CHECK
            // 
            DEBUG_CHECK.AutoSize = true;
            DEBUG_CHECK.Dock = DockStyle.Bottom;
            DEBUG_CHECK.ForeColor = Color.White;
            DEBUG_CHECK.Location = new Point(4, 88);
            DEBUG_CHECK.Margin = new Padding(4, 3, 4, 3);
            DEBUG_CHECK.Name = "DEBUG_CHECK";
            DEBUG_CHECK.Size = new Size(117, 21);
            DEBUG_CHECK.TabIndex = 2;
            DEBUG_CHECK.Text = "DEBUG MODE";
            DEBUG_CHECK.UseVisualStyleBackColor = true;
            // 
            // EXIT_BTN
            // 
            EXIT_BTN.Cursor = Cursors.Hand;
            flowLayoutPanel1.SetFlowBreak(EXIT_BTN, true);
            EXIT_BTN.Location = new Point(4, 115);
            EXIT_BTN.Margin = new Padding(4, 3, 4, 3);
            EXIT_BTN.Name = "EXIT_BTN";
            EXIT_BTN.Size = new Size(194, 26);
            EXIT_BTN.TabIndex = 3;
            EXIT_BTN.Text = "Quit";
            EXIT_BTN.UseVisualStyleBackColor = true;
            EXIT_BTN.Visible = false;
            EXIT_BTN.Click += EXIT_BTN_Click;
            // 
            // Output
            // 
            Output.AccessibleDescription = "Shows program output messages";
            Output.AccessibleName = "Output Window";
            Output.BackColor = Color.Black;
            Output.BorderStyle = BorderStyle.None;
            Output.Dock = DockStyle.Fill;
            Output.Location = new Point(206, 0);
            Output.Margin = new Padding(4, 3, 4, 3);
            Output.Name = "Output";
            Output.ReadOnly = true;
            Output.Size = new Size(726, 651);
            Output.TabIndex = 4;
            Output.Text = "";
            // 
            // MAIN
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(932, 651);
            Controls.Add(Output);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("OCR A Extended", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(767, 561);
            Name = "MAIN";
            Text = "WoaModHarm Installer";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Install_BTN;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button VERIFYINTEGRITY_BTN;
        private CheckBox DEBUG_CHECK;
        private RichTextBox Output;
        private Button EXIT_BTN;
        private ProgressBar DOWNLOAD_PROG;
    }
}
