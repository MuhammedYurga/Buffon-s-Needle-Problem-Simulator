
namespace BuffonsNeedleProblemSimulator_MuhammedYurga
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.needlelentrack = new Telerik.WinControls.UI.RadTrackBar();
            this.speedtrack = new Telerik.WinControls.UI.RadTrackBar();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.needlelenud = new System.Windows.Forms.NumericUpDown();
            this.speedud = new System.Windows.Forms.NumericUpDown();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.droptimesud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnclear = new System.Windows.Forms.Button();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblratio = new System.Windows.Forms.Label();
            this.lblOnLineCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDropCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.simulationpanel = new Telerik.WinControls.UI.RadPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.needlelentrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedtrack)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.needlelenud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droptimesud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulationpanel)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.simulationpanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 474F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.14724F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.852761F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Controls.Add(this.radPanel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnclear, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.radPanel2, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1178, 87);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnstart);
            this.radPanel1.Controls.Add(this.btnstop);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(754, 3);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(58, 81);
            this.radPanel1.TabIndex = 0;
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(226)))), ((int)(((byte)(72)))));
            this.btnstart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnstart.Location = new System.Drawing.Point(0, 0);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(58, 81);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.Tomato;
            this.btnstop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnstop.Location = new System.Drawing.Point(0, 0);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(58, 81);
            this.btnstop.TabIndex = 5;
            this.btnstop.Text = "STOP";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Visible = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.92958F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.6506F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.3494F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(745, 81);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.needlelentrack, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.speedtrack, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(739, 44);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // needlelentrack
            // 
            this.needlelentrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.needlelentrack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.needlelentrack.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight;
            this.needlelentrack.LargeTickFrequency = 10;
            this.needlelentrack.Location = new System.Drawing.Point(372, 3);
            this.needlelentrack.Maximum = 100F;
            this.needlelentrack.Minimum = 10F;
            this.needlelentrack.Name = "needlelentrack";
            this.needlelentrack.ShowButtons = true;
            this.needlelentrack.Size = new System.Drawing.Size(364, 38);
            this.needlelentrack.SmallChange = 5;
            this.needlelentrack.SmallTickFrequency = 5;
            this.needlelentrack.TabIndex = 4;
            this.needlelentrack.ThemeName = "TelerikMetro";
            this.needlelentrack.ThumbSize = new System.Drawing.Size(20, 14);
            this.needlelentrack.TickStyle = Telerik.WinControls.Enumerations.TickStyles.BottomRight;
            this.needlelentrack.Value = 50F;
            this.needlelentrack.ValueChanged += new System.EventHandler(this.needlelentrack_ValueChanged);
            // 
            // speedtrack
            // 
            this.speedtrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedtrack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.speedtrack.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.BottomRight;
            this.speedtrack.LargeTickFrequency = 20;
            this.speedtrack.Location = new System.Drawing.Point(3, 3);
            this.speedtrack.Maximum = 100F;
            this.speedtrack.Name = "speedtrack";
            this.speedtrack.ShowButtons = true;
            this.speedtrack.Size = new System.Drawing.Size(363, 38);
            this.speedtrack.TabIndex = 2;
            this.speedtrack.ThemeName = "TelerikMetro";
            this.speedtrack.ThumbSize = new System.Drawing.Size(20, 14);
            this.speedtrack.TickStyle = Telerik.WinControls.Enumerations.TickStyles.BottomRight;
            this.speedtrack.Value = 50F;
            this.speedtrack.ValueChanged += new System.EventHandler(this.speedtrack_ValueChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 7;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.66929F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.33071F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel5.Controls.Add(this.needlelenud, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.speedud, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.radLabel1, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.droptimesud, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.radLabel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.radLabel3, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(739, 25);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // needlelenud
            // 
            this.needlelenud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.needlelenud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.needlelenud.Location = new System.Drawing.Point(667, 3);
            this.needlelenud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.needlelenud.Name = "needlelenud";
            this.needlelenud.Size = new System.Drawing.Size(69, 29);
            this.needlelenud.TabIndex = 0;
            this.needlelenud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.needlelenud.ValueChanged += new System.EventHandler(this.needlelenud_ValueChanged);
            // 
            // speedud
            // 
            this.speedud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.speedud.Location = new System.Drawing.Point(75, 3);
            this.speedud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedud.Name = "speedud";
            this.speedud.Size = new System.Drawing.Size(80, 29);
            this.speedud.TabIndex = 1;
            this.speedud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedud.ValueChanged += new System.EventHandler(this.speedud_ValueChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radLabel1.Location = new System.Drawing.Point(532, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(129, 25);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "NEEDLE LENGTH";
            // 
            // droptimesud
            // 
            this.droptimesud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.droptimesud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.droptimesud.Location = new System.Drawing.Point(372, 3);
            this.droptimesud.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.droptimesud.Name = "droptimesud";
            this.droptimesud.Size = new System.Drawing.Size(115, 29);
            this.droptimesud.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(301, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "(0 is Infinity)";
            // 
            // radLabel2
            // 
            this.radLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radLabel2.Location = new System.Drawing.Point(3, 3);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(54, 25);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "SPEED";
            // 
            // radLabel3
            // 
            this.radLabel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radLabel3.Location = new System.Drawing.Point(195, 3);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(100, 25);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "DROP TIMES";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(62)))));
            this.btnclear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnclear.Location = new System.Drawing.Point(1120, 3);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(55, 81);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.label4);
            this.radPanel2.Controls.Add(this.lblratio);
            this.radPanel2.Controls.Add(this.lblOnLineCount);
            this.radPanel2.Controls.Add(this.label1);
            this.radPanel2.Controls.Add(this.lblDropCount);
            this.radPanel2.Controls.Add(this.label2);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(818, 3);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(296, 81);
            this.radPanel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "On The Line Ratio: 2 /";
            // 
            // lblratio
            // 
            this.lblratio.AutoSize = true;
            this.lblratio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblratio.Location = new System.Drawing.Point(161, 56);
            this.lblratio.Name = "lblratio";
            this.lblratio.Size = new System.Drawing.Size(19, 21);
            this.lblratio.TabIndex = 4;
            this.lblratio.Text = "0";
            // 
            // lblOnLineCount
            // 
            this.lblOnLineCount.AutoSize = true;
            this.lblOnLineCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOnLineCount.Location = new System.Drawing.Point(181, 31);
            this.lblOnLineCount.Name = "lblOnLineCount";
            this.lblOnLineCount.Size = new System.Drawing.Size(19, 21);
            this.lblOnLineCount.TabIndex = 3;
            this.lblOnLineCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count Of Drops:";
            // 
            // lblDropCount
            // 
            this.lblDropCount.AutoSize = true;
            this.lblDropCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDropCount.Location = new System.Drawing.Point(181, 6);
            this.lblDropCount.Name = "lblDropCount";
            this.lblDropCount.Size = new System.Drawing.Size(19, 21);
            this.lblDropCount.TabIndex = 2;
            this.lblDropCount.Text = "0";
            this.lblDropCount.TextChanged += new System.EventHandler(this.lblDropCount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dropped On The Line: ";
            // 
            // simulationpanel
            // 
            this.simulationpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simulationpanel.Enabled = false;
            this.simulationpanel.Location = new System.Drawing.Point(3, 96);
            this.simulationpanel.Name = "simulationpanel";
            this.simulationpanel.Size = new System.Drawing.Size(1178, 468);
            this.simulationpanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Buffon\'s Needle Problem Simulator - Muhammed Yurga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.needlelentrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedtrack)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.needlelenud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droptimesud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulationpanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label lblOnLineCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDropCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Telerik.WinControls.UI.RadTrackBar needlelentrack;
        private Telerik.WinControls.UI.RadTrackBar speedtrack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.NumericUpDown needlelenud;
        private System.Windows.Forms.NumericUpDown speedud;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.NumericUpDown droptimesud;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadPanel simulationpanel;
        private System.Windows.Forms.Button btnstop;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private System.Windows.Forms.Label lblratio;
        private System.Windows.Forms.Label label4;
    }
}

