using System;
using System.Linq;
using System.Windows.Forms;
using OfflineARM.DAO.Entities.Dictionaries;
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

                //var rrr = rep.DictionaryRepositories.CityRepository.GetAll().ToList();




                rep.DictionaryRepositories.CityRepository.Insert(new City()
                {
                    //Id = 1,
                    //Guid = Guid.Parse("FFFD820E-1A39-4C99-B610-D6BCF286C3DB"),//Guid.NewGuid(),
                    Name = "name"
                });
                rep.Save();
            }
            catch (Exception e1)
            {
                throw;
            }


            base.OnLoad(e);
        }
    }
}
