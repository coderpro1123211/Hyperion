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
            this.materialCheckBox1 = new MaterialListView();
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
            this.contactMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.contactMenu.Name = "contactMenu";
            this.contactMenu.Size = new System.Drawing.Size(209, 433);
            this.contactMenu.TabIndex = 0;
            this.contactMenu.Text = "none";
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialCheckBox1.FullRowSelect = true;
            this.materialCheckBox1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialCheckBox1.Location = new System.Drawing.Point(212, 64);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.OwnerDraw = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(611, 433);
            this.materialCheckBox1.TabIndex = 0;
            this.materialCheckBox1.Text = "materialCheckBox1";
            this.materialCheckBox1.UseCompatibleStateImageBehavior = false;
            this.materialCheckBox1.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 496);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.contactMenu);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hyperion";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider contactMenu;
        private MaterialListView materialCheckBox1;
    }
}

