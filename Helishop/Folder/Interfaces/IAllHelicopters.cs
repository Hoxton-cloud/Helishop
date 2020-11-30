using Helishop.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helishop.Folder.Interfaces
{
    public interface IAllHelicopters
    {
        IEnumerable<Helicopter> Helicopters { get; }
        Helicopter getObjectHelicopter(int helicopterID);
    }
}
