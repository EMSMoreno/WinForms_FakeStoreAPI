using Newtonsoft.Json;
using System.Resources;

namespace WinFormsFakeStoreAPI
{
    public partial class Form1 : Form
    {
        private List<Product> products;
        private DatabaseHelper dbHelper;

        public Form1()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadProducts();
            pictureBoxIcon.Image = ResourceImages._default; //define a imagem "default" como padrão
        }

        private async void LoadProducts() //Carrega os produtos
        {
            progressBar.Value = 0; //progressBar começa em 0
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) //procura produtos da API se que houver net
            {
                progressBar.Value = 20;
                products = await FetchProductsFromAPI();
                dbHelper.SaveProducts(products); //guarda os produtos recebidos da API na BD
                progressBar.Value = 100;
            }
            else //se não houver net, procura os produtos saltos na BD local
            {
                progressBar.Value = 50;
                products = dbHelper.GetProducts();
                progressBar.Value = 100;
            }
            DisplayProducts(); //passa o DisplayProducts para mostrar os produtos carregados no UI
        } 

        /// <summary>
        /// Procura produtos na API e retorna os primeiros 5 da lista, conforme requisito do teste. Faz uma requisição HTTP e usa o 'JsonConvert'.
        /// </summary>
        /// <returns></returns>
        /// 

        private async Task<List<Product>> FetchProductsFromAPI()
        {
            var productsList = new List<Product>(); //cria uma lista vazia para armazenar os dados da API
            using (var client = new HttpClient()) //cria uma instâcia que é usada para fazer a requisição HTTP à API
            {
                try
                {
                    var response = await client.GetStringAsync("https://fakestoreapi.com/products"); //Uso da API
                    productsList = JsonConvert.DeserializeObject<List<Product>>(response).Take(5).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Existe um erro ao ir buscar os produtos: {ex.Message}");
                }
            }
            return productsList;
        }

        private void DisplayProducts() //Mostra os titulos dos produtos na lista
        {
            ProductBox.Items.Clear(); //limpa a lista
            if (products != null) //vê se a lista não está nula
            {
                foreach (var product in products) //itera na lista sobre cada produto
                {
                    if (!string.IsNullOrEmpty(product?.Title))
                    {
                        ProductBox.Items.Add(product.Title); //adiciona o título dos produtos à lista como um item na lista.
                    }
                }
            }
        }

        #region UI

        /// <summary>
        /// Mostra os detalhes do produto selecionado nas respetivas caixas de texto e imagem correspondente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductBox.SelectedIndex != -1 && products != null && products.Count > ProductBox.SelectedIndex)
            {
                var selectedProduct = products[ProductBox.SelectedIndex];
                txtTitle.Text = selectedProduct.Title;
                txtPrice.Text = selectedProduct.Price.ToString();
                txtDescription.Text = selectedProduct.Description;
                txtCategory.Text = selectedProduct.Category;
                txtLink.Text = !string.IsNullOrEmpty(selectedProduct.Image) ? selectedProduct.Image : "N/D"; //Quando não tem link, passa "N/D" conforme requisito

                pictureBoxIcon.Image = GetIconForCategory(selectedProduct.Category);
            }
        }

        private void btnLoadProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        } //Btn p/carregar dados da API

        #endregion

        #region Anexar Imagens como Resources (Recursos)

        private Image GetIconForCategory(string category) // Carrega as imagens
        {
            switch (category.ToLower())
            {
                case "electronics":
                    return ResourceImages.electronics;
                case "jewelery":
                    return ResourceImages.jewelery;
                case "men's clothing":
                    return ResourceImages.men_s_clothing;
                case "women's clothing":
                    return ResourceImages.women_s_clothing;
                default:
                    return ResourceImages._default;
            }
        }

        #endregion
    }
}
