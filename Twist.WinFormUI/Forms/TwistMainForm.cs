using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using Twist.ORM;
using Twist.Entity.LanguageMangEntity;
using System.Collections;
using WindowsFormsApp1.Forms;
using EasyModbus;
using Twist.WinFormUI.Classes;
using System.Linq;

namespace Twist.WinFormUI.Forms
{
    public partial class TwistMainForm : Form
    {
        Dictionary<Type, Form> ActiveForms;
        List<Language> languages = new List<Language>();
        Form ChildForm = null;
        ModbusClient modbusClient;
        

        public TwistMainForm()
        {
            
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ActiveForms = new Dictionary<Type, Form>();

        }
       
        private void TwistMainForm_Load(object sender, EventArgs e)
        {
          
            combo_Languages.Text = "Change Language";
            LanguagesList languageList = new LanguagesList();
            foreach(Language language in languageList)
            {
                combo_Languages.Items.Add(language);
            }
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }

        private void btn_DisConnect_Click(object sender, EventArgs e)
        {
            modbusClient = new ModbusClient();
            modbusClient.Disconnect();

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            modbusClient = new ModbusClient();
            modbusClient.Connect();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            ShowForm<ListProductsForm>();
        }

        private void btn_Cables_Click(object sender, EventArgs e)
        {
            ShowForm<ListCablesForm>();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            ShowForm<ListUsersForm>();
        }
        
        private void ShowForm<T>() where T: Form
        {
          

            if (ActiveForms.ContainsKey(typeof(T)))
            {
                ChildForm = ActiveForms[typeof(T)];
                ChildForm.WindowState = FormWindowState.Normal;
                ChildForm.Activate();
            }
            else
            {
                ChildForm = Activator.CreateInstance<T>();
                ChildForm.MdiParent = this;
                ChildForm.FormClosed += form_FormClosed;
                ChildForm.Show();
                ActiveForms.Add(typeof(T), ChildForm);
            }
            
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            SetLanguage.SetChildFormLanguage(ChildForm, combo_Languages);
            ChildFormControls controls = new ChildFormControls();
           

            DesignUI.ChildFormButtonsDesign(ChildForm);
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void combo_Languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Language language = (Language)combo_Languages.SelectedItem;
            SetMainFormLanguage(language.TwistMainForm.Path);
            SetLanguage.SetChildFormLanguage(ChildForm, combo_Languages);
        }

        private void SetMainFormLanguage(string resourcePath)
        {

            ResXResourceReader rsxr = new ResXResourceReader(resourcePath);

            var allChild = Tools.GetAllControl(this);

            foreach (DictionaryEntry langInfo in rsxr)
            {

                foreach(Control childCtrl in allChild)
                {
                    if (string.Compare(langInfo.Key.ToString(), childCtrl.Name) == 0)
                    {
                        childCtrl.Text = langInfo.Value.ToString();
                        break;
                    }
                }

            }
        }

        //private void NewLocation()
        //{
        //    btn_X.Location = new Point(this.Width - (btn_X.Width + 10), 0);
        //    btn_Simge.Location = new Point(btn_X.Location.X - (btn_Simge.Width + 5), 0);
        //    combo_Languages.Location = new Point(this.Width - (combo_Languages.Width + 10), 45);
        //    pictureBox_EksonLogo.Location = new Point(0, Panel_LeftMenu.Height - pictureBox_EksonLogo.Height - 5);
        //}

        private void pictureBox_EksonLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ekson.com.tr/");
            
        }

        private void pictureBox_EksonLogo_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBox_EksonLogo, "www.ekson.com.tr");    
        }

       
        private void btn_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Simge_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
