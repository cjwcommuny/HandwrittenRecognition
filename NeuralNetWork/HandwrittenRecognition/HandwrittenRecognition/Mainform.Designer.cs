namespace HandwrittenRecogniration
{
    partial class Mainform
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
                _MainMutex.Dispose();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mNISTDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelRecognizedValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPRPrevious = new System.Windows.Forms.Button();
            this.buttonPRNext = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonMnistTestDatabase = new System.Windows.Forms.RadioButton();
            this.radioButtonMnistTrainDatabase = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonMnistNext = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonMnistPrevious = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownThreads = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumberofTestPattern = new System.Windows.Forms.NumericUpDown();
            this.radioButtonTestingdatabase = new System.Windows.Forms.RadioButton();
            this.radioButtonTrainingdatabase = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonMnistStopTest = new System.Windows.Forms.Button();
            this.buttonMnistTest = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StartBackPropagationbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberofTestPattern)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1804, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkParametersToolStripMenuItem,
            this.mNISTDatabaseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // networkParametersToolStripMenuItem
            // 
            this.networkParametersToolStripMenuItem.Name = "networkParametersToolStripMenuItem";
            this.networkParametersToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.networkParametersToolStripMenuItem.Text = "Network Parameters";
            this.networkParametersToolStripMenuItem.Click += new System.EventHandler(this.networkParametersToolStripMenuItem_Click);
            // 
            // mNISTDatabaseToolStripMenuItem
            // 
            this.mNISTDatabaseToolStripMenuItem.Name = "mNISTDatabaseToolStripMenuItem";
            this.mNISTDatabaseToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.mNISTDatabaseToolStripMenuItem.Text = "MNIST Database";
            this.mNISTDatabaseToolStripMenuItem.Click += new System.EventHandler(this.mNISTDatabaseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 28);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.viewHelpToolStripMenuItem.Text = "About";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(764, 812);
            this.splitContainer2.SplitterDistance = 290;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelRecognizedValue);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.buttonPRPrevious);
            this.groupBox3.Controls.Add(this.buttonPRNext);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(384, 290);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pattern Recognition";
            // 
            // labelRecognizedValue
            // 
            this.labelRecognizedValue.AutoSize = true;
            this.labelRecognizedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecognizedValue.ForeColor = System.Drawing.Color.Red;
            this.labelRecognizedValue.Location = new System.Drawing.Point(261, 36);
            this.labelRecognizedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecognizedValue.Name = "labelRecognizedValue";
            this.labelRecognizedValue.Size = new System.Drawing.Size(89, 55);
            this.labelRecognizedValue.TabIndex = 6;
            this.labelRecognizedValue.Text = "     ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 33);
            this.label9.TabIndex = 5;
            this.label9.Text = "Recognized value:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(9, 120);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPRPrevious
            // 
            this.buttonPRPrevious.Enabled = false;
            this.buttonPRPrevious.Location = new System.Drawing.Point(214, 120);
            this.buttonPRPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPRPrevious.Name = "buttonPRPrevious";
            this.buttonPRPrevious.Size = new System.Drawing.Size(57, 72);
            this.buttonPRPrevious.TabIndex = 4;
            this.buttonPRPrevious.Text = "Previous";
            this.buttonPRPrevious.UseVisualStyleBackColor = true;
            // 
            // buttonPRNext
            // 
            this.buttonPRNext.Enabled = false;
            this.buttonPRNext.Location = new System.Drawing.Point(304, 120);
            this.buttonPRNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPRNext.Name = "buttonPRNext";
            this.buttonPRNext.Size = new System.Drawing.Size(57, 72);
            this.buttonPRNext.TabIndex = 2;
            this.buttonPRNext.Text = "Next";
            this.buttonPRNext.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.radioButtonMnistTestDatabase);
            this.groupBox2.Controls.Add(this.radioButtonMnistTrainDatabase);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonMnistNext);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonMnistPrevious);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(384, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(380, 290);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MNIST manual test";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(189, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "0  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Pattern No.:";
            // 
            // radioButtonMnistTestDatabase
            // 
            this.radioButtonMnistTestDatabase.AutoSize = true;
            this.radioButtonMnistTestDatabase.Checked = true;
            this.radioButtonMnistTestDatabase.Enabled = false;
            this.radioButtonMnistTestDatabase.Location = new System.Drawing.Point(201, 259);
            this.radioButtonMnistTestDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMnistTestDatabase.Name = "radioButtonMnistTestDatabase";
            this.radioButtonMnistTestDatabase.Size = new System.Drawing.Size(177, 22);
            this.radioButtonMnistTestDatabase.TabIndex = 8;
            this.radioButtonMnistTestDatabase.TabStop = true;
            this.radioButtonMnistTestDatabase.Text = "Testing Database";
            this.radioButtonMnistTestDatabase.UseVisualStyleBackColor = true;
            this.radioButtonMnistTestDatabase.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonMnistTrainDatabase
            // 
            this.radioButtonMnistTrainDatabase.AutoSize = true;
            this.radioButtonMnistTrainDatabase.Enabled = false;
            this.radioButtonMnistTrainDatabase.Location = new System.Drawing.Point(201, 215);
            this.radioButtonMnistTrainDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMnistTrainDatabase.Name = "radioButtonMnistTrainDatabase";
            this.radioButtonMnistTrainDatabase.Size = new System.Drawing.Size(177, 22);
            this.radioButtonMnistTrainDatabase.TabIndex = 7;
            this.radioButtonMnistTrainDatabase.TabStop = true;
            this.radioButtonMnistTrainDatabase.Text = "Traning Database";
            this.radioButtonMnistTrainDatabase.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(9, 120);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 158);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "0   ";
            // 
            // buttonMnistNext
            // 
            this.buttonMnistNext.Enabled = false;
            this.buttonMnistNext.Location = new System.Drawing.Point(300, 120);
            this.buttonMnistNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMnistNext.Name = "buttonMnistNext";
            this.buttonMnistNext.Size = new System.Drawing.Size(57, 72);
            this.buttonMnistNext.TabIndex = 2;
            this.buttonMnistNext.Text = "Next";
            this.buttonMnistNext.UseVisualStyleBackColor = true;
            this.buttonMnistNext.Click += new System.EventHandler(this.next_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "0";
            // 
            // buttonMnistPrevious
            // 
            this.buttonMnistPrevious.Enabled = false;
            this.buttonMnistPrevious.Location = new System.Drawing.Point(210, 120);
            this.buttonMnistPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMnistPrevious.Name = "buttonMnistPrevious";
            this.buttonMnistPrevious.Size = new System.Drawing.Size(57, 72);
            this.buttonMnistPrevious.TabIndex = 4;
            this.buttonMnistPrevious.Text = "Previous";
            this.buttonMnistPrevious.UseVisualStyleBackColor = true;
            this.buttonMnistPrevious.Click += new System.EventHandler(this.previous_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Recognized No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Actual No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(764, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neural network training";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(4, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(756, 399);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.numericUpDownThreads);
            this.tabPage2.Controls.Add(this.numericUpDownNumberofTestPattern);
            this.tabPage2.Controls.Add(this.radioButtonTestingdatabase);
            this.tabPage2.Controls.Add(this.radioButtonTrainingdatabase);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.buttonMnistStopTest);
            this.tabPage2.Controls.Add(this.buttonMnistTest);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(748, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NN Testing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(141, 111);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 18);
            this.label14.TabIndex = 7;
            this.label14.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 111);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "Current Pattern:";
            // 
            // numericUpDownThreads
            // 
            this.numericUpDownThreads.Location = new System.Drawing.Point(552, 53);
            this.numericUpDownThreads.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownThreads.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownThreads.Name = "numericUpDownThreads";
            this.numericUpDownThreads.Size = new System.Drawing.Size(60, 28);
            this.numericUpDownThreads.TabIndex = 5;
            this.numericUpDownThreads.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownNumberofTestPattern
            // 
            this.numericUpDownNumberofTestPattern.Location = new System.Drawing.Point(477, 18);
            this.numericUpDownNumberofTestPattern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownNumberofTestPattern.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownNumberofTestPattern.Name = "numericUpDownNumberofTestPattern";
            this.numericUpDownNumberofTestPattern.Size = new System.Drawing.Size(135, 28);
            this.numericUpDownNumberofTestPattern.TabIndex = 5;
            this.numericUpDownNumberofTestPattern.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // radioButtonTestingdatabase
            // 
            this.radioButtonTestingdatabase.AutoSize = true;
            this.radioButtonTestingdatabase.Checked = true;
            this.radioButtonTestingdatabase.Location = new System.Drawing.Point(52, 53);
            this.radioButtonTestingdatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonTestingdatabase.Name = "radioButtonTestingdatabase";
            this.radioButtonTestingdatabase.Size = new System.Drawing.Size(177, 22);
            this.radioButtonTestingdatabase.TabIndex = 4;
            this.radioButtonTestingdatabase.TabStop = true;
            this.radioButtonTestingdatabase.Text = "Testing database";
            this.radioButtonTestingdatabase.UseVisualStyleBackColor = true;
            this.radioButtonTestingdatabase.CheckedChanged += new System.EventHandler(this.radioButtonTestingdatabase_CheckedChanged);
            // 
            // radioButtonTrainingdatabase
            // 
            this.radioButtonTrainingdatabase.AutoSize = true;
            this.radioButtonTrainingdatabase.Location = new System.Drawing.Point(52, 18);
            this.radioButtonTrainingdatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonTrainingdatabase.Name = "radioButtonTrainingdatabase";
            this.radioButtonTrainingdatabase.Size = new System.Drawing.Size(186, 22);
            this.radioButtonTrainingdatabase.TabIndex = 4;
            this.radioButtonTrainingdatabase.Text = "Training database";
            this.radioButtonTrainingdatabase.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(290, 55);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "Number of Test thread:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Number of Test pattern:";
            // 
            // buttonMnistStopTest
            // 
            this.buttonMnistStopTest.Location = new System.Drawing.Point(528, 97);
            this.buttonMnistStopTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMnistStopTest.Name = "buttonMnistStopTest";
            this.buttonMnistStopTest.Size = new System.Drawing.Size(202, 32);
            this.buttonMnistStopTest.TabIndex = 2;
            this.buttonMnistStopTest.Text = "Stop Mnist Test";
            this.buttonMnistStopTest.UseVisualStyleBackColor = true;
            this.buttonMnistStopTest.Click += new System.EventHandler(this.buttonStopMnistTest_Click);
            // 
            // buttonMnistTest
            // 
            this.buttonMnistTest.Location = new System.Drawing.Point(314, 97);
            this.buttonMnistTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMnistTest.Name = "buttonMnistTest";
            this.buttonMnistTest.Size = new System.Drawing.Size(189, 32);
            this.buttonMnistTest.TabIndex = 1;
            this.buttonMnistTest.Text = "Start Mnist Test";
            this.buttonMnistTest.UseVisualStyleBackColor = true;
            this.buttonMnistTest.Click += new System.EventHandler(this.buttonMnistTest_Click);
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(4, 143);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(740, 220);
            this.listBox2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.StartBackPropagationbutton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(748, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NN Training";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(4, 143);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(740, 220);
            this.listBox1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(456, 91);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 32);
            this.button3.TabIndex = 1;
            this.button3.Text = "Stop BackPropagation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.StopBackPropagationbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "0            ";
            // 
            // StartBackPropagationbutton
            // 
            this.StartBackPropagationbutton.Location = new System.Drawing.Point(170, 91);
            this.StartBackPropagationbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartBackPropagationbutton.Name = "StartBackPropagationbutton";
            this.StartBackPropagationbutton.Size = new System.Drawing.Size(204, 32);
            this.StartBackPropagationbutton.TabIndex = 0;
            this.StartBackPropagationbutton.Text = "Start BackPropagation";
            this.StartBackPropagationbutton.UseVisualStyleBackColor = true;
            this.StartBackPropagationbutton.Click += new System.EventHandler(this.StartBackPropagationbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current pattern: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "MSE: 0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxMain, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1034, 812);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.Location = new System.Drawing.Point(16, 4);
            this.pictureBoxMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(1014, 804);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 34);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1804, 812);
            this.splitContainer1.SplitterDistance = 1034;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 846);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handwritten character recognition system";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberofTestPattern)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mNISTDatabaseToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonMnistTestDatabase;
        private System.Windows.Forms.RadioButton radioButtonMnistTrainDatabase;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonMnistNext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonMnistPrevious;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button StartBackPropagationbutton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPRPrevious;
        private System.Windows.Forms.Button buttonPRNext;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonMnistTest;
        private System.Windows.Forms.Label labelRecognizedValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonMnistStopTest;
        private System.Windows.Forms.NumericUpDown numericUpDownThreads;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberofTestPattern;
        private System.Windows.Forms.RadioButton radioButtonTestingdatabase;
        private System.Windows.Forms.RadioButton radioButtonTrainingdatabase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
    }
}

