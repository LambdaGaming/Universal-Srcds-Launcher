namespace GMod_Server_Launcher_Console
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lancheck = new System.Windows.Forms.CheckBox();
			this.mapselect = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.maxplayers = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.consolecheck = new System.Windows.Forms.CheckBox();
			this.gameselect = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.TokenEnable = new System.Windows.Forms.CheckBox();
			this.TokenFolder = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.maxplayers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lancheck
			// 
			this.lancheck.AutoSize = true;
			this.lancheck.Cursor = System.Windows.Forms.Cursors.Default;
			this.lancheck.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lancheck.ForeColor = System.Drawing.Color.White;
			this.lancheck.Location = new System.Drawing.Point(12, 62);
			this.lancheck.Name = "lancheck";
			this.lancheck.Size = new System.Drawing.Size(78, 19);
			this.lancheck.TabIndex = 0;
			this.lancheck.Text = "LAN Server";
			this.lancheck.UseVisualStyleBackColor = true;
			this.lancheck.CheckedChanged += new System.EventHandler(this.LanCheck);
			// 
			// mapselect
			// 
			this.mapselect.Enabled = false;
			this.mapselect.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mapselect.FormattingEnabled = true;
			this.mapselect.Location = new System.Drawing.Point(10, 315);
			this.mapselect.Name = "mapselect";
			this.mapselect.Size = new System.Drawing.Size(132, 23);
			this.mapselect.TabIndex = 2;
			this.mapselect.SelectedIndexChanged += new System.EventHandler(this.MapChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(12, 297);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Map:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DimGray;
			this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(0, 480);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(484, 64);
			this.button1.TabIndex = 4;
			this.button1.Text = "START";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// maxplayers
			// 
			this.maxplayers.Location = new System.Drawing.Point(10, 179);
			this.maxplayers.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.maxplayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.maxplayers.Name = "maxplayers";
			this.maxplayers.Size = new System.Drawing.Size(61, 20);
			this.maxplayers.TabIndex = 6;
			this.maxplayers.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.maxplayers.ValueChanged += new System.EventHandler(this.MaxPlayersChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(9, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Max Players:";
			// 
			// consolecheck
			// 
			this.consolecheck.AutoSize = true;
			this.consolecheck.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consolecheck.ForeColor = System.Drawing.Color.White;
			this.consolecheck.Location = new System.Drawing.Point(12, 12);
			this.consolecheck.Name = "consolecheck";
			this.consolecheck.Size = new System.Drawing.Size(98, 19);
			this.consolecheck.TabIndex = 1;
			this.consolecheck.Text = "Enable Console";
			this.consolecheck.UseVisualStyleBackColor = true;
			this.consolecheck.CheckedChanged += new System.EventHandler(this.ConsoleCheck);
			// 
			// gameselect
			// 
			this.gameselect.FormattingEnabled = true;
			this.gameselect.Location = new System.Drawing.Point(10, 247);
			this.gameselect.Name = "gameselect";
			this.gameselect.Size = new System.Drawing.Size(121, 23);
			this.gameselect.TabIndex = 8;
			this.gameselect.SelectedIndexChanged += new System.EventHandler(this.GamemodeChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(12, 229);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "Gamemode:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.ImageLocation = "";
			this.pictureBox1.Location = new System.Drawing.Point(264, 161);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(183, 179);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(7, 433);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(119, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "Current server file path: ";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(10, 451);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Change Path";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.ChangePathClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(12, 365);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 15);
			this.label5.TabIndex = 12;
			this.label5.Text = "Password:";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(10, 383);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(100, 20);
			this.passwordBox.TabIndex = 13;
			this.passwordBox.TextChanged += new System.EventHandler(this.PasswordChanged);
			// 
			// TokenEnable
			// 
			this.TokenEnable.AutoSize = true;
			this.TokenEnable.BackColor = System.Drawing.Color.Black;
			this.TokenEnable.ForeColor = System.Drawing.Color.White;
			this.TokenEnable.Location = new System.Drawing.Point(12, 111);
			this.TokenEnable.Name = "TokenEnable";
			this.TokenEnable.Size = new System.Drawing.Size(118, 19);
			this.TokenEnable.TabIndex = 14;
			this.TokenEnable.Text = "Enable Steam Token";
			this.TokenEnable.UseVisualStyleBackColor = false;
			this.TokenEnable.CheckedChanged += new System.EventHandler(this.TokenEnableChanged);
			// 
			// TokenFolder
			// 
			this.TokenFolder.Location = new System.Drawing.Point(136, 111);
			this.TokenFolder.Name = "TokenFolder";
			this.TokenFolder.Size = new System.Drawing.Size(96, 22);
			this.TokenFolder.TabIndex = 15;
			this.TokenFolder.Text = "Browse for Token";
			this.TokenFolder.UseVisualStyleBackColor = true;
			this.TokenFolder.Click += new System.EventHandler(this.TokenFolderClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(484, 544);
			this.Controls.Add(this.TokenFolder);
			this.Controls.Add(this.TokenEnable);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.gameselect);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.maxplayers);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mapselect);
			this.Controls.Add(this.lancheck);
			this.Controls.Add(this.consolecheck);
			this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Garry\'s Mod Server Launcher (GUI)";
			((System.ComponentModel.ISupportInitialize)(this.maxplayers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox lancheck;
		private System.Windows.Forms.ComboBox mapselect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.NumericUpDown maxplayers;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox consolecheck;
		private System.Windows.Forms.ComboBox gameselect;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.CheckBox TokenEnable;
		private System.Windows.Forms.Button TokenFolder;
	}
}

