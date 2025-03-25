namespace Pr_1
{
    partial class FromMain
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
            panelTop = new Panel();
            labelUsers = new Label();
            panel2 = new Panel();
            labelInAboutUsers = new Label();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelUsers);
            panelTop.Dock = DockStyle.Top;
            panelTop.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(912, 70);
            panelTop.TabIndex = 0;
            panelTop.Paint += panel1_Paint;
            // 
            // labelUsers
            // 
            labelUsers.Dock = DockStyle.Fill;
            labelUsers.Location = new Point(10, 10);
            labelUsers.Name = "labelUsers";
            labelUsers.Size = new Size(892, 50);
            labelUsers.TabIndex = 0;
            labelUsers.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelInAboutUsers);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(912, 658);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // labelInAboutUsers
            // 
            labelInAboutUsers.Dock = DockStyle.Fill;
            labelInAboutUsers.Location = new Point(10, 10);
            labelInAboutUsers.Name = "labelInAboutUsers";
            labelInAboutUsers.Size = new Size(892, 638);
            labelInAboutUsers.TabIndex = 0;
            // 
            // FromMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(912, 728);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            Name = "FromMain";
            Text = "Пользователи";
            Load += FromMain_Load;
            panelTop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panel2;
        private Label labelUsers;
        private Label labelInAboutUsers;
    }
}
