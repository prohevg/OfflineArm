using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfflineARM.Gui
{
    public partial class MainForm : Form
    {
        private readonly List<Order> _orders = new List<Order>();

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.Text = GuiResource.MainForm_Caption;
            base.OnLoad(e);

            LoadDictionary();

            btnOrder_Click(null, e);
        }

        private bool _isLoadDictionary;
        private void LoadDictionary()
        {
            if (_isLoadDictionary)
            {
                return;
            }

            _isLoadDictionary = true;
            pbLoadDictionary.Visible = true;
            slLoadDictionary.Visible = true;

            Task.Factory.StartNew(() =>
            {
                string messCont = ".";
                for (int i = 0; i < 101; i++)
                {
                    if (messCont.Length > 3)
                    {
                        messCont = ".";
                    }

                    string dictName;
                    if (i < 33)
                    {
                        dictName = "Города";
                    }
                    else if (i >33 && i <66)
                    {
                        dictName = "Номенклатура";
                    }
                    else
                    {
                        dictName = "Другие данные";
                    }
                    string mess = $"Обновляются: \"{dictName}\"{messCont}";

                    this.Invoke((MethodInvoker)delegate {
                        pbLoadDictionary.Value = i;
                        slLoadDictionary.Text = mess;
                    });
                    pbLoadDictionary.Value = i;
                    Thread.Sleep(250);

                    messCont += ".";
                }

                this.Invoke((MethodInvoker)delegate {
                    pbLoadDictionary.Visible = false;
                    slLoadDictionary.Text = "Справочники успешно обновлены";
                });

                Thread.Sleep(3000);

                this.Invoke((MethodInvoker)delegate {
                    slLoadDictionary.Visible = false;
                });

                _isLoadDictionary = false;
            });
        }

        private void tsmProxy_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmUpdateDictionaries_Click(object sender, EventArgs e)
        {
            LoadDictionary();
        }

        private void tsmChangeUser_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm { ShowInTaskbar = false };
            if (loginForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void tsmAboutProgram_Click(object sender, EventArgs e)
        {
            var aboutBoxProgram = new AboutBoxProgram();
            aboutBoxProgram.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.Aqua;
            btnExpo.BackColor = mMenu.BackColor;
            button1.Visible = true;
            button2.Visible = true;
            dataGridView1.Visible = true;
        }

        private void btnExpo_Click(object sender, EventArgs e)
        {
            btnExpo.BackColor = Color.Aqua;
            btnOrder.BackColor = mMenu.BackColor;
            button1.Visible = false;
            button2.Visible = false;
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newOrder = new Order()
            {
                Date = DateTime.Now,
                Number = "Номер 1" + _orders.Count + 1,
                Status = "Создан",
                Fio = Guid.NewGuid().ToString()
            };

            _orders.Add(newOrder);

            dataGridView1.DataSource = _orders;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_orders.Count == 0)
            {
                return;
            }
            var orderForm = new OrderForm();
            orderForm.Init(_orders[0]);
            orderForm.ShowInTaskbar = false;
            orderForm.Show();
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }

    public class Order
    {
        public DateTime Date { get; set; }

        public string Number { get; set; }

        public string Status { get; set; }

        public string Fio { get; set; }
    }

}
