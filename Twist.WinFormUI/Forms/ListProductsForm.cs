using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Twist.Entity;
using Twist.Entity.Enums;
using Twist.ORM;

namespace WindowsFormsApp1.Forms
{
    public partial class ListProductsForm : Form
    {
        public ListProductsForm()
        {
            InitializeComponent();
        }

        ProtocolInfo protocolInfo = new ProtocolInfo();
        ModbusORMBASE modbusORMBASE = new ModbusORMBASE();

        Dictionary<int, Product> dataCollection;
        Product productData = new Product();

        private void ListProductForm_Load(object sender, EventArgs e)
        {
            ListProducts();
           
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product productData = new Product();
            if (listView_Products.SelectedItems.Count == 1)
            {
                foreach (KeyValuePair<int, Product> KeyValuePairProduct in dataCollection)
                {
                    productData = KeyValuePairProduct.Value;
                    foreach (Parameters parameters in productData)
                    {
                        if (string.Compare(parameters.Value, listView_Products.SelectedItems[0].Text) == 0)
                        {
                            ProductDetailsForm detailsForm = new ProductDetailsForm(productData, parameters.Value);
                            detailsForm.ShowDialog();
                            break;
                        }
                    }
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ListProducts();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProduct = new AddProductForm();
            addProduct.ShowDialog();
        }

        private void ListProducts()
        {
            protocolInfo.comType = WriteOrRead.read;
            protocolInfo.requestDataType = RequestDataType.products;
            WriteOrReadDataType allowProtocol = modbusORMBASE.DataExchangeProtocol(protocolInfo);

            if (allowProtocol == WriteOrReadDataType.readableProducts)
            {
                Product product = new Product();
                dataCollection = modbusORMBASE.GetData<Product>();
                if (dataCollection != null)
                {
                    foreach (KeyValuePair<int, Product> KeyValuePairProduct in dataCollection)
                    {
                        productData = KeyValuePairProduct.Value;
                        string[] row =
                        {
                        productData.ProductName.Value, productData.LabelName.Value, productData.Cable1Color.Value,
                        productData.Cable2Color.Value, productData.Quantity.Value, productData.CableSection.Value,
                        productData.CableDiameter.Value, productData.CableDirection.Value
                        };
                        var lvi = new ListViewItem(row);
                        listView_Products.Items.Add(lvi);
                    }
                }
                
            }
        }
    }
}

