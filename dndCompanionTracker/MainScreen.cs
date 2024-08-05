using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dndCompanionTracker {
	
	public partial class MainScreen : Form {

		public const string LIST_FILE_NAME = "creatures.json";

		public MainScreen() {
			InitializeComponent();
			this.tb_hpVal.KeyPress += new KeyPressEventHandler(checkKeys);
			statblocks = new List<CreatureStatblock>();
			loadCreaturesFromFile();
		}

		public IndexResult indexToImport;

		public CreatureStatblock currentCreature;

		public List<CreatureStatblock> statblocks;

		private void btn_add_Click(object sender, EventArgs e) {

			//TODO: Add saving for current creature if anything has been changed

			DialogResult importAnswer = MessageBox.Show("Do you want to import a creature from the API?", "Import options", MessageBoxButtons.YesNo);

			if (importAnswer == DialogResult.Yes) {

				ImportOptions importOptionsMenu = new ImportOptions(this);

				importOptionsMenu.ShowDialog();

			} else {

				//save the details, and clear the form

			}

		}

		public void ImportOptionClosed(bool importCancelled) {

			if (!importCancelled) {

				if (indexToImport != null) {

					fetchCreatureData();
				
				} else {

					MessageBox.Show("Oops, creature not passed through!");

				}

			}

		}

		public async void fetchCreatureData() {

			var client = new HttpClient();
			var request = new HttpRequestMessage(HttpMethod.Get, "https://www.dnd5eapi.co/api/monsters/" + indexToImport.Index);
			request.Headers.Add("Accept", "application/json");
			var response = await client.SendAsync(request);
			response.EnsureSuccessStatusCode();
			var resultString = await response.Content.ReadAsStringAsync();

			currentCreature = JsonConvert.DeserializeObject<CreatureStatblock>(resultString);

			statblocks.Add(currentCreature);

			MessageBox.Show("Creature imported successfully!");

			lsb_creatures.Items.Add(currentCreature.Name);
			lsb_creatures.SelectedIndex = lsb_creatures.Items.Count - 1;

			formatCreatureData();

		}

		public void formatCreatureData() {

			#region BaseData

			tb_AC.Text = currentCreature.AC[0].Value.ToString();

			if(currentCreature.CurrentHP == null)
				currentCreature.CurrentHP = currentCreature.HP;
			tb_currHP.Text = currentCreature.CurrentHP.ToString();
			tb_maxHP.Text = currentCreature.HP.ToString();
			tb_name.Text = currentCreature.Name;

			#endregion

			#region Statblock

			//statblock stuff
			lb_str.Text = getModifier(currentCreature.Strength).ToString();
			lb_dex.Text = getModifier(currentCreature.Dexterity).ToString();
			lb_con.Text = getModifier(currentCreature.Constitution).ToString();
			lb_int.Text = getModifier(currentCreature.Intelligence).ToString();
			lb_wis.Text = getModifier(currentCreature.Wisdom).ToString();
			lb_cha.Text = getModifier(currentCreature.Charisma).ToString();

			tb_str.Text = currentCreature.Strength.ToString();
			tb_dex.Text = currentCreature.Dexterity.ToString();
			tb_con.Text = currentCreature.Constitution.ToString();
			tb_int.Text = currentCreature.Intelligence.ToString();
			tb_wis.Text = currentCreature.Wisdom.ToString();
			tb_cha.Text = currentCreature.Charisma.ToString();

			tb_info.Text = currentCreature.Size + " " + currentCreature.Type + " (" + currentCreature.Alignment + ")";

			int stringTrim = 2;

			string speedString = "";

			foreach (var speed in currentCreature.Speed) {

				if (speed.Key.ToLower() == "hover") {
					break;
				}

				speedString += speed.Key + " " +  speed.Value + ", ";

			}

			if(speedString.Any()) {
				speedString = speedString.Substring(0, speedString.Length - stringTrim);
			}

			#endregion

			#region Traits

			string savingThrowString = "";
			string skillString = "";

			foreach (var proficiency in currentCreature.Proficiencies) {

				var proficiencyName = proficiency.proficiency.Name;

				//SKILL
				if(proficiencyName.Substring(0, 5).ToLower() == "skill") {

					skillString += proficiencyName.Substring(7, proficiencyName.Length - 7) + " +" + proficiency.value + ", ";

				//SAVING THROW
				} else {

					savingThrowString += proficiencyName.Substring(proficiencyName.Length - 3, 3) + " +" + proficiency.value + ", ";

				}

			}

			if (savingThrowString.Any()) {
				savingThrowString = savingThrowString.Substring(0, savingThrowString.Length - stringTrim);
			}

			if (skillString.Any()) {
				skillString = skillString.Substring(0, skillString.Length - stringTrim);
			}

			string dmgVulnString = "";

            foreach (var item in currentCreature.DamageVulnerabilities)
            {
				dmgVulnString += item + ", ";
            }

			if(dmgVulnString.Any()) {
				dmgVulnString = dmgVulnString.Substring(0, dmgVulnString.Length - stringTrim);
			}

			string dmgResString = "";

			foreach (var item in currentCreature.DamageResistances) {
				dmgResString += item + ", ";
			}

			if (dmgResString.Any()) {
				dmgResString = dmgResString.Substring(0, dmgResString.Length - stringTrim);
			}

			string dmgImmString = "";

			foreach (var item in currentCreature.DamageImmunities) {
				dmgImmString += item + ", ";
			}

			if (dmgImmString.Any()) {
				dmgImmString = dmgImmString.Substring(0, dmgImmString.Length - stringTrim);
			}

			string condImmString = "";

			foreach (var item in currentCreature.ConditionImmunities) {
				condImmString += item.Name + ", ";
			}

			if (condImmString.Any()) {
				condImmString = condImmString.Substring(0, condImmString.Length - stringTrim);
			}

			string senseString = "";

			foreach (var item in currentCreature.Senses) {

				string keyName = item.Key;

				if(item.Key.ToLower() == "passive_perception") {
					keyName = "Passive Perception";
				}

				senseString += keyName + " " + item.Value + ", ";

			}

			if (senseString.Any()) {
				senseString = senseString.Substring(0, senseString.Length - stringTrim);
			}

			string specialActionString = formatActions(currentCreature.SpecialAbilities);

			tb_traits.Text = $@"Speed: {speedString}
Saving Throws: {savingThrowString}
Skills: {skillString}
Damage Vulnerabilities: { dmgVulnString }
Damage Resistances: { dmgResString }
Damage Immunities: {dmgImmString }
Condition Immunities: { condImmString }
Senses: { senseString }
Languages: { currentCreature.Languages }
Challenge: { currentCreature.CR } ({ currentCreature.XP } XP)
-----------------------------------------------
{ specialActionString }";

			#endregion

			#region Actions

			string actionString = formatActions(currentCreature.Actions);

			string legendActionString = $@"Legendary Actions
-----------------------------------------------------------------
The {currentCreature.Name} can take 3 legendary actions, choosing from the options below. Only one legendary action option can be used at a time and only at the end of another creature's turn. The {currentCreature.Name} regains spent legendary actions at the start of its turn.

";

			if (currentCreature.LegendaryActions.Any()) {
				legendActionString += formatActions(currentCreature.LegendaryActions);
			} else {
				legendActionString = "";
			}

			string reactionString = formatActions(currentCreature.Reactions);

			tb_actions.Text = 
$@"Actions
-----------------------------------------------------------------
{ actionString }

{ legendActionString }

Reactions
-----------------------------------------------------------------
{  reactionString }
";

			#endregion

		}

		public int getModifier(int? baseStat) {

			int modifier = 0;

			if (!baseStat.HasValue) {
				return modifier;
			}

			switch (baseStat) {
				case 1:
					modifier = -5;
					break;
				case 2 or 3:
					modifier = -4;
					break;
				case 4 or 5:
					modifier = -3;
					break;
				case 6 or 7:
					modifier = -2;
					break;
				case 8 or 9:
					modifier = -1;
					break;
				case 10 or 11:
					modifier = 0;
					break;
				case 12 or 13:
					modifier = 1;
					break;
				case 14 or 15:
					modifier = 2;
					break;
				case 16 or 17:
					modifier = 3;
					break;
				case 18 or 19:
					modifier = 4;
					break;
				case 20 or 21:
					modifier = 5;
					break;
				case 22 or 23:
					modifier = 6;
					break;
				case 24 or 25:
					modifier = 7;
					break;
				case 26 or 27:
					modifier = 8;
					break;
				case 28 or 29:
					modifier = 9;
					break;
				case 30:
					modifier = 10;
					break;
			}

			return modifier;

		}

		public void checkKeys(object sender, KeyPressEventArgs e) {

			e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);

		}

		private void btn_addHealth_Click(object sender, EventArgs e) {

			editHealth(true);

		}

		private void btn_takeHealth_Click(object sender, EventArgs e) {

			editHealth(false);

		}

		private void editHealth(bool addHealth) {

			int healthMod, currentHealth, maxHealth, newHealth;

			int.TryParse(tb_hpVal.Text, out healthMod);
			int.TryParse(tb_currHP.Text, out currentHealth);
			int.TryParse(tb_maxHP.Text, out maxHealth);

			if(addHealth) {
				newHealth = Math.Min(maxHealth, (currentHealth + healthMod));
			} else {
				newHealth = Math.Max(0, (currentHealth - healthMod));
			}

			tb_currHP.Text = newHealth.ToString();

			currentCreature.CurrentHP = newHealth;

		}

		private string formatActions(List<CreatureActions> actions) {

			var returnedString = "";

			if (actions == null) {

				return returnedString;

			}

			foreach (var action in actions ?? new List<CreatureActions>()) {

				string useText = "";

				var usage = action.Usage;

				if (usage != null) {

					switch (usage.Type) {
						case "at will":
							break;
						case "per day":
							useText += $@" ({usage.Times}/Day)";
							break;
						case "recharge after rest":
							break;
						case "recharge on roll":
							useText += $@" (Recharge {usage.MinValue}- { usage.Dice.Substring(usage.Dice.Length - 1, 1) })";
							break;
					}

				}

				string a = $@"{action.Name}{useText}. {action.Description}";

				returnedString += a + "\n";

			}

			return returnedString;

		}

		private void lsb_creatures_SelectedIndexChanged(object sender, EventArgs e) {

			//save previous creature data

			//load creature from index
			currentCreature = statblocks[lsb_creatures.SelectedIndex];
			formatCreatureData();

		}

		private void saveProgramState() {

			//save list of open creatures to its own json
			var creatureList = new List<string>();

            foreach (var creature in lsb_creatures.Items ?? new ListBox.ObjectCollection(lsb_creatures))
            {
				creatureList.Add(creature.ToString());
            }

			string jsonString = JsonConvert.SerializeObject(creatureList);

			File.WriteAllText(LIST_FILE_NAME, jsonString);

			Console.WriteLine(File.ReadAllText(LIST_FILE_NAME));

			//save each creature to its own json file

			foreach (var creature in statblocks ?? new List<CreatureStatblock>()) {

				saveCreatureState(creature);

			}

        }

		private void saveCreatureState(CreatureStatblock creature) {

			string creatureJsonString = JsonConvert.SerializeObject(creature);

			string fileName = creature.Name + ".json";

			File.WriteAllText(fileName, creatureJsonString);

			//Console.WriteLine(File.ReadAllText(fileName));

		}

		private void loadCreaturesFromFile() {

			var fileContext = File.ReadAllText(LIST_FILE_NAME);

			var jsonContent = JsonConvert.DeserializeObject<List<string>>(fileContext);

			foreach (var creature in jsonContent) {

				try {

					lsb_creatures.Items.Add(creature.ToString());

					string fileName = creature.ToString() + ".json";

					var creatureContent = File.ReadAllText(fileName);

					var jsonCreature = JsonConvert.DeserializeObject<CreatureStatblock>(creatureContent);

					statblocks.Add(jsonCreature);

					currentCreature = statblocks[0];
					formatCreatureData();
					lsb_creatures.SelectedIndex = 0;

				} catch (Exception) {

					throw;
				}

			}

			//populate listbox with names

			//load each info from file

		}

		protected override void OnFormClosing(FormClosingEventArgs e) {
			base.OnFormClosing(e);

			saveProgramState();
		}

		private void btn_save_Click(object sender, EventArgs e) {

			saveCreatureState(currentCreature);	

		}
	}

}
