using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joels_Rom_Tools.Tags
{
    public interface ITag
    {
    }

    public interface IPS3 : ITag { }
    public interface IPSX : ITag { }
    public interface IPS2 : ITag { }
}
