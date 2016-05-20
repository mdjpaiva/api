using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalCode.Surfing.Device;
using Microsoft.Azure.Devices.Client;
using Mono.Security;

namespace GlobalCode.Surfing.Win
{
    public partial class Form1 : Form
    {
        private const string DeviceConnectionString = "HostName=joincommunity.azure-devices.net;DeviceId=join;SharedAccessKey=FZu4CPCiPbYWw/QD6Ho8P/7nfKmXfykElh2ozbZ98To=";
        private DeviceClient _deviceClient;
        private string _retorno;

        IoTSurfboard _board = null;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnConectar_Click(object sender, EventArgs e)
        {
            _board = new IoTSurfboard(txtPorta.Text, 9600);
            lblID.Text = "Contectado";
            _deviceClient = DeviceClient.CreateFromConnectionString(DeviceConnectionString, TransportType.Mqtt);
        }

        private void btnLuz_Click(object sender, EventArgs e)
        {
            try
            {
                lblLuz.Text = _board.Light().ToString();
            }
            catch (Exception ex)
            {
                lblLuz.Text = ex.Message;
            }

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                _board?.Close();
                lblID.Text = "Descontectado";
                //await _deviceClient.CloseAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnRGB_Click(object sender, EventArgs e)
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

        private void btnTemp_Click(object sender, EventArgs e)
        {
            try
            {
                lblTemp.Text = _board.Temperature().ToString();
            }
            catch (Exception ex)
            {
                lblTemp.Text = ex.Message;
            }
        }


        private async Task SendEvent(DeviceClient deviceClient, string mensagem)
        {
            await deviceClient.OpenAsync();
            var eventMessage = new Microsoft.Azure.Devices.Client.Message(Encoding.UTF8.GetBytes(mensagem));
            eventMessage.MessageId = Guid.NewGuid().ToString();
            await deviceClient.SendEventAsync(eventMessage);
        }

        private async void btnEnviarLuz_Click(object sender, EventArgs e)
        {
            try
            {
                await SendEvent(_deviceClient, lblLuz.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnReceber_Click(object sender, EventArgs e)
        {
            try
            {
                await ReceiveCommands(_deviceClient, _board);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task ReceiveCommands(DeviceClient deviceClient, IoTSurfboard boarIoTSurfboard)
        {
            while (true)
            {
                var receivedMessage = await deviceClient.ReceiveAsync(TimeSpan.FromSeconds(1));

                if (receivedMessage == null) continue;

                var messageData = Encoding.ASCII.GetString(receivedMessage.GetBytes());

                if (messageData == "rgb")
                {
                    boarIoTSurfboard.Red(255);
                    Thread.Sleep(500);
                    boarIoTSurfboard.Red(0);
                    Thread.Sleep(500);
                    boarIoTSurfboard.Green(255);
                    Thread.Sleep(500);
                    boarIoTSurfboard.Green(0);
                    Thread.Sleep(500);
                    boarIoTSurfboard.Blue(255);
                    Thread.Sleep(500);
                    boarIoTSurfboard.Blue(0);
                }
                else if (messageData == "buzzer")
                {
                    boarIoTSurfboard.Speaker(true);
                    Thread.Sleep(500);
                    boarIoTSurfboard.Speaker(false);
                }

                await deviceClient.CompleteAsync(receivedMessage);
            }
        }
    }
}
