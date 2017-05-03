namespace Hyperion_Messaging
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
            this.contactMenu = new MaterialSkin.Controls.MaterialDivider();
            this.panel1 = new MessageControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactMenu
            // 
            this.contactMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactMenu.BackColor = System.Drawing.Color.SlateGray;
            this.contactMenu.Depth = 0;
            this.contactMenu.Location = new System.Drawing.Point(0, 64);
            this.contactMenu.Margin = new System.Windows.Forms.Padding(0);
            this.contactMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.contactMenu.Name = "contactMenu";
            this.contactMenu.Size = new System.Drawing.Size(209, 433);
            this.contactMenu.TabIndex = 0;
            this.contactMenu.Text = "none";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Location = new System.Drawing.Point(207, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 63);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(209, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 433);
            this.panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.contactMenu);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hyperion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider contactMenu;
        private MessageControl panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

