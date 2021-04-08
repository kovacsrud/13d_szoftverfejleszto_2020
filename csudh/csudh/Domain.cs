using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csudh
{
    public class Domain
    {
        public string DomainName { get; set; }
        public string IpAddress { get; set; }

        public Domain(string sor,char hatarolo)
        {
            var e = sor.Split(hatarolo);
            DomainName = e[0];
            IpAddress = e[1];
        }

        public string DomainLevel(int level)
        {
            var levels = DomainName.Split('.');

            //???
        }
    }
}
