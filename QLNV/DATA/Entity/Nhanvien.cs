using DATA.Entity;
using DATA.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DATA.Entity
{
    public class Nhanvien
    {
        public int Id { get; set; }

        public string CV { get; set; }
        public string Ten { get; set; }
        public DateTime Ngaysinhh { get; set; }
        public string Diachi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public int ChucvuId { get; set; }
        public Chucvu Chucvu { get; set; }

        public int VitriId { get; set; }
        public Vitri Vitri { get; set; }

        public int Nguoigioithieu { get; set; }

        public bool isApply { get; set; }

        public ETrangthai Trangthai { get; set; }
        public string Lydoloai { get; set; }
    }
}
