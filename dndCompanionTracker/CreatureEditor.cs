using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dndCompanionTracker {
	public partial class CreatureEditor : Form {

		public CreatureStatblock creature;

		public CreatureEditor(bool newCreature, CreatureStatblock creature) {
			InitializeComponent();

			if (newCreature) {
				this.creature = creature;
				Console.WriteLine(creature.Name);
			}

		}

		private void lsb_actions_SelectedIndexChanged(object sender, EventArgs e) {

		}
	}
}
