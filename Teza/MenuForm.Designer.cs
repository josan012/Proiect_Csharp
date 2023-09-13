namespace Teza
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.button_factors = new System.Windows.Forms.Button();
            this.button_amenintari = new System.Windows.Forms.Button();
            this.button_riscuri = new System.Windows.Forms.Button();
            this.button_clients = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 465);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bun venit la analiza\r\n riscului de faliment \r\na unei întreprinderi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Teza.Properties.Resources.risk;
            this.pictureBox1.Location = new System.Drawing.Point(95, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closebtn);
            this.panel2.Controls.Add(this.button_factors);
            this.panel2.Controls.Add(this.button_amenintari);
            this.panel2.Controls.Add(this.button_riscuri);
            this.panel2.Controls.Add(this.button_clients);
            this.panel2.Controls.Add(this.button_users);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 465);
            this.panel2.TabIndex = 4;
            // 
            // closebtn
            // 
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.closebtn.Location = new System.Drawing.Point(397, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(40, 40);
            this.closebtn.TabIndex = 7;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // button_factors
            // 
            this.button_factors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_factors.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_factors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button_factors.Location = new System.Drawing.Point(0, 220);
            this.button_factors.Name = "button_factors";
            this.button_factors.Size = new System.Drawing.Size(437, 50);
            this.button_factors.TabIndex = 2;
            this.button_factors.Text = "Tabel Factori";
            this.button_factors.UseVisualStyleBackColor = true;
            this.button_factors.Click += new System.EventHandler(this.button_factors_Click);
            // 
            // button_amenintari
            // 
            this.button_amenintari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_amenintari.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_amenintari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button_amenintari.Location = new System.Drawing.Point(0, 150);
            this.button_amenintari.Name = "button_amenintari";
            this.button_amenintari.Size = new System.Drawing.Size(437, 50);
            this.button_amenintari.TabIndex = 3;
            this.button_amenintari.Text = "Tabel Amenintari";
            this.button_amenintari.UseVisualStyleBackColor = true;
            this.button_amenintari.Click += new System.EventHandler(this.button_amenintari_Click);
            // 
            // button_riscuri
            // 
            this.button_riscuri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_riscuri.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_riscuri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button_riscuri.Location = new System.Drawing.Point(0, 80);
            this.button_riscuri.Name = "button_riscuri";
            this.button_riscuri.Size = new System.Drawing.Size(437, 50);
            this.button_riscuri.TabIndex = 4;
            this.button_riscuri.Text = "Tabel Riscuri";
            this.button_riscuri.UseVisualStyleBackColor = true;
            this.button_riscuri.Click += new System.EventHandler(this.button_riscuri_Click);
            // 
            // button_clients
            // 
            this.button_clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clients.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button_clients.Location = new System.Drawing.Point(0, 360);
            this.button_clients.Name = "button_clients";
            this.button_clients.Size = new System.Drawing.Size(437, 50);
            this.button_clients.TabIndex = 5;
            this.button_clients.Text = "Tabel Clienti";
            this.button_clients.UseVisualStyleBackColor = true;
            this.button_clients.Click += new System.EventHandler(this.button_clients_Click);
            // 
            // button_users
            // 
            this.button_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_users.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button_users.Location = new System.Drawing.Point(0, 290);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(437, 50);
            this.button_users.TabIndex = 6;
            this.button_users.Text = "Tabel Utilizatori";
            this.button_users.UseVisualStyleBackColor = true;
            this.button_users.Click += new System.EventHandler(this.button_users_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 465);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_factors;
        private System.Windows.Forms.Button button_amenintari;
        private System.Windows.Forms.Button button_riscuri;
        private System.Windows.Forms.Button button_clients;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button closebtn;
    }
}