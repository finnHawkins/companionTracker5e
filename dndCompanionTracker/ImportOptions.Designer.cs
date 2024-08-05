namespace dndCompanionTracker {
	partial class ImportOptions {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportOptions));
			this.cb_creatures = new System.Windows.Forms.ComboBox();
			this.btn_select = new System.Windows.Forms.Button();
			this.btn_back = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cb_creatures
			// 
			this.cb_creatures.BackColor = System.Drawing.Color.Beige;
			this.cb_creatures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_creatures.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_creatures.FormattingEnabled = true;
			this.cb_creatures.Location = new System.Drawing.Point(12, 12);
			this.cb_creatures.Name = "cb_creatures";
			this.cb_creatures.Size = new System.Drawing.Size(208, 26);
			this.cb_creatures.TabIndex = 0;
			this.cb_creatures.SelectedIndexChanged += new System.EventHandler(this.cb_creatures_SelectedIndexChanged);
			// 
			// btn_select
			// 
			this.btn_select.BackColor = System.Drawing.Color.Beige;
			this.btn_select.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_select.Location = new System.Drawing.Point(12, 44);
			this.btn_select.Name = "btn_select";
			this.btn_select.Size = new System.Drawing.Size(208, 27);
			this.btn_select.TabIndex = 1;
			this.btn_select.Text = "Select";
			this.btn_select.UseVisualStyleBackColor = false;
			this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
			// 
			// btn_back
			// 
			this.btn_back.BackColor = System.Drawing.Color.Beige;
			this.btn_back.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_back.Location = new System.Drawing.Point(12, 77);
			this.btn_back.Name = "btn_back";
			this.btn_back.Size = new System.Drawing.Size(208, 27);
			this.btn_back.TabIndex = 2;
			this.btn_back.Text = "Back";
			this.btn_back.UseVisualStyleBackColor = false;
			this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
			// 
			// ImportOptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(232, 126);
			this.Controls.Add(this.btn_back);
			this.Controls.Add(this.btn_select);
			this.Controls.Add(this.cb_creatures);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ImportOptions";
			this.Text = "Import";
			this.Load += new System.EventHandler(this.ImportOptions_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_creatures;
		private System.Windows.Forms.Button btn_select;
		private System.Windows.Forms.Button btn_back;
	}
}