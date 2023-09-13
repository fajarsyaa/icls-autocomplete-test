using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pelabuhan
{
    public partial class pelabuhan : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        private string kodeNegara;

        public pelabuhan()
        {
            InitializeComponent();
        }

        private void pelabuhan_Load(object sender, EventArgs e)
        {
            
        }

        private async void txNegara_TextChanged(object sender, EventArgs e)
        {
            string searchText = txNegara.Text;
            Dictionary<string, string> autoCompleteData = await GetDataNegara(searchText);

            var customSource = new AutoCompleteStringCollection();
            customSource.AddRange(autoCompleteData.Keys.ToArray());

            txNegara.AutoCompleteMode = AutoCompleteMode.Suggest;
            txNegara.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txNegara.AutoCompleteCustomSource = customSource;

            autoCompleteData.TryGetValue(txNegara.Text, out kodeNegara);
        }

        private async void txPelabuhan_TextChanged(object sender, EventArgs e)
        {
            string searchText = txPelabuhan.Text;
            List<String> autoCompleteData = await GetDataPelabuhan(kodeNegara, searchText);

            var customSource = new AutoCompleteStringCollection();
            customSource.AddRange(autoCompleteData.ToArray());

            txPelabuhan.AutoCompleteMode = AutoCompleteMode.Suggest;
            txPelabuhan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txPelabuhan.AutoCompleteCustomSource = customSource;
        }

        private void txKodeBarang_TextChanged(object sender, EventArgs e)
        {
            GetBarang(txKodeBarang.Text);
        }

        private void txHarga_TextChanged(object sender, EventArgs e)
        {
            GetTarifAndSetTotalHarga(txKodeBarang.Text);
        }



        private async Task<Dictionary<string,string>> GetDataNegara(string textSeacrh)
        {
            Dictionary<string, string> dictNegara = new Dictionary<string, string>();            
            try
            {
                string urlApi = $"https://insw-dev.ilcs.co.id/n/negara?ur_negara={textSeacrh}";
                HttpResponseMessage response = await httpClient.GetAsync(urlApi);
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    JArray jsonArray = JArray.Parse(data);

                    foreach (var item in jsonArray)
                    {
                        string urNegara = item["ur_negara"]?.ToString();
                        string kdNegara = item["kd_negara"]?.ToString();

                        if (!string.IsNullOrEmpty(urNegara) && !string.IsNullOrEmpty(kdNegara))
                        {
                            dictNegara[urNegara] = kdNegara;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show($"Error: {ex.Message}");
            }
            
            return dictNegara;
        }

        private async Task<List<String>> GetDataPelabuhan(string kodeNegara,string textSeacrh)
        {
            List<String> listPelabuhan = new List<String>();            
            try
            {
                string urlApi = $"https://insw-dev.ilcs.co.id/n/pelabuhan?kd_negara={kodeNegara}&ur_pelabuhan={textSeacrh}";
                HttpResponseMessage response = await httpClient.GetAsync(urlApi);
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    JArray jsonArray = JArray.Parse(data);

                    foreach (var item in jsonArray)
                    {
                        string urPelabuhan = item["ur_pelabuhan"]?.ToString();                        

                        if (!string.IsNullOrEmpty(urPelabuhan))
                        {
                            listPelabuhan.Add(urPelabuhan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show($"Error: {ex.Message}");
            }          

            return listPelabuhan;
        }

        private async void GetBarang(string kodeBarang)
        {
            List<String> listBarang = new List<String>();
            try
            {
                string urlApi = $" https://insw-dev.ilcs.co.id/n/barang?hs_code={kodeBarang}";
                HttpResponseMessage response = await httpClient.GetAsync(urlApi);
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    JArray jsonArray = JArray.Parse(data);

                    foreach (var item in jsonArray)
                    {
                        string barang = item["ur_barang"]?.ToString();

                        txBarang.AppendText(barang);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }

        private async void GetTarifAndSetTotalHarga(string kodeBarang)
        {            
            try
            {
                string urlApi = $"https://insw-dev.ilcs.co.id/n/tarif?hs_code={kodeBarang}";
                HttpResponseMessage response = await httpClient.GetAsync(urlApi);
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    JObject jsonObject = JObject.Parse(data);

                    int bm = Convert.ToInt32(jsonObject["ur_beamasuk"]?.ToString());
                    txTarifBeaMasuk.Text = bm.ToString();

                    if (int.TryParse(txHarga.Text, out int harga))
                    {
                        int result = bm * harga;
                        txTotalHarga.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show($"Error: Invalid 'txHarga' input");                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

    }
}
