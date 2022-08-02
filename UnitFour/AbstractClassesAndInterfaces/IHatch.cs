using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces
{
    public interface IHatch
    {
        bool HatchIsOpen { get; set; }

        void OpenHatch();
    }
}
