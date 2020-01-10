using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Twist.Entity;
using Twist.Entity.Enums;
using Twist.ORM;
using Twist.WinFormUI.Classes;
using Twist.WinFormUI.Forms;

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
            string[] text =
            {
                "muzaffer", "Cikay", "gshdcbjx", "gvdhbjsxn",
            };
            ListViewItem lvi = new ListViewItem(text);

            listView_Products.DoubleClick += ListView_Products_DoubleClick;

            listView_Products.Items.Add(lvi);
            
           
        }

      

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ListProducts();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            IntPtr m = Application.OpenForms["TwistMainForm"].Handle;
            ComboBox comboBox_Languages = TwistMainForm.FromHandle(m).Controls.Find("combo_Languages", true).FirstOrDefault() as ComboBox;
            AddProductForm addProduct = new AddProductForm();
            SetLanguage.SetChildFormLanguage(addProduct, comboBox_Languages);
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
                        listView_Products.MouseClick += ListView_Products_DoubleClick;
                    }
                }
            }
        }

        private void ListView_Products_DoubleClick(object sender, EventArgs e)
        {
            Product productData = new Product();
            
            if (listView_Products.SelectedItems.Count == 1 && dataCollection != null)
            {
                foreach (KeyValuePair<int, Product> KeyValuePairProduct in dataCollection)
                {

                    foreach (Parameters parameters in productData)
                    {
                        if (string.Compare(parameters.Value, listView_Products.SelectedItems[0].Text) == 0)
                        {
                            productData = KeyValuePairProduct.Value;
                            break;
                        }
                    }
                }
            }

            ProductDetailsForm detailsForm = new ProductDetailsForm(productData);
            detailsForm.ShowDialog();
        }

    }
}

