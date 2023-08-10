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
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.TokenEnable = new System.Windows.Forms.CheckBox();
			this.line1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.CollectionIDBox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.launchParameters = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.maxplayers)).BeginInit();
			this.SuspendLayout();
			// 
			// lancheck
			// 
			this.lancheck.AutoSize = true;
			this.lancheck.Cursor = System.Windows.Forms.Cursors.Default;
			this.lancheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lancheck.ForeColor = System.Drawing.Color.White;
			this.lancheck.Location = new System.Drawing.Point(12, 52);
			this.lancheck.Name = "lancheck";
			this.lancheck.Size = new System.Drawing.Size(91, 17);
			this.lancheck.TabIndex = 0;
			this.lancheck.Text = "LAN Server";
			this.lancheck.UseVisualStyleBackColor = true;
			this.lancheck.CheckedChanged += new System.EventHandler(this.LanCheck);
			// 
			// mapselect
			// 
			this.mapselect.AllowDrop = true;
			this.mapselect.Enabled = false;
			this.mapselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mapselect.Location = new System.Drawing.Point(223, 98);
			this.mapselect.Name = "mapselect";
			this.mapselect.Size = new System.Drawing.Size(121, 21);
			this.mapselect.TabIndex = 2;
			this.mapselect.SelectedIndexChanged += new System.EventHandler(this.MapChanged);
			this.mapselect.TextChanged += new System.EventHandler(this.MapChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(309, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
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
			this.button1.Location = new System.Drawing.Point(0, 313);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(357, 64);
			this.button1.TabIndex = 4;
			this.button1.Text = "START";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// maxplayers
			// 
			this.maxplayers.Location = new System.Drawing.Point(11, 157);
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
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(10, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Max Players:";
			// 
			// consolecheck
			// 
			this.consolecheck.AutoSize = true;
			this.consolecheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consolecheck.ForeColor = System.Drawing.Color.White;
			this.consolecheck.Location = new System.Drawing.Point(12, 12);
			this.consolecheck.Name = "consolecheck";
			this.consolecheck.Size = new System.Drawing.Size(150, 17);
			this.consolecheck.TabIndex = 1;
			this.consolecheck.Text = "Use Legacy Launcher";
			this.consolecheck.UseVisualStyleBackColor = true;
			this.consolecheck.CheckedChanged += new System.EventHandler(this.ConsoleCheck);
			// 
			// gameselect
			// 
			this.gameselect.AllowDrop = true;
			this.gameselect.Location = new System.Drawing.Point(223, 30);
			this.gameselect.Name = "gameselect";
			this.gameselect.Size = new System.Drawing.Size(121, 21);
			this.gameselect.TabIndex = 8;
			this.gameselect.SelectedIndexChanged += new System.EventHandler(this.GamemodeChanged);
			this.gameselect.TextChanged += new System.EventHandler(this.GamemodeChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(271, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Gamemode:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(10, 297);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Current path: ";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(11, 271);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Change Exe Path";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.ChangePathClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(279, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Password:";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(223, 166);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(121, 20);
			this.passwordBox.TabIndex = 13;
			this.passwordBox.TextChanged += new System.EventHandler(this.PasswordChanged);
			// 
			// TokenEnable
			// 
			this.TokenEnable.AutoSize = true;
			this.TokenEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.TokenEnable.ForeColor = System.Drawing.Color.White;
			this.TokenEnable.Location = new System.Drawing.Point(12, 92);
			this.TokenEnable.Name = "TokenEnable";
			this.TokenEnable.Size = new System.Drawing.Size(144, 17);
			this.TokenEnable.TabIndex = 14;
			this.TokenEnable.Text = "Enable Steam Token";
			this.TokenEnable.UseVisualStyleBackColor = false;
			this.TokenEnable.CheckedChanged += new System.EventHandler(this.TokenEnableChanged);
			// 
			// line1
			// 
			this.line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.line1.Location = new System.Drawing.Point(12, 40);
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(120, 1);
			this.line1.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(11, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 1);
			this.label6.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Location = new System.Drawing.Point(12, 118);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 1);
			this.label7.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(12, 192);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 1);
			this.label8.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Location = new System.Drawing.Point(194, 67);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(150, 1);
			this.label9.TabIndex = 20;
			// 
			// label10
			// 
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Location = new System.Drawing.Point(194, 136);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(150, 1);
			this.label10.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Location = new System.Drawing.Point(194, 204);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(150, 1);
			this.label11.TabIndex = 22;
			// 
			// CollectionIDBox
			// 
			this.CollectionIDBox.Location = new System.Drawing.Point(223, 233);
			this.CollectionIDBox.Name = "CollectionIDBox";
			this.CollectionIDBox.Size = new System.Drawing.Size(121, 20);
			this.CollectionIDBox.TabIndex = 24;
			this.CollectionIDBox.TextChanged += new System.EventHandler(this.CollectionIDBoxChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(199, 215);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(145, 13);
			this.label12.TabIndex = 23;
			this.label12.Text = "Workshop Collection ID:";
			// 
			// label13
			// 
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label13.Location = new System.Drawing.Point(194, 263);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(150, 1);
			this.label13.TabIndex = 25;
			// 
			// launchParameters
			// 
			this.launchParameters.Location = new System.Drawing.Point(11, 221);
			this.launchParameters.Name = "launchParameters";
			this.launchParameters.Size = new System.Drawing.Size(119, 20);
			this.launchParameters.TabIndex = 27;
			this.launchParameters.TextChanged += new System.EventHandler(this.LaunchParamsChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(8, 204);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(120, 13);
			this.label14.TabIndex = 26;
			this.label14.Text = "Launch Parameters:";
			// 
			// label15
			// 
			this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label15.Location = new System.Drawing.Point(13, 256);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(120, 1);
			this.label15.TabIndex = 28;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(357, 377);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.launchParameters);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.CollectionIDBox);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.line1);
			this.Controls.Add(this.TokenEnable);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.gameselect);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.maxplayers);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mapselect);
			this.Controls.Add(this.lancheck);
			this.Controls.Add(this.consolecheck);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Garry\'s Mod Server Launcher GUI";
			((System.ComponentModel.ISupportInitialize)(this.maxplayers)).EndInit();
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
		private System.Windows.Forms.CheckBox consolecheck;
		private System.Windows.Forms.ComboBox gameselect;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.CheckBox TokenEnable;
		private System.Windows.Forms.Label line1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox CollectionIDBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox launchParameters;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
	}
}
