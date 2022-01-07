namespace ShowMyLocation
{
    partial class ShowMyLocation
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblNewIPAddress = new System.Windows.Forms.Label();
            this.txtNewIPAddress = new System.Windows.Forms.TextBox();
            this.btnGetIPLocation = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCityTitle = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblRegionTitle = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCountryTitle = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblIPAddressTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.panelLeft, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 34);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1028, 690);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = global::ShowMyLocation.Properties.Resources._2205195;
            this.panelLeft.Controls.Add(this.lblNewIPAddress);
            this.panelLeft.Controls.Add(this.txtNewIPAddress);
            this.panelLeft.Controls.Add(this.btnGetIPLocation);
            this.panelLeft.Controls.Add(this.lblCity);
            this.panelLeft.Controls.Add(this.lblCityTitle);
            this.panelLeft.Controls.Add(this.lblRegion);
            this.panelLeft.Controls.Add(this.lblRegionTitle);
            this.panelLeft.Controls.Add(this.lblCountry);
            this.panelLeft.Controls.Add(this.lblCountryTitle);
            this.panelLeft.Controls.Add(this.lblIPAddress);
            this.panelLeft.Controls.Add(this.lblIPAddressTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 690);
            this.panelLeft.TabIndex = 1;
            // 
            // lblNewIPAddress
            // 
            this.lblNewIPAddress.AutoSize = true;
            this.lblNewIPAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblNewIPAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewIPAddress.ForeColor = System.Drawing.Color.White;
            this.lblNewIPAddress.Location = new System.Drawing.Point(3, 576);
            this.lblNewIPAddress.Name = "lblNewIPAddress";
            this.lblNewIPAddress.Size = new System.Drawing.Size(80, 19);
            this.lblNewIPAddress.TabIndex = 10;
            this.lblNewIPAddress.Text = "IP Address";
            // 
            // txtNewIPAddress
            // 
            this.txtNewIPAddress.BackColor = System.Drawing.Color.White;
            this.txtNewIPAddress.Location = new System.Drawing.Point(4, 598);
            this.txtNewIPAddress.Name = "txtNewIPAddress";
            this.txtNewIPAddress.Size = new System.Drawing.Size(193, 27);
            this.txtNewIPAddress.TabIndex = 9;
            // 
            // btnGetIPLocation
            // 
            this.btnGetIPLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGetIPLocation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGetIPLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnGetIPLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGetIPLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetIPLocation.ForeColor = System.Drawing.Color.White;
            this.btnGetIPLocation.Location = new System.Drawing.Point(27, 641);
            this.btnGetIPLocation.Name = "btnGetIPLocation";
            this.btnGetIPLocation.Size = new System.Drawing.Size(144, 37);
            this.btnGetIPLocation.TabIndex = 8;
            this.btnGetIPLocation.Text = "GET IP LOCATION";
            this.btnGetIPLocation.UseVisualStyleBackColor = false;
            this.btnGetIPLocation.Click += new System.EventHandler(this.btnGetIPLocation_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(15, 218);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(0, 19);
            this.lblCity.TabIndex = 7;
            // 
            // lblCityTitle
            // 
            this.lblCityTitle.AutoSize = true;
            this.lblCityTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCityTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityTitle.ForeColor = System.Drawing.Color.White;
            this.lblCityTitle.Location = new System.Drawing.Point(15, 190);
            this.lblCityTitle.Name = "lblCityTitle";
            this.lblCityTitle.Size = new System.Drawing.Size(35, 19);
            this.lblCityTitle.TabIndex = 6;
            this.lblCityTitle.Text = "City";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.BackColor = System.Drawing.Color.Transparent;
            this.lblRegion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.ForeColor = System.Drawing.Color.White;
            this.lblRegion.Location = new System.Drawing.Point(15, 162);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(0, 19);
            this.lblRegion.TabIndex = 5;
            // 
            // lblRegionTitle
            // 
            this.lblRegionTitle.AutoSize = true;
            this.lblRegionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRegionTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegionTitle.ForeColor = System.Drawing.Color.White;
            this.lblRegionTitle.Location = new System.Drawing.Point(15, 134);
            this.lblRegionTitle.Name = "lblRegionTitle";
            this.lblRegionTitle.Size = new System.Drawing.Size(56, 19);
            this.lblRegionTitle.TabIndex = 4;
            this.lblRegionTitle.Text = "Region";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point(15, 106);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(0, 19);
            this.lblCountry.TabIndex = 3;
            // 
            // lblCountryTitle
            // 
            this.lblCountryTitle.AutoSize = true;
            this.lblCountryTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCountryTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryTitle.ForeColor = System.Drawing.Color.White;
            this.lblCountryTitle.Location = new System.Drawing.Point(15, 78);
            this.lblCountryTitle.Name = "lblCountryTitle";
            this.lblCountryTitle.Size = new System.Drawing.Size(64, 19);
            this.lblCountryTitle.TabIndex = 2;
            this.lblCountryTitle.Text = "Country";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblIPAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.ForeColor = System.Drawing.Color.White;
            this.lblIPAddress.Location = new System.Drawing.Point(15, 50);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(0, 19);
            this.lblIPAddress.TabIndex = 1;
            // 
            // lblIPAddressTitle
            // 
            this.lblIPAddressTitle.AutoSize = true;
            this.lblIPAddressTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblIPAddressTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddressTitle.ForeColor = System.Drawing.Color.White;
            this.lblIPAddressTitle.Location = new System.Drawing.Point(15, 22);
            this.lblIPAddressTitle.Name = "lblIPAddressTitle";
            this.lblIPAddressTitle.Size = new System.Drawing.Size(80, 19);
            this.lblIPAddressTitle.TabIndex = 0;
            this.lblIPAddressTitle.Text = "IP Address";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
            this.panelTop.Controls.Add(this.pbClose);
            this.panelTop.Controls.Add(this.pbLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1028, 34);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::ShowMyLocation.Properties.Resources.Close;
            this.pbClose.Location = new System.Drawing.Point(1002, 10);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(15, 15);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 2;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ShowMyLocation.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(4, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(30, 30);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // ShowMyLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 724);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowMyLocation";
            this.Text = "ShowMyLocation";
            this.Load += new System.EventHandler(this.ShowMyLocation_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCityTitle;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblRegionTitle;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCountryTitle;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblIPAddressTitle;
        private System.Windows.Forms.Button btnGetIPLocation;
        private System.Windows.Forms.TextBox txtNewIPAddress;
        private System.Windows.Forms.Label lblNewIPAddress;
        private System.Windows.Forms.PictureBox pbClose;
    }
}