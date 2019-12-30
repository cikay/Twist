using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Twist.Entity;
using Twist.Entity.Enums;
using Twist.ORM;

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
            AddAccountForm addAccountForm = new AddAccountForm();
            addAccountForm.ShowDialog();
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
