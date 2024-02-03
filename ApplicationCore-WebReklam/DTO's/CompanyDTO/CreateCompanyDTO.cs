﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore_WebReklam.DTO_s.CompanyDTO
{
    public class CreateCompanyDTO
    {
        [Required(ErrorMessage = "Şirket adı zorunludur..")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Konum { get; set; }
    }
}
