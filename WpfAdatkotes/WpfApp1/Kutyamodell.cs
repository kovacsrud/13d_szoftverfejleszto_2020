using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Kutyamodell
    {
        public KutyafajtaLista kutyafajtalista { get; }
        public KutyanevLista kutyanevlista { get; }

        public Kutyamodell()
        {
            kutyafajtalista = new KutyafajtaLista("kutyafajtak.csv");
            kutyanevlista = new KutyanevLista("Kutyanevek.csv");
        }

    }
}
