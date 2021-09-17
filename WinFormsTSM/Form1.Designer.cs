
namespace WinFormsTSM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._aantalTextveld = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._lengteTextveld = new System.Windows.Forms.TextBox();
            this._btn_route1 = new System.Windows.Forms.Button();
            this._btn_route2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _aantalTextveld
            // 
            this._aantalTextveld.Location = new System.Drawing.Point(142, 23);
            this._aantalTextveld.Name = "_aantalTextveld";
            this._aantalTextveld.ReadOnly = true;
            this._aantalTextveld.Size = new System.Drawing.Size(49, 31);
            this._aantalTextveld.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "aantal knopen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(765, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "routelengte";
            // 
            // _lengteTextveld
            // 
            this._lengteTextveld.Location = new System.Drawing.Point(887, 22);
            this._lengteTextveld.Name = "_lengteTextveld";
            this._lengteTextveld.Size = new System.Drawing.Size(72, 31);
            this._lengteTextveld.TabIndex = 3;
            // 
            // _btn_route1
            // 
            this._btn_route1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._btn_route1.Location = new System.Drawing.Point(432, 21);
            this._btn_route1.Name = "_btn_route1";
            this._btn_route1.Size = new System.Drawing.Size(123, 34);
            this._btn_route1.TabIndex = 4;
            this._btn_route1.Text = "brute force";
            this._btn_route1.UseVisualStyleBackColor = false;
            this._btn_route1.Click += new System.EventHandler(this._btn_route1_Click);
            // 
            // _btn_route2
            // 
            this._btn_route2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._btn_route2.Location = new System.Drawing.Point(592, 19);
            this._btn_route2.Name = "_btn_route2";
            this._btn_route2.Size = new System.Drawing.Size(167, 34);
            this._btn_route2.TabIndex = 5;
            this._btn_route2.Text = "Nearest neighbour";
            this._btn_route2.UseVisualStyleBackColor = false;
            this._btn_route2.Click += new System.EventHandler(this._btn_route2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.btn_plus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._aantalTextveld);
            this.panel1.Controls.Add(this._btn_route2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this._btn_route1);
            this.panel1.Controls.Add(this._lengteTextveld);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 73);
            this.panel1.TabIndex = 6;
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_min.Location = new System.Drawing.Point(327, 20);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(82, 34);
            this.btn_min.TabIndex = 8;
            this.btn_min.Text = "-";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_plus.Location = new System.Drawing.Point(217, 19);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(82, 34);
            this.btn_plus.TabIndex = 7;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 377);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox _aantalTextveld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _lengteTextveld;
        private System.Windows.Forms.Button _btn_route1;
        private System.Windows.Forms.Button _btn_route2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_plus;
    }
}

