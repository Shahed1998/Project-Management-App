using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo <TClass, TReturn>
    {
        TReturn Add(TClass @class);

        List<TClass> Get();

        TClass Get(int id);


        TReturn Update(TClass @class);

        TReturn Delete(int id);

    }
}
