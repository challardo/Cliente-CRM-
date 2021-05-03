using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cliente;
namespace Cliente__CRM_
{
    public interface IObserver
    {
        
        void update(ConexionTcp conexionTcp);
    }
}
