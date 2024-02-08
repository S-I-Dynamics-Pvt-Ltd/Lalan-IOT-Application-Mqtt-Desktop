using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

using Newtonsoft.Json;
//using System.Collections.Generic;

using MySql.Data.MySqlClient;
using System.Threading;
using System.Data;
using System.Net.Sockets;

namespace mqtt
{
    public partial class Form1 : Form
    {

        bool bConnectionStatus = false;
        bool bSubscriptionStatus = false;
        bool bLogSubscription = false;
        string sFilePath = "";

        int CountMSS = 0;
        int CountMSS15 = 0;
        int CountMSS21 = 0;
        int iCntrMessageTransmit = 0;
        int iCntrMessageReceive = 0;

        ClassGeneralFunctions cGF = new ClassGeneralFunctions();

        MqttClient mqttClient;
        MqttClient mqttClient15;
        MqttClient mqttClient21;

        string connectionString;
        string connectionString1;
        string connectionString2;

        MySqlConnection conn = new MySqlConnection();
        MySqlConnection conn1 = new MySqlConnection();
        MySqlConnection DBCon = new MySqlConnection();

        object[][] valueArray = new object[6][]; // creating new object array 


        public Form1()
        {
            InitializeComponent();

            //MySqlConnection conn = new MySqlConnection(connectionString);
            //MySqlConnection conn1 = new MySqlConnection(connectionString);
            //MySqlConnection DBCon = new MySqlConnection(connectionString);
            //connectionString1 = "SERVER=" + server + "; PORT = 3306 ;" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            //connectionString2 = "SERVER=" + server + "; PORT = 3306 ;" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


        }


        private void Form1_Load(object sender, EventArgs e)
        {

            //  initMqtt(); 
            //idTextBoxClientID.Text = cGF.RandomString(15);
            loadSavedSettings();

        }

        private void Form1_Close(object sender, EventArgs e)
        {
            //  initMqtt(); 
        }

        void mqttConnect()
        {
            if (idTextBoxClientID.Text == "")
            {
                idTextBoxClientID.Text = cGF.RandomString(25);
            }

            if (idTextBoxClientIDnew.Text == "")
            {
                idTextBoxClientIDnew.Text = cGF.RandomString(25);
            }

            if (idTextBoxClientIDnew21.Text == "")
            {
                idTextBoxClientIDnew21.Text = cGF.RandomString(25);
            }

            if (idTextBoxHost.Text == "")
            {
                idtextBoxReceivedMessage.AppendText("Host cannot be empty");
                return;
            }
            if (idTextBoxPort.Text == "")
            {
                idtextBoxReceivedMessage.AppendText("port cannot be empty");
                return;
            }

            try
            {

                //mqttClient15 = new MqttClient(idTextBoxHost.Text);
                //mqttClient15.Connect(idTextBoxClientIDnew.Text, idTextBoxUserName.Text, idTextBoxPassoword.Text);

                mqttClient21 = new MqttClient(idTextBoxHost.Text);
                mqttClient21.Connect(idTextBoxClientIDnew21.Text, idTextBoxUserName.Text, idTextBoxPassoword.Text);

                mqttClient = new MqttClient(idTextBoxHost.Text);
                mqttClient.Connect(idTextBoxClientID.Text, idTextBoxUserName.Text, idTextBoxPassoword.Text);

                bConnectionStatus = true;
                idButtonConnect.Text = "Connected, Click to Disconnect";
                idButtonConnect.BackColor = Color.LightGreen;

            }
            catch (Exception ex)
            {
                idButtonConnect.Text = "Connect";
                idButtonConnect.BackColor = Color.Red;
                appendTextBox(idtextBoxReceivedMessage, "Connection Exception : " + ex.Message);
            }
        }

        Thread T1;


        private void MqttClient_MqttMsgPublishReceived_BOB(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            string server = "localhost";
            string database = "lalan_database";
            // string uid = "ABC";
            string uid = "root";
            // string password = "lalan@123";
            // string password = "Lalan@*Pack123]";
            string password = "sierra@123";

            connectionString1 = "SERVER=" + server + "; PORT = 3306 ;" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";



            MySqlConnection DBCon = new MySqlConnection(connectionString1);


            try
            {
                DBCon.Open();

                var message = Encoding.UTF8.GetString(e.Message);

                appendTextBox(idtextBoxReceivedMessage21, message);
                iCntrMessageReceive++;
                idLabelRecMessageCounter.Invoke((MethodInvoker)(() => idLabelRecMessageCounter.Text = iCntrMessageReceive.ToString()));

                var ob = JsonConvert.DeserializeObject<CardData>(Encoding.UTF8.GetString(e.Message));

                string Dipadd = ob.ipadd.ToString();
                string Ddeviceid = ob.deviceid.ToString();
                string Dtype = ob.type.ToString();
                int Dvalue = ob.value;
                string Dstate = ob.State.ToString();

                Reader readerInstance = new Reader();
                readerInstance.MqttClient_MqttMsgPublish(Dipadd, Ddeviceid, Dtype, Dvalue, Dstate, DBCon, cGF);

                CountMSS21++;

                if (CountMSS21 > 8)
                {
                    T1 = new Thread(f3);
                    T1.Start();
                }


            }

            catch (SocketException ex)
            {
                txterror.Invoke((MethodInvoker)(() => txterror.Text += "SocketException: " + ex.Message));
                Thread.Sleep(5000);
                conn.Close();
                RetryDatabaseConnectionMForsgPublishReceived_BOB();
            }
            catch (MySqlException ex)
            {
                txterror.Invoke((MethodInvoker)(() => txterror.Text += "MySqlException: " + ex.Message));
                Thread.Sleep(5000);
                conn.Close();
                RetryDatabaseConnectionMForsgPublishReceived_BOB();
            }
            catch (Exception ex)
            {

                txterror.Invoke((MethodInvoker)(() => txterror.Text += "----------------NEW ERROR 21--------------------"));
                txterror.Invoke((MethodInvoker)(() => txterror.Text += ex));

            }

            finally
            {
                if (DBCon.State == ConnectionState.Open)
                {
                    DBCon.Close();

                }
            }

        }

        private void RetryDatabaseConnectionMForsgPublishReceived_BOB()
        {
            const int maxRetryAttempts = 5;
            int retryCount = 0;

            while (retryCount < maxRetryAttempts)
            {
                try
                {
                    DBCon.Open();
                    break;
                }
                catch (MySqlException)
                {
                    Thread.Sleep(5000);

                }
                catch (SocketException)
                {

                    Thread.Sleep(5000);
                }

                retryCount++;
            }

            if (retryCount >= maxRetryAttempts)
            {
                txterror.Invoke((MethodInvoker)(() => txterror.Text += "Max retry attempts reached. Could not establish a database connection."));
            }
        }

        private void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {

            string server = "localhost";
            string database = "lalan_database";
            // string uid = "ABC";
            string uid = "root";
            // string password = "lalan@123";
            // string password = "Lalan@*Pack123]";
            string password = "sierra@123";

            connectionString = "SERVER=" + server + "; PORT = 3306 ;" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                var message = Encoding.UTF8.GetString(e.Message);

                appendTextBox(idtextBoxReceivedMessage, message);
                iCntrMessageReceive++;
                idLabelRecMessageCounter.Invoke((MethodInvoker)(() => idLabelRecMessageCounter.Text = iCntrMessageReceive.ToString()));

                var ob = JsonConvert.DeserializeObject<CardData>(Encoding.UTF8.GetString(e.Message));

                string Dipadd = ob.ipadd.ToString();
                string Ddeviceid = ob.deviceid.ToString();
                string Dtype = ob.type.ToString();
                int Dvalue = ob.value;

                if (Dtype != "bobbin1" && Dtype != "bobbin2" && Dtype != "bobbin0" && Dtype != "bobbin12" && Dtype != "waste")
                {
                    if (Dtype == "PStopped")
                    {
                        valueArray[0] = new object[] { "10000010", 0 };
                        valueArray[1] = new object[] { "10000011", 0 };
                        valueArray[2] = new object[] { "10000012", 0 };
                        valueArray[3] = new object[] { "10000013", 0 };
                        valueArray[4] = new object[] { "10000014", 0 };
                        valueArray[5] = new object[] { "10000017", 0 };
                    }
                    else
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            if (valueArray[i][0] is string deviceid && valueArray[i][1] is int intValue)
                            {
                                if (deviceid == Ddeviceid)
                                {
                                    if (intValue - 2 > Dvalue || intValue + 2 < Dvalue || intValue == 0)
                                    {
                                        valueArray[i] = new object[] { Ddeviceid, Dvalue };
                                        Thread.Sleep(900);
                                        string cmdText = "INSERT INTO iot_input_process(device_id_in_iot_input, parameter_id_in_iot_input,value_input) " +
                                                              "VALUES (@DID, @DTYP, @DVAL)";
                                        MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                                        cmd.Parameters.AddWithValue("@DID", Ddeviceid);
                                        cmd.Parameters.AddWithValue("@DTYP", Dtype);
                                        cmd.Parameters.AddWithValue("@DVAL", Dvalue);
                                        cmd.ExecuteNonQuery();
                                        break;
                                    }
                                }
                            }
                        }
                    }

                }

                Console.WriteLine("Inserting Data Successfully");

                CountMSS++;

                if (CountMSS > 50)
                {
                    T1 = new Thread(f1);
                    T1.Start();
                }


            }

            catch (SocketException ex)
            {
                txterror.Invoke((MethodInvoker)(() => txterror.Text += "SocketException: " + ex.Message));
                Thread.Sleep(5000);
                conn.Close();
                RetryDatabaseConnectionMForsgPublishReceived();
            }
            catch (MySqlException ex)
            {
                txterror.Invoke((MethodInvoker)(() => txterror.Text += "MySqlException: " + ex.Message));
                Thread.Sleep(5000);
                conn.Close();
                RetryDatabaseConnectionMForsgPublishReceived();
            }

            catch (Exception ex)
            {
                txterror.Invoke((MethodInvoker)(() => txterror.Text += "----------------NEW ERROR COM--------------------"));
                txterror.Invoke((MethodInvoker)(() => txterror.Text += ex));
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();

                }
            }

        }

        private void RetryDatabaseConnectionMForsgPublishReceived()
        {
            const int maxRetryAttempts = 5;
            int retryCount = 0;

            while (retryCount < maxRetryAttempts)
            {
                try
                {
                    conn.Open();
                    break;
                }
                catch (MySqlException)
                {
                    Thread.Sleep(5000);

                }
                catch (SocketException)
                {

                    Thread.Sleep(5000);
                }

                retryCount++;
            }

            if (retryCount >= maxRetryAttempts)
            {
                txterror.Invoke((MethodInvoker)(() => txterror.Text += "Max retry attempts reached. Could not establish a database connection."));
            }
        }

        void f1()
        {

            idtextBoxReceivedMessage.Invoke((MethodInvoker)(() => idtextBoxReceivedMessage.Text = ""));
            CountMSS = 0;

        }

        void f2()
        {

            idtextBoxReceivedMessage15.Invoke((MethodInvoker)(() => idtextBoxReceivedMessage15.Text = ""));
            CountMSS15 = 0;

        }

        void f3()
        {

            idtextBoxReceivedMessage21.Invoke((MethodInvoker)(() => idtextBoxReceivedMessage21.Text = ""));
            CountMSS21 = 0;

        }

        public class CardData
        {
            public string ipadd { get; set; }

            public string deviceid { get; set; }

            public string type { get; set; }

            public int value { get; set; }

            public string State { get; set; }

            public override string ToString()
            {
                return String.Format("ipadd: {0},deviceid: {1}, type: {2}, value: {3} , value: {4}", ipadd, deviceid, type, value, State);
            }

        }



        private void idButtonConnect_Click(object sender, EventArgs e)
        {
            if (bConnectionStatus == false)
            {
                mqttConnect();
            }
            else
            {
                idButtonConnect.BackColor = Color.Red;
                idButtonConnect.Text = "Connect";
                disconnectConnection();
            }

        }

        private void idButtonSubscribe_Click(object sender, EventArgs e)
        {

            if (idTextBoxSubTopic.Text == "")
            {
                appendTextBox(idtextBoxReceivedMessage, "Subscrition topic cannot be left black");
                return;
            }

            if (mqttClient != null && mqttClient.IsConnected == true || mqttClient15 != null && mqttClient15.IsConnected == true || mqttClient21 != null && mqttClient21.IsConnected == true)
            {

                if (bSubscriptionStatus == false)
                {
                    try
                    {

                        //mqttClient15.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived15;
                        //mqttClient15.Subscribe(new string[] { txtTopic15.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });

                        mqttClient21.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived_BOB;
                        mqttClient21.Subscribe(new string[] { txtTopic21.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });

                        mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
                        mqttClient.Subscribe(new string[] { idTextBoxSubTopic.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });

                        idButtonSubscribe.BackColor = Color.LightGreen;
                        idButtonSubscribe.Text = "Unsubscribe";
                        bSubscriptionStatus = true;

                    }
                    catch (Exception ex)
                    {
                        idButtonSubscribe.BackColor = Color.Red;
                    }
                }
                else
                {
                    bSubscriptionStatus = false;
                    idButtonSubscribe.Text = "Subscribe";
                    idButtonSubscribe.BackColor = Color.Red;
                    try
                    {
                        mqttClient.Unsubscribe(new string[] { idTextBoxSubTopic.Text });
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            else
            {

                appendTextBox(idtextBoxReceivedMessage, "Mqtt not connected");
            }
        }

        void appendTextBox(TextBox txtBox, string sMsg)
        {
            string sMessage = "\r\n" + cGF.getCurrentDateTimeIST(true, false, false) + "  : " + sMsg;
            txtBox.Invoke((MethodInvoker)(() => txtBox.AppendText(sMessage)));

            if (bLogSubscription == true)
                File.AppendAllText(sFilePath, sMessage);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveSettings();

            disconnectConnection();
        }

        void disconnectConnection()
        {
            bConnectionStatus = false;
            bSubscriptionStatus = false;
            try
            {
                if (bSubscriptionStatus == true)
                    mqttClient.Unsubscribe(new string[] { idTextBoxSubTopic.Text });
            }
            catch (Exception ex)
            {

            }

            try
            {
                if (mqttClient != null && mqttClient.IsConnected == true)
                    mqttClient.Disconnect();
            }
            catch (Exception ex)
            {

            }
        }

        private void idButtonSubClear_Click(object sender, EventArgs e)
        {
            idtextBoxReceivedMessage.Text = "";

        }

        private void idButtonSubCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(idtextBoxReceivedMessage.Text);
        }

        private void idButtonSubLog_Click(object sender, EventArgs e)
        {
            if (bLogSubscription == false)
            {
                sFilePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                sFilePath += "\\" + "Logs";
                if (Directory.Exists(sFilePath))
                {
                    Console.WriteLine("That path exists already.");
                }
                else
                {
                    DirectoryInfo di = Directory.CreateDirectory(sFilePath);
                }

                sFilePath += "\\" + DateTime.Now.ToString("ddMMMyyyy hh_mm_ss") + ".txt";
                idtextBoxReceivedMessage.AppendText("\r\nsFilePath = " + sFilePath);
                File.AppendAllText(sFilePath, "Log started ");
                bLogSubscription = true;
                idButtonSubLog.BackColor = System.Drawing.Color.LightGreen;
                idButtonSubLog.Text = "Logging";
            }
            else
            {
                bLogSubscription = false;
                idButtonSubLog.BackColor = System.Drawing.Color.Red;
            }
        }

        private void idButtonPublish_Click(object sender, EventArgs e)
        {
            if (mqttClient != null && mqttClient.IsConnected == true)
            {
                if (idTextBoxPublishTopic.Text == "")
                {
                    appendTextBox(idtextBoxPublishMessage, "Publish topic cannot be Blank");
                }
                else
                {
                    try
                    {
                        mqttClient.Publish(idTextBoxPublishTopic.Text, Encoding.UTF8.GetBytes(idtextBoxPublishMessage.Text));
                        iCntrMessageTransmit++;
                        idLabelTraMessageCounter.Invoke((MethodInvoker)(() => idLabelTraMessageCounter.Text = iCntrMessageTransmit.ToString()));
                    }
                    catch (Exception ex)
                    {
                        appendTextBox(idtextBoxPublishMessage, "Exc : " + ex.Message);
                    }
                }
            }
            else
                appendTextBox(idtextBoxPublishMessage, "Mqtt not connected");
        }

        private void idButtonPubClear_Click(object sender, EventArgs e)
        {
            idtextBoxPublishMessage.Text = "";
        }

        private void idButtonPubCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(idtextBoxPublishMessage.Text);
        }

        private void timerRTC_Tick(object sender, EventArgs e)
        {
            idLableRTC.Text = cGF.getCurrentDateTimeISTinDateTime().ToString("ddMMMyyyy HH:mm:ss");
        }

        private void idButtonGenClientID_Click(object sender, EventArgs e)
        {
            idTextBoxClientID.Text = cGF.RandomString(25);
            idTextBoxClientIDnew.Text = cGF.RandomString(25);
            idTextBoxClientIDnew21.Text = cGF.RandomString(25);
        }

        void saveSettings()
        {
            StringBuilder sbConfig = new StringBuilder();
            sbConfig.Append(idTextBoxClientID.Text + Environment.NewLine);//client ID
            sbConfig.Append(idTextBoxClientIDnew.Text + Environment.NewLine);//client ID
            sbConfig.Append(idTextBoxClientIDnew21.Text + Environment.NewLine);//client ID
            sbConfig.Append(idTextBoxHost.Text + Environment.NewLine);
            sbConfig.Append(idTextBoxPort.Text + Environment.NewLine);
            sbConfig.Append(idTextBoxUserName.Text + Environment.NewLine);
            sbConfig.Append(idTextBoxPassoword.Text + Environment.NewLine);
            sbConfig.Append(idTextBoxSubTopic.Text + Environment.NewLine);
            sbConfig.Append(idTextBoxPublishTopic.Text + Environment.NewLine);

            string sConfigFile = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            sConfigFile += "\\" + "config.txt";
            if (File.Exists(sConfigFile))
            {
                File.Delete(sConfigFile);
            }

            File.AppendAllText(sConfigFile, sbConfig.ToString());

        }

        void loadSavedSettings()
        {
            string sConfigFile = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            sConfigFile += "\\" + "config.txt";
            string sLine = "";
            int iLinecntr = 1;
            if (File.Exists(sConfigFile))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(sConfigFile);
                while ((sLine = file.ReadLine()) != null)
                {
                    switch (iLinecntr)
                    {
                        case 1:
                            idTextBoxClientID.Text = sLine;
                            break;
                        case 2:
                            idTextBoxClientIDnew.Text = sLine;
                            break;
                        case 3:
                            idTextBoxClientIDnew21.Text = sLine;
                            break;
                        case 4:
                            idTextBoxHost.Text = sLine;
                            break;
                        case 5:
                            idTextBoxPort.Text = sLine;
                            break;
                        case 6:
                            idTextBoxUserName.Text = sLine;
                            break;
                        case 7:
                            idTextBoxPassoword.Text = sLine;
                            break;
                        case 8:
                            idTextBoxSubTopic.Text = sLine;
                            break;
                        case 9:
                            idTextBoxPublishTopic.Text = sLine;
                            break;

                        default:

                            break;
                    }

                    iLinecntr++;
                }

                file.Close();
            }
            else
            {

            }
        }

        private void idTextBoxPort_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
