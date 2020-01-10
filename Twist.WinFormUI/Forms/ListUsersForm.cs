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
    public partial class ListUsersForm : Form
    {
        ModbusORMBASE modbusORMBASE = new ModbusORMBASE();
        ProtocolInfo protocolInfo = new ProtocolInfo();

        Dictionary<int, User> dataCollection;
       
        public ListUsersForm()
        {
            InitializeComponent();

        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {
            ListAccounts();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ListAccounts();
        }

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            IntPtr m = Application.OpenForms["TwistMainForm"].Handle;
            ComboBox comboBox_Languages = TwistMainForm.FromHandle(m).Controls.Find("combo_Languages", true).FirstOrDefault() as ComboBox;
            AddUserForm addUserForm = new AddUserForm();
            SetLanguage.SetChildFormLanguage(addUserForm, comboBox_Languages);
            addUserForm.ShowDialog();
        }


        private void ListAccounts()
        {
            protocolInfo.comType = WriteOrRead.read;
            protocolInfo.requestDataType = RequestDataType.users;
            WriteOrReadDataType protocolAllow = modbusORMBASE.DataExchangeProtocol(protocolInfo);
            ListData listData = new ListData();
            if (protocolAllow == WriteOrReadDataType.readableAccounts)
            {
               
                lV_Users = listData.List<User>(lV_Users);
            }
        }
    }
}
