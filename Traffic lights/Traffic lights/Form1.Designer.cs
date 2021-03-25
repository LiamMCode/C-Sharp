namespace Traffic_lights
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.redlight = new System.Windows.Forms.PictureBox();
            this.amberlight = new System.Windows.Forms.PictureBox();
            this.greenlight = new System.Windows.Forms.PictureBox();
            this.tmrTraffic = new System.Windows.Forms.Timer(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.imgcar = new System.Windows.Forms.PictureBox();
            this.tmrcar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.redlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amberlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcar)).BeginInit();
            this.SuspendLayout();
            // 
            // redlight
            // 
            this.redlight.BackColor = System.Drawing.Color.Red;
            this.redlight.Location = new System.Drawing.Point(68, 12);
            this.redlight.Name = "redlight";
            this.redlight.Size = new System.Drawing.Size(113, 113);
            this.redlight.TabIndex = 0;
            this.redlight.TabStop = false;
            // 
            // amberlight
            // 
            this.amberlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.amberlight.Location = new System.Drawing.Point(68, 131);
            this.amberlight.Name = "amberlight";
            this.amberlight.Size = new System.Drawing.Size(113, 112);
            this.amberlight.TabIndex = 1;
            this.amberlight.TabStop = false;
            // 
            // greenlight
            // 
            this.greenlight.BackColor = System.Drawing.Color.Green;
            this.greenlight.Location = new System.Drawing.Point(68, 249);
            this.greenlight.Name = "greenlight";
            this.greenlight.Size = new System.Drawing.Size(113, 112);
            this.greenlight.TabIndex = 2;
            this.greenlight.TabStop = false;
            this.greenlight.Click += new System.EventHandler(this.greenlight_Click);
            // 
            // tmrTraffic
            // 
            this.tmrTraffic.Enabled = true;
            this.tmrTraffic.Interval = 1000;
            this.tmrTraffic.Tick += new System.EventHandler(this.tmrTraffic_Tick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 55);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(13, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "1";
            // 
            // imgcar
            // 
            this.imgcar.Image = ((System.Drawing.Image)(resources.GetObject("imgcar.Image")));
            this.imgcar.Location = new System.Drawing.Point(15, 385);
            this.imgcar.Name = "imgcar";
            this.imgcar.Size = new System.Drawing.Size(239, 168);
            this.imgcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgcar.TabIndex = 4;
            this.imgcar.TabStop = false;
            // 
            // tmrcar
            // 
            this.tmrcar.Enabled = true;
            this.tmrcar.Interval = 1;
            this.tmrcar.Tick += new System.EventHandler(this.tmrcar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 565);
            this.Controls.Add(this.imgcar);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.greenlight);
            this.Controls.Add(this.amberlight);
            this.Controls.Add(this.redlight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.redlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amberlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox redlight;
        private System.Windows.Forms.PictureBox amberlight;
        private System.Windows.Forms.PictureBox greenlight;
        private System.Windows.Forms.Timer tmrTraffic;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox imgcar;
        private System.Windows.Forms.Timer tmrcar;
    }
}

