using System;
using System.Threading.Tasks;
using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.Dictionaries.Interfaces;
using OfflineARM.Business.Models.Businesses;
using OfflineARM.Business.Models.Dictionaries;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.Repositories;

namespace OfflineARM.Business
{
    public class InitDatabase
    {
        public void Init()
        {
            Task.Factory.StartNew(AddNomencl);
        }

        private void AddNomencl()
        {
            using (var unit = new UnitOfWork())
            {
                var rep = unit.DictionaryRepositories.NomenclatureRepository;
                if (rep.Count() > 0)
                {
                    return;
                }
            }

            var imp = IoCBusiness.Instance.Get<INomenclatureImp>();

            for (int i = 0; i < 10; i++)
            {
                var mainGuid = Guid.NewGuid();
                var newNomencl = new NomenclatureModel
                {
                    Guid = mainGuid,
                    Name = "Диван_" + mainGuid.ToString().Substring(0, 4)
                };
                var resMainModify = imp.Insert(newNomencl);
                newNomencl.Id = resMainModify.NewId;


                for (int j = 0; j < 2; j++)
                {
                    var childGuid = Guid.NewGuid();
                    var childNomencl = new NomenclatureModel
                    {
                        Guid = childGuid,
                        Parent = newNomencl
                    };
                    childNomencl.Name = newNomencl.Name + "_Inner_" + childGuid.ToString().Substring(0, 4);

                    var resChildModify = imp.Insert(childNomencl);
                    childNomencl.Id = resChildModify.NewId;

                    AddCharact(childNomencl);
                }               
            }
        }

        private void AddCharact(INomenclatureModel nomecModel)
        {
            var imp = IoCBusiness.Instance.Get<IFeatureImp>();

            for (int i = 0; i < 3; i++)
            {
                var guid = Guid.NewGuid();
                var newCharact = new FeatureModel()
                {
                    Guid = guid,
                    Nomenclature = nomecModel,
                    Name = "Характер_" + guid.ToString().Substring(0, 4),
                    Price = 100,
                };

                var resChildModify = imp.Insert(newCharact);
                newCharact.Id = resChildModify.NewId;

                AddExposit(newCharact);
            }
        }

        private void AddExposit(IFeatureModel charModel)
        {
            var imp = IoCBusiness.Instance.Get<IExpositionImp>();

            for (int i = 0; i < 2; i++)
            {
                var guid = Guid.NewGuid();
                var newExpo = new ExpositionModel()
                {
                    Guid = guid,
                    Nomenclature = charModel.Nomenclature,
                    Characteristic = charModel,
                    IsEnabled = i == 1,
                    Count = i,
                    Price = 100
                };

                imp.Insert(newExpo);
            }
        }
    }
}
