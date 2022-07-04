namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Products> products = new List<Products>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idNewRow = dtgvProductos.Rows.Add();
            
            Products newProduct = new Products(txtNombre.Text, txtPrecio.Text, txtDesc.Text);

            products.Add(newProduct);

            dtgvProductos.Rows[idNewRow].Cells[0].Value = newProduct.Id;
            dtgvProductos.Rows[idNewRow].Cells[1].Value = newProduct.Name;
            dtgvProductos.Rows[idNewRow].Cells[2].Value = newProduct.Price;
            dtgvProductos.Rows[idNewRow].Cells[3].Value = newProduct.Description;

            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtDesc.Text = "";

            string textoMostrar = "";

            foreach (Products product in products)
            {
                textoMostrar += product.Name + " ";
            }
            
            MessageBox.Show(textoMostrar);
        }
    }
}