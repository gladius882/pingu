/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2019-04-13
 * Time: 21:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Pingu
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.htmlPanel1 = new MetroFramework.Drawing.Html.HtmlPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripMax = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripMin = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripAvg = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripCurrent = new System.Windows.Forms.ToolStripLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.htmlPanel1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Categorized;
			this.propertyGrid1.Size = new System.Drawing.Size(286, 546);
			this.propertyGrid1.TabIndex = 1;
			this.propertyGrid1.ToolbarVisible = false;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.propertyGrid1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.htmlPanel1);
			this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
			this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
			this.splitContainer1.Size = new System.Drawing.Size(705, 546);
			this.splitContainer1.SplitterDistance = 286;
			this.splitContainer1.TabIndex = 2;
			// 
			// htmlPanel1
			// 
			this.htmlPanel1.AutoScroll = true;
			this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(415, 0);
			this.htmlPanel1.BackColor = System.Drawing.SystemColors.Window;
			this.htmlPanel1.Controls.Add(this.textBox1);
			this.htmlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htmlPanel1.Location = new System.Drawing.Point(0, 31);
			this.htmlPanel1.Name = "htmlPanel1";
			this.htmlPanel1.Size = new System.Drawing.Size(415, 490);
			this.htmlPanel1.TabIndex = 5;
			this.htmlPanel1.Text = "<style>div { margin-left: 10px; } </style>";
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(415, 490);
			this.textBox1.TabIndex = 0;
			this.textBox1.WordWrap = false;
			// 
			// toolStrip2
			// 
			this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripLabel1,
									this.toolStripMax,
									this.toolStripSeparator1,
									this.toolStripLabel3,
									this.toolStripMin,
									this.toolStripSeparator2,
									this.toolStripLabel5,
									this.toolStripAvg,
									this.toolStripSeparator3,
									this.toolStripLabel2,
									this.toolStripCurrent});
			this.toolStrip2.Location = new System.Drawing.Point(0, 521);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(415, 25);
			this.toolStrip2.TabIndex = 4;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.ForeColor = System.Drawing.Color.Red;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(61, 22);
			this.toolStripLabel1.Text = "Maximum";
			// 
			// toolStripMax
			// 
			this.toolStripMax.ForeColor = System.Drawing.Color.Red;
			this.toolStripMax.Name = "toolStripMax";
			this.toolStripMax.Size = new System.Drawing.Size(13, 22);
			this.toolStripMax.Text = "0";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(60, 22);
			this.toolStripLabel3.Text = "Minimum";
			// 
			// toolStripMin
			// 
			this.toolStripMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.toolStripMin.Name = "toolStripMin";
			this.toolStripMin.Size = new System.Drawing.Size(13, 22);
			this.toolStripMin.Text = "0";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel5
			// 
			this.toolStripLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.toolStripLabel5.Name = "toolStripLabel5";
			this.toolStripLabel5.Size = new System.Drawing.Size(50, 22);
			this.toolStripLabel5.Text = "Average";
			// 
			// toolStripAvg
			// 
			this.toolStripAvg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.toolStripAvg.Name = "toolStripAvg";
			this.toolStripAvg.Size = new System.Drawing.Size(13, 22);
			this.toolStripAvg.Text = "0";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(29, 22);
			this.toolStripLabel2.Text = "Last";
			// 
			// toolStripCurrent
			// 
			this.toolStripCurrent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.toolStripCurrent.Name = "toolStripCurrent";
			this.toolStripCurrent.Size = new System.Drawing.Size(14, 22);
			this.toolStripCurrent.Text = "0";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButtonStart,
									this.toolStripButtonStop,
									this.toolStripButtonClear});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(415, 31);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonStart
			// 
			this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
			this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStart.Name = "toolStripButtonStart";
			this.toolStripButtonStart.Size = new System.Drawing.Size(28, 28);
			this.toolStripButtonStart.Text = "Start";
			this.toolStripButtonStart.Click += new System.EventHandler(this.ToolStripButtonStartClick);
			// 
			// toolStripButtonStop
			// 
			this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
			this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStop.Name = "toolStripButtonStop";
			this.toolStripButtonStop.Size = new System.Drawing.Size(28, 28);
			this.toolStripButtonStop.Text = "Stop";
			this.toolStripButtonStop.Click += new System.EventHandler(this.ToolStripButton2Click);
			// 
			// toolStripButtonClear
			// 
			this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
			this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonClear.Name = "toolStripButtonClear";
			this.toolStripButtonClear.Size = new System.Drawing.Size(28, 28);
			this.toolStripButtonClear.Text = "toolStripButton3";
			this.toolStripButtonClear.Click += new System.EventHandler(this.ToolStripButtonClearClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(705, 546);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Pingu";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.htmlPanel1.ResumeLayout(false);
			this.htmlPanel1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripLabel toolStripCurrent;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ToolStripLabel toolStripAvg;
		private System.Windows.Forms.ToolStripLabel toolStripLabel5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel toolStripMin;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel toolStripMax;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton toolStripButtonClear;
		private System.Windows.Forms.ToolStripButton toolStripButtonStop;
		private System.Windows.Forms.ToolStripButton toolStripButtonStart;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private MetroFramework.Drawing.Html.HtmlPanel htmlPanel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
	}
}
