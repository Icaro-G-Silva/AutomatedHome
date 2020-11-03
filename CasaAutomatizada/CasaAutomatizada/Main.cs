using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;

namespace CasaAutomatizada
{
    public partial class Main : Form
    {
        #region Main Construction
        public Main()
        {
            InitializeComponent();
        }

        #endregion

        #region Buttons

        private void btn_Check_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            check.Show();
            this.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Setting Attributes
        /*
        *  Configurando alguns atributos da classe (Apenas criando eles para posteriormente adicionar alguma coisa mais útil)
        */
        private ConnectionSQLite sqlite;

        private SpeechRecognition speech, speechTrigger;
        private List<string> instructionList = new List<string>();
        private string[] library;

        private SerialPort serial;
        private string[] ports;
        #endregion

        #region Main Configurations
        
        /*
        *  Configurações principais, aqui já começo configurando algumas coisas que irá ser utilizada
        */
        
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                //Aqui começo a instânciar a Classe do Banco de Dados e a puxar os dados do Banco
                this.sqlite = new ConnectionSQLite();
                DataTable content = this.loadBD();
                //Neste looping estou adicionando as instruções em uma lista para passar para o "reconhecedor de voz"
                for (int i = 0; i < content.Rows.Count; i++) this.instructionList.Add(content.Rows[i]["Instrucao"].ToString());

                this.instructionList.Add("obrigado");
                this.instructionList.Add("obrigada");
                this.library = this.instructionList.ToArray();
                this.speech = new SpeechRecognition(this.library);
                string[] triggerLib = { "ei casa" };
                this.speechTrigger = new SpeechRecognition(triggerLib);
                //Aqui é feita a configuração dos métodos que vão "escutar" a sua voz
                this.speech.speechEngine.SpeechRecognized += this.speechRecognized;
                this.speechTrigger.speechEngine.SpeechRecognized += this.speechTriggerListener;

                this.speechTrigger.listen();
                //Aqui inicio a configuração do Arduino
                this.setArduinoThings();
            }
            catch (Exception err)
            {
                pnl_Main.BackColor = Color.LightCoral;
                MessageBox.Show("Erro no Main -> " + err.Message, "Alguma coisa aconteceu!");
            }
        }

        #endregion

        #region Logical SpeechRecognition
        /*
        *  Todo código até o próximo "#endregion" é toda a parte lógica do "reconhecedor de voz"
        */
        private void speechTriggerListener(object sender, SpeechRecognizedEventArgs e)
        {
            try
            {
                if (e.Result.Text.Equals("ei casa"))
                {
                    lbl_Response.Text = "Ouvindo...";
                    pnl_Main.BackColor = Color.LightBlue;
                    this.speech.listen();
                    this.speechTrigger.stop();
                }
            } catch(Exception err)
            {
                pnl_Main.BackColor = Color.LightCoral;
                MessageBox.Show("Erro no SpeechTrigger -> " + err.Message, "Alguma coisa aconteceu!");
            }
            
        }

        private void speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            try
            {
                DataTable content = this.loadBD();
                if (e.Result.Text.Equals("obrigado") || e.Result.Text.Equals("obrigada"))
                {
                    lbl_Response.Text = "Disponha ;)";
                    pnl_Main.BackColor = Color.Gainsboro;
                    this.speech.stop();
                    this.speechTrigger.listen();
                }
                else
                {
                    //Aqui é onde definitivamente é feita a análise do que você disse e comparado às instruções, e então é executado o que está dentro do "IF"
                    for (int i = 0; i < content.Rows.Count; i++)
                    {
                        if (e.Result.Text.Equals(content.Rows[i]["Instrucao"].ToString()))
                        {
                            lbl_Response.Text = content.Rows[i]["Instrucao"].ToString() + " OK!";
                            serial.Write(content.Rows[i]["Retorno"].ToString());
                            pnl_Main.BackColor = Color.PaleGreen;
                            this.speech.stop();
                            this.speechTrigger.listen();
                        }
                    }
                }
                
            } catch(Exception err)
            {
                pnl_Main.BackColor = Color.LightCoral;
                MessageBox.Show("Erro no Speech -> " + err.Message, "Alguma coisa aconteceu!");
            }
        }

        #endregion

        #region Select into DB
        /*
        *  Aqui é onde pega as informações de dentro do BD
        */
        private DataTable loadBD()
        {
            try
            {
                this.sqlite.connect();
                DataTable pivot = this.sqlite.getData();
                this.sqlite.disconnect();
                return pivot;
            }
            catch (Exception err)
            {
                pnl_Main.BackColor = Color.LightCoral;
                MessageBox.Show("Erro no LoadDB -> " + err.Message, "Alguma coisa aconteceu!");
                return new DataTable();
            }
        }

        #endregion

        #region Doing some Arduino Things
        /*
        *  Até o próximo "#endregion" é feito tudo o que for preciso para o funcionamento do Arduino
        */
        private void getAvaiablePorts()
        {
            this.ports = SerialPort.GetPortNames();
        }

        //Esse é o método de Conexão
        private void connectOnArduino()
        {
            try
            {
                string selectedPort = cmb_Ports.GetItemText(cmb_Ports.SelectedItem);
                serial = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                serial.Open();
                MessageBox.Show("Conexão realizada com sucesso!", "Sucesso!");
            } catch(Exception err)
            {
                pnl_Main.BackColor = Color.LightCoral;
                MessageBox.Show("Erro na Conexao Com Arduino -> " + err.Message, "Alguma coisa aconteceu!");
            }
        }

        private void disconnectArduino()
        {
            serial.Close();
        }

        private void cmb_Ports_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.disconnectArduino();
            this.connectOnArduino();
        }

        private void setArduinoThings()
        {
            this.getAvaiablePorts();
            foreach(string port in this.ports)
            {
                cmb_Ports.Items.Add(port);
                if (ports[0] != null) cmb_Ports.SelectedItem = ports[0];
            }
        }

        #endregion

    }
}
