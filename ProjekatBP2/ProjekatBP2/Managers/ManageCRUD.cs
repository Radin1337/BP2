using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBP2.Managers
{
    public class ManageCRUD
    {
        public ServisCRUD ServisCRUD { get; set; }
        public AutomobilCRUD AutomobilCRUD { get; set; }
        public ServiserCRUD ServiserCRUD { get; set; }
        public PopravljenCRUD PopravljenCRUD { get; set; }
        public PokvarenCRUD PokvarenCRUD { get; set; }
        public PregledCRUD PregledCRUD { get; set; }
        public DeoCRUD DeoCRUD { get; set; }
        public MajstorZaCRUD MajstorZaCRUD { get; set; }

        public ManageCRUD(ServisDBMFContainer dbContext)
        {
            ServisCRUD = new ServisCRUD(dbContext);
            AutomobilCRUD = new AutomobilCRUD(dbContext);
            ServiserCRUD = new ServiserCRUD(dbContext);
            PopravljenCRUD = new PopravljenCRUD(dbContext);
            PokvarenCRUD = new PokvarenCRUD(dbContext);
            PregledCRUD = new PregledCRUD(dbContext);
            DeoCRUD = new DeoCRUD(dbContext);
            MajstorZaCRUD = new MajstorZaCRUD(dbContext);
        }


    }
}
