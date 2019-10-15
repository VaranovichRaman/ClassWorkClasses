using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkClasses.Models
{
    public class Weapon
    {
        public WeaponType TypeOfWeapon { get; set; }
        public WeaponSize SizeOfWeapon { get; set; }
        public WeaponMaterial MaterialOfWeapon { get; set; }
    }
}
