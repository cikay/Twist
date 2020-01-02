using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twist.Entity.LanguageMangEntity
{
    public class Language: IEnumerable<FormInfo>
    {
        public string Name { get; set; }
        public FormInfo TwistMainForm { get; set; }
        public FormInfo ListProductsForm { get; set; }
        public FormInfo ListCablesForm { get; set; }
        public FormInfo ListUsersForm { get; set; }
        public FormInfo AddProductForm { get; set; }
        public FormInfo AddCableForm { get; set; }
        public FormInfo AddUserForm { get; set; }

        public override string ToString()
        {
            return Name;
        }


        public IEnumerator<FormInfo> GetEnumerator()
        {
            
            yield return TwistMainForm;
            yield return ListProductsForm;
            yield return ListCablesForm;
            yield return ListUsersForm;
            yield return AddProductForm;
            yield return AddCableForm;
            yield return AddUserForm;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
