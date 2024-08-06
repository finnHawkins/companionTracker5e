using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dndCompanionTracker {

	#region FetchAllCreatures

	public class IndexResult {

		[JsonProperty("index")]
		public string Index;

		[JsonProperty("name")]
		public string Name;

		[JsonProperty("url")]
		public string Url;

	}

	public class MainIndexResult {
		[JsonProperty("count")]
		public int? Count;

		[JsonProperty("results")]
		public List<IndexResult> Results;
	}

	#endregion

	public class CreatureAction {

		[JsonProperty("name")]
		public string Name;

		[JsonProperty("desc")]
		public string Description;

		[JsonProperty("usage")]
		public Usage Usage;

	}

	public class Usage {

		[JsonProperty("times")]
		public int? Times;

		[JsonProperty("type")]
		public string Type;

		[JsonProperty("rest_types")]
		public List<string> RestTypes;

		[JsonProperty("min_value")]
		public int? MinValue;

		[JsonProperty("dice")]
		public string Dice;

	}

	public class ArmourClass {

		[JsonProperty("type")]
		public string Type;

		[JsonProperty("value")]
		public int? Value;

	}

	public class Condition {

		[JsonProperty("name")]
		public string Name;

	}

	#region Proficiency

	public class  Proficiency {

		[JsonProperty("value")]
		public int? value;

		[JsonProperty("proficiency")]
		public ProficiencyDetails proficiency;

	}

	public class ProficiencyDetails {

		[JsonProperty("name")]
		public string Name;

	}

	#endregion

	public class CreatureStatblock {

		[JsonProperty("name")]
		public string Name;

		[JsonProperty("challenge_rating")]
		public double? CR;

		[JsonProperty("charisma")]
		public int? Charisma;

		[JsonProperty("constitution")]
		public int? Constitution;

		[JsonProperty("dexterity")]
		public int? Dexterity;

		[JsonProperty("intelligence")]
		public int? Intelligence;

		[JsonProperty("strength")]
		public int? Strength;

		[JsonProperty("wisdom")]
		public int? Wisdom;

		[JsonProperty("size")]
		public string Size;

		[JsonProperty("type")]
		public string Type;

		[JsonProperty("subtype")]
		public string Subtype;

		[JsonProperty("alignment")]
		public string Alignment;

		[JsonProperty("armor_class")]
		public List<ArmourClass> AC;

		[JsonProperty("hit_points")]
		public int? HP;

		[JsonProperty("hit_dice")]
		public string HitDice;

		[JsonProperty("hit_points_roll")]
		public string HPRoll;

		[JsonProperty("proficiencies")]
		public List<Proficiency> Proficiencies;

		[JsonProperty("damage_vulnerabilities")]
		public List<object> DamageVulnerabilities;

		[JsonProperty("damage_resistances")]
		public List<object> DamageResistances;

		[JsonProperty("damage_immunities")]
		public List<object> DamageImmunities;

		[JsonProperty("condition_immunities")]
		public List<Condition> ConditionImmunities;

		[JsonProperty("actions")]
		public List<CreatureAction> Actions;

		[JsonProperty("legendary_actions")]
		public List<CreatureAction> LegendaryActions;

		[JsonProperty("senses")]
		public Dictionary<string,string> Senses;

		[JsonProperty("languages")]
		public string Languages;

		[JsonProperty("reactions")]
		public List<CreatureAction> Reactions;

		[JsonProperty("special_abilities")]
		public List<CreatureAction> SpecialAbilities;

		[JsonProperty("speed")]
		public Dictionary<string, string> Speed;

		[JsonProperty("xp")]
		public int? XP;

		public int? CurrentHP;

	}

}
