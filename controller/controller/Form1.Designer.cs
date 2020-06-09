namespace controller {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.btn_quit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.sr_label = new System.Windows.Forms.Label();
      this.btn_win_dec = new System.Windows.Forms.Button();
      this.btn_sr_set = new System.Windows.Forms.Button();
      this.btn_win_inc = new System.Windows.Forms.Button();
      this.btn_lose_inc = new System.Windows.Forms.Button();
      this.btn_lose_dec = new System.Windows.Forms.Button();
      this.btn_draw_inc = new System.Windows.Forms.Button();
      this.btn_draw_dec = new System.Windows.Forms.Button();
      this.tb_draw_count = new System.Windows.Forms.TextBox();
      this.tb_lose_count = new System.Windows.Forms.TextBox();
      this.tb_sr_count = new System.Windows.Forms.TextBox();
      this.tb_win_count = new System.Windows.Forms.TextBox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(152)))), ((int)(((byte)(29)))));
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.btn_quit);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(209, 32);
      this.panel1.TabIndex = 0;
      this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Koverwatch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.Snow;
      this.label5.Location = new System.Drawing.Point(10, 6);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(160, 19);
      this.label5.TabIndex = 20;
      this.label5.Text = "OW Overlay Controller";
      this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
      // 
      // btn_quit
      // 
      this.btn_quit.FlatAppearance.BorderSize = 0;
      this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_quit.Font = new System.Drawing.Font("Koverwatch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_quit.Image = ((System.Drawing.Image)(resources.GetObject("btn_quit.Image")));
      this.btn_quit.Location = new System.Drawing.Point(175, 0);
      this.btn_quit.Margin = new System.Windows.Forms.Padding(0);
      this.btn_quit.Name = "btn_quit";
      this.btn_quit.Size = new System.Drawing.Size(32, 32);
      this.btn_quit.TabIndex = 19;
      this.btn_quit.UseVisualStyleBackColor = true;
      this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Koverwatch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 50);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(30, 18);
      this.label1.TabIndex = 2;
      this.label1.Text = "Win";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Koverwatch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 86);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(33, 18);
      this.label2.TabIndex = 3;
      this.label2.Text = "Lose";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Koverwatch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(12, 122);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 18);
      this.label3.TabIndex = 4;
      this.label3.Text = "Draw";
      // 
      // sr_label
      // 
      this.sr_label.AutoSize = true;
      this.sr_label.Font = new System.Drawing.Font("Koverwatch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sr_label.Location = new System.Drawing.Point(12, 157);
      this.sr_label.Name = "sr_label";
      this.sr_label.Size = new System.Drawing.Size(22, 18);
      this.sr_label.TabIndex = 5;
      this.sr_label.Text = "SR";
      // 
      // btn_win_dec
      // 
      this.btn_win_dec.Font = new System.Drawing.Font("Koverwatch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_win_dec.Location = new System.Drawing.Point(121, 44);
      this.btn_win_dec.Name = "btn_win_dec";
      this.btn_win_dec.Size = new System.Drawing.Size(34, 30);
      this.btn_win_dec.TabIndex = 9;
      this.btn_win_dec.Text = " -";
      this.btn_win_dec.UseVisualStyleBackColor = true;
      this.btn_win_dec.Click += new System.EventHandler(this.btn_click_handler);
      // 
      // btn_sr_set
      // 
      this.btn_sr_set.Font = new System.Drawing.Font("Koverwatch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_sr_set.Location = new System.Drawing.Point(121, 151);
      this.btn_sr_set.Name = "btn_sr_set";
      this.btn_sr_set.Size = new System.Drawing.Size(75, 30);
      this.btn_sr_set.TabIndex = 11;
      this.btn_sr_set.Text = "Set";
      this.btn_sr_set.UseVisualStyleBackColor = true;
      this.btn_sr_set.Click += new System.EventHandler(this.btn_sr_set_Click);
      // 
      // btn_win_inc
      // 
      this.btn_win_inc.Font = new System.Drawing.Font("Koverwatch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_win_inc.Location = new System.Drawing.Point(162, 44);
      this.btn_win_inc.Name = "btn_win_inc";
      this.btn_win_inc.Size = new System.Drawing.Size(34, 30);
      this.btn_win_inc.TabIndex = 14;
      this.btn_win_inc.Text = " +";
      this.btn_win_inc.UseVisualStyleBackColor = true;
      this.btn_win_inc.Click += new System.EventHandler(this.btn_click_handler);
      // 
      // btn_lose_inc
      // 
      this.btn_lose_inc.Font = new System.Drawing.Font("Koverwatch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_lose_inc.Location = new System.Drawing.Point(162, 80);
      this.btn_lose_inc.Name = "btn_lose_inc";
      this.btn_lose_inc.Size = new System.Drawing.Size(34, 30);
      this.btn_lose_inc.TabIndex = 16;
      this.btn_lose_inc.Text = " +";
      this.btn_lose_inc.UseVisualStyleBackColor = true;
      this.btn_lose_inc.Click += new System.EventHandler(this.btn_click_handler);
      // 
      // btn_lose_dec
      // 
      this.btn_lose_dec.Font = new System.Drawing.Font("Koverwatch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_lose_dec.Location = new System.Drawing.Point(121, 80);
      this.btn_lose_dec.Name = "btn_lose_dec";
      this.btn_lose_dec.Size = new System.Drawing.Size(34, 30);
      this.btn_lose_dec.TabIndex = 15;
      this.btn_lose_dec.Text = " -";
      this.btn_lose_dec.UseVisualStyleBackColor = true;
      this.btn_lose_dec.Click += new System.EventHandler(this.btn_click_handler);
      // 
      // btn_draw_inc
      // 
      this.btn_draw_inc.Font = new System.Drawing.Font("Koverwatch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_draw_inc.Location = new System.Drawing.Point(162, 116);
      this.btn_draw_inc.Name = "btn_draw_inc";
      this.btn_draw_inc.Size = new System.Drawing.Size(34, 30);
      this.btn_draw_inc.TabIndex = 18;
      this.btn_draw_inc.Text = " +";
      this.btn_draw_inc.UseVisualStyleBackColor = true;
      this.btn_draw_inc.Click += new System.EventHandler(this.btn_click_handler);
      // 
      // btn_draw_dec
      // 
      this.btn_draw_dec.Font = new System.Drawing.Font("Koverwatch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_draw_dec.Location = new System.Drawing.Point(121, 116);
      this.btn_draw_dec.Name = "btn_draw_dec";
      this.btn_draw_dec.Size = new System.Drawing.Size(34, 30);
      this.btn_draw_dec.TabIndex = 17;
      this.btn_draw_dec.Text = " -";
      this.btn_draw_dec.UseVisualStyleBackColor = true;
      this.btn_draw_dec.Click += new System.EventHandler(this.btn_click_handler);
      // 
      // tb_draw_count
      // 
      this.tb_draw_count.Font = new System.Drawing.Font("BigNoodleTooOblique", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tb_draw_count.Location = new System.Drawing.Point(60, 116);
      this.tb_draw_count.Name = "tb_draw_count";
      this.tb_draw_count.Size = new System.Drawing.Size(52, 31);
      this.tb_draw_count.TabIndex = 19;
      this.tb_draw_count.Text = "0000 ";
      this.tb_draw_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tb_draw_count.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyUp);
      // 
      // tb_lose_count
      // 
      this.tb_lose_count.Font = new System.Drawing.Font("BigNoodleTooOblique", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tb_lose_count.Location = new System.Drawing.Point(60, 80);
      this.tb_lose_count.Name = "tb_lose_count";
      this.tb_lose_count.Size = new System.Drawing.Size(52, 31);
      this.tb_lose_count.TabIndex = 20;
      this.tb_lose_count.Text = "0000 ";
      this.tb_lose_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tb_lose_count.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyUp);
      // 
      // tb_sr_count
      // 
      this.tb_sr_count.Font = new System.Drawing.Font("BigNoodleTooOblique", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tb_sr_count.Location = new System.Drawing.Point(60, 151);
      this.tb_sr_count.Name = "tb_sr_count";
      this.tb_sr_count.Size = new System.Drawing.Size(52, 31);
      this.tb_sr_count.TabIndex = 21;
      this.tb_sr_count.Text = "0000 ";
      this.tb_sr_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tb_sr_count.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyUp);
      // 
      // tb_win_count
      // 
      this.tb_win_count.Font = new System.Drawing.Font("BigNoodleTooOblique", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tb_win_count.Location = new System.Drawing.Point(60, 44);
      this.tb_win_count.Name = "tb_win_count";
      this.tb_win_count.Size = new System.Drawing.Size(52, 31);
      this.tb_win_count.TabIndex = 22;
      this.tb_win_count.Text = "0000 ";
      this.tb_win_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tb_win_count.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyUp);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(209, 197);
      this.Controls.Add(this.tb_win_count);
      this.Controls.Add(this.tb_sr_count);
      this.Controls.Add(this.tb_lose_count);
      this.Controls.Add(this.tb_draw_count);
      this.Controls.Add(this.btn_draw_inc);
      this.Controls.Add(this.btn_draw_dec);
      this.Controls.Add(this.btn_lose_inc);
      this.Controls.Add(this.btn_lose_dec);
      this.Controls.Add(this.btn_win_inc);
      this.Controls.Add(this.btn_sr_set);
      this.Controls.Add(this.btn_win_dec);
      this.Controls.Add(this.sr_label);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sr_label;
        private System.Windows.Forms.Button btn_win_dec;
        private System.Windows.Forms.Button btn_sr_set;
        private System.Windows.Forms.Button btn_win_inc;
        private System.Windows.Forms.Button btn_lose_inc;
        private System.Windows.Forms.Button btn_lose_dec;
        private System.Windows.Forms.Button btn_draw_inc;
        private System.Windows.Forms.Button btn_draw_dec;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btn_quit;
    private System.Windows.Forms.TextBox tb_draw_count;
    private System.Windows.Forms.TextBox tb_lose_count;
    private System.Windows.Forms.TextBox tb_sr_count;
    private System.Windows.Forms.TextBox tb_win_count;
  }
}

