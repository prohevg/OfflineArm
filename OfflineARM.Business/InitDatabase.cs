using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OfflineARM.Business.Dictionaries;
using OfflineARM.Business.Dictionaries.Interfaces;
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
            
            for (int i = 0; i < 50; i++)
            {
                var newNomencl = new NomenclatureModel
                {
                    Guid = Guid.NewGuid()
                };
                newNomencl.Name = "Диван_" + newNomencl.Guid.ToString().Substring(0, 4);

                newNomencl.Childs = new List<INomenclatureModel>();
                for (int j = 0; j < 2; j++)
                {
                    var childNomencl = new NomenclatureModel
                    {
                        Guid = Guid.NewGuid()
                    };
                    childNomencl.Name = newNomencl.Name + "_Inner_" + childNomencl.Guid.ToString().Substring(0, 4);
                    newNomencl.Childs.Add(childNomencl);
                }

                var resModify = imp.Insert(newNomencl);
                newNomencl.Id = resModify.NewId;
                
                AddCharact(newNomencl);
            }
        }

        private void AddCharact(INomenclatureModel nomecModel)
        {
            var imp = IoCBusiness.Instance.Get<ICharacteristicImp>();

            for (int i = 0; i < 3; i++)
            {
                var guid = Guid.NewGuid();
                var newCharact = new CharacteristicModel()
                {
                    Guid = guid,
                    Nomenclature = nomecModel,
                    Name = "Характер_" + guid.ToString().Substring(0, 4),
                    Price = 100
                };

                imp.Insert(newCharact);
            }
        }
    }
}
