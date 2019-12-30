using System;
using System.Reflection;
using System.Windows.Forms;
using Twist.Entity;
using Twist.Entity.Enums;
using Twist.ORM;

namespace WindowsFormsApp1.Forms
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
        ModbusORMBASE modbusORMBASE = new ModbusORMBASE();
        Product product = new Product();
        ProtocolInfo protocolInfo = new ProtocolInfo();

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            Parameters parameters;
            var allNud = Tools.GetAllChildControl(this, typeof(NumericUpDown));
           
            PropertyInfo[] properties = typeof(Product).GetProperties();


            foreach (NumericUpDown nud in allNud)
            {
                foreach (var prop in properties)
                {
                    if (nud.Name.Contains(prop.Name))
                    {
                        parameters = (Parameters)prop.GetValue(product);
                        parameters.Value = nud.Value.ToString();
                        break;
                    }
                }
            }
            protocolInfo.comType = WriteOrRead.write;
            protocolInfo.requestDataType = RequestDataType.products;
            WriteOrReadDataType protocolAllow = modbusORMBASE.DataExchangeProtocol(protocolInfo);
            if (protocolAllow == WriteOrReadDataType.writeableProducts)
            {
                modbusORMBASE.SendData<Product>(product);
            }

        }

      
      
    }
}
