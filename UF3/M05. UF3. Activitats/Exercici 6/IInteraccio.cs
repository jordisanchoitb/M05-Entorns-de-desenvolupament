using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public interface IInteraccio
    {
        bool Deposita(float quantitat);
        bool Extreura(float quantitat);
    }
}
