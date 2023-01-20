using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace MethodSignatureFinder
{
    public partial class IGINativesForm : Form
    {
        string jsonNatives;
        dynamic jsonData;

        public IGINativesForm()
        {
            try
            {
                InitializeComponent();

                // Add a vertical scrollbar to the TextBox
                txtOutput.ScrollBars = ScrollBars.Vertical;

                // Read JSON file
                jsonNatives = File.ReadAllText(@"IGI-Natives.json");

                // Parse JSON into dynamic object
                jsonData = JObject.Parse(jsonNatives);
            }
            catch(Exception exception)
            {
                MessageBox.Show("Exception occurred:" + exception.Message, "EXCEPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // Get user input method name
            string methodName = txtMethodName.Text.ToLower();

            if (String.IsNullOrEmpty(methodName))
            {
                MessageBox.Show("Input field cannot be empty", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            // Initialize variable to store output
            string output = "";

            // Loop through "Natives" array in JSON
            foreach (var native in jsonData.Natives)
            {
                // Check if current "Native" object's "name" property contains the user input method name (case-insensitive)
                if (native.Native.name.ToString().ToLower().Contains(methodName))
                {
                    // Add signature and hash to output
                    output += "Method Name: " + native.Native.name + Environment.NewLine + "Signature: " + native.Native.signature + Environment.NewLine  + "Address: " + native.Native.hash + Environment.NewLine + Environment.NewLine;
                }
            }

            // Display output in label
            txtOutput.Text = output;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get user input method name
            string methodName = txtMethodName.Text;

            if (String.IsNullOrEmpty(txtOutput.Text))
            {
                MessageBox.Show("Output text is empty,\nNo natives were generated yet.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create file name
            string fileName = "IGI-Natives-" + methodName + ".txt";

            // Write output to file
            File.WriteAllText(fileName, txtOutput.Text);
            MessageBox.Show("Data saved to " + fileName,"Info");
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            // Deserialize JSON to dynamic object
            dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(jsonNatives);

            // Initialize CSV file
            string csvData = "name,address,signature,note\n";

            // Loop through "Natives" array in JSON
            foreach (var native in jsonData.Natives)
            {
                // Add current "Native" object's properties to CSV file
                csvData += native.Native.name + "," + native.Native.hash + "," + native.Native.signature + "," + native.Native.note + "\n";
            }

            // Save CSV file
            File.WriteAllText("IGI-Natives-CSV.csv", csvData);
            MessageBox.Show("Data saved to IGI-Natives-CSV.csv","INFO");
        }
    }
}