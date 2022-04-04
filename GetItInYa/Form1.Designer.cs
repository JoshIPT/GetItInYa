namespace GetItInYa
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ping_last1 = new System.Windows.Forms.Label();
            this.ping_last2 = new System.Windows.Forms.Label();
            this.ping_last3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.pingWorker = new System.ComponentModel.BackgroundWorker();
            this.traceWorker = new System.ComponentModel.BackgroundWorker();
            this.engineWorker = new System.ComponentModel.BackgroundWorker();
            this.httpWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "https://atlas.iptelco.com.au/images/IPTelco.svg";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get It";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ping_last3);
            this.groupBox1.Controls.Add(this.ping_last2);
            this.groupBox1.Controls.Add(this.ping_last1);
            this.groupBox1.Location = new System.Drawing.Point(513, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 36);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1400B Ping";
            // 
            // ping_last1
            // 
            this.ping_last1.Location = new System.Drawing.Point(6, 13);
            this.ping_last1.Name = "ping_last1";
            this.ping_last1.Size = new System.Drawing.Size(80, 17);
            this.ping_last1.TabIndex = 0;
            this.ping_last1.Text = "0";
            this.ping_last1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ping_last2
            // 
            this.ping_last2.Location = new System.Drawing.Point(92, 13);
            this.ping_last2.Name = "ping_last2";
            this.ping_last2.Size = new System.Drawing.Size(80, 17);
            this.ping_last2.TabIndex = 1;
            this.ping_last2.Text = "0";
            this.ping_last2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ping_last3
            // 
            this.ping_last3.Location = new System.Drawing.Point(178, 13);
            this.ping_last3.Name = "ping_last3";
            this.ping_last3.Size = new System.Drawing.Size(80, 17);
            this.ping_last3.TabIndex = 2;
            this.ping_last3.Text = "0";
            this.ping_last3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(513, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 303);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Traceroute";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(249, 278);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Host";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ms";
            this.columnHeader3.Width = 40;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.logBox);
            this.groupBox3.Location = new System.Drawing.Point(15, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 303);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(6, 19);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logBox.Size = new System.Drawing.Size(480, 278);
            this.logBox.TabIndex = 0;
            // 
            // pingWorker
            // 
            this.pingWorker.WorkerReportsProgress = true;
            this.pingWorker.WorkerSupportsCancellation = true;
            this.pingWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.pingWorker_DoWork);
            this.pingWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.pingWorker_ProgressChanged);
            this.pingWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.pingWorker_RunWorkerCompleted);
            // 
            // traceWorker
            // 
            this.traceWorker.WorkerReportsProgress = true;
            this.traceWorker.WorkerSupportsCancellation = true;
            this.traceWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.traceWorker_DoWork);
            this.traceWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.traceWorker_ProgressChanged);
            // 
            // engineWorker
            // 
            this.engineWorker.WorkerReportsProgress = true;
            this.engineWorker.WorkerSupportsCancellation = true;
            this.engineWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.engineWorker_DoWork);
            this.engineWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.engineWorker_ProgressChanged);
            // 
            // httpWorker
            // 
            this.httpWorker.WorkerReportsProgress = true;
            this.httpWorker.WorkerSupportsCancellation = true;
            this.httpWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.httpWorker_DoWork);
            this.httpWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.httpWorker_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 366);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetItInYa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ping_last3;
        private System.Windows.Forms.Label ping_last2;
        private System.Windows.Forms.Label ping_last1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox logBox;
        private System.ComponentModel.BackgroundWorker pingWorker;
        private System.ComponentModel.BackgroundWorker traceWorker;
        private System.ComponentModel.BackgroundWorker engineWorker;
        private System.ComponentModel.BackgroundWorker httpWorker;
    }
}

