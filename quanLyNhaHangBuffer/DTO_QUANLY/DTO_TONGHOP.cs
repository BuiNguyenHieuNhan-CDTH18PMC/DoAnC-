﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLY
{
    public class DTO_TONGHOP
    {
        private string mahd;
        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        public DTO_TONGHOP(string ma) 
        {
            this.mahd = ma;
        }
    }
}
