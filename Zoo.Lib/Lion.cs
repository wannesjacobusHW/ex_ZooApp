﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Lib
{
    public enum Sex { F, M };
    /// <summary>
    /// this class describes a lion: very dangerous animal
    /// </summary>
    public class Lion
    {  
        public Sex Sex { get; set; }
        public string Name { get; set; }

        public Lion(string name, Sex sex)
        {
            Name = name;
            Sex = sex;
        }
    }
}
