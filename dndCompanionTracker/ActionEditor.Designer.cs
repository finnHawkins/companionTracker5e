namespace dndCompanionTracker {
	partial class ActionEditor {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionEditor));
			this.lsb_actions = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lsb_actions
			// 
			this.lsb_actions.BackColor = System.Drawing.Color.Beige;
			this.lsb_actions.FormattingEnabled = true;
			this.lsb_actions.ItemHeight = 18;
			this.lsb_actions.Location = new System.Drawing.Point(12, 11);
			this.lsb_actions.Name = "lsb_actions";
			this.lsb_actions.Size = new System.Drawing.Size(150, 436);
			this.lsb_actions.TabIndex = 0;
			// 
			// ActionEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(778, 459);
			this.Controls.Add(this.lsb_actions);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ActionEditor";
			this.Text = "ActionEditor";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lsb_actions;
	}
}