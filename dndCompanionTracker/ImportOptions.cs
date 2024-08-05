using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace dndCompanionTracker {
	public partial class ImportOptions : Form {
		public ImportOptions(MainScreen parentForm) {
			InitializeComponent();
			_parentForm = parentForm;
		}

		private MainScreen _parentForm;

		MainIndexResult resultsObject;

		public IndexResult selectedResult;

		private async void ImportOptions_Load(object sender, EventArgs e) {

			var client = new HttpClient();
			var request = new HttpRequestMessage(HttpMethod.Get, "https://www.dnd5eapi.co/api/monsters");
			request.Headers.Add("Accept", "application/json");
			var response = await client.SendAsync(request);
			response.EnsureSuccessStatusCode();
			var resultString = await response.Content.ReadAsStringAsync();

			resultsObject = JsonConvert.DeserializeObject<MainIndexResult>(resultString);

			Console.WriteLine(resultsObject);

			resultsObject.Results.ForEach(x => {
				cb_creatures.Items.Add(x.Name);
			});

			cb_creatures.SelectedIndex = 0;

		}

		private void cb_creatures_SelectedIndexChanged(object sender, EventArgs e) {

			var index = cb_creatures.SelectedIndex;

			Console.WriteLine("Index = " + index + " : Selected creature = " + resultsObject.Results[index].Name);

			selectedResult = resultsObject.Results[index];

		}

		private void btn_back_Click(object sender, EventArgs e) {

			this.Close();
			_parentForm.ImportOptionClosed(true);

		}

		private void btn_select_Click(object sender, EventArgs e) {

			this.Close();
			_parentForm.indexToImport = selectedResult;
			_parentForm.ImportOptionClosed(false);

		}
	}

}
