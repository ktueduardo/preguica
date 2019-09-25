namespace Pim
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Dock = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.acessLevelLabel = new System.Windows.Forms.Label();
            this.dateFooter = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Container = new System.Windows.Forms.Panel();
            this.Dock.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dock
            // 
            this.Dock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dock.BackColor = System.Drawing.Color.DarkBlue;
            this.Dock.Controls.Add(this.button5);
            this.Dock.Controls.Add(this.button4);
            this.Dock.Controls.Add(this.button3);
            this.Dock.Controls.Add(this.button2);
            this.Dock.Controls.Add(this.button1);
            this.Dock.Location = new System.Drawing.Point(0, 0);
            this.Dock.Name = "Dock";
            this.Dock.Size = new System.Drawing.Size(652, 75);
            this.Dock.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 52);
            this.button5.TabIndex = 7;
            this.button5.Text = "Funcionarios";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(119, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 52);
            this.button4.TabIndex = 6;
            this.button4.Text = "Veiculos";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(226, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "Empresas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(333, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pagamentos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(440, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Requisições";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // footerPanel
            // 
            this.footerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footerPanel.Controls.Add(this.acessLevelLabel);
            this.footerPanel.Controls.Add(this.dateFooter);
            this.footerPanel.Controls.Add(this.userLabel);
            this.footerPanel.Location = new System.Drawing.Point(0, 571);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(652, 21);
            this.footerPanel.TabIndex = 1;
            // 
            // acessLevelLabel
            // 
            this.acessLevelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acessLevelLabel.AutoSize = true;
            this.acessLevelLabel.Location = new System.Drawing.Point(93, 4);
            this.acessLevelLabel.Name = "acessLevelLabel";
            this.acessLevelLabel.Size = new System.Drawing.Size(155, 13);
            this.acessLevelLabel.TabIndex = 2;
            this.acessLevelLabel.Text = "Nivel de acesso:  Administrador";
            // 
            // dateFooter
            // 
            this.dateFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFooter.AutoSize = true;
            this.dateFooter.Location = new System.Drawing.Point(409, 4);
            this.dateFooter.Name = "dateFooter";
            this.dateFooter.Size = new System.Drawing.Size(35, 13);
            this.dateFooter.TabIndex = 1;
            this.dateFooter.Text = "label1";
            // 
            // userLabel
            // 
            this.userLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(3, 4);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(62, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Usuario Um";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Container
            // 
            this.Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Container.BackColor = System.Drawing.SystemColors.Control;
            this.Container.Location = new System.Drawing.Point(0, 75);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(652, 496);
            this.Container.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(652, 592);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.Dock);
            this.MinimumSize = new System.Drawing.Size(668, 631);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Dock.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Dock;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label dateFooter;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label acessLevelLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Container;
    }
}

