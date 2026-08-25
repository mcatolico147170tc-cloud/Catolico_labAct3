using System;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class sad : Form
    {
        // One shared queue counter for ALL patient types
        private int queueCounter = 1;

        public sad()
        {
            InitializeComponent();

            // Clear output when the form starts
            lblQueueNumberOutput.Text = "";
            lblPatientTypeOutput.Text = "";
            lblPriorityOutput.Text = "";
        }

        private void btnAddToQueue_Click(object sender, EventArgs e)
        {
            string patientName = txtPatientName.Text.Trim();
            string age = txtAge.Text.Trim();
            string reason = txtReason.Text.Trim();
            string patientType = cmbPatientType.Text;

            // Validate inputs
            if (patientName == "" ||
                age == "" ||
                reason == "" ||
                patientType == "")
            {
                MessageBox.Show(
                    "Please complete all required fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Determine priority
            string priority;

            if (patientType == "Emergency")
            {
                priority = "EMERGENCY";
            }
            else if (patientType == "Senior")
            {
                priority = "SENIOR PRIORITY";
            }
            else if (patientType == "Pregnant")
            {
                priority = "PRIORITY";
            }
            else
            {
                priority = "REGULAR";
            }

            // Generate shared queue number
            string queueNumber = "Q" + queueCounter.ToString("D3");

            // Display results
            lblQueueNumberOutput.Text = queueNumber;
            lblPatientTypeOutput.Text = "Patient Type: " + patientType.ToUpper();
            lblPriorityOutput.Text = priority;

            // Increase counter
            queueCounter++;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear inputs
            txtPatientName.Clear();
            txtAge.Clear();
            txtReason.Clear();
            cmbPatientType.SelectedIndex = -1;

            // Clear outputs
            lblQueueNumberOutput.Text = "";
            lblPatientTypeOutput.Text = "";
            lblPriorityOutput.Text = "";

            // IMPORTANT:
            // Do not reset queueCounter.
        }
    }
}