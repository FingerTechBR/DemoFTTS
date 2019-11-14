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
<<<<<<< HEAD
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
            picbox_img_digital.Image = new System.Drawing.Bitmap(utils.Conversor(utils.conertstringtoTEXTENCODE(digital)), new System.Drawing.Size(picbox_img_digital.Width, picbox_img_digital.Height));

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            // Utils utils = new Utils();
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
            
=======
          
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



>>>>>>> ba662f0a7f944a02a2b1a0270a5fed59f2b97255




        }
    }
}
