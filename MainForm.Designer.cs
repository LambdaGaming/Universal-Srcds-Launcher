namespace Universal_Srcds_Launcher
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
			this.lancheck = new System.Windows.Forms.CheckBox();
			this.mapselect = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.maxplayers = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.legacyCheck = new System.Windows.Forms.CheckBox();
			this.gameselect = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.exePathLabel = new System.Windows.Forms.Label();
			this.exePathButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.TokenEnable = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.CollectionIDBox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.launchParameters = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.gamePathButton = new System.Windows.Forms.Button();
			this.gamePathLabel = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.maxplayers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lancheck
			// 
			this.lancheck.AutoSize = true;
			this.lancheck.Cursor = System.Windows.Forms.Cursors.Default;
			this.lancheck.Dock = System.Windows.Forms.DockStyle.Top;
			this.lancheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lancheck.ForeColor = System.Drawing.Color.White;
			this.lancheck.Location = new System.Drawing.Point(10, 37);
			this.lancheck.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.lancheck.Name = "lancheck";
			this.lancheck.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lancheck.Size = new System.Drawing.Size(165, 27);
			this.lancheck.TabIndex = 0;
			this.lancheck.Text = "LAN Server";
			this.lancheck.UseVisualStyleBackColor = true;
			this.lancheck.CheckedChanged += new System.EventHandler(this.LanCheck);
			// 
			// mapselect
			// 
			this.mapselect.AllowDrop = true;
			this.mapselect.Dock = System.Windows.Forms.DockStyle.Top;
			this.mapselect.Enabled = false;
			this.mapselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mapselect.Location = new System.Drawing.Point(10, 67);
			this.mapselect.Name = "mapselect";
			this.mapselect.Size = new System.Drawing.Size(148, 21);
			this.mapselect.TabIndex = 2;
			this.mapselect.SelectedIndexChanged += new System.EventHandler(this.MapChanged);
			this.mapselect.TextChanged += new System.EventHandler(this.MapChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(10, 44);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.label1.Size = new System.Drawing.Size(35, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Map:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DimGray;
			this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(0, 280);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(357, 64);
			this.button1.TabIndex = 4;
			this.button1.Text = "START";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// maxplayers
			// 
			this.maxplayers.Dock = System.Windows.Forms.DockStyle.Top;
			this.maxplayers.Location = new System.Drawing.Point(10, 115);
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
			this.maxplayers.Size = new System.Drawing.Size(165, 20);
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
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(10, 92);
			this.label2.Margin = new System.Windows.Forms.Padding(3);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.label2.Size = new System.Drawing.Size(79, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Max Players:";
			// 
			// legacyCheck
			// 
			this.legacyCheck.AutoSize = true;
			this.legacyCheck.Dock = System.Windows.Forms.DockStyle.Top;
			this.legacyCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.legacyCheck.ForeColor = System.Drawing.Color.White;
			this.legacyCheck.Location = new System.Drawing.Point(10, 10);
			this.legacyCheck.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.legacyCheck.Name = "legacyCheck";
			this.legacyCheck.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.legacyCheck.Size = new System.Drawing.Size(165, 27);
			this.legacyCheck.TabIndex = 1;
			this.legacyCheck.Text = "Use Legacy Launcher";
			this.legacyCheck.UseVisualStyleBackColor = true;
			this.legacyCheck.CheckedChanged += new System.EventHandler(this.LegacyCheck);
			// 
			// gameselect
			// 
			this.gameselect.AllowDrop = true;
			this.gameselect.Dock = System.Windows.Forms.DockStyle.Top;
			this.gameselect.Location = new System.Drawing.Point(10, 23);
			this.gameselect.Name = "gameselect";
			this.gameselect.Size = new System.Drawing.Size(148, 21);
			this.gameselect.TabIndex = 8;
			this.gameselect.SelectedIndexChanged += new System.EventHandler(this.GamemodeChanged);
			this.gameselect.TextChanged += new System.EventHandler(this.GamemodeChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(10, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Game/Gamemode:";
			// 
			// exePathLabel
			// 
			this.exePathLabel.AutoSize = true;
			this.exePathLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.exePathLabel.ForeColor = System.Drawing.Color.White;
			this.exePathLabel.Location = new System.Drawing.Point(0, 254);
			this.exePathLabel.Name = "exePathLabel";
			this.exePathLabel.Size = new System.Drawing.Size(65, 13);
			this.exePathLabel.TabIndex = 10;
			this.exePathLabel.Text = "Exe path: ";
			// 
			// exePathButton
			// 
			this.exePathButton.BackColor = System.Drawing.Color.White;
			this.exePathButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.exePathButton.ForeColor = System.Drawing.Color.Black;
			this.exePathButton.Location = new System.Drawing.Point(10, 206);
			this.exePathButton.Name = "exePathButton";
			this.exePathButton.Size = new System.Drawing.Size(148, 23);
			this.exePathButton.TabIndex = 11;
			this.exePathButton.Text = "Change Exe Path";
			this.exePathButton.UseVisualStyleBackColor = false;
			this.exePathButton.Click += new System.EventHandler(this.ChangeExePathClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(10, 88);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.label5.Size = new System.Drawing.Size(65, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Password:";
			// 
			// passwordBox
			// 
			this.passwordBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.passwordBox.Location = new System.Drawing.Point(10, 111);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(148, 20);
			this.passwordBox.TabIndex = 13;
			this.passwordBox.TextChanged += new System.EventHandler(this.PasswordChanged);
			// 
			// TokenEnable
			// 
			this.TokenEnable.AutoSize = true;
			this.TokenEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.TokenEnable.Dock = System.Windows.Forms.DockStyle.Top;
			this.TokenEnable.ForeColor = System.Drawing.Color.White;
			this.TokenEnable.Location = new System.Drawing.Point(10, 64);
			this.TokenEnable.Name = "TokenEnable";
			this.TokenEnable.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.TokenEnable.Size = new System.Drawing.Size(165, 27);
			this.TokenEnable.TabIndex = 14;
			this.TokenEnable.Text = "Enable Steam Token";
			this.TokenEnable.UseVisualStyleBackColor = false;
			this.TokenEnable.CheckedChanged += new System.EventHandler(this.TokenEnableChanged);
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Location = new System.Drawing.Point(10, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(165, 1);
			this.label6.TabIndex = 17;
			// 
			// CollectionIDBox
			// 
			this.CollectionIDBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.CollectionIDBox.Location = new System.Drawing.Point(10, 154);
			this.CollectionIDBox.Name = "CollectionIDBox";
			this.CollectionIDBox.Size = new System.Drawing.Size(148, 20);
			this.CollectionIDBox.TabIndex = 24;
			this.CollectionIDBox.TextChanged += new System.EventHandler(this.CollectionIDBoxChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Dock = System.Windows.Forms.DockStyle.Top;
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(10, 131);
			this.label12.Name = "label12";
			this.label12.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.label12.Size = new System.Drawing.Size(145, 23);
			this.label12.TabIndex = 23;
			this.label12.Text = "Workshop Collection ID:";
			// 
			// launchParameters
			// 
			this.launchParameters.Dock = System.Windows.Forms.DockStyle.Top;
			this.launchParameters.Location = new System.Drawing.Point(10, 158);
			this.launchParameters.Name = "launchParameters";
			this.launchParameters.Size = new System.Drawing.Size(165, 20);
			this.launchParameters.TabIndex = 27;
			this.launchParameters.TextChanged += new System.EventHandler(this.LaunchParamsChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Dock = System.Windows.Forms.DockStyle.Top;
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(10, 135);
			this.label14.Name = "label14";
			this.label14.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.label14.Size = new System.Drawing.Size(120, 23);
			this.label14.TabIndex = 26;
			this.label14.Text = "Launch Parameters:";
			// 
			// gamePathButton
			// 
			this.gamePathButton.BackColor = System.Drawing.Color.White;
			this.gamePathButton.ForeColor = System.Drawing.Color.Black;
			this.gamePathButton.Location = new System.Drawing.Point(12, 206);
			this.gamePathButton.Name = "gamePathButton";
			this.gamePathButton.Size = new System.Drawing.Size(165, 23);
			this.gamePathButton.TabIndex = 29;
			this.gamePathButton.Text = "Change Game Path";
			this.gamePathButton.UseVisualStyleBackColor = false;
			this.gamePathButton.Click += new System.EventHandler(this.ChangeGamePathClick);
			// 
			// gamePathLabel
			// 
			this.gamePathLabel.AutoSize = true;
			this.gamePathLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gamePathLabel.ForeColor = System.Drawing.Color.White;
			this.gamePathLabel.Location = new System.Drawing.Point(0, 267);
			this.gamePathLabel.Name = "gamePathLabel";
			this.gamePathLabel.Size = new System.Drawing.Size(76, 13);
			this.gamePathLabel.TabIndex = 30;
			this.gamePathLabel.Text = "Game path: ";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.launchParameters);
			this.splitContainer1.Panel1.Controls.Add(this.label14);
			this.splitContainer1.Panel1.Controls.Add(this.gamePathButton);
			this.splitContainer1.Panel1.Controls.Add(this.maxplayers);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label6);
			this.splitContainer1.Panel1.Controls.Add(this.TokenEnable);
			this.splitContainer1.Panel1.Controls.Add(this.lancheck);
			this.splitContainer1.Panel1.Controls.Add(this.legacyCheck);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.exePathButton);
			this.splitContainer1.Panel2.Controls.Add(this.label17);
			this.splitContainer1.Panel2.Controls.Add(this.label16);
			this.splitContainer1.Panel2.Controls.Add(this.label15);
			this.splitContainer1.Panel2.Controls.Add(this.label8);
			this.splitContainer1.Panel2.Controls.Add(this.CollectionIDBox);
			this.splitContainer1.Panel2.Controls.Add(this.label12);
			this.splitContainer1.Panel2.Controls.Add(this.passwordBox);
			this.splitContainer1.Panel2.Controls.Add(this.label5);
			this.splitContainer1.Panel2.Controls.Add(this.mapselect);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.gameselect);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.splitContainer1.Size = new System.Drawing.Size(357, 344);
			this.splitContainer1.SplitterDistance = 185;
			this.splitContainer1.TabIndex = 34;
			// 
			// label17
			// 
			this.label17.Dock = System.Windows.Forms.DockStyle.Top;
			this.label17.ForeColor = System.Drawing.Color.White;
			this.label17.Location = new System.Drawing.Point(10, 201);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(148, 5);
			this.label17.TabIndex = 36;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Dock = System.Windows.Forms.DockStyle.Top;
			this.label16.ForeColor = System.Drawing.Color.White;
			this.label16.Location = new System.Drawing.Point(10, 188);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(0, 13);
			this.label16.TabIndex = 35;
			// 
			// label15
			// 
			this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label15.Dock = System.Windows.Forms.DockStyle.Top;
			this.label15.Location = new System.Drawing.Point(10, 187);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(148, 1);
			this.label15.TabIndex = 34;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Top;
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(10, 174);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(0, 13);
			this.label8.TabIndex = 34;
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(0, 249);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(357, 5);
			this.label7.TabIndex = 33;
			// 
			// label18
			// 
			this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label18.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label18.Location = new System.Drawing.Point(0, 248);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(357, 1);
			this.label18.TabIndex = 34;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(11, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(165, 1);
			this.label4.TabIndex = 35;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(357, 344);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.exePathLabel);
			this.Controls.Add(this.gamePathLabel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Universal SRCDS Launcher";
			((System.ComponentModel.ISupportInitialize)(this.maxplayers)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox lancheck;
		private System.Windows.Forms.ComboBox mapselect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown maxplayers;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox legacyCheck;
		private System.Windows.Forms.ComboBox gameselect;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label exePathLabel;
		private System.Windows.Forms.Button exePathButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.CheckBox TokenEnable;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox CollectionIDBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox launchParameters;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button gamePathButton;
		private System.Windows.Forms.Label gamePathLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label4;
	}
}
