namespace kemen
{
  partial class Launcher
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
      this.btnLanzar = new System.Windows.Forms.Button();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      this.SuspendLayout();
      // 
      // btnLanzar
      // 
      this.btnLanzar.Location = new System.Drawing.Point(47, 201);
      this.btnLanzar.Name = "btnLanzar";
      this.btnLanzar.Size = new System.Drawing.Size(75, 29);
      this.btnLanzar.TabIndex = 0;
      this.btnLanzar.Text = "Abrir";
      this.btnLanzar.UseVisualStyleBackColor = true;
      this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
      // 
      // pictureBox2
      // 
      this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(43)))));
      this.pictureBox2.Image = global::kemen.Properties.Resources.logo_dinaksa;
      this.pictureBox2.Location = new System.Drawing.Point(6, 1);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(162, 30);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 62;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(43)))));
      this.pictureBox1.Location = new System.Drawing.Point(-1, 201);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(174, 30);
      this.pictureBox1.TabIndex = 63;
      this.pictureBox1.TabStop = false;
      // 
      // pictureBox3
      // 
      this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(43)))));
      this.pictureBox3.Location = new System.Drawing.Point(-1, 1);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(174, 30);
      this.pictureBox3.TabIndex = 64;
      this.pictureBox3.TabStop = false;
      // 
      // Launcher
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(207)))), ((int)(((byte)(107)))));
      this.ClientSize = new System.Drawing.Size(173, 235);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.btnLanzar);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.pictureBox3);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Launcher";
      this.Text = "Abrir KEMEN";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnLanzar;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox3;
  }
}