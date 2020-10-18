using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;

namespace CasaAutomatizada
{
    public partial class Check : Form
    {
        static string[] library = { "microfone", "casa automatizada" };
        private SpeechRecognition speech = new SpeechRecognition(library);

        public Check()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void Check_Load(object sender, EventArgs e)
        {
            this.speech.speechEngine.SpeechRecognized += speechRecognized;
        }

        void speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch(e.Result.Text)
            {
                case "microfone":
                    lbl_Response.Text = "Agora diga: 'Casa Automatizada'";
                    break;
                case "casa automatizada":
                    lbl_Response.Text = "Microfone OK!";
                    this.speech.stop();
                    break;
            }
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            this.speech.listen();
            lbl_Response.Text = "Diga 'Microfone'";
        }
    }
}
