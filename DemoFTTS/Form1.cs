using FTTSS;
using System;
using System.Windows.Forms;

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

            Utils utils = new Utils();
            Connect ftts = new Connect();
            int i = FTTSS.Connect.methods.Capturar;
            FTTSS.Connect connect = new Connect();

            String digital = null;

            try
            {
                
                digital = connect.getDigitalString(FTTSS.Connect.methods.Capturar);

                txtbox_digital.Text = digital;

            }
            catch (Exception d)
            {
                lb_status_text.Text = "Não foi possível encontrar o leitor";
                MessageBox.Show(d.ToString());
            }

            lb_status_text.Text = "Coletado com Sucesso";
            lb_text_ip.Text = connect.ambiente.ip;
            lb_text_solicitante.Text = connect.ambiente.user;
            picbox_img_digital.Visible = true;
            txtbox_digital.Text = digital;
            picbox_img_digital.Image = new System.Drawing.Bitmap(utils.Conversor(utils.conertstringtoTEXTENCODE(digital)), new System.Drawing.Size(picbox_img_digital.Width, picbox_img_digital.Height));

        }


        private void Button2_Click_1(object sender, EventArgs e)
        {
            Connect ftts = new Connect();
            int i = FTTSS.Connect.methods.Capturar;
            FTTSS.Connect connect = new Connect();
            String digital = null;
            try
            {
                digital = connect.getDigitalString(FTTSS.Connect.methods.Enroll);
                txtbox_digital.Text = digital;
            }
            catch (Exception d)
            {
                lb_status_text.Text = "Não foi possível capturar encontrar o leitor";
                MessageBox.Show(d.ToString());
            }

            lb_status_text.Text = "Coletada com Sucesso";
            lb_text_ip.Text = connect.ambiente.ip;
            lb_text_solicitante.Text = connect.ambiente.user;
            picbox_img_digital.Visible = false;
<<<<<<< HEAD


=======
>>>>>>> 2329194868871ce866148b1d1bd22b05ad3e3f6d


        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
