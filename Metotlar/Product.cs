﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Fiyati { get; set; }
        public string Aciklama { get; set; }

        public int StokAdedi { get; set; }
    }
}