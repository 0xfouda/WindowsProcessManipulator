namespace WindowsFormsApplication1
{
    partial class MemRW
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_memadd = new System.Windows.Forms.Label();
            this.txtbx_memadd = new System.Windows.Forms.TextBox();
            this.txtbx_len = new System.Windows.Forms.TextBox();
            this.lbx_allprocs = new System.Windows.Forms.ListBox();
            this.txtbx_hx = new System.Windows.Forms.TextBox();
            this.txtbx_ascii = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_inject = new System.Windows.Forms.Button();
            this.txtbx_dllpath = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_injectshellcode = new System.Windows.Forms.Button();
            this.txtbx_shellcode = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Read Memory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Write Memory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 94);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Process List";
            // 
            // lbl_memadd
            // 
            this.lbl_memadd.AutoSize = true;
            this.lbl_memadd.Location = new System.Drawing.Point(155, 16);
            this.lbl_memadd.Name = "lbl_memadd";
            this.lbl_memadd.Size = new System.Drawing.Size(85, 13);
            this.lbl_memadd.TabIndex = 4;
            this.lbl_memadd.Text = "Memory Address";
            // 
            // txtbx_memadd
            // 
            this.txtbx_memadd.BackColor = System.Drawing.Color.Black;
            this.txtbx_memadd.ForeColor = System.Drawing.Color.Lime;
            this.txtbx_memadd.Location = new System.Drawing.Point(246, 13);
            this.txtbx_memadd.Name = "txtbx_memadd";
            this.txtbx_memadd.Size = new System.Drawing.Size(100, 20);
            this.txtbx_memadd.TabIndex = 1;
            // 
            // txtbx_len
            // 
            this.txtbx_len.Location = new System.Drawing.Point(352, 46);
            this.txtbx_len.Name = "txtbx_len";
            this.txtbx_len.Size = new System.Drawing.Size(55, 20);
            this.txtbx_len.TabIndex = 3;
            // 
            // lbx_allprocs
            // 
            this.lbx_allprocs.FormattingEnabled = true;
            this.lbx_allprocs.Location = new System.Drawing.Point(15, 25);
            this.lbx_allprocs.Name = "lbx_allprocs";
            this.lbx_allprocs.Size = new System.Drawing.Size(120, 225);
            this.lbx_allprocs.Sorted = true;
            this.lbx_allprocs.TabIndex = 5;
            // 
            // txtbx_hx
            // 
            this.txtbx_hx.BackColor = System.Drawing.Color.Black;
            this.txtbx_hx.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_hx.ForeColor = System.Drawing.Color.Lime;
            this.txtbx_hx.Location = new System.Drawing.Point(424, 25);
            this.txtbx_hx.Multiline = true;
            this.txtbx_hx.Name = "txtbx_hx";
            this.txtbx_hx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_hx.Size = new System.Drawing.Size(230, 173);
            this.txtbx_hx.TabIndex = 6;
            // 
            // txtbx_ascii
            // 
            this.txtbx_ascii.BackColor = System.Drawing.Color.Black;
            this.txtbx_ascii.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_ascii.ForeColor = System.Drawing.Color.Lime;
            this.txtbx_ascii.Location = new System.Drawing.Point(660, 25);
            this.txtbx_ascii.Multiline = true;
            this.txtbx_ascii.Name = "txtbx_ascii";
            this.txtbx_ascii.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_ascii.Size = new System.Drawing.Size(125, 174);
            this.txtbx_ascii.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hex View";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ASCII View";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Length";
            // 
            // btn_inject
            // 
            this.btn_inject.Location = new System.Drawing.Point(149, 202);
            this.btn_inject.Name = "btn_inject";
            this.btn_inject.Size = new System.Drawing.Size(267, 23);
            this.btn_inject.TabIndex = 4;
            this.btn_inject.Text = "Inject DLL";
            this.btn_inject.UseVisualStyleBackColor = true;
            this.btn_inject.Click += new System.EventHandler(this.btn_inject_Click);
            // 
            // txtbx_dllpath
            // 
            this.txtbx_dllpath.Location = new System.Drawing.Point(422, 205);
            this.txtbx_dllpath.Name = "txtbx_dllpath";
            this.txtbx_dllpath.Size = new System.Drawing.Size(283, 20);
            this.txtbx_dllpath.TabIndex = 3;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(711, 205);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(74, 23);
            this.btn_browse.TabIndex = 4;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // fbd
            // 
            this.fbd.FileName = "injected.dll";
            this.fbd.Filter = "DLL files|*.dll";
            this.fbd.ReadOnlyChecked = true;
            this.fbd.Title = "Choose DLL To Inject";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 22);
            this.button3.TabIndex = 7;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Form1_Load);
            // 
            // btn_injectshellcode
            // 
            this.btn_injectshellcode.Location = new System.Drawing.Point(149, 231);
            this.btn_injectshellcode.Name = "btn_injectshellcode";
            this.btn_injectshellcode.Size = new System.Drawing.Size(267, 23);
            this.btn_injectshellcode.TabIndex = 4;
            this.btn_injectshellcode.Text = "Inject Shellcode \"CreateRemoteThread Method\"";
            this.btn_injectshellcode.UseVisualStyleBackColor = true;
            this.btn_injectshellcode.Click += new System.EventHandler(this.btn_injectshellcode_Click);
            // 
            // txtbx_shellcode
            // 
            this.txtbx_shellcode.Location = new System.Drawing.Point(422, 234);
            this.txtbx_shellcode.Multiline = true;
            this.txtbx_shellcode.Name = "txtbx_shellcode";
            this.txtbx_shellcode.Size = new System.Drawing.Size(363, 48);
            this.txtbx_shellcode.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(149, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(267, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Inject Shellcode \"Method#2\"";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_injectshellcode_Click);
            // 
            // MemRW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 294);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtbx_ascii);
            this.Controls.Add(this.txtbx_hx);
            this.Controls.Add(this.lbx_allprocs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_memadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_memadd);
            this.Controls.Add(this.txtbx_dllpath);
            this.Controls.Add(this.txtbx_len);
            this.Controls.Add(this.txtbx_shellcode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_injectshellcode);
            this.Controls.Add(this.btn_inject);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MemRW";
            this.Text = "Memory RW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_memadd;
        private System.Windows.Forms.TextBox txtbx_memadd;
        private System.Windows.Forms.TextBox txtbx_len;
        private System.Windows.Forms.ListBox lbx_allprocs;
        private System.Windows.Forms.TextBox txtbx_hx;
        private System.Windows.Forms.TextBox txtbx_ascii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_inject;
        private System.Windows.Forms.TextBox txtbx_dllpath;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.OpenFileDialog fbd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_injectshellcode;
        private System.Windows.Forms.TextBox txtbx_shellcode;
        private System.Windows.Forms.Button button4;
    }
}

