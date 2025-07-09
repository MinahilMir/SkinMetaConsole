using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Data.SqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SkinMetaConsole
{
    public partial class Recommendation : Form
    {
        private const string API_KEY = "c04b349df0d69f1829133a5bb6d86423";
        private HttpClient client;
        private SqlConnection con = DatabaseHelper.GetConnection();
        
        public Recommendation()
        {
            InitializeComponent();
            client = new HttpClient();

            // Only add this if txtCity exists and is properly initialized
            if (EnterCity != null)
            {
                EnterCity.KeyDown += TxtCity_KeyDown;
            }
            else
            {
                MessageBox.Show("txtCity control is not initialized properly.");
            }
        }
        private void TxtCity_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the "ding" sound
                SearchCity();
            }
        }

        private async void SearchCity()
        {
            string city = EnterCity.Text.Trim();
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please enter a city name.");
                return;
            }

            try
            {
                await GetWeatherData(city);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}");
            }
        }

        private async Task GetWeatherData(string city)
        {
            // Get weather data
            string weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={API_KEY}&units=metric";
            HttpResponseMessage weatherResponse = await client.GetAsync(weatherUrl);

            if (!weatherResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("City not found or weather data unavailable.");
                return;
            }

            string weatherJson = await weatherResponse.Content.ReadAsStringAsync();
            dynamic weatherData = JsonConvert.DeserializeObject(weatherJson);

            // Extract weather information
            double humidity = weatherData.main.humidity;
            double temperature = weatherData.main.temp;

            // Get air pollution data
            double lat = weatherData.coord.lat;
            double lon = weatherData.coord.lon;
            string pollutionUrl = $"https://api.openweathermap.org/data/2.5/air_pollution?lat={lat}&lon={lon}&appid={API_KEY}";

            HttpResponseMessage pollutionResponse = await client.GetAsync(pollutionUrl);
            string pollutionJson = await pollutionResponse.Content.ReadAsStringAsync();
            dynamic pollutionData = JsonConvert.DeserializeObject(pollutionJson);

            // Air Quality Index ranges from 1 (Good) to 5 (Very Poor)
            int aqi = pollutionData.list[0].main.aqi;
            // Convert to percentage (1=20%, 5=100%)
            double pollutionPercent = (aqi / 5.0) * 100;

            // For radiation, we'll use UV index as a proxy
            string uvUrl = $"https://api.openweathermap.org/data/2.5/uvi?lat={lat}&lon={lon}&appid={API_KEY}";
            HttpResponseMessage uvResponse = await client.GetAsync(uvUrl);

            // In case UV endpoint doesn't work (deprecated in some API versions)
            double uvIndex = 0;
            try
            {
                string uvJson = await uvResponse.Content.ReadAsStringAsync();
                dynamic uvData = JsonConvert.DeserializeObject(uvJson);
                uvIndex = uvData.value ?? 0;
            }
            catch
            {
                // Fallback: estimate UV based on weather conditions
                string weatherCondition = weatherData.weather[0].main.ToString().ToLower();
                if (weatherCondition.Contains("clear") || weatherCondition.Contains("sun"))
                    uvIndex = 8;
                else if (weatherCondition.Contains("cloud"))
                    uvIndex = 4;
                else
                    uvIndex = 2;
            }

            // Convert UV index (usually 0-11) to percentage
            double radiationPercent = (uvIndex / 11.0) * 100;

            // Update UI
            HumidityIndex.Text = $"{humidity}%";
            PollutionIndex.Text = $"{Math.Round(pollutionPercent)}%";
            RadiationsIndex.Text = $"{Math.Round(radiationPercent)}%";
            WeatherConditionsIndex.Text = $"{temperature}°C";

            // Generate skincare advice based on environmental factors
            GenerateSkinAdvice(humidity, pollutionPercent, radiationPercent, temperature, city);

            // Store climate data in database
            StoreClimateData(city, humidity, temperature, pollutionPercent, radiationPercent);
        }

        private void GenerateSkinAdvice(double humidity, double pollution, double radiation, double temperature, string city)
        {
            string advice = $"Current Environmental Analysis for {city}:\n\n";
            List<string> recommendedProducts = new List<string>();

            // Analyze humidity effect on skin
            if (humidity < 30)
            {
                advice += "• Low Humidity: Your skin may become dry and flaky.\n";
                recommendedProducts.Add("CeraVe Moisturizing Cream");
                recommendedProducts.Add("Neutrogena Hydro Boost Water Gel");
            }
            else if (humidity > 70)
            {
                advice += "• High Humidity: Your skin may become oily and prone to breakouts.\n";
                recommendedProducts.Add("Neutrogena Oil-Free Acne Wash");
                recommendedProducts.Add("La Roche-Posay Anthelios Clear Skin Oil-Free Sunscreen");
            }

            // Analyze pollution effect
            if (pollution > 60)
            {
                advice += "• High Pollution: Your skin needs extra protection from environmental toxins.\n";
                recommendedProducts.Add("Origins Clear Improvement Active Charcoal Mask");
                recommendedProducts.Add("Skinceuticals C E Ferulic");
            }

            // Analyze UV/radiation effect
            if (radiation > 50)
            {
                advice += "• High UV Radiation: Your skin needs protection from sun damage.\n";
                recommendedProducts.Add("Supergoop! Unseen Sunscreen SPF 40");
                recommendedProducts.Add("EltaMD UV Clear Broad-Spectrum SPF 46");
            }

            // Analyze temperature effect
            if (temperature > 30)
            {
                advice += "• High Temperature: Heat can increase oil production and irritation.\n";
                recommendedProducts.Add("Fresh Soy Face Cleanser");
                recommendedProducts.Add("Laneige Water Sleeping Mask");
            }
            else if (temperature < 10)
            {
                advice += "• Low Temperature: Cold can cause dryness and sensitivity.\n";
                recommendedProducts.Add("Embryolisse Lait-Crème Concentré");
                recommendedProducts.Add("Kiehl's Ultra Facial Cream");
            }

            // Add recommended routine
            advice += "\nRecommended Skincare Actions:\n";

            // General advice for all conditions
            advice += "• Cleanse your skin twice daily\n";
            advice += "• Apply moisturizer appropriate for your skin type\n";

            if (pollution > 40 || radiation > 40)
                advice += "• Use antioxidant serums to combat environmental damage\n";

            if (radiation > 30)
                advice += "• Apply broad-spectrum sunscreen every 2 hours when outdoors\n";

            if (humidity < 40 || temperature < 15)
                advice += "• Consider using a humidifier indoors\n";

            // Add product recommendations
            if (recommendedProducts.Count > 0)
            {
                advice += "\nRecommended Products from our Database:\n";
                foreach (var product in recommendedProducts.Distinct().Take(5))
                {
                    advice += $"• {product}\n"; // Use proper string interpolation
                }
            }

            MessageBox.Show(advice, "Skincare Advice", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void StoreClimateData(string city, double humidity, double temperature, double pollutionIndex, double radiationIndex)
        {
            try
            {
                // Open connection
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string query = @"INSERT INTO ClimateData (City, Date, Humidity, Temperature, PollutionIndex, RadiationIndex)
                                    VALUES (@City, @Date, @Humidity, @Temperature, @PollutionIndex, @RadiationIndex)";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@City", city);
                        command.Parameters.AddWithValue("@Date", DateTime.Now);
                        command.Parameters.AddWithValue("@Humidity", humidity);
                        command.Parameters.AddWithValue("@Temperature", temperature);
                        command.Parameters.AddWithValue("@PollutionIndex", pollutionIndex);
                        command.Parameters.AddWithValue("@RadiationIndex", radiationIndex);

                        command.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                // Log the error but don't display to user
                Console.WriteLine($"Error storing climate data: {ex.Message}");
            }
        }

        private void Recommendation_Load(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            profile.Show();
            this.Hide();
        }
    }
}
