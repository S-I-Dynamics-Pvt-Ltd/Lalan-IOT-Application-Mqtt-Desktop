namespace mqtt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.idtextBoxReceivedMessage = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.idTextBoxClientID = new System.Windows.Forms.TextBox();
            this.idLabelConnectionID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTextBoxClientIDnew21 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idTextBoxClientIDnew = new System.Windows.Forms.TextBox();
            this.idButtonGenClientID = new System.Windows.Forms.Button();
            this.idButtonConnect = new System.Windows.Forms.Button();
            this.idLabelTraMessageCounter = new System.Windows.Forms.Label();
            this.idLabelRecMessageCounter = new System.Windows.Forms.Label();
            this.idLableRTC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idTextBoxPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idTextBoxHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBoxPassoword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBoxUserName = new System.Windows.Forms.TextBox();
            this.Subscribe = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTopic21 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTopic15 = new System.Windows.Forms.TextBox();
            this.idtextBoxReceivedMessage21 = new System.Windows.Forms.TextBox();
            this.idtextBoxReceivedMessage15 = new System.Windows.Forms.TextBox();
            this.idButtonSubLog = new System.Windows.Forms.Button();
            this.idButtonSubCopy = new System.Windows.Forms.Button();
            this.idButtonSubClear = new System.Windows.Forms.Button();
            this.idButtonSubscribe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idTextBoxSubTopic = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idButtonPubCopy = new System.Windows.Forms.Button();
            this.idButtonPubClear = new System.Windows.Forms.Button();
            this.idButtonPublish = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.idtextBoxPublishMessage = new System.Windows.Forms.TextBox();
            this.idTextBoxPublishTopic = new System.Windows.Forms.TextBox();
            this.timerRTC = new System.Windows.Forms.Timer(this.components);
            this.txterror = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.Subscribe.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idtextBoxReceivedMessage
            // 
            this.idtextBoxReceivedMessage.Location = new System.Drawing.Point(25, 91);
            this.idtextBoxReceivedMessage.Margin = new System.Windows.Forms.Padding(4);
            this.idtextBoxReceivedMessage.Multiline = true;
            this.idtextBoxReceivedMessage.Name = "idtextBoxReceivedMessage";
            this.idtextBoxReceivedMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.idtextBoxReceivedMessage.Size = new System.Drawing.Size(508, 530);
            this.idtextBoxReceivedMessage.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // idTextBoxClientID
            // 
            this.idTextBoxClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBoxClientID.Location = new System.Drawing.Point(152, 32);
            this.idTextBoxClientID.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBoxClientID.Name = "idTextBoxClientID";
            this.idTextBoxClientID.Size = new System.Drawing.Size(272, 30);
            this.idTextBoxClientID.TabIndex = 2;
            // 
            // idLabelConnectionID
            // 
            this.idLabelConnectionID.AutoSize = true;
            this.idLabelConnectionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabelConnectionID.Location = new System.Drawing.Point(20, 32);
            this.idLabelConnectionID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabelConnectionID.Name = "idLabelConnectionID";
            this.idLabelConnectionID.Size = new System.Drawing.Size(102, 25);
            this.idLabelConnectionID.TabIndex = 3;
            this.idLabelConnectionID.Text = "Client. ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idTextBoxClientIDnew21);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.idTextBoxClientIDnew);
            this.groupBox1.Controls.Add(this.idButtonGenClientID);
            this.groupBox1.Controls.Add(this.idButtonConnect);
            this.groupBox1.Controls.Add(this.idLabelTraMessageCounter);
            this.groupBox1.Controls.Add(this.idLabelRecMessageCounter);
            this.groupBox1.Controls.Add(this.idLableRTC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.idTextBoxPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.idTextBoxHost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idTextBoxPassoword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.idTextBoxUserName);
            this.groupBox1.Controls.Add(this.idLabelConnectionID);
            this.groupBox1.Controls.Add(this.idTextBoxClientID);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1091, 231);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ConnectionInfo";
            // 
            // idTextBoxClientIDnew21
            // 
            this.idTextBoxClientIDnew21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBoxClientIDnew21.Location = new System.Drawing.Point(152, 120);
            this.idTextBoxClientIDnew21.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBoxClientIDnew21.Name = "idTextBoxClientIDnew21";
            this.idTextBoxClientIDnew21.Size = new System.Drawing.Size(272, 30);
            this.idTextBoxClientIDnew21.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Client. ID 21:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Client. ID 15 :";
            // 
            // idTextBoxClientIDnew
            // 
            this.idTextBoxClientIDnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBoxClientIDnew.Location = new System.Drawing.Point(152, 80);
            this.idTextBoxClientIDnew.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBoxClientIDnew.Name = "idTextBoxClientIDnew";
            this.idTextBoxClientIDnew.Size = new System.Drawing.Size(272, 30);
            this.idTextBoxClientIDnew.TabIndex = 21;
            // 
            // idButtonGenClientID
            // 
            this.idButtonGenClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idButtonGenClientID.Location = new System.Drawing.Point(433, 32);
            this.idButtonGenClientID.Margin = new System.Windows.Forms.Padding(4);
            this.idButtonGenClientID.Name = "idButtonGenClientID";
            this.idButtonGenClientID.Size = new System.Drawing.Size(80, 32);
            this.idButtonGenClientID.TabIndex = 20;
            this.idButtonGenClientID.Text = "Gen";
            this.idButtonGenClientID.UseVisualStyleBackColor = true;
            this.idButtonGenClientID.Click += new System.EventHandler(this.idButtonGenClientID_Click);
            // 
            // idButtonConnect
            // 
            this.idButtonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idButtonConnect.Location = new System.Drawing.Point(583, 26);
            this.idButtonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.idButtonConnect.Name = "idButtonConnect";
            this.idButtonConnect.Size = new System.Drawing.Size(273, 42);
            this.idButtonConnect.TabIndex = 19;
            this.idButtonConnect.Text = "Connect";
            this.idButtonConnect.UseVisualStyleBackColor = true;
            this.idButtonConnect.Click += new System.EventHandler(this.idButtonConnect_Click);
            // 
            // idLabelTraMessageCounter
            // 
            this.idLabelTraMessageCounter.AutoSize = true;
            this.idLabelTraMessageCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabelTraMessageCounter.Location = new System.Drawing.Point(889, 195);
            this.idLabelTraMessageCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabelTraMessageCounter.Name = "idLabelTraMessageCounter";
            this.idLabelTraMessageCounter.Size = new System.Drawing.Size(53, 25);
            this.idLabelTraMessageCounter.TabIndex = 15;
            this.idLabelTraMessageCounter.Text = "Tra :";
            // 
            // idLabelRecMessageCounter
            // 
            this.idLabelRecMessageCounter.AutoSize = true;
            this.idLabelRecMessageCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabelRecMessageCounter.Location = new System.Drawing.Point(889, 156);
            this.idLabelRecMessageCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabelRecMessageCounter.Name = "idLabelRecMessageCounter";
            this.idLabelRecMessageCounter.Size = new System.Drawing.Size(57, 25);
            this.idLabelRecMessageCounter.TabIndex = 13;
            this.idLabelRecMessageCounter.Text = "Rec :";
            // 
            // idLableRTC
            // 
            this.idLableRTC.AutoSize = true;
            this.idLableRTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLableRTC.Location = new System.Drawing.Point(888, 25);
            this.idLableRTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLableRTC.Name = "idLableRTC";
            this.idLableRTC.Size = new System.Drawing.Size(53, 25);
            this.idLableRTC.TabIndex = 12;
            this.idLableRTC.Text = "RTC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Port :";
            // 
            // idTextBoxPort
            // 
            this.idTextBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBoxPort.Location = new System.Drawing.Point(584, 155);
            this.idTextBoxPort.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBoxPort.Name = "idTextBoxPort";
            this.idTextBoxPort.Size = new System.Drawing.Size(272, 30);
            this.idTextBoxPort.TabIndex = 10;
            this.idTextBoxPort.Text = "1883";
            this.idTextBoxPort.TextChanged += new System.EventHandler(this.idTextBoxPort_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Host :";
            // 
            // idTextBoxHost
            // 
            this.idTextBoxHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBoxHost.Location = new System.Drawing.Point(152, 155);
            this.idTextBoxHost.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBoxHost.Name = "idTextBoxHost";
            this.idTextBoxHost.Size = new System.Drawing.Size(272, 30);
            this.idTextBoxHost.TabIndex = 8;
            this.idTextBoxHost.Text = "localhost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password :";
            // 
            // idTextBoxPassoword
            // 
            this.idTextBoxPassoword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBoxPassoword.Location = new System.Drawing.Point(584, 195);
            this.idTextBoxPassoword.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBoxPassoword.Name = "idTextBoxPassoword";
            this.idTextBoxPassoword.Size = new System.Drawing.Size(272, 30);
            this.idTextBoxPassoword.TabIndex = 6;
            this.idTextBoxPassoword.Text = "satish";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName :";
            // 
            // idTextBoxUserName
            // 
            this.idTextBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBoxUserName.Location = new System.Drawing.Point(152, 195);
            this.idTextBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBoxUserName.Name = "idTextBoxUserName";
            this.idTextBoxUserName.Size = new System.Drawing.Size(272, 30);
            this.idTextBoxUserName.TabIndex = 4;
            this.idTextBoxUserName.Text = "yantra";
            // 
            // Subscribe
            // 
            this.Subscribe.Controls.Add(this.label8);
            this.Subscribe.Controls.Add(this.txtTopic21);
            this.Subscribe.Controls.Add(this.label7);
            this.Subscribe.Controls.Add(this.txtTopic15);
            this.Subscribe.Controls.Add(this.idtextBoxReceivedMessage21);
            this.Subscribe.Controls.Add(this.idtextBoxReceivedMessage15);
            this.Subscribe.Controls.Add(this.idButtonSubLog);
            this.Subscribe.Controls.Add(this.idButtonSubCopy);
            this.Subscribe.Controls.Add(this.idButtonSubClear);
            this.Subscribe.Controls.Add(this.idButtonSubscribe);
            this.Subscribe.Controls.Add(this.label5);
            this.Subscribe.Controls.Add(this.idtextBoxReceivedMessage);
            this.Subscribe.Controls.Add(this.idTextBoxSubTopic);
            this.Subscribe.Location = new System.Drawing.Point(16, 246);
            this.Subscribe.Margin = new System.Windows.Forms.Padding(4);
            this.Subscribe.Name = "Subscribe";
            this.Subscribe.Padding = new System.Windows.Forms.Padding(4);
            this.Subscribe.Size = new System.Drawing.Size(1149, 679);
            this.Subscribe.TabIndex = 5;
            this.Subscribe.TabStop = false;
            this.Subscribe.Text = "Subscribe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(546, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Topic :";
            // 
            // txtTopic21
            // 
            this.txtTopic21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopic21.Location = new System.Drawing.Point(626, 180);
            this.txtTopic21.Margin = new System.Windows.Forms.Padding(4);
            this.txtTopic21.Name = "txtTopic21";
            this.txtTopic21.Size = new System.Drawing.Size(350, 30);
            this.txtTopic21.TabIndex = 28;
            this.txtTopic21.Text = "10000021";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Topic :";
            // 
            // txtTopic15
            // 
            this.txtTopic15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopic15.Location = new System.Drawing.Point(626, 57);
            this.txtTopic15.Margin = new System.Windows.Forms.Padding(4);
            this.txtTopic15.Name = "txtTopic15";
            this.txtTopic15.Size = new System.Drawing.Size(350, 30);
            this.txtTopic15.TabIndex = 26;
            this.txtTopic15.Text = "10000015";
            // 
            // idtextBoxReceivedMessage21
            // 
            this.idtextBoxReceivedMessage21.Location = new System.Drawing.Point(541, 218);
            this.idtextBoxReceivedMessage21.Margin = new System.Windows.Forms.Padding(4);
            this.idtextBoxReceivedMessage21.Multiline = true;
            this.idtextBoxReceivedMessage21.Name = "idtextBoxReceivedMessage21";
            this.idtextBoxReceivedMessage21.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.idtextBoxReceivedMessage21.Size = new System.Drawing.Size(608, 403);
            this.idtextBoxReceivedMessage21.TabIndex = 25;
            // 
            // idtextBoxReceivedMessage15
            // 
            this.idtextBoxReceivedMessage15.Location = new System.Drawing.Point(541, 91);
            this.idtextBoxReceivedMessage15.Margin = new System.Windows.Forms.Padding(4);
            this.idtextBoxReceivedMessage15.Multiline = true;
            this.idtextBoxReceivedMessage15.Name = "idtextBoxReceivedMessage15";
            this.idtextBoxReceivedMessage15.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.idtextBoxReceivedMessage15.Size = new System.Drawing.Size(608, 81);
            this.idtextBoxReceivedMessage15.TabIndex = 24;
            // 
            // idButtonSubLog
            // 
            this.idButtonSubLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idButtonSubLog.Location = new System.Drawing.Point(388, 629);
            this.idButtonSubLog.Margin = new System.Windows.Forms.Padding(4);
            this.idButtonSubLog.Name = "idButtonSubLog";
            this.idButtonSubLog.Size = new System.Drawing.Size(145, 42);
            this.idButtonSubLog.TabIndex = 23;
            this.idButtonSubLog.Text = "LOG";
            this.idButtonSubLog.UseVisualStyleBackColor = true;
            this.idButtonSubLog.Click += new System.EventHandler(this.idButtonSubLog_Click);
            // 
            // idButtonSubCopy
            // 
            this.idButtonSubCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idButtonSubCopy.Location = new System.Drawing.Point(214, 629);
            this.idButtonSubCopy.Margin = new System.Windows.Forms.Padding(4);
            this.idButtonSubCopy.Name = "idButtonSubCopy";
            this.idButtonSubCopy.Size = new System.Drawing.Size(145, 42);
            this.idButtonSubCopy.TabIndex = 22;
            this.idButtonSubCopy.Text = "Copy";
            this.idButtonSubCopy.UseVisualStyleBackColor = true;
            this.idButtonSubCopy.Click += new System.EventHandler(this.idButtonSubCopy_Click);
            // 
            // idButtonSubClear
            // 
            this.idButtonSubClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idButtonSubClear.Location = new System.Drawing.Point(24, 629);
            this.idButtonSubClear.Margin = new System.Windows.Forms.Padding(4);
            this.idButtonSubClear.Name = "idButtonSubClear";
            this.idButtonSubClear.Size = new System.Drawing.Size(145, 42);
            this.idButtonSubClear.TabIndex = 21;
            this.idButtonSubClear.Text = "Clear";
            this.idButtonSubClear.UseVisualStyleBackColor = true;
            this.idButtonSubClear.Click += new System.EventHandler(this.idButtonSubClear_Click);
            // 
            // idButtonSubscribe
            // 
            this.idButtonSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idButtonSubscribe.Location = new System.Drawing.Point(368, 28);
            this.idButtonSubscribe.Margin = new System.Windows.Forms.Padding(4);
            this.idButtonSubscribe.Name = "idButtonSubscribe";
            this.idButtonSubscribe.Size = new System.Drawing.Size(145, 42);
            this.idButtonSubscribe.TabIndex = 20;
            this.idButtonSubscribe.Text = "Subscribe";
            this.idButtonSubscribe.UseVisualStyleBackColor = true;
            this.idButtonSubscribe.Click += new System.EventHandler(this.idButtonSubscribe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Topic :";
            // 
            // idTextBoxSubTopic
            // 
            this.idTextBoxSubTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBoxSubTopic.Location = new System.Drawing.Point(101, 33);
            this.idTextBoxSubTopic.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBoxSubTopic.Name = "idTextBoxSubTopic";
            this.idTextBoxSubTopic.Size = new System.Drawing.Size(257, 30);
            this.idTextBoxSubTopic.TabIndex = 16;
            this.idTextBoxSubTopic.Text = "topicTest";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.idButtonPubCopy);
            this.groupBox2.Controls.Add(this.idButtonPubClear);
            this.groupBox2.Controls.Add(this.idButtonPublish);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.idtextBoxPublishMessage);
            this.groupBox2.Controls.Add(this.idTextBoxPublishTopic);
            this.groupBox2.Location = new System.Drawing.Point(1173, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(491, 296);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Publish";
            // 
            // idButtonPubCopy
            // 
            this.idButtonPubCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idButtonPubCopy.Location = new System.Drawing.Point(355, 241);
            this.idButtonPubCopy.Margin = new System.Windows.Forms.Padding(4);
            this.idButtonPubCopy.Name = "idButtonPubCopy";
            this.idButtonPubCopy.Size = new System.Drawing.Size(85, 42);
            this.idButtonPubCopy.TabIndex = 22;
            this.idButtonPubCopy.Text = "Copy";
            this.idButtonPubCopy.UseVisualStyleBackColor = true;
            this.idButtonPubCopy.Click += new System.EventHandler(this.idButtonPubCopy_Click);
            // 
            // idButtonPubClear
            // 
            this.idButtonPubClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idButtonPubClear.Location = new System.Drawing.Point(254, 243);
            this.idButtonPubClear.Margin = new System.Windows.Forms.Padding(4);
            this.idButtonPubClear.Name = "idButtonPubClear";
            this.idButtonPubClear.Size = new System.Drawing.Size(93, 42);
            this.idButtonPubClear.TabIndex = 21;
            this.idButtonPubClear.Text = "Clear";
            this.idButtonPubClear.UseVisualStyleBackColor = true;
            this.idButtonPubClear.Click += new System.EventHandler(this.idButtonPubClear_Click);
            // 
            // idButtonPublish
            // 
            this.idButtonPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idButtonPublish.Location = new System.Drawing.Point(131, 242);
            this.idButtonPublish.Margin = new System.Windows.Forms.Padding(4);
            this.idButtonPublish.Name = "idButtonPublish";
            this.idButtonPublish.Size = new System.Drawing.Size(115, 42);
            this.idButtonPublish.TabIndex = 20;
            this.idButtonPublish.Text = "Publish";
            this.idButtonPublish.UseVisualStyleBackColor = true;
            this.idButtonPublish.Click += new System.EventHandler(this.idButtonPublish_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Topic :";
            // 
            // idtextBoxPublishMessage
            // 
            this.idtextBoxPublishMessage.Location = new System.Drawing.Point(25, 91);
            this.idtextBoxPublishMessage.Margin = new System.Windows.Forms.Padding(4);
            this.idtextBoxPublishMessage.Multiline = true;
            this.idtextBoxPublishMessage.Name = "idtextBoxPublishMessage";
            this.idtextBoxPublishMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.idtextBoxPublishMessage.Size = new System.Drawing.Size(462, 142);
            this.idtextBoxPublishMessage.TabIndex = 0;
            // 
            // idTextBoxPublishTopic
            // 
            this.idTextBoxPublishTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBoxPublishTopic.Location = new System.Drawing.Point(100, 34);
            this.idTextBoxPublishTopic.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBoxPublishTopic.Name = "idTextBoxPublishTopic";
            this.idTextBoxPublishTopic.Size = new System.Drawing.Size(228, 30);
            this.idTextBoxPublishTopic.TabIndex = 16;
            this.idTextBoxPublishTopic.Text = "topicTe";
            // 
            // timerRTC
            // 
            this.timerRTC.Interval = 1000;
            this.timerRTC.Tick += new System.EventHandler(this.timerRTC_Tick);
            // 
            // txterror
            // 
            this.txterror.Location = new System.Drawing.Point(1173, 332);
            this.txterror.Margin = new System.Windows.Forms.Padding(4);
            this.txterror.Multiline = true;
            this.txterror.Name = "txterror";
            this.txterror.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txterror.Size = new System.Drawing.Size(487, 535);
            this.txterror.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 938);
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Subscribe);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "LALAN PROJECT - MQTT App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Close);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Subscribe.ResumeLayout(false);
            this.Subscribe.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            // valueArray initializing
            valueArray[0] = new object[] { "10000010", 0 };
            valueArray[1] = new object[] { "10000011", 0 };
            valueArray[2] = new object[] { "10000012", 0 };
            valueArray[3] = new object[] { "10000013", 0 };
            valueArray[4] = new object[] { "10000014", 0 };
            valueArray[5] = new object[] { "10000017", 0 };
        }

        #endregion

        private System.Windows.Forms.TextBox idtextBoxReceivedMessage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox idTextBoxClientID;
        private System.Windows.Forms.Label idLabelConnectionID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label idLabelTraMessageCounter;
        private System.Windows.Forms.Label idLabelRecMessageCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTextBoxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTextBoxHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBoxPassoword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBoxUserName;
        private System.Windows.Forms.GroupBox Subscribe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTextBoxSubTopic;
        private System.Windows.Forms.Button idButtonConnect;
        private System.Windows.Forms.Label idLableRTC;
        private System.Windows.Forms.Button idButtonSubscribe;
        private System.Windows.Forms.Button idButtonSubLog;
        private System.Windows.Forms.Button idButtonSubCopy;
        private System.Windows.Forms.Button idButtonSubClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button idButtonPubCopy;
        private System.Windows.Forms.Button idButtonPubClear;
        private System.Windows.Forms.Button idButtonPublish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idtextBoxPublishMessage;
        private System.Windows.Forms.TextBox idTextBoxPublishTopic;
        private System.Windows.Forms.Timer timerRTC;
        private System.Windows.Forms.Button idButtonGenClientID;
        private System.Windows.Forms.TextBox idtextBoxReceivedMessage21;
        private System.Windows.Forms.TextBox idtextBoxReceivedMessage15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTopic21;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTopic15;
        private System.Windows.Forms.TextBox idTextBoxClientIDnew;
        private System.Windows.Forms.TextBox idTextBoxClientIDnew21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txterror;
    }
}

