using Bootcamp.Model;
using Bootcamp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Repository
{
    public interface IPersonRepository
    {
        Task<int> Create(Person person);
        Task<IEnumerable<PersonViewModel>> GetAll();
        Task<int> Update(Person person);
        Task<IEnumerable<PersonViewModel>> Delete();
    }
}
