namespace HavenParadisio
{
    partial class Havenscherm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.liAlleSchepen = new System.Windows.Forms.ListBox();
            this.lblNaamVanDeHaven = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInboeken = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLadingInboeken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLengteInboeken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaamInboeken = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaamUitboeken = new System.Windows.Forms.TextBox();
            this.btnUitboeken = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStatistiek = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.liAlleSchepen);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schepen in de haven";
            // 
            // liAlleSchepen
            // 
            this.liAlleSchepen.FormattingEnabled = true;
            this.liAlleSchepen.Location = new System.Drawing.Point(6, 19);
            this.liAlleSchepen.Name = "liAlleSchepen";
            this.liAlleSchepen.Size = new System.Drawing.Size(237, 277);
            this.liAlleSchepen.TabIndex = 0;
            this.liAlleSchepen.TabStop = false;
            // 
            // lblNaamVanDeHaven
            // 
            this.lblNaamVanDeHaven.AutoSize = true;
            this.lblNaamVanDeHaven.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaamVanDeHaven.Location = new System.Drawing.Point(12, 9);
            this.lblNaamVanDeHaven.Name = "lblNaamVanDeHaven";
            this.lblNaamVanDeHaven.Size = new System.Drawing.Size(525, 39);
            this.lblNaamVanDeHaven.TabIndex = 1;
            this.lblNaamVanDeHaven.Text = "Hier komt de naam van de haven";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnInboeken);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtLadingInboeken);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLengteInboeken);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNaamInboeken);
            this.groupBox2.Location = new System.Drawing.Point(267, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 300);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inkomend schip";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "m";
            // 
            // btnInboeken
            // 
            this.btnInboeken.Location = new System.Drawing.Point(6, 230);
            this.btnInboeken.Name = "btnInboeken";
            this.btnInboeken.Size = new System.Drawing.Size(188, 56);
            this.btnInboeken.TabIndex = 3;
            this.btnInboeken.Text = "Inboeken";
            this.btnInboeken.UseVisualStyleBackColor = true;
            this.btnInboeken.Click += new System.EventHandler(this.btnInboeken_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lading";
            // 
            // txtLadingInboeken
            // 
            this.txtLadingInboeken.Location = new System.Drawing.Point(6, 163);
            this.txtLadingInboeken.Name = "txtLadingInboeken";
            this.txtLadingInboeken.Size = new System.Drawing.Size(188, 20);
            this.txtLadingInboeken.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lengte";
            // 
            // txtLengteInboeken
            // 
            this.txtLengteInboeken.Location = new System.Drawing.Point(6, 101);
            this.txtLengteInboeken.Name = "txtLengteInboeken";
            this.txtLengteInboeken.Size = new System.Drawing.Size(102, 20);
            this.txtLengteInboeken.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Naam";
            // 
            // txtNaamInboeken
            // 
            this.txtNaamInboeken.Location = new System.Drawing.Point(6, 40);
            this.txtNaamInboeken.Name = "txtNaamInboeken";
            this.txtNaamInboeken.Size = new System.Drawing.Size(188, 20);
            this.txtNaamInboeken.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtNaamUitboeken);
            this.groupBox3.Controls.Add(this.btnUitboeken);
            this.groupBox3.Location = new System.Drawing.Point(473, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 132);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Uitgaand schip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naam";
            // 
            // txtNaamUitboeken
            // 
            this.txtNaamUitboeken.Location = new System.Drawing.Point(6, 40);
            this.txtNaamUitboeken.Name = "txtNaamUitboeken";
            this.txtNaamUitboeken.Size = new System.Drawing.Size(188, 20);
            this.txtNaamUitboeken.TabIndex = 4;
            // 
            // btnUitboeken
            // 
            this.btnUitboeken.Location = new System.Drawing.Point(6, 66);
            this.btnUitboeken.Name = "btnUitboeken";
            this.btnUitboeken.Size = new System.Drawing.Size(188, 56);
            this.btnUitboeken.TabIndex = 5;
            this.btnUitboeken.Text = "Uitboeken";
            this.btnUitboeken.UseVisualStyleBackColor = true;
            this.btnUitboeken.Click += new System.EventHandler(this.btnUitboeken_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.White;
            this.pnlStatus.Location = new System.Drawing.Point(593, 267);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(80, 80);
            this.pnlStatus.TabIndex = 4;
            this.pnlStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStatus_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // btnStatistiek
            // 
            this.btnStatistiek.Location = new System.Drawing.Point(479, 205);
            this.btnStatistiek.Name = "btnStatistiek";
            this.btnStatistiek.Size = new System.Drawing.Size(188, 56);
            this.btnStatistiek.TabIndex = 6;
            this.btnStatistiek.Text = "Statistiek";
            this.btnStatistiek.UseVisualStyleBackColor = true;
            this.btnStatistiek.Click += new System.EventHandler(this.btnStatistiek_Click);
            // 
            // Havenscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 360);
            this.Controls.Add(this.btnStatistiek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblNaamVanDeHaven);
            this.Controls.Add(this.groupBox1);
            this.Name = "Havenscherm";
            this.Text = "Havenbeheer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox liAlleSchepen;
        private System.Windows.Forms.Label lblNaamVanDeHaven;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaamUitboeken;
        private System.Windows.Forms.Button btnUitboeken;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStatistiek;
        private System.Windows.Forms.Button btnInboeken;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLadingInboeken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLengteInboeken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaamInboeken;
        private System.Windows.Forms.Label label7;
    }
}

