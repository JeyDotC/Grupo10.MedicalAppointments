using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo10.Mvc
{
    internal interface IReturnData<T>
    {
        T Data { get; }
    }
}
