
namespace PARCIAL2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.USUARIOSADMIN = new System.Windows.Forms.Button();
            this.PERFIL = new System.Windows.Forms.Button();
            this.LOGSADMIN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iRALLOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(289, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡BIENVENIDO!";
            // 
            // USUARIOSADMIN
            // 
            this.USUARIOSADMIN.BackColor = System.Drawing.Color.MediumAquamarine;
            this.USUARIOSADMIN.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USUARIOSADMIN.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.USUARIOSADMIN.Location = new System.Drawing.Point(247, 381);
            this.USUARIOSADMIN.Name = "USUARIOSADMIN";
            this.USUARIOSADMIN.Size = new System.Drawing.Size(272, 92);
            this.USUARIOSADMIN.TabIndex = 1;
            this.USUARIOSADMIN.Text = "USUARIOS";
            this.USUARIOSADMIN.UseVisualStyleBackColor = false;
            this.USUARIOSADMIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // PERFIL
            // 
            this.PERFIL.BackColor = System.Drawing.Color.MediumAquamarine;
            this.PERFIL.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PERFIL.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.PERFIL.Location = new System.Drawing.Point(247, 88);
            this.PERFIL.Name = "PERFIL";
            this.PERFIL.Size = new System.Drawing.Size(272, 108);
            this.PERFIL.TabIndex = 2;
            this.PERFIL.Text = "Perfil";
            this.PERFIL.UseVisualStyleBackColor = false;
            this.PERFIL.Click += new System.EventHandler(this.button2_Click);
            // 
            // LOGSADMIN
            // 
            this.LOGSADMIN.BackColor = System.Drawing.Color.MediumAquamarine;
            this.LOGSADMIN.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGSADMIN.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.LOGSADMIN.Location = new System.Drawing.Point(247, 234);
            this.LOGSADMIN.Name = "LOGSADMIN";
            this.LOGSADMIN.Size = new System.Drawing.Size(272, 109);
            this.LOGSADMIN.TabIndex = 3;
            this.LOGSADMIN.Text = "LOGS";
            this.LOGSADMIN.UseVisualStyleBackColor = false;
            this.LOGSADMIN.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPCIONESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(792, 36);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPCIONESToolStripMenuItem
            // 
            this.oPCIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iRALLOGINToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.oPCIONESToolStripMenuItem.Name = "oPCIONESToolStripMenuItem";
            this.oPCIONESToolStripMenuItem.Size = new System.Drawing.Size(114, 30);
            this.oPCIONESToolStripMenuItem.Text = "OPCIONES";
            // 
            // iRALLOGINToolStripMenuItem
            // 
            this.iRALLOGINToolStripMenuItem.Name = "iRALLOGINToolStripMenuItem";
            this.iRALLOGINToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.iRALLOGINToolStripMenuItem.Text = "SALIR AL LOGIN ";
            this.iRALLOGINToolStripMenuItem.Click += new System.EventHandler(this.iRALLOGINToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.sALIRToolStripMenuItem.Text = "SALIR ";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(792, 485);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LOGSADMIN);
            this.Controls.Add(this.PERFIL);
            this.Controls.Add(this.USUARIOSADMIN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button USUARIOSADMIN;
        private System.Windows.Forms.Button PERFIL;
        private System.Windows.Forms.Button LOGSADMIN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPCIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iRALLOGINToolStripMenuItem;
    }
}