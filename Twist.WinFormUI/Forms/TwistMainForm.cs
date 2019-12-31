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
            NewLocation();
            combo_Languages.Text = "Change Language";

            Language Turkish = new Language {
                Name = "Turkish",
                TwistMainForm = new FormInfo {
                    FormName = "TwistMainForm",
                    Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/Turkish/TwistMainForm.Turkish.resx",
                },

                ProductsForm = new FormInfo {
                    FormName = "ListProductsForm",
                    Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/Turkish/TwistProductsForm.Turkish.resx",
                },

                CablesForm = new FormInfo {
                    FormName = "ListCablesForm",
                    Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/Turkish/TwistCablesForm.Turkish.resx",
                },
                UsersForm = new FormInfo {
                    FormName = "ListUsersForm",
                    Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/Turkish/TwistUsersForm.Turkish.resx",
                },
            };

            Language English = new Language {
                Name = "English",
                TwistMainForm = new FormInfo
                {
                    FormName="TwistMainForm",
                    Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/English/TwistMainForm.English.resx",
                },

                ProductsForm = new FormInfo {
                    FormName = "ListProductsForm",
                    Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/English/TwistProductsForm.English.resx",
                },
                CablesForm = new FormInfo {
                    FormName= "ListCablesForm",
                    Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/English/TwistCablesForm.English.resx",
                },
                UsersForm = new FormInfo {
                    FormName= "ListUsersForm",
                    Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/English/TwistUsersForm.English.resx",
                },

            };

            combo_Languages.Items.Add(Turkish);
            combo_Languages.Items.Add(English);
            SetLanguage(Turkish.TwistMainForm.Path);
        }

        private void pictureB_MiniBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureB_FullScreenBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureB_XBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
            ChildForm.SetBounds(0, 0, this.Width, this.Height);
            Language language = (Language)combo_Languages.SelectedItem;

            SetChildFormLanguage(ChildForm);
           

        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void combo_Languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Language language = (Language)combo_Languages.SelectedItem;

            SetLanguage(language.TwistMainForm.Path);
            SetChildFormLanguage(ChildForm);
            
        }

        private void SetLanguage(string resourcePath)
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

    
        private bool SetChildFormLanguage(Form form)
        {
            Language language = (Language)combo_Languages.SelectedItem;
            if (form == null || language==null) return false;
            ResXResourceReader rsxr = null;
            foreach (var info in language)
            {
                if (string.Compare(form.Name, info.FormName) == 0)
                {
                    rsxr = new ResXResourceReader(info.Path);
                    break;
                }
            }


            foreach (Control control in form.Controls)
            {
                foreach (DictionaryEntry langInfo in rsxr)
                {
                    if(control is ListView)
                    {
                        ListView listView = (ListView)control;

                        foreach(ColumnHeader column in listView.Columns)
                        {
                            if(string.Compare(column.Tag.ToString(), langInfo.Key.ToString()) == 0 )
                            {
                                column.Text = langInfo.Value.ToString();
                            }
                        }
                    }
                    
                }
            }

            return true;

        }

        private void NewLocation()
        {
            pictureB_XBtn.Location = new Point(this.Width - (pictureB_XBtn.Width + 10), 5);
            pictureB_FullScreenBtn.Location = new Point(pictureB_XBtn.Location.X - (pictureB_FullScreenBtn.Width + 5), 5);
            pictureB_MiniBtn.Location = new Point(pictureB_FullScreenBtn.Location.X - (pictureB_MiniBtn.Width + 5), 5);
            combo_Languages.Location = new Point(this.Width - (combo_Languages.Width + 10), 30);

            pictureBox_EksonLogo.Location = new Point(0, Panel_LeftMenu.Height - pictureBox_EksonLogo.Height - 5);
        }

        private void pictureBox_EksonLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ekson.com.tr/");
            
        }

        private void pictureBox_EksonLogo_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBox_EksonLogo, "www.ekson.com.tr");    
        }       
    }
}
