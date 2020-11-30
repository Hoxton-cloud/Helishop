using Helishop.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helishop.ViewModels
{
    public class HelicoptersListViewModel
    {
        public IEnumerable<Helicopter> getAllHelicopters { get; set; }

        public string currentCategory { get; set; }
    }
}
