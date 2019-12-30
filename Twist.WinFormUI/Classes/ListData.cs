using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twist.Entity;
using Twist.ORM;

namespace WindowsFormsApp1
{
    public class ListData
    {
        ModbusORMBASE modbusORMBASE = new ModbusORMBASE();
        public ListView List<T>(ListView listView)
        {
           
            Dictionary<int, T> dataCollection = modbusORMBASE.GetData<T>();
            if (dataCollection == null) return listView;
            foreach (KeyValuePair<int, T> keyValuePair in dataCollection)
            {
                T data = keyValuePair.Value;
                PropertyInfo[] Properties=typeof(T).GetProperties();
                ListViewItem lvi = new ListViewItem();
                string[] row = new string[dataCollection.Values.Count];
                
                Parameters parameters = (Parameters)Properties[0].GetValue(data);
                lvi.Text = parameters.Value;

                for(int i = 0; i < Properties.Length; ++i)
                {
                    parameters = (Parameters)Properties[i].GetValue(data);
                    lvi.SubItems.Add(parameters.Value);
                }
                listView.Items.Add(lvi);

            }
            return listView;
        }

        
    }
}
