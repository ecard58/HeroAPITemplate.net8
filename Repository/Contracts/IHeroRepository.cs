using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IHeroRepository
    {
        Task<Hero> InsertHero(Hero hero);
    }
}
