using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTTSS;

namespace DemoFTTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            Connect ftts = new Connect();
            int i = FTTSS.Connect.methods.Capturar;
            FTTSS.Connect connect = new Connect();
          
            try
            {
                txtbox_digital.Text = connect.getDigitalString(FTTSS.Connect.methods.Capturar);

            }
            catch(Exception d)
            {
                lb_status_text.Text = "Não foi possível capturar encontrar o leitor";
                MessageBox.Show(d.ToString());
            }

            lb_status_text.Text = "Coletado com Sucesso" + connect.ambiente.ip;
            lb_text_ip.Text = connect.ambiente.ip;







        }
    }
}
