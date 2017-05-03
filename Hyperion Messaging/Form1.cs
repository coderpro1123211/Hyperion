using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
    }
}
