
namespace MySystem
{
    partial class ProductModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModuleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPid = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.comboCat = new Guna.UI.WinForms.GunaComboBox();
            this.txtPName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPDes = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.ControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 49);
            this.panel1.TabIndex = 14;
            // 
            // ControlBox1
            // 
            this.ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBox1.BorderRadius = 4;
            this.ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.ControlBox1.HoverState.Parent = this.ControlBox1;
            this.ControlBox1.IconColor = System.Drawing.Color.White;
            this.ControlBox1.Location = new System.Drawing.Point(515, 0);
            this.ControlBox1.Name = "ControlBox1";
            this.ControlBox1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.ControlBox1.ShadowDecoration.Parent = this.ControlBox1;
            this.ControlBox1.Size = new System.Drawing.Size(36, 35);
            this.ControlBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "خانة المواد";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(446, 210);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "الوصف :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(446, 250);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "الفئة :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(436, 165);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "السعر :  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(443, 115);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "العدد : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(443, 66);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = " أسم المادة : ";
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Location = new System.Drawing.Point(499, 295);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(73, 18);
            this.lblPid.TabIndex = 29;
            this.lblPid.Text = "product id";
            this.lblPid.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 5;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.DisabledState.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(23)))), ((int)(((byte)(41)))));
            this.btnClear.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(303, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(73, 37);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "مسح";
            this.btnClear.UseTransparentBackground = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 5;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DisabledState.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btnSave.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(109, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(73, 37);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseTransparentBackground = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.DisabledState.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(210)))));
            this.btnUpdate.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(207, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(73, 37);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "تحديث";
            this.btnUpdate.UseTransparentBackground = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboCat
            // 
            this.comboCat.BackColor = System.Drawing.Color.Transparent;
            this.comboCat.BaseColor = System.Drawing.Color.White;
            this.comboCat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.comboCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCat.FocusedColor = System.Drawing.Color.Empty;
            this.comboCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboCat.ForeColor = System.Drawing.Color.Black;
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Location = new System.Drawing.Point(39, 246);
            this.comboCat.Name = "comboCat";
            this.comboCat.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboCat.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboCat.Radius = 5;
            this.comboCat.Size = new System.Drawing.Size(396, 31);
            this.comboCat.TabIndex = 33;
            // 
            // txtPName
            // 
            this.txtPName.Animated = true;
            this.txtPName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtPName.BorderRadius = 5;
            this.txtPName.BorderThickness = 2;
            this.txtPName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPName.DefaultText = "";
            this.txtPName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtPName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPName.DisabledState.Parent = this.txtPName;
            this.txtPName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPName.FocusedState.Parent = this.txtPName;
            this.txtPName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPName.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtPName.HoverState.Parent = this.txtPName;
            this.txtPName.Location = new System.Drawing.Point(39, 68);
            this.txtPName.Name = "txtPName";
            this.txtPName.PasswordChar = '\0';
            this.txtPName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPName.PlaceholderText = "";
            this.txtPName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPName.SelectedText = "";
            this.txtPName.ShadowDecoration.Parent = this.txtPName;
            this.txtPName.Size = new System.Drawing.Size(396, 27);
            this.txtPName.TabIndex = 42;
            // 
            // txtPQty
            // 
            this.txtPQty.Animated = true;
            this.txtPQty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtPQty.BorderRadius = 5;
            this.txtPQty.BorderThickness = 2;
            this.txtPQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPQty.DefaultText = "";
            this.txtPQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtPQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPQty.DisabledState.Parent = this.txtPQty;
            this.txtPQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPQty.FocusedState.Parent = this.txtPQty;
            this.txtPQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPQty.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtPQty.HoverState.Parent = this.txtPQty;
            this.txtPQty.Location = new System.Drawing.Point(39, 115);
            this.txtPQty.Name = "txtPQty";
            this.txtPQty.PasswordChar = '\0';
            this.txtPQty.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPQty.PlaceholderText = "";
            this.txtPQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPQty.SelectedText = "";
            this.txtPQty.ShadowDecoration.Parent = this.txtPQty;
            this.txtPQty.Size = new System.Drawing.Size(396, 27);
            this.txtPQty.TabIndex = 43;
            // 
            // txtPPrice
            // 
            this.txtPPrice.Animated = true;
            this.txtPPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtPPrice.BorderRadius = 5;
            this.txtPPrice.BorderThickness = 2;
            this.txtPPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPPrice.DefaultText = "";
            this.txtPPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtPPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPPrice.DisabledState.Parent = this.txtPPrice;
            this.txtPPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPPrice.FocusedState.Parent = this.txtPPrice;
            this.txtPPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPPrice.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtPPrice.HoverState.Parent = this.txtPPrice;
            this.txtPPrice.Location = new System.Drawing.Point(39, 163);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.PasswordChar = '\0';
            this.txtPPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPPrice.PlaceholderText = "";
            this.txtPPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPPrice.SelectedText = "";
            this.txtPPrice.ShadowDecoration.Parent = this.txtPPrice;
            this.txtPPrice.Size = new System.Drawing.Size(396, 27);
            this.txtPPrice.TabIndex = 44;
            // 
            // txtPDes
            // 
            this.txtPDes.Animated = true;
            this.txtPDes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtPDes.BorderRadius = 5;
            this.txtPDes.BorderThickness = 2;
            this.txtPDes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPDes.DefaultText = "";
            this.txtPDes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtPDes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPDes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPDes.DisabledState.Parent = this.txtPDes;
            this.txtPDes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPDes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPDes.FocusedState.Parent = this.txtPDes;
            this.txtPDes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPDes.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtPDes.HoverState.Parent = this.txtPDes;
            this.txtPDes.Location = new System.Drawing.Point(39, 208);
            this.txtPDes.Name = "txtPDes";
            this.txtPDes.PasswordChar = '\0';
            this.txtPDes.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPDes.PlaceholderText = "";
            this.txtPDes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPDes.SelectedText = "";
            this.txtPDes.ShadowDecoration.Parent = this.txtPDes;
            this.txtPDes.Size = new System.Drawing.Size(396, 27);
            this.txtPDes.TabIndex = 45;
            // 
            // ProductModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 364);
            this.Controls.Add(this.txtPDes);
            this.Controls.Add(this.txtPPrice);
            this.Controls.Add(this.txtPQty);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.comboCat);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.f);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblPid;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public Guna.UI2.WinForms.Guna2Button btnClear;
        public Guna.UI2.WinForms.Guna2Button btnUpdate;
        public Guna.UI2.WinForms.Guna2Button btnSave;
        public Guna.UI.WinForms.GunaComboBox comboCat;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBox1;
        public Guna.UI2.WinForms.Guna2TextBox txtPDes;
        public Guna.UI2.WinForms.Guna2TextBox txtPPrice;
        public Guna.UI2.WinForms.Guna2TextBox txtPQty;
        public Guna.UI2.WinForms.Guna2TextBox txtPName;
    }
}