namespace dndCompanionTracker {
	partial class MainScreen {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
			this.btn_add = new System.Windows.Forms.Button();
			this.lsb_creatures = new System.Windows.Forms.ListBox();
			this.btn_delete = new System.Windows.Forms.Button();
			this.tb_proficiencyBonus = new System.Windows.Forms.TextBox();
			this.lb_pb = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_playerLevel = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_spellMod = new System.Windows.Forms.TextBox();
			this.btn_save = new System.Windows.Forms.Button();
			this.btn_addHealth = new System.Windows.Forms.Button();
			this.btn_takeHealth = new System.Windows.Forms.Button();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.tb_info = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tb_tempHP = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_currHP = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_AC = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tb_maxHP = new System.Windows.Forms.TextBox();
			this.tb_traits = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tb_str = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_dex = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tb_con = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tb_int = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tb_wis = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tb_cha = new System.Windows.Forms.TextBox();
			this.lb_str = new System.Windows.Forms.Label();
			this.lb_dex = new System.Windows.Forms.Label();
			this.lb_con = new System.Windows.Forms.Label();
			this.lb_int = new System.Windows.Forms.Label();
			this.lb_wis = new System.Windows.Forms.Label();
			this.lb_cha = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.gb_statblock = new System.Windows.Forms.GroupBox();
			this.tb_hpVal = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pl_actions = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.gb_statblock.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_add
			// 
			this.btn_add.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_add.Location = new System.Drawing.Point(12, 12);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(136, 23);
			this.btn_add.TabIndex = 0;
			this.btn_add.Text = "Add Creature";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// lsb_creatures
			// 
			this.lsb_creatures.BackColor = System.Drawing.Color.Beige;
			this.lsb_creatures.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lsb_creatures.FormattingEnabled = true;
			this.lsb_creatures.ItemHeight = 18;
			this.lsb_creatures.Location = new System.Drawing.Point(12, 42);
			this.lsb_creatures.Name = "lsb_creatures";
			this.lsb_creatures.Size = new System.Drawing.Size(136, 508);
			this.lsb_creatures.TabIndex = 1;
			this.lsb_creatures.SelectedIndexChanged += new System.EventHandler(this.lsb_creatures_SelectedIndexChanged);
			// 
			// btn_delete
			// 
			this.btn_delete.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_delete.ForeColor = System.Drawing.Color.IndianRed;
			this.btn_delete.Location = new System.Drawing.Point(12, 571);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(136, 23);
			this.btn_delete.TabIndex = 3;
			this.btn_delete.Text = "Delete Creature";
			this.btn_delete.UseVisualStyleBackColor = true;
			// 
			// tb_proficiencyBonus
			// 
			this.tb_proficiencyBonus.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_proficiencyBonus.Location = new System.Drawing.Point(696, 571);
			this.tb_proficiencyBonus.MaxLength = 1;
			this.tb_proficiencyBonus.Name = "tb_proficiencyBonus";
			this.tb_proficiencyBonus.Size = new System.Drawing.Size(25, 22);
			this.tb_proficiencyBonus.TabIndex = 4;
			this.tb_proficiencyBonus.Text = "0";
			// 
			// lb_pb
			// 
			this.lb_pb.AutoSize = true;
			this.lb_pb.BackColor = System.Drawing.Color.Transparent;
			this.lb_pb.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_pb.Location = new System.Drawing.Point(588, 574);
			this.lb_pb.Name = "lb_pb";
			this.lb_pb.Size = new System.Drawing.Size(102, 16);
			this.lb_pb.TabIndex = 5;
			this.lb_pb.Text = "Proficiency Bonus:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(739, 574);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Level:";
			// 
			// tb_playerLevel
			// 
			this.tb_playerLevel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_playerLevel.Location = new System.Drawing.Point(784, 571);
			this.tb_playerLevel.MaxLength = 1;
			this.tb_playerLevel.Name = "tb_playerLevel";
			this.tb_playerLevel.Size = new System.Drawing.Size(25, 22);
			this.tb_playerLevel.TabIndex = 7;
			this.tb_playerLevel.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(824, 574);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "Spellcasting Modifier:";
			// 
			// tb_spellMod
			// 
			this.tb_spellMod.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_spellMod.Location = new System.Drawing.Point(946, 571);
			this.tb_spellMod.MaxLength = 1;
			this.tb_spellMod.Name = "tb_spellMod";
			this.tb_spellMod.Size = new System.Drawing.Size(25, 22);
			this.tb_spellMod.TabIndex = 9;
			this.tb_spellMod.Text = "0";
			// 
			// btn_save
			// 
			this.btn_save.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_save.Location = new System.Drawing.Point(155, 571);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(136, 23);
			this.btn_save.TabIndex = 10;
			this.btn_save.Text = "Save Creature";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_addHealth
			// 
			this.btn_addHealth.BackColor = System.Drawing.Color.LightGreen;
			this.btn_addHealth.FlatAppearance.BorderSize = 0;
			this.btn_addHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_addHealth.Location = new System.Drawing.Point(210, 85);
			this.btn_addHealth.Name = "btn_addHealth";
			this.btn_addHealth.Size = new System.Drawing.Size(50, 25);
			this.btn_addHealth.TabIndex = 3;
			this.btn_addHealth.Text = "+";
			this.btn_addHealth.UseVisualStyleBackColor = false;
			this.btn_addHealth.Click += new System.EventHandler(this.btn_addHealth_Click);
			// 
			// btn_takeHealth
			// 
			this.btn_takeHealth.BackColor = System.Drawing.Color.IndianRed;
			this.btn_takeHealth.FlatAppearance.BorderSize = 0;
			this.btn_takeHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_takeHealth.Location = new System.Drawing.Point(210, 139);
			this.btn_takeHealth.Name = "btn_takeHealth";
			this.btn_takeHealth.Size = new System.Drawing.Size(50, 25);
			this.btn_takeHealth.TabIndex = 4;
			this.btn_takeHealth.Text = "-";
			this.btn_takeHealth.UseVisualStyleBackColor = false;
			this.btn_takeHealth.Click += new System.EventHandler(this.btn_takeHealth_Click);
			// 
			// tb_name
			// 
			this.tb_name.BackColor = System.Drawing.Color.Beige;
			this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_name.ForeColor = System.Drawing.Color.Brown;
			this.tb_name.Location = new System.Drawing.Point(6, 19);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(263, 22);
			this.tb_name.TabIndex = 5;
			this.tb_name.Text = "Creature Name";
			// 
			// tb_info
			// 
			this.tb_info.BackColor = System.Drawing.Color.Beige;
			this.tb_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_info.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_info.Location = new System.Drawing.Point(6, 47);
			this.tb_info.Name = "tb_info";
			this.tb_info.Size = new System.Drawing.Size(263, 18);
			this.tb_info.TabIndex = 7;
			this.tb_info.Text = "Size, type, alignment";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Brown;
			this.pictureBox1.Location = new System.Drawing.Point(6, 72);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(263, 2);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// tb_tempHP
			// 
			this.tb_tempHP.BackColor = System.Drawing.Color.Beige;
			this.tb_tempHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_tempHP.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_tempHP.Location = new System.Drawing.Point(154, 139);
			this.tb_tempHP.MaxLength = 4;
			this.tb_tempHP.Name = "tb_tempHP";
			this.tb_tempHP.Size = new System.Drawing.Size(50, 25);
			this.tb_tempHP.TabIndex = 9;
			this.tb_tempHP.Text = "0";
			this.tb_tempHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(83, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 18);
			this.label3.TabIndex = 10;
			this.label3.Text = "Temp HP:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(68, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 18);
			this.label4.TabIndex = 11;
			this.label4.Text = "Current HP:";
			// 
			// tb_currHP
			// 
			this.tb_currHP.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_currHP.Location = new System.Drawing.Point(154, 112);
			this.tb_currHP.MaxLength = 4;
			this.tb_currHP.Name = "tb_currHP";
			this.tb_currHP.Size = new System.Drawing.Size(50, 25);
			this.tb_currHP.TabIndex = 12;
			this.tb_currHP.Text = "0";
			this.tb_currHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(15, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 18);
			this.label5.TabIndex = 13;
			this.label5.Text = "AC:";
			// 
			// tb_AC
			// 
			this.tb_AC.BackColor = System.Drawing.Color.Beige;
			this.tb_AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_AC.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_AC.Location = new System.Drawing.Point(11, 123);
			this.tb_AC.MaxLength = 4;
			this.tb_AC.Name = "tb_AC";
			this.tb_AC.Size = new System.Drawing.Size(38, 25);
			this.tb_AC.TabIndex = 14;
			this.tb_AC.Text = "0";
			this.tb_AC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Brown;
			this.pictureBox2.Location = new System.Drawing.Point(6, 170);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(263, 2);
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(90, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 18);
			this.label6.TabIndex = 16;
			this.label6.Text = "Max HP:";
			// 
			// tb_maxHP
			// 
			this.tb_maxHP.BackColor = System.Drawing.Color.Beige;
			this.tb_maxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_maxHP.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_maxHP.Location = new System.Drawing.Point(154, 85);
			this.tb_maxHP.MaxLength = 4;
			this.tb_maxHP.Name = "tb_maxHP";
			this.tb_maxHP.Size = new System.Drawing.Size(50, 25);
			this.tb_maxHP.TabIndex = 17;
			this.tb_maxHP.Text = "0";
			this.tb_maxHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_traits
			// 
			this.tb_traits.BackColor = System.Drawing.Color.Beige;
			this.tb_traits.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_traits.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_traits.Location = new System.Drawing.Point(6, 262);
			this.tb_traits.Name = "tb_traits";
			this.tb_traits.Size = new System.Drawing.Size(263, 277);
			this.tb_traits.TabIndex = 18;
			this.tb_traits.Text = "Speed\nSaving Throws\nSkills\nDamage Vulnerabilities\nDamage Resistances\nDamage Immun" +
    "ities\nCondition Immunities\nSenses\nLanguages\nChallenge";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(15, 185);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 18);
			this.label7.TabIndex = 19;
			this.label7.Text = "STR";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tb_str
			// 
			this.tb_str.BackColor = System.Drawing.Color.Beige;
			this.tb_str.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_str.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_str.Location = new System.Drawing.Point(11, 208);
			this.tb_str.MaxLength = 4;
			this.tb_str.Name = "tb_str";
			this.tb_str.Size = new System.Drawing.Size(38, 25);
			this.tb_str.TabIndex = 20;
			this.tb_str.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(59, 185);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(33, 18);
			this.label8.TabIndex = 21;
			this.label8.Text = "DEX";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tb_dex
			// 
			this.tb_dex.BackColor = System.Drawing.Color.Beige;
			this.tb_dex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_dex.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_dex.Location = new System.Drawing.Point(55, 208);
			this.tb_dex.MaxLength = 4;
			this.tb_dex.Name = "tb_dex";
			this.tb_dex.Size = new System.Drawing.Size(38, 25);
			this.tb_dex.TabIndex = 22;
			this.tb_dex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(98, 185);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 18);
			this.label9.TabIndex = 23;
			this.label9.Text = "CON";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tb_con
			// 
			this.tb_con.BackColor = System.Drawing.Color.Beige;
			this.tb_con.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_con.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_con.Location = new System.Drawing.Point(99, 208);
			this.tb_con.MaxLength = 4;
			this.tb_con.Name = "tb_con";
			this.tb_con.Size = new System.Drawing.Size(38, 25);
			this.tb_con.TabIndex = 24;
			this.tb_con.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(147, 185);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(31, 18);
			this.label12.TabIndex = 25;
			this.label12.Text = "INT";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tb_int
			// 
			this.tb_int.BackColor = System.Drawing.Color.Beige;
			this.tb_int.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_int.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_int.Location = new System.Drawing.Point(143, 208);
			this.tb_int.MaxLength = 4;
			this.tb_int.Name = "tb_int";
			this.tb_int.Size = new System.Drawing.Size(38, 25);
			this.tb_int.TabIndex = 26;
			this.tb_int.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(191, 185);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 18);
			this.label11.TabIndex = 27;
			this.label11.Text = "WIS";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tb_wis
			// 
			this.tb_wis.BackColor = System.Drawing.Color.Beige;
			this.tb_wis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_wis.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_wis.Location = new System.Drawing.Point(187, 208);
			this.tb_wis.MaxLength = 4;
			this.tb_wis.Name = "tb_wis";
			this.tb_wis.Size = new System.Drawing.Size(38, 25);
			this.tb_wis.TabIndex = 28;
			this.tb_wis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(232, 185);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 18);
			this.label10.TabIndex = 29;
			this.label10.Text = "CHA";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tb_cha
			// 
			this.tb_cha.BackColor = System.Drawing.Color.Beige;
			this.tb_cha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_cha.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_cha.Location = new System.Drawing.Point(231, 208);
			this.tb_cha.MaxLength = 4;
			this.tb_cha.Name = "tb_cha";
			this.tb_cha.Size = new System.Drawing.Size(38, 25);
			this.tb_cha.TabIndex = 30;
			this.tb_cha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lb_str
			// 
			this.lb_str.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_str.Location = new System.Drawing.Point(11, 233);
			this.lb_str.Name = "lb_str";
			this.lb_str.Size = new System.Drawing.Size(38, 18);
			this.lb_str.TabIndex = 31;
			this.lb_str.Text = "STR";
			this.lb_str.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lb_dex
			// 
			this.lb_dex.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_dex.Location = new System.Drawing.Point(55, 233);
			this.lb_dex.Name = "lb_dex";
			this.lb_dex.Size = new System.Drawing.Size(38, 18);
			this.lb_dex.TabIndex = 32;
			this.lb_dex.Text = "DEX";
			this.lb_dex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lb_con
			// 
			this.lb_con.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_con.Location = new System.Drawing.Point(99, 233);
			this.lb_con.Name = "lb_con";
			this.lb_con.Size = new System.Drawing.Size(38, 18);
			this.lb_con.TabIndex = 33;
			this.lb_con.Text = "CON";
			this.lb_con.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lb_int
			// 
			this.lb_int.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_int.Location = new System.Drawing.Point(143, 233);
			this.lb_int.Name = "lb_int";
			this.lb_int.Size = new System.Drawing.Size(38, 18);
			this.lb_int.TabIndex = 34;
			this.lb_int.Text = "INT";
			this.lb_int.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lb_wis
			// 
			this.lb_wis.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_wis.Location = new System.Drawing.Point(187, 233);
			this.lb_wis.Name = "lb_wis";
			this.lb_wis.Size = new System.Drawing.Size(39, 18);
			this.lb_wis.TabIndex = 35;
			this.lb_wis.Text = "WIS";
			this.lb_wis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lb_cha
			// 
			this.lb_cha.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_cha.Location = new System.Drawing.Point(232, 233);
			this.lb_cha.Name = "lb_cha";
			this.lb_cha.Size = new System.Drawing.Size(37, 18);
			this.lb_cha.TabIndex = 36;
			this.lb_cha.Text = "CHA";
			this.lb_cha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Brown;
			this.pictureBox3.Location = new System.Drawing.Point(6, 254);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(263, 2);
			this.pictureBox3.TabIndex = 37;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Brown;
			this.pictureBox4.Location = new System.Drawing.Point(436, 22);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(2, 535);
			this.pictureBox4.TabIndex = 38;
			this.pictureBox4.TabStop = false;
			// 
			// gb_statblock
			// 
			this.gb_statblock.BackColor = System.Drawing.Color.Transparent;
			this.gb_statblock.Controls.Add(this.tb_hpVal);
			this.gb_statblock.Controls.Add(this.pictureBox3);
			this.gb_statblock.Controls.Add(this.lb_cha);
			this.gb_statblock.Controls.Add(this.lb_wis);
			this.gb_statblock.Controls.Add(this.lb_int);
			this.gb_statblock.Controls.Add(this.lb_con);
			this.gb_statblock.Controls.Add(this.lb_dex);
			this.gb_statblock.Controls.Add(this.lb_str);
			this.gb_statblock.Controls.Add(this.tb_cha);
			this.gb_statblock.Controls.Add(this.label10);
			this.gb_statblock.Controls.Add(this.tb_wis);
			this.gb_statblock.Controls.Add(this.label11);
			this.gb_statblock.Controls.Add(this.tb_int);
			this.gb_statblock.Controls.Add(this.label12);
			this.gb_statblock.Controls.Add(this.tb_con);
			this.gb_statblock.Controls.Add(this.label9);
			this.gb_statblock.Controls.Add(this.tb_dex);
			this.gb_statblock.Controls.Add(this.label8);
			this.gb_statblock.Controls.Add(this.tb_str);
			this.gb_statblock.Controls.Add(this.label7);
			this.gb_statblock.Controls.Add(this.tb_traits);
			this.gb_statblock.Controls.Add(this.tb_maxHP);
			this.gb_statblock.Controls.Add(this.label6);
			this.gb_statblock.Controls.Add(this.pictureBox2);
			this.gb_statblock.Controls.Add(this.tb_AC);
			this.gb_statblock.Controls.Add(this.label5);
			this.gb_statblock.Controls.Add(this.tb_currHP);
			this.gb_statblock.Controls.Add(this.label4);
			this.gb_statblock.Controls.Add(this.label3);
			this.gb_statblock.Controls.Add(this.tb_tempHP);
			this.gb_statblock.Controls.Add(this.pictureBox1);
			this.gb_statblock.Controls.Add(this.tb_info);
			this.gb_statblock.Controls.Add(this.tb_name);
			this.gb_statblock.Controls.Add(this.btn_takeHealth);
			this.gb_statblock.Controls.Add(this.btn_addHealth);
			this.gb_statblock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gb_statblock.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gb_statblock.Location = new System.Drawing.Point(154, 13);
			this.gb_statblock.Name = "gb_statblock";
			this.gb_statblock.Size = new System.Drawing.Size(277, 545);
			this.gb_statblock.TabIndex = 2;
			this.gb_statblock.TabStop = false;
			this.gb_statblock.Text = "Statblock";
			// 
			// tb_hpVal
			// 
			this.tb_hpVal.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_hpVal.Location = new System.Drawing.Point(210, 112);
			this.tb_hpVal.MaxLength = 4;
			this.tb_hpVal.Name = "tb_hpVal";
			this.tb_hpVal.Size = new System.Drawing.Size(50, 25);
			this.tb_hpVal.TabIndex = 39;
			this.tb_hpVal.Text = "0";
			this.tb_hpVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(437, 571);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Edit Actions";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// pl_actions
			// 
			this.pl_actions.AutoScroll = true;
			this.pl_actions.BackColor = System.Drawing.Color.Transparent;
			this.pl_actions.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pl_actions.Location = new System.Drawing.Point(444, 23);
			this.pl_actions.Name = "pl_actions";
			this.pl_actions.Size = new System.Drawing.Size(527, 535);
			this.pl_actions.TabIndex = 39;
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Beige;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(983, 606);
			this.Controls.Add(this.pl_actions);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.tb_spellMod);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_playerLevel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lb_pb);
			this.Controls.Add(this.tb_proficiencyBonus);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.gb_statblock);
			this.Controls.Add(this.lsb_creatures);
			this.Controls.Add(this.btn_add);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainScreen";
			this.Text = "Statblock";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.gb_statblock.ResumeLayout(false);
			this.gb_statblock.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.ListBox lsb_creatures;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.TextBox tb_proficiencyBonus;
		private System.Windows.Forms.Label lb_pb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_playerLevel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_spellMod;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_addHealth;
		private System.Windows.Forms.Button btn_takeHealth;
		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.TextBox tb_info;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox tb_tempHP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_currHP;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_AC;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tb_maxHP;
		private System.Windows.Forms.RichTextBox tb_traits;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tb_str;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tb_dex;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tb_con;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox tb_int;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox tb_wis;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tb_cha;
		private System.Windows.Forms.Label lb_str;
		private System.Windows.Forms.Label lb_dex;
		private System.Windows.Forms.Label lb_con;
		private System.Windows.Forms.Label lb_int;
		private System.Windows.Forms.Label lb_wis;
		private System.Windows.Forms.Label lb_cha;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.GroupBox gb_statblock;
		private System.Windows.Forms.TextBox tb_hpVal;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel pl_actions;
	}
}

