using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace SkinMetaConsole
{
    public partial class SkinDiary : Form
    {
        private SqlConnection con = DatabaseHelper.GetConnection();
        private int userid;
        public SkinDiary(int id)
        {
            userid = id;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicBox = sender as PictureBox;
            if (clickedPicBox != null && clickedPicBox.Image != null)
            {
                Form imageViewerForm = new Form
                {
                    Text = "Skin Diary Image",
                    Size = new Size(800, 600),
                    StartPosition = FormStartPosition.CenterParent
                };

                PictureBox fullImagePicBox = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = clickedPicBox.Image
                };

                imageViewerForm.Controls.Add(fullImagePicBox);
                imageViewerForm.ShowDialog();
            }
        }
        private void PictureBox_DoubleClick(object sender, EventArgs e)
        {
            PictureBox_Click(sender, e); // Reuse existing functionality
        }
        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            UploadDailyImage("Monday", MonPic);
        }
        private void UploadDailyImage(string dayOfWeek, PictureBox pictureBox)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select an image";
                ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp; *.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load image into PictureBox
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Image = Image.FromFile(ofd.FileName);

                        // Convert image to byte array
                        byte[] imageBytes = File.ReadAllBytes(ofd.FileName);

                        // Get current logged in user ID
                        int currentUserId = GetCurrentUserId();

                        // Save image to database
                        SaveOrUpdateSkinEntry(currentUserId, dayOfWeek, imageBytes);

                        MessageBox.Show("Image uploaded and saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        // Helper method to save or update skin entries
        private void SaveOrUpdateSkinEntry(int userId, string dayOfWeek, byte[] imageData)
        {
            try
            {
                // Ensure connection is open
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // First check if an entry already exists
                string checkQuery = "SELECT Id FROM WeeklySkinCare WHERE UserId = @userId AND DayOfWeek = @day";
                bool entryExists = false;
                int existingEntryId = 0;

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@userId", userId);
                    checkCmd.Parameters.AddWithValue("@day", dayOfWeek);

                    var result = checkCmd.ExecuteScalar();
                    if (result != null)
                    {
                        entryExists = true;
                        existingEntryId = Convert.ToInt32(result);
                    }
                }

                // Either update existing entry or create a new one
                string query;
                if (entryExists)
                {
                    query = "UPDATE WeeklySkinCare SET Image = @img, UploadedAt = GETDATE() WHERE Id = @id";
                }
                else
                {
                    query = "INSERT INTO WeeklySkinCare (UserId, DayOfWeek, Image, UploadedAt) VALUES (@userId, @day, @img, GETDATE())";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (entryExists)
                    {
                        cmd.Parameters.AddWithValue("@id", existingEntryId);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@day", dayOfWeek);
                    }

                    cmd.Parameters.AddWithValue("@img", imageData);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving skin entry: {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        // Helper method to get the current user ID
        private int GetCurrentUserId()
        {
            return userid; 
        }

        // Method to load existing skin diary entries when form loads
        private void LoadSkinDiaryEntries()
        {
            int currentUserId = GetCurrentUserId();

            try
            {
                // Ensure connection is open
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string query = "SELECT DayOfWeek, Image FROM WeeklySkinCare WHERE UserId = @userId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", currentUserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string day = reader["DayOfWeek"].ToString();
                            byte[] imageData = (byte[])reader["Image"];

                            // Convert byte array to image
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                Image image = Image.FromStream(ms);

                                // Set the image to the appropriate PictureBox based on the day
                                switch (day)
                                {
                                    case "Monday":
                                        MonPic.Image = image;
                                        MonPic.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case "Tuesday":
                                        TuePic.Image = image;
                                        TuePic.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case "Wednesday":
                                        WedPic.Image = image;
                                        WedPic.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case "Thursday":
                                        ThursPic.Image = image;
                                        ThursPic.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case "Friday":
                                        FriPic.Image = image;
                                        FriPic.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case "Saturday":
                                        SatPic.Image = image;
                                        SatPic.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                    case "Sunday":
                                        SunPic.Image = image;
                                        SunPic.SizeMode = PictureBoxSizeMode.StretchImage;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading skin diary entries: {ex.Message}",
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        // Call this in your form's Load event
        private void SkinDiary_Load(object sender, EventArgs e)
        {
            // Set up picture box click events
            SetupPictureBoxClickEvents();

            // Load existing entries
            LoadSkinDiaryEntries();
        }

        // Optional: Method to view full-size image when clicking on a thumbnail
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicBox = sender as PictureBox;
            if (clickedPicBox != null && clickedPicBox.Image != null)
            {
                // Create a new form to display the full-size image
                Form imageViewerForm = new Form();
                imageViewerForm.Text = "Skin Diary Image";
                imageViewerForm.Size = new Size(800, 600);
                imageViewerForm.StartPosition = FormStartPosition.CenterParent;

                PictureBox fullImagePicBox = new PictureBox();
                fullImagePicBox.Dock = DockStyle.Fill;
                fullImagePicBox.SizeMode = PictureBoxSizeMode.Zoom;
                fullImagePicBox.Image = clickedPicBox.Image;

                imageViewerForm.Controls.Add(fullImagePicBox);
                imageViewerForm.ShowDialog();
            }
        }

        // Add click events to all PictureBoxes in the form's constructor or Load event
        private void SetupPictureBoxClickEvents()
        {
            MonPic.DoubleClick += PictureBox_DoubleClick;
            TuePic.DoubleClick += PictureBox_DoubleClick;
            WedPic.DoubleClick += PictureBox_DoubleClick;
            ThursPic.DoubleClick += PictureBox_DoubleClick;
            FriPic.DoubleClick += PictureBox_DoubleClick;
            SatPic.DoubleClick += PictureBox_DoubleClick;
            SunPic.DoubleClick += PictureBox_DoubleClick;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TueUpload_Click(object sender, EventArgs e)
        {
            UploadDailyImage("Tuesday", TuePic);
        }

        private void WedUpload_Click(object sender, EventArgs e)
        {
            UploadDailyImage("Wednesday", WedPic);
        }

        private void ThursUpload_Click(object sender, EventArgs e)
        {
            UploadDailyImage("Thursday", ThursPic);
        }

        private void FriUpload_Click(object sender, EventArgs e)
        {
            UploadDailyImage("Friday", FriPic);
        }

        private void SatUpload_Click(object sender, EventArgs e)
        {
            UploadDailyImage("Saturday", SatPic);
        }

        private void SunUpload_Click(object sender, EventArgs e)
        {
            UploadDailyImage("Sunday", SunPic);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile(userid, CurrentUser.Email);
            profile.Show();
            this.Close(); // not Hide, so form reloads next time
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadSkinDiaryEntries(); // Always refresh entries when form is shown
        }
    }
}
