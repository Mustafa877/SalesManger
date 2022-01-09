
namespace MySystem
{
    partial class printpageout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printpageout));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.phonetext = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.addresstext = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.palltext = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.datetext = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MAINTEXT = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.idtext = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.totaltext = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panelprint = new System.Windows.Forms.Panel();
            this.Printsenddpt = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelprint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Printsenddpt)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.Interval = 300;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.UseAntiAlias = true;
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // phonetext
            // 
            this.phonetext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.phonetext.Location = new System.Drawing.Point(629, 23);
            this.phonetext.Name = "phonetext";
            this.phonetext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phonetext.Size = new System.Drawing.Size(80, 25);
            this.phonetext.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.phonetext.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.phonetext.StateCommon.ShortText.Font = new System.Drawing.Font("Arabic Typesetting", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetext.TabIndex = 51;
            this.phonetext.Values.Text = "07502680210";
            // 
            // addresstext
            // 
            this.addresstext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addresstext.Location = new System.Drawing.Point(600, 56);
            this.addresstext.Name = "addresstext";
            this.addresstext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addresstext.Size = new System.Drawing.Size(109, 25);
            this.addresstext.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.addresstext.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.addresstext.StateCommon.ShortText.Font = new System.Drawing.Font("Arabic Typesetting", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstext.TabIndex = 52;
            this.addresstext.Values.Text = "العراق -النجف الاشرف";
            this.addresstext.Paint += new System.Windows.Forms.PaintEventHandler(this.addresstext_Paint);
            // 
            // palltext
            // 
            this.palltext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.palltext.Location = new System.Drawing.Point(49, 226);
            this.palltext.Name = "palltext";
            this.palltext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.palltext.Size = new System.Drawing.Size(50, 25);
            this.palltext.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.palltext.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.palltext.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palltext.TabIndex = 53;
            this.palltext.Values.Text = "krypto";
            // 
            // datetext
            // 
            this.datetext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.datetext.Location = new System.Drawing.Point(607, 243);
            this.datetext.Name = "datetext";
            this.datetext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datetext.Size = new System.Drawing.Size(70, 25);
            this.datetext.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.datetext.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.datetext.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetext.TabIndex = 55;
            this.datetext.Values.Text = "kryptonLa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // MAINTEXT
            // 
            this.MAINTEXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MAINTEXT.Location = new System.Drawing.Point(312, 89);
            this.MAINTEXT.Name = "MAINTEXT";
            this.MAINTEXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MAINTEXT.Size = new System.Drawing.Size(199, 25);
            this.MAINTEXT.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.MAINTEXT.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.MAINTEXT.StateCommon.ShortText.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAINTEXT.TabIndex = 57;
            this.MAINTEXT.Values.Text = "Meem Sales System";
            this.MAINTEXT.Paint += new System.Windows.Forms.PaintEventHandler(this.MAINTEXT_Paint);
            // 
            // idtext
            // 
            this.idtext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.idtext.AutoSize = false;
            this.idtext.Location = new System.Drawing.Point(571, 198);
            this.idtext.Name = "idtext";
            this.idtext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idtext.Size = new System.Drawing.Size(113, 28);
            this.idtext.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.idtext.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.idtext.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtext.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.idtext.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.idtext.TabIndex = 58;
            this.idtext.Values.Text = "krypto";
            this.idtext.Paint += new System.Windows.Forms.PaintEventHandler(this.idtext_Paint);
            // 
            // totaltext
            // 
            this.totaltext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totaltext.AutoSize = false;
            this.totaltext.Location = new System.Drawing.Point(302, 889);
            this.totaltext.Name = "totaltext";
            this.totaltext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totaltext.Size = new System.Drawing.Size(382, 24);
            this.totaltext.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.totaltext.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.totaltext.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltext.TabIndex = 59;
            this.totaltext.Values.Text = "krypto";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel1.Location = new System.Drawing.Point(710, 23);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(45, 25);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arabic Typesetting", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 60;
            this.kryptonLabel1.Values.Text = ": الهاتف";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel2.Location = new System.Drawing.Point(709, 56);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(46, 25);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arabic Typesetting", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 61;
            this.kryptonLabel2.Values.Text = ": العنوان ";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel8.Location = new System.Drawing.Point(690, 198);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(57, 25);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel8.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 62;
            this.kryptonLabel8.Values.Text = ": تسلسل";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel9.Location = new System.Drawing.Point(688, 243);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(57, 25);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 63;
            this.kryptonLabel9.Values.Text = ": التاريخ";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel5.Location = new System.Drawing.Point(111, 226);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(87, 25);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel5.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 64;
            this.kryptonLabel5.Values.Text = ":  الفاتورة الى";
            this.kryptonLabel5.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel5_Paint);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel6.Location = new System.Drawing.Point(692, 888);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(74, 25);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel6.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 65;
            this.kryptonLabel6.Values.Text = ": المجموع";
            // 
            // panelprint
            // 
            this.panelprint.BackColor = System.Drawing.Color.Transparent;
            this.panelprint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelprint.BackgroundImage")));
            this.panelprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelprint.Controls.Add(this.Printsenddpt);
            this.panelprint.Controls.Add(this.kryptonLabel3);
            this.panelprint.Controls.Add(this.kryptonLabel6);
            this.panelprint.Controls.Add(this.kryptonLabel5);
            this.panelprint.Controls.Add(this.kryptonLabel9);
            this.panelprint.Controls.Add(this.kryptonLabel8);
            this.panelprint.Controls.Add(this.kryptonLabel2);
            this.panelprint.Controls.Add(this.kryptonLabel1);
            this.panelprint.Controls.Add(this.totaltext);
            this.panelprint.Controls.Add(this.idtext);
            this.panelprint.Controls.Add(this.MAINTEXT);
            this.panelprint.Controls.Add(this.pictureBox1);
            this.panelprint.Controls.Add(this.datetext);
            this.panelprint.Controls.Add(this.palltext);
            this.panelprint.Controls.Add(this.addresstext);
            this.panelprint.Controls.Add(this.phonetext);
            this.panelprint.ForeColor = System.Drawing.Color.White;
            this.panelprint.Location = new System.Drawing.Point(3, 48);
            this.panelprint.Name = "panelprint";
            this.panelprint.Size = new System.Drawing.Size(769, 1050);
            this.panelprint.TabIndex = 0;
            this.panelprint.Paint += new System.Windows.Forms.PaintEventHandler(this.panelprint_Paint);
            // 
            // Printsenddpt
            // 
            this.Printsenddpt.AllowUserToAddRows = false;
            this.Printsenddpt.AllowUserToDeleteRows = false;
            this.Printsenddpt.AllowUserToResizeColumns = false;
            this.Printsenddpt.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Printsenddpt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Printsenddpt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Printsenddpt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Printsenddpt.ColumnHeadersHeight = 30;
            this.Printsenddpt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.Printsenddpt.Location = new System.Drawing.Point(0, 307);
            this.Printsenddpt.Name = "Printsenddpt";
            this.Printsenddpt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Printsenddpt.RowHeadersVisible = false;
            this.Printsenddpt.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.Printsenddpt.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Printsenddpt.RowTemplate.Height = 31;
            this.Printsenddpt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Printsenddpt.Size = new System.Drawing.Size(766, 533);
            this.Printsenddpt.StateCommon.Background.Color1 = System.Drawing.Color.WhiteSmoke;
            this.Printsenddpt.StateCommon.Background.Color2 = System.Drawing.Color.WhiteSmoke;
            this.Printsenddpt.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.Printsenddpt.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.Printsenddpt.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.Printsenddpt.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Printsenddpt.StateCommon.DataCell.Border.Rounding = 0;
            this.Printsenddpt.StateCommon.DataCell.Border.Width = 1;
            this.Printsenddpt.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.Printsenddpt.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.Printsenddpt.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Printsenddpt.StateCommon.HeaderColumn.Border.Rounding = 4;
            this.Printsenddpt.StateCommon.HeaderColumn.Border.Width = 2;
            this.Printsenddpt.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.Printsenddpt.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.Printsenddpt.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Transparent;
            this.Printsenddpt.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Transparent;
            this.Printsenddpt.StateNormal.Background.Color1 = System.Drawing.Color.Transparent;
            this.Printsenddpt.StateNormal.Background.Color2 = System.Drawing.Color.Transparent;
            this.Printsenddpt.StateNormal.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.Printsenddpt.StateNormal.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.Printsenddpt.TabIndex = 69;
            this.Printsenddpt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Printsenddpt_CellContentClick_1);
            // 
            // Column
            // 
            this.Column.HeaderText = "اسم المادة";
            this.Column.MinimumWidth = 6;
            this.Column.Name = "Column";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "السعر";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "العدد";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "المجموع ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "تاريخ الطلب";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(325, 1024);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(156, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Arabic Typesetting", 7.8F);
            this.kryptonLabel3.TabIndex = 68;
            this.kryptonLabel3.Values.Text = "Thank you for doing business with us.";
            // 
            // printpageout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 1053);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelprint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "printpageout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.printpageout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelprint.ResumeLayout(false);
            this.panelprint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Printsenddpt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        public Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        public System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        public System.Windows.Forms.Panel panelprint;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel totaltext;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel idtext;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel MAINTEXT;
        public System.Windows.Forms.PictureBox pictureBox1;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel datetext;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel palltext;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel addresstext;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel phonetext;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView Printsenddpt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}