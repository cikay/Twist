using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twist.Entity.LanguageMangEntity;

namespace Twist.WinFormUI.Classes
{
    public class SetLanguage
    {
        public static bool SetChildFormLanguage(Form form, ComboBox comboBox_Languages)
        {
            Language language = (Language)comboBox_Languages.SelectedItem;
            int leftAlign;
            if (form == null || language == null) return false;
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
                    if (control is ListView)
                    {
                        ListView listView = (ListView)control;

                        foreach (ColumnHeader column in listView.Columns)
                        {
                            if (string.Compare(column.Tag.ToString(), langInfo.Key.ToString()) == 0)
                            {
                                column.Text = langInfo.Value.ToString();
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (string.Compare(control.Name, langInfo.Key.ToString()) == 0)
                        {
                            leftAlign = control.Width + control.Left;
                            control.Text = langInfo.Value.ToString();
                            control.Left = leftAlign - control.Width;
                            break;
                        }
                    }
                }
            }

            return true;

        }
    }
}
