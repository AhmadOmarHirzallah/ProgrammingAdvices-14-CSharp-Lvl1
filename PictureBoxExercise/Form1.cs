using ReaLTaiizor.Controls;
using Syncfusion.Windows.Forms.Tools;
using System.Runtime.CompilerServices;

namespace PictureBoxExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConnectAll_RDOS_Events();
        }


        private void loadImgByName(string ImgName)
        {
            picDisplay.Image = (Image)Properties.Resources.ResourceManager.GetObject(ImgName);
        }

        private void ConnectAll_RDOS_Events()
        {
            foreach (Control Ctrl in gbPicsChoice.Controls)
            {
                if ((Ctrl is RadioButtonAdv rdoAdv))
                    rdoAdv.CheckChanged += rdo_CheckChanged_AnyRdo;
            }
        }

        private void rdo_CheckChanged_AnyRdo(object sender, EventArgs e)
        {
            if ((sender is RadioButtonAdv rdoAdv) && (rdoAdv.Checked))
            {
                loadImgByName(rdoAdv.Tag.ToString());
                lblTitle.Text = rdoAdv.Tag.ToString();
            }
        }
    }
}
