namespace LatestFollow_light
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_interval = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_spaces = new System.Windows.Forms.NumericUpDown();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_browser = new System.Windows.Forms.Button();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.cb_active = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_spaces)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(76, 12);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 20);
            this.txt_username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // num_interval
            // 
            this.num_interval.Location = new System.Drawing.Point(343, 12);
            this.num_interval.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.num_interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_interval.Name = "num_interval";
            this.num_interval.Size = new System.Drawing.Size(105, 20);
            this.num_interval.TabIndex = 2;
            this.num_interval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interval:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Spaces:";
            // 
            // num_spaces
            // 
            this.num_spaces.Location = new System.Drawing.Point(344, 38);
            this.num_spaces.Name = "num_spaces";
            this.num_spaces.Size = new System.Drawing.Size(104, 20);
            this.num_spaces.TabIndex = 6;
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(85, 70);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(281, 20);
            this.txt_path.TabIndex = 7;
            // 
            // btn_browser
            // 
            this.btn_browser.Location = new System.Drawing.Point(373, 70);
            this.btn_browser.Name = "btn_browser";
            this.btn_browser.Size = new System.Drawing.Size(75, 23);
            this.btn_browser.TabIndex = 8;
            this.btn_browser.Text = "Browse...";
            this.btn_browser.UseVisualStyleBackColor = true;
            this.btn_browser.Click += new System.EventHandler(this.btn_browser_Click);
            // 
            // timer_main
            // 
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // cb_active
            // 
            this.cb_active.AutoSize = true;
            this.cb_active.Location = new System.Drawing.Point(392, 99);
            this.cb_active.Name = "cb_active";
            this.cb_active.Size = new System.Drawing.Size(56, 17);
            this.cb_active.TabIndex = 9;
            this.cb_active.Text = "Active";
            this.cb_active.UseVisualStyleBackColor = true;
            this.cb_active.CheckedChanged += new System.EventHandler(this.cb_active_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 118);
            this.Controls.Add(this.cb_active);
            this.Controls.Add(this.btn_browser);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.num_spaces);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_interval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.Name = "Main";
            this.Text = "LatestFollow-light";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.num_interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_spaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_interval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_spaces;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_browser;
        private System.Windows.Forms.Timer timer_main;
        private System.Windows.Forms.CheckBox cb_active;
    }
}

