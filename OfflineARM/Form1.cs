using System;
using System.Windows.Forms;
using OfflineARM.DAO.Entities;
using OfflineARM.Repositories;

namespace OfflineARM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                var rep = new UnitOfWork();
                rep.CityRepository.Insert(new City()
                {
                    //Id = 1,
                    Guid = Guid.NewGuid(),
                    Name = "name"
                });
                rep.Save();
            }
            catch (Exception)
            {
                
                throw;
            }


            base.OnLoad(e);
        }
    }
}
