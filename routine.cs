using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace SkinMetaConsole
{
    public partial class routine : Form
    {
        private SqlConnection con = DatabaseHelper.GetConnection();
        private int currentUserID;
        private DateTime selectedDate;
        private DateTime cycleStartDate;
        private int cycleLength = 28; // Default cycle length

        public routine()
        {
            InitializeComponent();
            // Assuming your calendar control is named 'monthCalendar1'
            monthCalendar1.DateSelected += new DateRangeEventHandler(MonthCalendar1_DateSelected);

            // Set the default selected date to today
            selectedDate = DateTime.Today;

            // You would need to retrieve the user's cycle start date from settings or database
            // For example:
            LoadUserCycleSettings();

        }

        private void LoadUserCycleSettings()
        {
            // This would load from your user settings or a database
            // For example purposes, let's assume the last period started 10 days ago
            cycleStartDate = DateTime.Today.AddDays(-10);

            // Optionally, load custom cycle length if you track that
            // cycleLength = userCycleLength;
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Update the selected date when user clicks on calendar
            selectedDate = e.Start;

            // Show phase information for the selected date
            UpdateHormonalPhaseDisplay(selectedDate);
        }

        private void UpdateHormonalPhaseDisplay(DateTime date)
        {
            try
            {
                // Open connection
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                // Calculate which day of the cycle the selected date falls on
                int dayOfCycle = CalculateDayOfCycle(date, cycleStartDate, cycleLength);

                string query =
                        "SELECT phase_name, skin_behavior, message, recommended_products " +
                        "FROM menstrual_phase_messages " +
                        "WHERE @dayOfCycle BETWEEN start_day AND end_day";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.Add("@dayOfCycle", SqlDbType.Int).Value = dayOfCycle;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string phaseName = reader.GetString(reader.GetOrdinal("phase_name"));
                            string skinBehavior = reader.IsDBNull(reader.GetOrdinal("skin_behavior")) ?
                                "No specific behavior noted" : reader.GetString(reader.GetOrdinal("skin_behavior"));
                            string message = reader.GetString(reader.GetOrdinal("message"));
                            string products = reader.IsDBNull(reader.GetOrdinal("recommended_products")) ?
                                "No specific products recommended" : reader.GetString(reader.GetOrdinal("recommended_products"));

                            // Display the information in your UI
                            // For example, highlight the current phase in your UI
                            HighlightPhase(phaseName);

                            // Show the message in a dialog box or dedicated panel
                            ShowPhaseInformation(phaseName, skinBehavior, message, products);
                        }
                        else
                        {
                            MessageBox.Show("No phase information found for the selected date.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving phase information: " + ex.Message);
            }
        }

        private int CalculateDayOfCycle(DateTime date, DateTime cycleStartDate, int cycleLength)
        {
            // Calculate days since the start of the cycle
            int daysSinceStart = (int)(date - cycleStartDate).TotalDays;

            // Convert to day of cycle (1-based, wrapping around if needed)
            int dayOfCycle = (daysSinceStart % cycleLength) + 1;
            if (dayOfCycle <= 0) dayOfCycle += cycleLength; // Handle negative days

            return dayOfCycle;
        }

        private void HighlightPhase(string phaseName)
        {
            try
            {
                // Find all buttons once
                var Menstruation = Controls.Find("labelMenstruation", true).FirstOrDefault() as Guna.UI2.WinForms.Guna2CircleButton;
                var Follicular = Controls.Find("labelFollicular", true).FirstOrDefault() as Guna.UI2.WinForms.Guna2CircleButton;
                var Ovulation = Controls.Find("labelOvulation", true).FirstOrDefault() as Guna.UI2.WinForms.Guna2CircleButton;
                var Luteal = Controls.Find("labelLuteal", true).FirstOrDefault() as Guna.UI2.WinForms.Guna2CircleButton;

                // Reset all to default color
                if (Menstruation != null) Menstruation.FillColor = Color.MistyRose;
                if (Follicular != null) Follicular.FillColor = Color.MistyRose;
                if (Ovulation != null) Ovulation.FillColor = Color.MistyRose;
                if (Luteal != null) Luteal.FillColor = Color.MistyRose;

                // Highlight the current phase
                switch (phaseName)
                {
                    case "Menstruation":
                        if (Menstruation != null) Menstruation.FillColor = Color.IndianRed;
                        break;
                    case "Follicular":
                        if (Follicular != null) Follicular.FillColor = Color.IndianRed;
                        break;
                    case "Ovulation":
                        if (Ovulation != null) Ovulation.FillColor = Color.IndianRed;
                        break;
                    case "Luteal":
                        if (Luteal != null) Luteal.FillColor = Color.IndianRed;
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("HighlightPhase error: " + ex.Message);
            }
        }

        private void ShowPhaseInformation(string phaseName, string skinBehavior, string message, string products)
        {
            // You can display this information in a dialog box:
            string dialogMessage =
                $"Phase: {phaseName}\n\n" +
                $"Skin Behavior: {skinBehavior}\n\n" +
                $"Message: {message}\n\n" +
                $"Recommended Products: {products}";

            MessageBox.Show(dialogMessage, "Skin Care Information for Selected Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateCycleStartDate_Click(object sender, EventArgs e)
        {
            // A button handler to let the user update their cycle start date
            // You could show a dialog to set this date
            using (Form dateInputForm = new Form())
            {
                dateInputForm.Text = "Set First Day of Period";
                dateInputForm.Size = new System.Drawing.Size(300, 200);
                dateInputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                dateInputForm.StartPosition = FormStartPosition.CenterParent;

                DateTimePicker datePicker = new DateTimePicker();
                datePicker.Format = DateTimePickerFormat.Short;
                datePicker.Value = cycleStartDate;
                datePicker.Location = new System.Drawing.Point(50, 30);

                Button okButton = new Button();
                okButton.Text = "OK";
                okButton.DialogResult = DialogResult.OK;
                okButton.Location = new System.Drawing.Point(50, 80);

                Button cancelButton = new Button();
                cancelButton.Text = "Cancel";
                cancelButton.DialogResult = DialogResult.Cancel;
                cancelButton.Location = new System.Drawing.Point(150, 80);

                dateInputForm.Controls.Add(datePicker);
                dateInputForm.Controls.Add(okButton);
                dateInputForm.Controls.Add(cancelButton);

                dateInputForm.AcceptButton = okButton;
                dateInputForm.CancelButton = cancelButton;

                if (dateInputForm.ShowDialog() == DialogResult.OK)
                {
                    cycleStartDate = datePicker.Value.Date;

                    // Save this to user settings or database
                    SaveUserCycleSettings();

                    // Update the display with the new cycle information
                    UpdateHormonalPhaseDisplay(selectedDate);
                }
            }
        }

        private void SaveUserCycleSettings()
        {
            // Save the cycle start date to your database or settings
            // This is where you would implement persistence of user settings
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Event handler for checkbox
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Additional event handler for calendar
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            profile.Show();
            this.Hide();
        }
    }

}