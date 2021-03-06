﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataAccess.Models.Baga
{
    [ComplexType]
    public class PersonalInfo
    {
        public Measurement Weight { get; set; }

        public Measurement Height { get; set; }

        public string DietryRestrictions { get; set; }
    }
}
