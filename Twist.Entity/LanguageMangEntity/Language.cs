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
        public FormInfo ProductsForm { get; set; }
        public FormInfo CablesForm { get; set; }
        public FormInfo UsersForm { get; set; }
      
        public override string ToString()
        {
            return Name;
        }

        public IEnumerator<FormInfo> GetEnumerator()
        {
            
            yield return TwistMainForm;
            yield return ProductsForm;
            yield return CablesForm;
            yield return UsersForm;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
