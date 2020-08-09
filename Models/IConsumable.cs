using System;
using System.Collections.Generic;

namespace FifthOOP.Models {
    interface IConsumable {
        string Name { get; set; }
        int Calories { get; set; }
        bool IsSpicy { get; set; }
        bool IsSweet { get; set; }
        string GetInfo ();
    }
}