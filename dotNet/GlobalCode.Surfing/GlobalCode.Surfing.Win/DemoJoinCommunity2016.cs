using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalCode.Surfing.Device;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace GlobalCode.Surfing.Win
{
    public partial class DemoJoinCommunity2016 : Form
    {
        private IoTSurfboard _board;
        private const string ServerBroker = "iot.eclipse.org";
        private MqttClient _clientMqtt;
        private readonly string _clientId = $"Join2016_{Guid.NewGuid()}";
        private Uri url;

        public DemoJoinCommunity2016()
        {
            InitializeComponent();
            url = new Uri("http://prontuariobackend.azurewebsites.net/api/joincommunity");
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                _board = new IoTSurfboard(txtPorta.Text, 9600);
                lblID.Text = "Contectado";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuz_Click(object sender, EventArgs e)
        {
            try
            {
                lblLuz.Text = _board.Light().ToString();
                picLuz.Image = _board.Light() < 100
                    ? global::GlobalCode.Surfing.Win.Properties.Resources.charge_jarbas_07_02
                    : global::GlobalCode.Surfing.Win.Properties.Resources.sol;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            try
            {
                lblTemp.Text = _board.Temperature().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRGB_Click(object sender, EventArgs e)
        {
            try
            {
                _board.Red(255);
                Thread.Sleep(500);
                _board.Red(0);
                Thread.Sleep(500);
                _board.Green(255);
                Thread.Sleep(500);
                _board.Green(0);
                Thread.Sleep(500);
                _board.Blue(255);
                Thread.Sleep(500);
                _board.Blue(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                _board?.Close();
                lblID.Text = "Descontectado";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            // create client instance 
            _clientMqtt = new MqttClient(ServerBroker);

            // register to message received 
            _clientMqtt.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;

            _clientMqtt.Connect(_clientId);

            // subscribe to the topic "/joincommunity/led" with QoS 2 
            _clientMqtt.Subscribe(new string[] { "/joincommunity/led" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

            //ativando timer
            timerEnvio.Enabled = true;
            lblMonitor.Text = "Ligado";
        }

        private void Client_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            try
            {
                var msg = Encoding.ASCII.GetString(e.Message);

                if (msg == "rgb")
                {
                    _board.Red(255);
                    Thread.Sleep(500);
                    _board.Red(0);
                    Thread.Sleep(500);
                    _board.Green(255);
                    Thread.Sleep(500);
                    _board.Green(0);
                    Thread.Sleep(500);
                    _board.Blue(255);
                    Thread.Sleep(500);
                    _board.Blue(0);
                }
                else if (msg == "buzzer")
                {
                    _board.Speaker(true);
                    Thread.Sleep(500);
                    _board.Speaker(false);
                }
                else if (msg == "red")
                {
                    _board.Red(255);
                    Thread.Sleep(500);
                    _board.Red(0);
                }
                else if (msg == "blue")
                {
                    _board.Blue(255);
                    Thread.Sleep(500);
                    _board.Blue(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFechaMonitor_Click(object sender, EventArgs e)
        {
            try
            {
                //desativando timer
                timerEnvio.Enabled = false;

                _clientMqtt?.Disconnect();
                lblMonitor.Text = "Desligado";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timerEnvio_Tick(object sender, EventArgs e)
        {
            try
            {
                // publish a message on "/joincommunity/luz" topic with QoS 2 
                _clientMqtt.Publish("/joincommunity/luz", Encoding.UTF8.GetBytes(_board.Light().ToString()),
                    MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
                lblLuz.Text = _board.Light().ToString();
                picLuz.Image = _board.Light() < 100
                    ? global::GlobalCode.Surfing.Win.Properties.Resources.charge_jarbas_07_02
                    : global::GlobalCode.Surfing.Win.Properties.Resources.sol;

                // publish a message on "/joincommunity/temperatura" topic with QoS 2 
                _clientMqtt.Publish("/joincommunity/temperatura", Encoding.UTF8.GetBytes(_board.Temperature().ToString()),
                    MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
                lblTemp.Text = _board.Temperature().ToString();
                publicarValorTemperatura(_board.Temperature());

                // publish a message on "/joincommunity/potencia" topic with QoS 2 
                _clientMqtt.Publish("/joincommunity/potencia", Encoding.UTF8.GetBytes(_board.Potentiometer().ToString()),
                    MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);

                lblPotenciometro.Text = _board.Potentiometer().ToString();

                //publish a message on "/joincommunity/alcool" topic with QoS 2
                _clientMqtt.Publish("/joincommunity/alcool", Encoding.UTF8.GetBytes(_board.Alcohol().ToString()),
                    MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
                lblAlcool.Text = _board.Alcohol().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void publicarValorTemperatura(float temperatura)
        {
            try
            {
                StringBuilder jsonBuilder = new StringBuilder();

                jsonBuilder.Append("{");
                jsonBuilder.Append("'");
                jsonBuilder.Append("Valor");
                jsonBuilder.Append("'");
                jsonBuilder.Append(":");
                jsonBuilder.Append(temperatura);
                jsonBuilder.Append("}");

                string json = jsonBuilder.ToString();

                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    client.UploadStringAsync(url, "POST", json);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
