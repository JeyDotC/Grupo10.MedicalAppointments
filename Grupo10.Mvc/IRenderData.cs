using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo10.Mvc
{
    public interface IRenderData<T>
    {
        void RenderData(T data);
    }
}
