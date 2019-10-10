using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWorkClasses.Models;
using WeaponSize;
using WeaponMaterial;
using WeaponType;

namespace ClassWorkClasses.Extensions
{
        public static class Weapons
    {
        public WeaponSize Size { get; set; }
        public WeaponType Type { get; set; }
        public WeaponMaterial Material { get; set; }
    }
}
