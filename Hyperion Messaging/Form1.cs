using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hyperion_Messaging
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();


            MaterialSkinManager.Instance.AddFormToManage(this);
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey700, Primary.BlueGrey900, Accent.Blue400, TextShade.WHITE);
            MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;


            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show(i.ToString());
                var temp = panel1;
                //panel2.Controls.Add();
            }

            MessageBox.Show(panel2.Controls.Count.ToString());
        }
    }
}

public class MessageControl : UserControl
{
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;

    void InitializeComponent()
    {
        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
        this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();

        this.SuspendLayout();

        // 
        // materialLabel1
        // 
        this.materialLabel1.AutoSize = false;
        this.materialLabel1.Depth = 0;
        this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
        this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.materialLabel1.Location = new System.Drawing.Point(63, 21);
        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel1.Name = "materialLabel1";
        this.materialLabel1.Size = new System.Drawing.Size(116, 19);
        this.materialLabel1.TabIndex = 1;
        this.materialLabel1.Text = "John Appleseed";
        // 
        // materialFlatButton1
        // 
        this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.materialFlatButton1.Depth = 0;
        this.materialFlatButton1.Location = new System.Drawing.Point(547, 0);
        this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialFlatButton1.Name = "materialFlatButton1";
        this.materialFlatButton1.Primary = false;
        this.materialFlatButton1.Size = new System.Drawing.Size(63, 63);
        this.materialFlatButton1.TabIndex = 0;
        this.materialFlatButton1.Text = "Talk";
        this.materialFlatButton1.UseVisualStyleBackColor = true;

        this.ResumeLayout();

        Controls.AddRange(new Control[] { materialFlatButton1, materialLabel1 });
    }
}