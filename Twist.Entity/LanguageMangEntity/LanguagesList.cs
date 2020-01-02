using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twist.Entity.LanguageMangEntity
{
    public class LanguagesList:IEnumerable<Language>
    {
        Language Turkish = new Language
        {
            Name = "Turkish",
            TwistMainForm = new FormInfo
            {
                FormName = "TwistMainForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/Turkish/Twist.MainForm.Turkish.resx",
            },

            ListProductsForm = new FormInfo
            {
                FormName = "ListProductsForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/Turkish/Twist.ListProductsForm.Turkish.resx",
            },

            ListCablesForm = new FormInfo
            {
                FormName = "ListCablesForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/Turkish/Twist.ListCablesForm.Turkish.resx",
            },
            ListUsersForm = new FormInfo
            {
                FormName = "ListUsersForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/Turkish/Twist.ListUsersForm.Turkish.resx",
            },
            AddProductForm = new FormInfo
            {
                FormName = "AddProductForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/Turkish/Twist.AddProductForm.Turkish.resx",
            },

            AddCableForm = new FormInfo
            {
                FormName = "AddCableForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/Turkish/Twist.AddCableForm.Turkish.resx",
            },
            AddUserForm = new FormInfo
            {
                FormName = "AddUserForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/Turkish/Twist.AddUserForm.Turkish.resx",
            },
        };

        Language English = new Language
        {
            Name = "English",
            TwistMainForm = new FormInfo
            {
                FormName = "TwistMainForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/English/Twist.MainForm.English.resx",
            },

            ListProductsForm = new FormInfo
            {
                FormName = "ListProductsForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/English/Twist.ListProductsForm.English.resx",
            },
            ListCablesForm = new FormInfo
            {
                FormName = "ListCablesForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/English/Twist.ListCablesForm.English.resx",
            },

            ListUsersForm = new FormInfo
            {
                FormName = "ListUsersForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/English/Twist.ListUsersForm.English.resx",
            },

            AddProductForm = new FormInfo
            {
                FormName = "AddProductForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/English/Twist.AddProductForm.English.resx",
            },
            AddCableForm = new FormInfo
            {
                FormName = "AddCableForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/English/Twist.AddCableForm.English.resx",
            },
            AddUserForm = new FormInfo
            {
                FormName = "AddUserForm",
                Path = "E:/Yazılım projeleri/Twist/Twist.WinFormUI/Resources/English/Twist.AddUserForm.English.resx",
            },

        };

        public IEnumerator<Language> GetEnumerator()
        {
            yield return Turkish;
            yield return English;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
