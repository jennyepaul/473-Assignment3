
namespace JennyCasey_Assign3
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serverPercentDropDown = new System.Windows.Forms.ComboBox();
            this.showPercentResultButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.roleDropDown = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.serverRangeDropDown = new System.Windows.Forms.ComboBox();
            this.roleServerLevelResultButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.minimumLevel = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.maximumLevel = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.guildTypeDropDown = new System.Windows.Forms.ComboBox();
            this.guildTypeResultButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classDropDown = new System.Windows.Forms.ComboBox();
            this.serverDropDown = new System.Windows.Forms.ComboBox();
            this.showClassResultButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tankRadioButton = new System.Windows.Forms.RadioButton();
            this.healerRadioButton = new System.Windows.Forms.RadioButton();
            this.damageRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roleResultButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.maxLvlPercentButton = new System.Windows.Forms.Button();
            this.queryResultBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimumLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumLevel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Percentage of Each Race From a Single Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(192, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Server";
            // 
            // serverPercentDropDown
            // 
            this.serverPercentDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverPercentDropDown.FormattingEnabled = true;
            this.serverPercentDropDown.Location = new System.Drawing.Point(195, 189);
            this.serverPercentDropDown.Name = "serverPercentDropDown";
            this.serverPercentDropDown.Size = new System.Drawing.Size(161, 26);
            this.serverPercentDropDown.TabIndex = 7;
            // 
            // showPercentResultButton
            // 
            this.showPercentResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPercentResultButton.Location = new System.Drawing.Point(405, 189);
            this.showPercentResultButton.Name = "showPercentResultButton";
            this.showPercentResultButton.Size = new System.Drawing.Size(118, 26);
            this.showPercentResultButton.TabIndex = 8;
            this.showPercentResultButton.Tag = "";
            this.showPercentResultButton.Text = "Show Results";
            this.showPercentResultButton.UseVisualStyleBackColor = true;
            this.showPercentResultButton.Click += new System.EventHandler(this.showPercentResultButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(438, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "All Role Types from a Single Server Within a Level Range";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Role";
            // 
            // roleDropDown
            // 
            this.roleDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleDropDown.FormattingEnabled = true;
            this.roleDropDown.Location = new System.Drawing.Point(15, 308);
            this.roleDropDown.Name = "roleDropDown";
            this.roleDropDown.Size = new System.Drawing.Size(161, 26);
            this.roleDropDown.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(192, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Server";
            // 
            // serverRangeDropDown
            // 
            this.serverRangeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverRangeDropDown.FormattingEnabled = true;
            this.serverRangeDropDown.Location = new System.Drawing.Point(195, 308);
            this.serverRangeDropDown.Name = "serverRangeDropDown";
            this.serverRangeDropDown.Size = new System.Drawing.Size(161, 26);
            this.serverRangeDropDown.TabIndex = 10;
            // 
            // roleServerLevelResultButton
            // 
            this.roleServerLevelResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleServerLevelResultButton.Location = new System.Drawing.Point(405, 307);
            this.roleServerLevelResultButton.Name = "roleServerLevelResultButton";
            this.roleServerLevelResultButton.Size = new System.Drawing.Size(118, 26);
            this.roleServerLevelResultButton.TabIndex = 11;
            this.roleServerLevelResultButton.Tag = "";
            this.roleServerLevelResultButton.Text = "Show Results";
            this.roleServerLevelResultButton.UseVisualStyleBackColor = true;
            this.roleServerLevelResultButton.Click += new System.EventHandler(this.roleServerLevelResultButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(12, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Min";
            // 
            // minimumLevel
            // 
            this.minimumLevel.Location = new System.Drawing.Point(15, 369);
            this.minimumLevel.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minimumLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimumLevel.Name = "minimumLevel";
            this.minimumLevel.Size = new System.Drawing.Size(50, 22);
            this.minimumLevel.TabIndex = 13;
            this.minimumLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(123, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Max";
            // 
            // maximumLevel
            // 
            this.maximumLevel.Location = new System.Drawing.Point(126, 369);
            this.maximumLevel.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.maximumLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maximumLevel.Name = "maximumLevel";
            this.maximumLevel.Size = new System.Drawing.Size(50, 22);
            this.maximumLevel.TabIndex = 15;
            this.maximumLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(12, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "All Guilds of a Single Type ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(12, 450);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "Type";
            // 
            // guildTypeDropDown
            // 
            this.guildTypeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guildTypeDropDown.FormattingEnabled = true;
            this.guildTypeDropDown.Location = new System.Drawing.Point(15, 471);
            this.guildTypeDropDown.Name = "guildTypeDropDown";
            this.guildTypeDropDown.Size = new System.Drawing.Size(161, 26);
            this.guildTypeDropDown.TabIndex = 9;
            // 
            // guildTypeResultButton
            // 
            this.guildTypeResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guildTypeResultButton.Location = new System.Drawing.Point(405, 470);
            this.guildTypeResultButton.Name = "guildTypeResultButton";
            this.guildTypeResultButton.Size = new System.Drawing.Size(118, 26);
            this.guildTypeResultButton.TabIndex = 12;
            this.guildTypeResultButton.Tag = "";
            this.guildTypeResultButton.Text = "Show Results";
            this.guildTypeResultButton.UseVisualStyleBackColor = true;
            this.guildTypeResultButton.Click += new System.EventHandler(this.guildTypeResultButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(12, 523);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(410, 18);
            this.label13.TabIndex = 13;
            this.label13.Text = "All Players Who Could Fill a Role But Presently Aren\'t";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Class Type from a Single Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(192, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server";
            // 
            // classDropDown
            // 
            this.classDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classDropDown.FormattingEnabled = true;
            this.classDropDown.Location = new System.Drawing.Point(15, 88);
            this.classDropDown.Name = "classDropDown";
            this.classDropDown.Size = new System.Drawing.Size(161, 26);
            this.classDropDown.TabIndex = 3;
            // 
            // serverDropDown
            // 
            this.serverDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverDropDown.FormattingEnabled = true;
            this.serverDropDown.Location = new System.Drawing.Point(195, 88);
            this.serverDropDown.Name = "serverDropDown";
            this.serverDropDown.Size = new System.Drawing.Size(161, 26);
            this.serverDropDown.TabIndex = 4;
            // 
            // showClassResultButton
            // 
            this.showClassResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showClassResultButton.Location = new System.Drawing.Point(405, 88);
            this.showClassResultButton.Name = "showClassResultButton";
            this.showClassResultButton.Size = new System.Drawing.Size(118, 26);
            this.showClassResultButton.TabIndex = 5;
            this.showClassResultButton.Tag = "";
            this.showClassResultButton.Text = "Show Results";
            this.showClassResultButton.UseVisualStyleBackColor = true;
            this.showClassResultButton.Click += new System.EventHandler(this.showClassResultButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(560, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 24);
            this.label14.TabIndex = 16;
            this.label14.Text = "Query";
            // 
            // tankRadioButton
            // 
            this.tankRadioButton.AutoSize = true;
            this.tankRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.tankRadioButton.Location = new System.Drawing.Point(6, 21);
            this.tankRadioButton.Name = "tankRadioButton";
            this.tankRadioButton.Size = new System.Drawing.Size(61, 21);
            this.tankRadioButton.TabIndex = 17;
            this.tankRadioButton.TabStop = true;
            this.tankRadioButton.Text = "Tank";
            this.tankRadioButton.UseVisualStyleBackColor = true;
            // 
            // healerRadioButton
            // 
            this.healerRadioButton.AutoSize = true;
            this.healerRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.healerRadioButton.Location = new System.Drawing.Point(74, 21);
            this.healerRadioButton.Name = "healerRadioButton";
            this.healerRadioButton.Size = new System.Drawing.Size(71, 21);
            this.healerRadioButton.TabIndex = 18;
            this.healerRadioButton.TabStop = true;
            this.healerRadioButton.Text = "Healer";
            this.healerRadioButton.UseVisualStyleBackColor = true;
            // 
            // damageRadioButton
            // 
            this.damageRadioButton.AutoSize = true;
            this.damageRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.damageRadioButton.Location = new System.Drawing.Point(151, 21);
            this.damageRadioButton.Name = "damageRadioButton";
            this.damageRadioButton.Size = new System.Drawing.Size(82, 21);
            this.damageRadioButton.TabIndex = 19;
            this.damageRadioButton.TabStop = true;
            this.damageRadioButton.Text = "Damage";
            this.damageRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tankRadioButton);
            this.groupBox1.Controls.Add(this.damageRadioButton);
            this.groupBox1.Controls.Add(this.healerRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 561);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 63);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // roleResultButton
            // 
            this.roleResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleResultButton.Location = new System.Drawing.Point(405, 577);
            this.roleResultButton.Name = "roleResultButton";
            this.roleResultButton.Size = new System.Drawing.Size(118, 26);
            this.roleResultButton.TabIndex = 21;
            this.roleResultButton.Tag = "";
            this.roleResultButton.Text = "Show Results";
            this.roleResultButton.UseVisualStyleBackColor = true;
            this.roleResultButton.Click += new System.EventHandler(this.roleResultButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(12, 646);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(348, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "Percentage of Max Level Players in All Guilds";
            // 
            // maxLvlPercentButton
            // 
            this.maxLvlPercentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLvlPercentButton.Location = new System.Drawing.Point(405, 672);
            this.maxLvlPercentButton.Name = "maxLvlPercentButton";
            this.maxLvlPercentButton.Size = new System.Drawing.Size(118, 26);
            this.maxLvlPercentButton.TabIndex = 23;
            this.maxLvlPercentButton.Tag = "";
            this.maxLvlPercentButton.Text = "Show Results";
            this.maxLvlPercentButton.UseVisualStyleBackColor = true;
            this.maxLvlPercentButton.Click += new System.EventHandler(this.maxLvlPercentButton_Click);
            // 
            // queryResultBox
            // 
            this.queryResultBox.Location = new System.Drawing.Point(564, 36);
            this.queryResultBox.Name = "queryResultBox";
            this.queryResultBox.Size = new System.Drawing.Size(720, 707);
            this.queryResultBox.TabIndex = 24;
            this.queryResultBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1296, 755);
            this.Controls.Add(this.queryResultBox);
            this.Controls.Add(this.maxLvlPercentButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.roleResultButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guildTypeResultButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guildTypeDropDown);
            this.Controls.Add(this.minimumLevel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.showClassResultButton);
            this.Controls.Add(this.maximumLevel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.showPercentResultButton);
            this.Controls.Add(this.serverDropDown);
            this.Controls.Add(this.roleServerLevelResultButton);
            this.Controls.Add(this.serverPercentDropDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.serverRangeDropDown);
            this.Controls.Add(this.classDropDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roleDropDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.minimumLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumLevel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showPercentResultButton;
        private System.Windows.Forms.ComboBox serverPercentDropDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox roleDropDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button guildTypeResultButton;
        private System.Windows.Forms.ComboBox guildTypeDropDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown maximumLevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown minimumLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button roleServerLevelResultButton;
        private System.Windows.Forms.ComboBox serverRangeDropDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox classDropDown;
        private System.Windows.Forms.ComboBox serverDropDown;
        private System.Windows.Forms.Button showClassResultButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton tankRadioButton;
        private System.Windows.Forms.RadioButton healerRadioButton;
        private System.Windows.Forms.RadioButton damageRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button roleResultButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button maxLvlPercentButton;
        private System.Windows.Forms.RichTextBox queryResultBox;
    }
}

