using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace MethodSignatureFinder
{
    public partial class IGINativesForm : Form
    {
        public IGINativesForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // Read JSON file
            string json = File.ReadAllText(@"IGI-Natives.json");

            // Parse JSON into dynamic object
            dynamic jsonData = JObject.Parse(json);

            // Get user input method name
            string methodName = txtMethodName.Text.ToLower();

            // Initialize variable to store output
            string output = "";

            // Loop through "Natives" array in JSON
            foreach (var native in jsonData.Natives)
            {
                // Check if current "Native" object's "name" property contains the user input method name (case-insensitive)
                if (native.Native.name.ToString().ToLower().Contains(methodName))
                {
                    // Add signature and hash to output
                    output += "Method Name: " + native.Native.name + "\nSignature: " + native.Native.signature + "\nHash: " + native.Native.hash + "\n\n";
                }
            }

            // Display output in label
            lblOutput.Text = output;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get user input method name
            string methodName = txtMethodName.Text;

            // Create file name
            string fileName = "IGI-Natives-" + methodName + ".txt";

            // Write output to file
            File.WriteAllText(fileName, lblOutput.Text);
            MessageBox.Show("Data saved to " + fileName,"Info");
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Read JSON file
            string json = File.ReadAllText(@"IGI-Natives.json");

            // Deserialize JSON to dynamic object
            dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(json);

            // Initialize CSV file
            string csv = "name,address,signature,note\n";

            // Loop through "Natives" array in JSON
            foreach (var native in jsonData.Natives)
            {
                // Add current "Native" object's properties to CSV file
                csv += native.Native.name + "," + native.Native.hash + "," + native.Native.signature + "," + native.Native.note + "\n";
            }

            // Save CSV file
            File.WriteAllText("IGI-Natives-CSV.csv", csv);
            MessageBox.Show("Data saved to IGI-Natives-CSV.csv","Info");
        }
    }
}