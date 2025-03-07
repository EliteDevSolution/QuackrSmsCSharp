/*
 * Created by SharpDevelop.
 * User: FSTAR
 * Date: 3/7/2025
 * Time: 1:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Quackrsms
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
			this.app_title = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_sms = new System.Windows.Forms.TextBox();
			this.btn_refresh = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// app_title
			// 
			this.app_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.app_title.Location = new System.Drawing.Point(6, 8);
			this.app_title.Name = "app_title";
			this.app_title.Size = new System.Drawing.Size(362, 39);
			this.app_title.TabIndex = 0;
			this.app_title.Text = "Quackrsms (+447454857546)";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txt_sms);
			this.panel1.Controls.Add(this.btn_refresh);
			this.panel1.Controls.Add(this.app_title);
			this.panel1.Location = new System.Drawing.Point(6, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(475, 360);
			this.panel1.TabIndex = 1;
			// 
			// txt_sms
			// 
			this.txt_sms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_sms.Location = new System.Drawing.Point(0, 50);
			this.txt_sms.Multiline = true;
			this.txt_sms.Name = "txt_sms";
			this.txt_sms.Size = new System.Drawing.Size(472, 307);
			this.txt_sms.TabIndex = 2;

			// btn_refresh
			// 
			this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_refresh.Location = new System.Drawing.Point(371, 3);
			this.btn_refresh.Name = "btn_refresh";
			this.btn_refresh.Size = new System.Drawing.Size(104, 41);
			this.btn_refresh.TabIndex = 1;
			this.btn_refresh.Text = "Refresh";
			this.btn_refresh.UseVisualStyleBackColor = true;
			this.btn_refresh.Click += new System.EventHandler(this.Btn_refreshClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximumSize = new System.Drawing.Size(500, 400);
			this.MinimumSize = new System.Drawing.Size(500, 400);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quackrsms";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txt_sms;
		private System.Windows.Forms.Button btn_refresh;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label app_title;
		
		
		
	}
}
