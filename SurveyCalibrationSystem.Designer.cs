﻿namespace Trolley_Control
{
    partial class Tunnel_Control_Form
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
            this.Go_Stop_Button = new System.Windows.Forms.Button();
            this.Forward_Reverse_Button = new System.Windows.Forms.Button();
            this.Bluetooth_Virtual_Serial_Port = new System.IO.Ports.SerialPort(this.components);
            this.Motor_Speed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BeamStrength = new System.Windows.Forms.ProgressBar();
            this.BeamStrength_label = new System.Windows.Forms.Label();
            this.FileMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMeasurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abortMeasurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTemperatureConfigFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Laser_Reading = new System.Windows.Forms.TextBox();
            this.Reset_Laser = new System.Windows.Forms.Button();
            this.DUTHostName = new System.Windows.Forms.TextBox();
            this.DUT_Server_label = new System.Windows.Forms.Label();
            this.Laser_Control = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nm_label = new System.Windows.Forms.Label();
            this.VacuumWavelenthTextbox = new System.Windows.Forms.TextBox();
            this.Laser_Reading_Label = new System.Windows.Forms.Label();
            this.DUT_Groupbox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DUT_Wavelength = new System.Windows.Forms.TextBox();
            this.Stdev_Textbox = new System.Windows.Forms.TextBox();
            this.Stdev_label = new System.Windows.Forms.Label();
            this.DUT_Read = new System.Windows.Forms.Button();
            this.DUT_Reading_Label = new System.Windows.Forms.Label();
            this.EDM_Reading = new System.Windows.Forms.TextBox();
            this.Bluetooth_Groupbox = new System.Windows.Forms.GroupBox();
            this.Connections_Label = new System.Windows.Forms.Label();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Status_Textbox = new System.Windows.Forms.TextBox();
            this.Bluetooth_Listbox = new System.Windows.Forms.ListBox();
            this.Targets_RichTextbox = new System.Windows.Forms.RichTextBox();
            this.Targets_Label = new System.Windows.Forms.Label();
            this.LaserParameters = new System.Windows.Forms.RichTextBox();
            this.Laser_Parameters_Label = new System.Windows.Forms.Label();
            this.HumidityLoggerHostName1_label = new System.Windows.Forms.Label();
            this.HumidityLoggerHostName_label = new System.Windows.Forms.Label();
            this.Humidity_logger_1 = new System.Windows.Forms.TextBox();
            this.Humidity_logger_2 = new System.Windows.Forms.TextBox();
            this.EDMRadioButton = new System.Windows.Forms.RadioButton();
            this.TotalStationRadioButton = new System.Windows.Forms.RadioButton();
            this.AuxLaserRadioButton = new System.Windows.Forms.RadioButton();
            this.openConfigFile = new System.Windows.Forms.OpenFileDialog();
            this.CO2_Level = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Motor_Speed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.FileMenu.SuspendLayout();
            this.Laser_Control.SuspendLayout();
            this.DUT_Groupbox.SuspendLayout();
            this.Bluetooth_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Go_Stop_Button
            // 
            this.Go_Stop_Button.Location = new System.Drawing.Point(16, 19);
            this.Go_Stop_Button.Name = "Go_Stop_Button";
            this.Go_Stop_Button.Size = new System.Drawing.Size(296, 23);
            this.Go_Stop_Button.TabIndex = 3;
            this.Go_Stop_Button.Text = "Set In Motion";
            this.Go_Stop_Button.UseVisualStyleBackColor = true;
            this.Go_Stop_Button.Click += new System.EventHandler(this.Go_Stop_Button_Click);
            // 
            // Forward_Reverse_Button
            // 
            this.Forward_Reverse_Button.Location = new System.Drawing.Point(16, 48);
            this.Forward_Reverse_Button.Name = "Forward_Reverse_Button";
            this.Forward_Reverse_Button.Size = new System.Drawing.Size(296, 23);
            this.Forward_Reverse_Button.TabIndex = 4;
            this.Forward_Reverse_Button.Text = "Toggle Forward Reverse";
            this.Forward_Reverse_Button.UseVisualStyleBackColor = true;
            this.Forward_Reverse_Button.Click += new System.EventHandler(this.Forward_Reverse_Button_Click);
            // 
            // Motor_Speed
            // 
            this.Motor_Speed.LargeChange = 20;
            this.Motor_Speed.Location = new System.Drawing.Point(16, 101);
            this.Motor_Speed.Maximum = 0;
            this.Motor_Speed.Minimum = -255;
            this.Motor_Speed.Name = "Motor_Speed";
            this.Motor_Speed.Size = new System.Drawing.Size(306, 45);
            this.Motor_Speed.TabIndex = 5;
            this.Motor_Speed.TickFrequency = 10;
            this.Motor_Speed.Scroll += new System.EventHandler(this.Motor_Speed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Motor Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Min";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Go_Stop_Button);
            this.groupBox1.Controls.Add(this.Forward_Reverse_Button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Motor_Speed);
            this.groupBox1.Location = new System.Drawing.Point(12, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 154);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motor Controls";
            // 
            // BeamStrength
            // 
            this.BeamStrength.Location = new System.Drawing.Point(56, 115);
            this.BeamStrength.Name = "BeamStrength";
            this.BeamStrength.Size = new System.Drawing.Size(121, 23);
            this.BeamStrength.TabIndex = 11;
            // 
            // BeamStrength_label
            // 
            this.BeamStrength_label.AutoSize = true;
            this.BeamStrength_label.Location = new System.Drawing.Point(56, 98);
            this.BeamStrength_label.Name = "BeamStrength_label";
            this.BeamStrength_label.Size = new System.Drawing.Size(77, 13);
            this.BeamStrength_label.TabIndex = 12;
            this.BeamStrength_label.Text = "Beam Strength";
            // 
            // FileMenu
            // 
            this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.FileMenu.Location = new System.Drawing.Point(0, 0);
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(1233, 24);
            this.FileMenu.TabIndex = 13;
            this.FileMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.startMeasurementToolStripMenuItem,
            this.abortMeasurementToolStripMenuItem,
            this.loadTemperatureConfigFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // startMeasurementToolStripMenuItem
            // 
            this.startMeasurementToolStripMenuItem.Name = "startMeasurementToolStripMenuItem";
            this.startMeasurementToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.startMeasurementToolStripMenuItem.Text = "Start Measurement";
            this.startMeasurementToolStripMenuItem.Click += new System.EventHandler(this.startMeasurementToolStripMenuItem_Click);
            // 
            // abortMeasurementToolStripMenuItem
            // 
            this.abortMeasurementToolStripMenuItem.Name = "abortMeasurementToolStripMenuItem";
            this.abortMeasurementToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.abortMeasurementToolStripMenuItem.Text = "Abort Measurement";
            this.abortMeasurementToolStripMenuItem.Click += new System.EventHandler(this.abortMeasurementToolStripMenuItem_Click);
            // 
            // loadTemperatureConfigFileToolStripMenuItem
            // 
            this.loadTemperatureConfigFileToolStripMenuItem.Name = "loadTemperatureConfigFileToolStripMenuItem";
            this.loadTemperatureConfigFileToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.loadTemperatureConfigFileToolStripMenuItem.Text = "Load Temperature Config File";
            this.loadTemperatureConfigFileToolStripMenuItem.Click += new System.EventHandler(this.loadTemperatureConfigFileToolStripMenuItem_Click);
            // 
            // Laser_Reading
            // 
            this.Laser_Reading.Location = new System.Drawing.Point(56, 163);
            this.Laser_Reading.Name = "Laser_Reading";
            this.Laser_Reading.Size = new System.Drawing.Size(121, 20);
            this.Laser_Reading.TabIndex = 14;
            this.Laser_Reading.Text = "0.000000";
            this.Laser_Reading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Reset_Laser
            // 
            this.Reset_Laser.Location = new System.Drawing.Point(6, 98);
            this.Reset_Laser.Name = "Reset_Laser";
            this.Reset_Laser.Size = new System.Drawing.Size(44, 85);
            this.Reset_Laser.TabIndex = 16;
            this.Reset_Laser.Text = "Reset";
            this.Reset_Laser.UseVisualStyleBackColor = true;
            this.Reset_Laser.Click += new System.EventHandler(this.Reset_Laser_Click);
            // 
            // DUTHostName
            // 
            this.DUTHostName.Location = new System.Drawing.Point(173, 31);
            this.DUTHostName.Name = "DUTHostName";
            this.DUTHostName.Size = new System.Drawing.Size(177, 20);
            this.DUTHostName.TabIndex = 17;
            this.DUTHostName.Text = "CISS29758";
            this.DUTHostName.TextChanged += new System.EventHandler(this.EDMHostName_TextChanged);
            // 
            // DUT_Server_label
            // 
            this.DUT_Server_label.AutoSize = true;
            this.DUT_Server_label.Location = new System.Drawing.Point(15, 34);
            this.DUT_Server_label.Name = "DUT_Server_label";
            this.DUT_Server_label.Size = new System.Drawing.Size(120, 13);
            this.DUT_Server_label.TabIndex = 18;
            this.DUT_Server_label.Text = "DUT Server Host Name";
            // 
            // Laser_Control
            // 
            this.Laser_Control.Controls.Add(this.label4);
            this.Laser_Control.Controls.Add(this.nm_label);
            this.Laser_Control.Controls.Add(this.VacuumWavelenthTextbox);
            this.Laser_Control.Controls.Add(this.Laser_Reading_Label);
            this.Laser_Control.Controls.Add(this.Reset_Laser);
            this.Laser_Control.Controls.Add(this.BeamStrength_label);
            this.Laser_Control.Controls.Add(this.Laser_Reading);
            this.Laser_Control.Controls.Add(this.BeamStrength);
            this.Laser_Control.Location = new System.Drawing.Point(12, 357);
            this.Laser_Control.Name = "Laser_Control";
            this.Laser_Control.Size = new System.Drawing.Size(183, 189);
            this.Laser_Control.TabIndex = 19;
            this.Laser_Control.TabStop = false;
            this.Laser_Control.Text = "Laser Control";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vacuum Wavelength";
            // 
            // nm_label
            // 
            this.nm_label.AutoSize = true;
            this.nm_label.Location = new System.Drawing.Point(151, 48);
            this.nm_label.Name = "nm_label";
            this.nm_label.Size = new System.Drawing.Size(21, 13);
            this.nm_label.TabIndex = 33;
            this.nm_label.Text = "nm";
            // 
            // VacuumWavelenthTextbox
            // 
            this.VacuumWavelenthTextbox.Location = new System.Drawing.Point(9, 45);
            this.VacuumWavelenthTextbox.Name = "VacuumWavelenthTextbox";
            this.VacuumWavelenthTextbox.Size = new System.Drawing.Size(139, 20);
            this.VacuumWavelenthTextbox.TabIndex = 33;
            this.VacuumWavelenthTextbox.Text = "632.991474";
            this.VacuumWavelenthTextbox.TextChanged += new System.EventHandler(this.VacuumWavelenthTextbox_TextChanged);
            // 
            // Laser_Reading_Label
            // 
            this.Laser_Reading_Label.AutoSize = true;
            this.Laser_Reading_Label.Location = new System.Drawing.Point(56, 143);
            this.Laser_Reading_Label.Name = "Laser_Reading_Label";
            this.Laser_Reading_Label.Size = new System.Drawing.Size(93, 13);
            this.Laser_Reading_Label.TabIndex = 21;
            this.Laser_Reading_Label.Text = "Laser Reading (m)";
            // 
            // DUT_Groupbox
            // 
            this.DUT_Groupbox.Controls.Add(this.label7);
            this.DUT_Groupbox.Controls.Add(this.label5);
            this.DUT_Groupbox.Controls.Add(this.DUT_Wavelength);
            this.DUT_Groupbox.Controls.Add(this.Stdev_Textbox);
            this.DUT_Groupbox.Controls.Add(this.Stdev_label);
            this.DUT_Groupbox.Controls.Add(this.DUT_Read);
            this.DUT_Groupbox.Controls.Add(this.DUT_Reading_Label);
            this.DUT_Groupbox.Controls.Add(this.EDM_Reading);
            this.DUT_Groupbox.Location = new System.Drawing.Point(201, 357);
            this.DUT_Groupbox.Name = "DUT_Groupbox";
            this.DUT_Groupbox.Size = new System.Drawing.Size(149, 189);
            this.DUT_Groupbox.TabIndex = 20;
            this.DUT_Groupbox.TabStop = false;
            this.DUT_Groupbox.Text = "DUT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "nm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Vacuum Wavelength";
            // 
            // DUT_Wavelength
            // 
            this.DUT_Wavelength.Location = new System.Drawing.Point(9, 45);
            this.DUT_Wavelength.Name = "DUT_Wavelength";
            this.DUT_Wavelength.Size = new System.Drawing.Size(104, 20);
            this.DUT_Wavelength.TabIndex = 5;
            this.DUT_Wavelength.Text = "850.000000";
            this.DUT_Wavelength.TextChanged += new System.EventHandler(this.DUT_Wavelength_TextChanged);
            // 
            // Stdev_Textbox
            // 
            this.Stdev_Textbox.Location = new System.Drawing.Point(11, 163);
            this.Stdev_Textbox.Name = "Stdev_Textbox";
            this.Stdev_Textbox.Size = new System.Drawing.Size(132, 20);
            this.Stdev_Textbox.TabIndex = 4;
            this.Stdev_Textbox.Text = "0.000000";
            // 
            // Stdev_label
            // 
            this.Stdev_label.AutoSize = true;
            this.Stdev_label.Location = new System.Drawing.Point(8, 143);
            this.Stdev_label.Name = "Stdev_label";
            this.Stdev_label.Size = new System.Drawing.Size(115, 13);
            this.Stdev_label.TabIndex = 3;
            this.Stdev_label.Text = "Standard Deviation (m)";
            // 
            // DUT_Read
            // 
            this.DUT_Read.Location = new System.Drawing.Point(11, 74);
            this.DUT_Read.Name = "DUT_Read";
            this.DUT_Read.Size = new System.Drawing.Size(80, 23);
            this.DUT_Read.TabIndex = 2;
            this.DUT_Read.Text = "Read";
            this.DUT_Read.UseVisualStyleBackColor = true;
            this.DUT_Read.Click += new System.EventHandler(this.DUT_Read_Click);
            // 
            // DUT_Reading_Label
            // 
            this.DUT_Reading_Label.AutoSize = true;
            this.DUT_Reading_Label.Location = new System.Drawing.Point(8, 101);
            this.DUT_Reading_Label.Name = "DUT_Reading_Label";
            this.DUT_Reading_Label.Size = new System.Drawing.Size(90, 13);
            this.DUT_Reading_Label.TabIndex = 1;
            this.DUT_Reading_Label.Text = "DUT Reading (m)";
            // 
            // EDM_Reading
            // 
            this.EDM_Reading.Location = new System.Drawing.Point(9, 115);
            this.EDM_Reading.Name = "EDM_Reading";
            this.EDM_Reading.Size = new System.Drawing.Size(132, 20);
            this.EDM_Reading.TabIndex = 0;
            this.EDM_Reading.Text = "0.000000";
            // 
            // Bluetooth_Groupbox
            // 
            this.Bluetooth_Groupbox.Controls.Add(this.Connections_Label);
            this.Bluetooth_Groupbox.Controls.Add(this.Status_Label);
            this.Bluetooth_Groupbox.Controls.Add(this.Status_Textbox);
            this.Bluetooth_Groupbox.Controls.Add(this.Bluetooth_Listbox);
            this.Bluetooth_Groupbox.Location = new System.Drawing.Point(12, 552);
            this.Bluetooth_Groupbox.Name = "Bluetooth_Groupbox";
            this.Bluetooth_Groupbox.Size = new System.Drawing.Size(338, 177);
            this.Bluetooth_Groupbox.TabIndex = 21;
            this.Bluetooth_Groupbox.TabStop = false;
            this.Bluetooth_Groupbox.Text = "Bluetooth Connection Information";
            // 
            // Connections_Label
            // 
            this.Connections_Label.AutoSize = true;
            this.Connections_Label.Location = new System.Drawing.Point(13, 77);
            this.Connections_Label.Name = "Connections_Label";
            this.Connections_Label.Size = new System.Drawing.Size(108, 13);
            this.Connections_Label.TabIndex = 3;
            this.Connections_Label.Text = "Availible Connections";
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Location = new System.Drawing.Point(13, 27);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(37, 13);
            this.Status_Label.TabIndex = 2;
            this.Status_Label.Text = "Status";
            // 
            // Status_Textbox
            // 
            this.Status_Textbox.Location = new System.Drawing.Point(16, 43);
            this.Status_Textbox.Name = "Status_Textbox";
            this.Status_Textbox.Size = new System.Drawing.Size(264, 20);
            this.Status_Textbox.TabIndex = 1;
            this.Status_Textbox.Text = "Start up";
            // 
            // Bluetooth_Listbox
            // 
            this.Bluetooth_Listbox.FormattingEnabled = true;
            this.Bluetooth_Listbox.Location = new System.Drawing.Point(16, 93);
            this.Bluetooth_Listbox.Name = "Bluetooth_Listbox";
            this.Bluetooth_Listbox.Size = new System.Drawing.Size(264, 69);
            this.Bluetooth_Listbox.TabIndex = 0;
            // 
            // Targets_RichTextbox
            // 
            this.Targets_RichTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Targets_RichTextbox.Location = new System.Drawing.Point(376, 47);
            this.Targets_RichTextbox.Name = "Targets_RichTextbox";
            this.Targets_RichTextbox.Size = new System.Drawing.Size(433, 682);
            this.Targets_RichTextbox.TabIndex = 22;
            this.Targets_RichTextbox.Text = "";
            // 
            // Targets_Label
            // 
            this.Targets_Label.AutoSize = true;
            this.Targets_Label.Location = new System.Drawing.Point(373, 31);
            this.Targets_Label.Name = "Targets_Label";
            this.Targets_Label.Size = new System.Drawing.Size(60, 13);
            this.Targets_Label.TabIndex = 23;
            this.Targets_Label.Text = "Targets (m)";
            // 
            // LaserParameters
            // 
            this.LaserParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LaserParameters.Location = new System.Drawing.Point(842, 47);
            this.LaserParameters.Name = "LaserParameters";
            this.LaserParameters.Size = new System.Drawing.Size(344, 669);
            this.LaserParameters.TabIndex = 24;
            this.LaserParameters.Text = "";
            // 
            // Laser_Parameters_Label
            // 
            this.Laser_Parameters_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Laser_Parameters_Label.AutoSize = true;
            this.Laser_Parameters_Label.Location = new System.Drawing.Point(839, 31);
            this.Laser_Parameters_Label.Name = "Laser_Parameters_Label";
            this.Laser_Parameters_Label.Size = new System.Drawing.Size(180, 13);
            this.Laser_Parameters_Label.TabIndex = 25;
            this.Laser_Parameters_Label.Text = "Environmental and Laser Parameters";
            // 
            // HumidityLoggerHostName1_label
            // 
            this.HumidityLoggerHostName1_label.AutoSize = true;
            this.HumidityLoggerHostName1_label.Location = new System.Drawing.Point(15, 60);
            this.HumidityLoggerHostName1_label.Name = "HumidityLoggerHostName1_label";
            this.HumidityLoggerHostName1_label.Size = new System.Drawing.Size(158, 13);
            this.HumidityLoggerHostName1_label.TabIndex = 26;
            this.HumidityLoggerHostName1_label.Text = "Humidity Logger 1 Host Address";
            // 
            // HumidityLoggerHostName_label
            // 
            this.HumidityLoggerHostName_label.AutoSize = true;
            this.HumidityLoggerHostName_label.Location = new System.Drawing.Point(15, 85);
            this.HumidityLoggerHostName_label.Name = "HumidityLoggerHostName_label";
            this.HumidityLoggerHostName_label.Size = new System.Drawing.Size(158, 13);
            this.HumidityLoggerHostName_label.TabIndex = 27;
            this.HumidityLoggerHostName_label.Text = "Humidity Logger 2 Host Address";
            // 
            // Humidity_logger_1
            // 
            this.Humidity_logger_1.Location = new System.Drawing.Point(173, 57);
            this.Humidity_logger_1.Name = "Humidity_logger_1";
            this.Humidity_logger_1.Size = new System.Drawing.Size(177, 20);
            this.Humidity_logger_1.TabIndex = 28;
            this.Humidity_logger_1.Text = "131.203.15.84";
            this.Humidity_logger_1.TextChanged += new System.EventHandler(this.Humidity_logger_1_TextChanged);
            // 
            // Humidity_logger_2
            // 
            this.Humidity_logger_2.Location = new System.Drawing.Point(173, 82);
            this.Humidity_logger_2.Name = "Humidity_logger_2";
            this.Humidity_logger_2.Size = new System.Drawing.Size(177, 20);
            this.Humidity_logger_2.TabIndex = 29;
            this.Humidity_logger_2.Text = "131.203.13.216";
            this.Humidity_logger_2.TextChanged += new System.EventHandler(this.Humidity_logger_2_TextChanged);
            // 
            // EDMRadioButton
            // 
            this.EDMRadioButton.AutoSize = true;
            this.EDMRadioButton.Checked = true;
            this.EDMRadioButton.Location = new System.Drawing.Point(18, 161);
            this.EDMRadioButton.Name = "EDMRadioButton";
            this.EDMRadioButton.Size = new System.Drawing.Size(49, 17);
            this.EDMRadioButton.TabIndex = 30;
            this.EDMRadioButton.TabStop = true;
            this.EDMRadioButton.Text = "EDM";
            this.EDMRadioButton.UseVisualStyleBackColor = true;
            this.EDMRadioButton.CheckedChanged += new System.EventHandler(this.EDMRadioButton_CheckedChanged);
            // 
            // TotalStationRadioButton
            // 
            this.TotalStationRadioButton.AutoSize = true;
            this.TotalStationRadioButton.Location = new System.Drawing.Point(137, 161);
            this.TotalStationRadioButton.Name = "TotalStationRadioButton";
            this.TotalStationRadioButton.Size = new System.Drawing.Size(85, 17);
            this.TotalStationRadioButton.TabIndex = 31;
            this.TotalStationRadioButton.Text = "Total Station";
            this.TotalStationRadioButton.UseVisualStyleBackColor = true;
            this.TotalStationRadioButton.CheckedChanged += new System.EventHandler(this.TotalStationRadioButton_CheckedChanged);
            // 
            // AuxLaserRadioButton
            // 
            this.AuxLaserRadioButton.AutoSize = true;
            this.AuxLaserRadioButton.Location = new System.Drawing.Point(262, 161);
            this.AuxLaserRadioButton.Name = "AuxLaserRadioButton";
            this.AuxLaserRadioButton.Size = new System.Drawing.Size(72, 17);
            this.AuxLaserRadioButton.TabIndex = 32;
            this.AuxLaserRadioButton.Text = "2nd Laser";
            this.AuxLaserRadioButton.UseVisualStyleBackColor = true;
            this.AuxLaserRadioButton.CheckedChanged += new System.EventHandler(this.AuxLaserRadioButton_CheckedChanged);
            // 
            // openConfigFile
            // 
            this.openConfigFile.FileName = "Tunnel";
            // 
            // CO2_Level
            // 
            this.CO2_Level.Location = new System.Drawing.Point(173, 108);
            this.CO2_Level.Name = "CO2_Level";
            this.CO2_Level.Size = new System.Drawing.Size(141, 20);
            this.CO2_Level.TabIndex = 35;
            this.CO2_Level.Text = "450";
            this.CO2_Level.TextChanged += new System.EventHandler(this.CO2_Level_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tunnel CO2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "ppm";
            // 
            // Tunnel_Control_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1233, 742);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AuxLaserRadioButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalStationRadioButton);
            this.Controls.Add(this.CO2_Level);
            this.Controls.Add(this.EDMRadioButton);
            this.Controls.Add(this.Humidity_logger_2);
            this.Controls.Add(this.Humidity_logger_1);
            this.Controls.Add(this.HumidityLoggerHostName_label);
            this.Controls.Add(this.HumidityLoggerHostName1_label);
            this.Controls.Add(this.Laser_Parameters_Label);
            this.Controls.Add(this.LaserParameters);
            this.Controls.Add(this.Targets_Label);
            this.Controls.Add(this.Targets_RichTextbox);
            this.Controls.Add(this.Bluetooth_Groupbox);
            this.Controls.Add(this.DUT_Groupbox);
            this.Controls.Add(this.DUT_Server_label);
            this.Controls.Add(this.DUTHostName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FileMenu);
            this.Controls.Add(this.Laser_Control);
            this.MainMenuStrip = this.FileMenu;
            this.Name = "Tunnel_Control_Form";
            this.Text = "Survey Calibration System";
            ((System.ComponentModel.ISupportInitialize)(this.Motor_Speed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FileMenu.ResumeLayout(false);
            this.FileMenu.PerformLayout();
            this.Laser_Control.ResumeLayout(false);
            this.Laser_Control.PerformLayout();
            this.DUT_Groupbox.ResumeLayout(false);
            this.DUT_Groupbox.PerformLayout();
            this.Bluetooth_Groupbox.ResumeLayout(false);
            this.Bluetooth_Groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go_Stop_Button;
        private System.Windows.Forms.Button Forward_Reverse_Button;
        private System.IO.Ports.SerialPort Bluetooth_Virtual_Serial_Port;
        private System.Windows.Forms.TrackBar Motor_Speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar BeamStrength;
        private System.Windows.Forms.Label BeamStrength_label;
        private System.Windows.Forms.MenuStrip FileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TextBox Laser_Reading;
        private System.Windows.Forms.Button Reset_Laser;
        private System.Windows.Forms.TextBox DUTHostName;
        private System.Windows.Forms.Label DUT_Server_label;
        private System.Windows.Forms.GroupBox Laser_Control;
        private System.Windows.Forms.ToolStripMenuItem startMeasurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abortMeasurementToolStripMenuItem;
        private System.Windows.Forms.Label Laser_Reading_Label;
        private System.Windows.Forms.GroupBox DUT_Groupbox;
        private System.Windows.Forms.Button DUT_Read;
        private System.Windows.Forms.Label DUT_Reading_Label;
        private System.Windows.Forms.TextBox EDM_Reading;
        private System.Windows.Forms.GroupBox Bluetooth_Groupbox;
        private System.Windows.Forms.ListBox Bluetooth_Listbox;
        private System.Windows.Forms.Label Connections_Label;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.TextBox Status_Textbox;
        private System.Windows.Forms.TextBox Stdev_Textbox;
        private System.Windows.Forms.Label Stdev_label;
        private System.Windows.Forms.RichTextBox Targets_RichTextbox;
        private System.Windows.Forms.Label Targets_Label;
        private System.Windows.Forms.RichTextBox LaserParameters;
        private System.Windows.Forms.Label Laser_Parameters_Label;
        private System.Windows.Forms.Label HumidityLoggerHostName1_label;
        private System.Windows.Forms.Label HumidityLoggerHostName_label;
        private System.Windows.Forms.TextBox Humidity_logger_1;
        private System.Windows.Forms.TextBox Humidity_logger_2;
        private System.Windows.Forms.RadioButton EDMRadioButton;
        private System.Windows.Forms.RadioButton TotalStationRadioButton;
        private System.Windows.Forms.RadioButton AuxLaserRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nm_label;
        private System.Windows.Forms.TextBox VacuumWavelenthTextbox;
        private System.Windows.Forms.ToolStripMenuItem loadTemperatureConfigFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openConfigFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DUT_Wavelength;
        private System.Windows.Forms.TextBox CO2_Level;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

