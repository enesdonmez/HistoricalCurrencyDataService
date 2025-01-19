using ServiceReference1;
using System.ServiceModel;

namespace HistoricalRates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HistoricalRatesServiceClient client = new HistoricalRatesServiceClient();
        private async void button1_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var fromCurrency = txtFromCurreny.Text;
            string[] toCurrencies = checkedListBox1.CheckedItems.Cast<string>().ToArray();

            try
            {
                FixerApiResponse rates = await client.GetExchangeRatesAsync(date, fromCurrency, toCurrencies);
                dataGridView1.DataSource = rates.Rates.Select(x => new { Currency = x.Key, Rate = x.Value }).ToList();
            }
            catch (FaultException ex)
            {
                MessageBox.Show("UYARI",ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UYARI", ex.Message);

            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (client.State == CommunicationState.Closed)
            {
                await client.OpenAsync();
            }

            var currencies = await client.GetSupportedCurrenciesAsync();
            checkedListBox1.Items.AddRange(currencies);
        }
    }
}
