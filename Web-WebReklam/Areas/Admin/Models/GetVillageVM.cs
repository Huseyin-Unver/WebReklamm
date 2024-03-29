﻿using ApplicationCore_WebReklam.Entities.Abstract;

namespace Web_WebReklam.Areas.Admin.Models
{
    public class GetVillageVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Status Status { get; set; }
    }
}
