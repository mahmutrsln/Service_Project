using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service_Project.IdentitNumberService;

namespace Service_Project
{
    public partial class IdentityControlForm : Form
    {
        public IdentityControlForm()
        {
            InitializeComponent();
        }

        private void IdentityControlForm_Load(object sender, EventArgs e)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient();

        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            long Tckn = Convert.ToInt64(mskdTcknn.Text);
            string Name = txtIsim.Text.ToUpper();
            string SurName = txtSoyIsim.Text.ToUpper();
            int BirthDate = Convert.ToInt32(mskdDogumYil.Text);

            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient();
            bool returnState = kPSPublicSoapClient.TCKimlikNoDogrula(Tckn, Name, SurName, BirthDate);

            if (returnState)
            {
                MessageBox.Show("Tc Kimlik Nuamarası Doğrulama Başarılı");
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
