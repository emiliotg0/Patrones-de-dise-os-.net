using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Shalloq
{
    public class Animal : ICloneable
    {
        public int Patas { get; set; }

        public string nombre { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
