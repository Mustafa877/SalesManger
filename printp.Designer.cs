
namespace MySystem.Properties
{
    partial class printpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printpage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.phonetext = new Guna.UI2.WinForms.Guna2TextBox();
            this.addresstext = new Guna.UI2.WinForms.Guna2TextBox();
            this.SAVETEXT = new Guna.UI2.WinForms.Guna2Button();
            this.btupdate = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(23, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Animated = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 4;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.DisabledState.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(210)))));
            this.btnClear.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(23, 86);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(97, 31);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "تحميل";
            this.btnClear.UseTransparentBackground = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.BorderRadius = 10;
            this.txtName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.Gainsboro;
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(192, 139);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "أسم المتجر";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(225, 36);
            this.txtName.TabIndex = 43;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phonetext
            // 
            this.phonetext.Animated = true;
            this.phonetext.BackColor = System.Drawing.Color.Transparent;
            this.phonetext.BorderRadius = 5;
            this.phonetext.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.phonetext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonetext.DefaultText = "";
            this.phonetext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phonetext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phonetext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonetext.DisabledState.Parent = this.phonetext;
            this.phonetext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonetext.FillColor = System.Drawing.Color.Gainsboro;
            this.phonetext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonetext.FocusedState.Parent = this.phonetext;
            this.phonetext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phonetext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phonetext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonetext.HoverState.Parent = this.phonetext;
            this.phonetext.Location = new System.Drawing.Point(382, 10);
            this.phonetext.Name = "phonetext";
            this.phonetext.PasswordChar = '\0';
            this.phonetext.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.phonetext.PlaceholderText = "الهاتف";
            this.phonetext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phonetext.SelectedText = "";
            this.phonetext.ShadowDecoration.Parent = this.phonetext;
            this.phonetext.Size = new System.Drawing.Size(136, 30);
            this.phonetext.TabIndex = 44;
            // 
            // addresstext
            // 
            this.addresstext.Animated = true;
            this.addresstext.BackColor = System.Drawing.Color.Transparent;
            this.addresstext.BorderRadius = 5;
            this.addresstext.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.addresstext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addresstext.DefaultText = "";
            this.addresstext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addresstext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addresstext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addresstext.DisabledState.Parent = this.addresstext;
            this.addresstext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addresstext.FillColor = System.Drawing.Color.Gainsboro;
            this.addresstext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addresstext.FocusedState.Parent = this.addresstext;
            this.addresstext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addresstext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addresstext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addresstext.HoverState.Parent = this.addresstext;
            this.addresstext.Location = new System.Drawing.Point(283, 52);
            this.addresstext.Name = "addresstext";
            this.addresstext.PasswordChar = '\0';
            this.addresstext.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.addresstext.PlaceholderText = "العنوان";
            this.addresstext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addresstext.SelectedText = "";
            this.addresstext.ShadowDecoration.Parent = this.addresstext;
            this.addresstext.Size = new System.Drawing.Size(235, 34);
            this.addresstext.TabIndex = 45;
            // 
            // SAVETEXT
            // 
            this.SAVETEXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SAVETEXT.Animated = true;
            this.SAVETEXT.BackColor = System.Drawing.Color.Transparent;
            this.SAVETEXT.BorderRadius = 5;
            this.SAVETEXT.CheckedState.Parent = this.SAVETEXT;
            this.SAVETEXT.CustomImages.Parent = this.SAVETEXT;
            this.SAVETEXT.DisabledState.Parent = this.SAVETEXT;
            this.SAVETEXT.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.SAVETEXT.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVETEXT.ForeColor = System.Drawing.Color.Black;
            this.SAVETEXT.HoverState.Parent = this.SAVETEXT;
            this.SAVETEXT.Location = new System.Drawing.Point(23, 663);
            this.SAVETEXT.Margin = new System.Windows.Forms.Padding(4);
            this.SAVETEXT.Name = "SAVETEXT";
            this.SAVETEXT.ShadowDecoration.Parent = this.SAVETEXT;
            this.SAVETEXT.Size = new System.Drawing.Size(81, 44);
            this.SAVETEXT.TabIndex = 46;
            this.SAVETEXT.Text = "حفظ";
            this.SAVETEXT.UseTransparentBackground = true;
            this.SAVETEXT.Click += new System.EventHandler(this.SAVETEXT_Click);
            // 
            // btupdate
            // 
            this.btupdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btupdate.Animated = true;
            this.btupdate.BackColor = System.Drawing.Color.Transparent;
            this.btupdate.BorderRadius = 5;
            this.btupdate.CheckedState.Parent = this.btupdate;
            this.btupdate.CustomImages.Parent = this.btupdate;
            this.btupdate.DefaultAutoSize = true;
            this.btupdate.DisabledState.Parent = this.btupdate;
            this.btupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(136)))), ((int)(((byte)(230)))));
            this.btupdate.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btupdate.ForeColor = System.Drawing.Color.Black;
            this.btupdate.HoverState.Parent = this.btupdate;
            this.btupdate.Location = new System.Drawing.Point(132, 663);
            this.btupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btupdate.Name = "btupdate";
            this.btupdate.ShadowDecoration.Parent = this.btupdate;
            this.btupdate.Size = new System.Drawing.Size(76, 44);
            this.btupdate.TabIndex = 48;
            this.btupdate.Text = "تحديث";
            this.btupdate.UseTransparentBackground = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // printpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 742);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.SAVETEXT);
            this.Controls.Add(this.addresstext);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "printpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "معلومات الطباعة الوصل  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        public Guna.UI2.WinForms.Guna2TextBox phonetext;
        public Guna.UI2.WinForms.Guna2TextBox addresstext;
        public Guna.UI2.WinForms.Guna2Button SAVETEXT;
        public Guna.UI2.WinForms.Guna2Button btupdate;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}