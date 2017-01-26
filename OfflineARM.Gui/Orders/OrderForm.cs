using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using OfflineARM.Gui.Base;

namespace OfflineARM.Gui.Orders
{
    public partial class OrderForm : BaseForm
    {
        List<Client> _operators = new List<Client>();

        List<Client> _clients = new List<Client>();

        List<Tovar> _tovar = new List<Tovar>();

        public OrderForm()
        {
            InitializeComponent();

            _operators.Add(new Client()
            {
                Id = 0,
                Name = "Введите ответственного...",
                Address = ""
            });

            _operators.Add(new Client()
            {
                Id = 1,
                Name = "Админ",
            });

            _operators.Add(new Client()
            {
                Id = 2,
                Name = "Иванова",
            });

            buttonEdit3.Properties.DataSource = _operators;
            buttonEdit3.EditValue = 0;


            _clients.Add(new Client()
            {
                Id = 0,
                Name = "Введите клиента...",
                Address = ""
            });

            _clients.Add(new Client()
            {
                Id = 1,
                Name = "Иванов",
                Address = "г. Саратов, ул Ульяновская д28"
            });

            _clients.Add(new Client()
            {
                Id = 2,
                Name = "Петров Иван Иваныч",
                Address = "г. Энгельс, ул Саратовская д1"
            });

            buttonEdit1.Properties.DataSource = _clients;
            buttonEdit1.ButtonClick += ButtonEdit1_ButtonClick;



            _tovar.Add(new Tovar()
            {
                Name = "Диван",
                Count = 2,
                Price = "20000",
                Descrs = new List<Descr>()
                {
                    new Descr()
                    {
                        Name = "Красный"
                    }
                }
            });

            _tovar.Add(new Tovar()
            {
                Name = "Rhjdfnm",
                Count = 1,
                Price = "10000",
                Descrs = new List<Descr>()
                {
                    new Descr()
                    {
                        Name = "Широкая"
                    }
                }
            });

            gridControl1.DataSource = _tovar;
        }

        private void ButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                MessageBox.Show("Открывается форма создания клиента");
            }
            else if (e.Button.Kind == ButtonPredefines.Close)
            {
                buttonEdit1.EditValue = 0;
            }
        }

        private void buttonEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (buttonEdit1.GetSelectedDataRow() != null)
            {
                buttonEdit2.Text = (buttonEdit1.GetSelectedDataRow() as Client).Address;
            }
        }

        private void buttonEdit1_Properties_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
           // LookUpEdit lookupEdit = sender as LookUpEdit;
           //// if (buttonEdit1.Properties.DataSource == null)
           // {
           //     e.DisplayText = "YourText";
           // }
        }
    }


    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }

    public class Tovar
    {
        public string Name { get; set; }

        public int Count { get; set; }

        public string Price { get; set; }

        public List<Descr> Descrs { get; set; }
    }

    public class Descr
    {
        public string Name { get; set; }

    }
}
