using System;
using System.Windows.Forms;
using Twist.Entity;
using Twist.Entity.Enums;
using Twist.ORM;


namespace WindowsFormsApp1.Forms
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }
        User user = new User();
        ModbusORMBASE modbusORMBASE = new ModbusORMBASE();
        ProtocolInfo protocolInfo = new ProtocolInfo();

        private void AddAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            protocolInfo.comType = WriteOrRead.write;
            protocolInfo.requestDataType = RequestDataType.users;
            WriteOrReadDataType protocolAllow = modbusORMBASE.DataExchangeProtocol(protocolInfo);

            if (protocolAllow == WriteOrReadDataType.writeableAccounts)
            {
                user.UserName.Value = txt_userName.Text;
                user.Pin.Value = txt_Pin.Text;
                user.BarcodPin.Value = txt_BarcodPin.Text;
                user.Level.Value = cb_Level.Text;
                user.ProtectInfo.Value = cb_ProtecInfo.Text;
                modbusORMBASE.SendData<User>(user);
                MessageBox.Show("Kullanıcı başarlı bir şekilde eklendi.");
            }
            else
            {
                MessageBox.Show("Haberleşme protokolünde hata oluştu!");
            }

        }
    }
}
