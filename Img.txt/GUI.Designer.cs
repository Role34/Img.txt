namespace Img.txt
{
    partial class GUI
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
            this.imgdottxt = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.Execute = new System.Windows.Forms.Button();
            this.LoadImage = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.openimg = new System.Windows.Forms.OpenFileDialog();
            this.Output = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.Label();
            this.Creator = new System.Windows.Forms.LinkLabel();
            this.Credit = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // imgdottxt
            // 
            this.imgdottxt.AutoSize = true;
            this.imgdottxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgdottxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgdottxt.Location = new System.Drawing.Point(8, 8);
            this.imgdottxt.Name = "imgdottxt";
            this.imgdottxt.Size = new System.Drawing.Size(64, 15);
            this.imgdottxt.TabIndex = 0;
            this.imgdottxt.Text = "Img.txt V1";
            this.imgdottxt.Click += new System.EventHandler(this.imgdottxt_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Result.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.White;
            this.Result.Location = new System.Drawing.Point(358, 56);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(329, 224);
            this.Result.TabIndex = 1;
            this.Result.Text = "";
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Execute.FlatAppearance.BorderSize = 0;
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.ForeColor = System.Drawing.Color.White;
            this.Execute.Location = new System.Drawing.Point(12, 286);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(88, 33);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // LoadImage
            // 
            this.LoadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LoadImage.FlatAppearance.BorderSize = 0;
            this.LoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadImage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadImage.ForeColor = System.Drawing.Color.White;
            this.LoadImage.Location = new System.Drawing.Point(106, 286);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(88, 33);
            this.LoadImage.TabIndex = 3;
            this.LoadImage.Text = "Load Image";
            this.LoadImage.UseVisualStyleBackColor = false;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.Minimize);
            this.Panel.Controls.Add(this.imgdottxt);
            this.Panel.Controls.Add(this.Exit);
            this.Panel.Controls.Add(this.Version);
            this.Panel.Location = new System.Drawing.Point(-1, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(700, 37);
            this.Panel.TabIndex = 4;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(636, 6);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 24);
            this.Minimize.TabIndex = 7;
            this.Minimize.Text = "—";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(664, 6);
            this.Exit.Margin = new System.Windows.Forms.Padding(1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(24, 24);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.ForeColor = System.Drawing.Color.White;
            this.Version.Location = new System.Drawing.Point(225, 8);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(246, 19);
            this.Version.TabIndex = 5;
            this.Version.Text = "OCR used - IronOcr 2022.11.0.10109";
            this.Version.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Version_MouseDown);
            this.Version.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Version_MouseMove);
            // 
            // img
            // 
            this.img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.img.Location = new System.Drawing.Point(10, 56);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(329, 224);
            this.img.TabIndex = 5;
            this.img.TabStop = false;
            // 
            // openimg
            // 
            this.openimg.FileName = "openimg";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(355, 40);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(51, 15);
            this.Output.TabIndex = 6;
            this.Output.Text = "Output:";
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.ForeColor = System.Drawing.Color.White;
            this.Input.Location = new System.Drawing.Point(9, 40);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(40, 15);
            this.Input.TabIndex = 9;
            this.Input.Text = "Input:";
            // 
            // Creator
            // 
            this.Creator.ActiveLinkColor = System.Drawing.Color.White;
            this.Creator.AutoSize = true;
            this.Creator.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creator.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Creator.LinkColor = System.Drawing.Color.White;
            this.Creator.Location = new System.Drawing.Point(600, 295);
            this.Creator.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.Creator.Name = "Creator";
            this.Creator.Size = new System.Drawing.Size(85, 15);
            this.Creator.TabIndex = 11;
            this.Creator.TabStop = true;
            this.Creator.Text = "Role34/Judiell";
            this.Creator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Creator_LinkClicked);
            // 
            // Credit
            // 
            this.Credit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Credit.AutoSize = true;
            this.Credit.BackColor = System.Drawing.Color.Transparent;
            this.Credit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Credit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.Credit.ForeColor = System.Drawing.Color.White;
            this.Credit.Location = new System.Drawing.Point(530, 295);
            this.Credit.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(71, 15);
            this.Credit.TabIndex = 10;
            this.Credit.Text = "Created by:";
            this.Credit.Click += new System.EventHandler(this.Credit_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(699, 327);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.Creator);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.img);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.LoadImage);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imgdottxt;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.OpenFileDialog openimg;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.LinkLabel Creator;
        private System.Windows.Forms.Label Credit;
    }
}

