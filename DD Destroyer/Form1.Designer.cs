namespace DD_Destroyer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.tb_directory = new System.Windows.Forms.TextBox();
            this.btn_auswaehlen = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.tc_alldictionaries = new System.Windows.Forms.TabControl();
            this.tp_allfound = new System.Windows.Forms.TabPage();
            this.lb_allfound = new System.Windows.Forms.ListBox();
            this.tp_path = new System.Windows.Forms.TabPage();
            this.lb_path = new System.Windows.Forms.ListBox();
            this.tc_alldictionaries.SuspendLayout();
            this.tp_allfound.SuspendLayout();
            this.tp_path.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_directory
            // 
            this.tb_directory.Location = new System.Drawing.Point(12, 12);
            this.tb_directory.Name = "tb_directory";
            this.tb_directory.Size = new System.Drawing.Size(281, 20);
            this.tb_directory.TabIndex = 0;
            // 
            // btn_auswaehlen
            // 
            this.btn_auswaehlen.Location = new System.Drawing.Point(299, 10);
            this.btn_auswaehlen.Name = "btn_auswaehlen";
            this.btn_auswaehlen.Size = new System.Drawing.Size(75, 23);
            this.btn_auswaehlen.TabIndex = 1;
            this.btn_auswaehlen.Text = "Auswählen";
            this.btn_auswaehlen.UseVisualStyleBackColor = true;
            this.btn_auswaehlen.Click += new System.EventHandler(this.btn_auswaehlen_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(299, 39);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // tc_alldictionaries
            // 
            this.tc_alldictionaries.Controls.Add(this.tp_allfound);
            this.tc_alldictionaries.Controls.Add(this.tp_path);
            this.tc_alldictionaries.Location = new System.Drawing.Point(12, 38);
            this.tc_alldictionaries.Name = "tc_alldictionaries";
            this.tc_alldictionaries.SelectedIndex = 0;
            this.tc_alldictionaries.Size = new System.Drawing.Size(281, 238);
            this.tc_alldictionaries.TabIndex = 4;
            // 
            // tp_allfound
            // 
            this.tp_allfound.Controls.Add(this.lb_allfound);
            this.tp_allfound.Location = new System.Drawing.Point(4, 22);
            this.tp_allfound.Name = "tp_allfound";
            this.tp_allfound.Padding = new System.Windows.Forms.Padding(3);
            this.tp_allfound.Size = new System.Drawing.Size(273, 212);
            this.tp_allfound.TabIndex = 0;
            this.tp_allfound.Text = "Duplikate";
            this.tp_allfound.UseVisualStyleBackColor = true;
            // 
            // lb_allfound
            // 
            this.lb_allfound.FormattingEnabled = true;
            this.lb_allfound.Location = new System.Drawing.Point(0, 0);
            this.lb_allfound.Name = "lb_allfound";
            this.lb_allfound.Size = new System.Drawing.Size(273, 212);
            this.lb_allfound.TabIndex = 0;
            // 
            // tp_path
            // 
            this.tp_path.Controls.Add(this.lb_path);
            this.tp_path.Location = new System.Drawing.Point(4, 22);
            this.tp_path.Name = "tp_path";
            this.tp_path.Padding = new System.Windows.Forms.Padding(3);
            this.tp_path.Size = new System.Drawing.Size(273, 212);
            this.tp_path.TabIndex = 1;
            this.tp_path.Text = "Pfad";
            this.tp_path.UseVisualStyleBackColor = true;
            // 
            // lb_path
            // 
            this.lb_path.FormattingEnabled = true;
            this.lb_path.Location = new System.Drawing.Point(-4, 0);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(277, 212);
            this.lb_path.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 287);
            this.Controls.Add(this.tc_alldictionaries);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_auswaehlen);
            this.Controls.Add(this.tb_directory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DD Destroyer";
            this.tc_alldictionaries.ResumeLayout(false);
            this.tp_allfound.ResumeLayout(false);
            this.tp_path.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox tb_directory;
        private System.Windows.Forms.Button btn_auswaehlen;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TabControl tc_alldictionaries;
        private System.Windows.Forms.TabPage tp_allfound;
        private System.Windows.Forms.TabPage tp_path;
        private System.Windows.Forms.ListBox lb_allfound;
        private System.Windows.Forms.ListBox lb_path;
    }
}

