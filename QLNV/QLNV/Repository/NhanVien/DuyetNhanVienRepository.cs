using DATA.Entity;
using Microsoft.EntityFrameworkCore;
using QLNV.Interface.NhanVien;
using QLNV.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Repository.NhanVien
{
    public class DuyetNhanVienRepository :BaseRepository,IDuyetNhanVienRepository
    {
        public bool DuyetCv(int id)
        {
            try
            {
                var data = base._context.Nhanviens.Where(x => x.Id == id).FirstOrDefault();
                data.Trangthai = DATA.Enum.ETrangthai.DuyetCV;
                base._context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<List<DuyetNhanVienViewModel>> GetAll()
        {
            var data = from x in base._context.Nhanviens
                       join c in _context.Chucvus on x.ChucvuId equals c.Id
                       join v in _context.Vitris on x.VitriId equals v.Id
                       where x.Trangthai == DATA.Enum.ETrangthai.NhanCV
                       select new DuyetNhanVienViewModel
                       {
                           Id=x.Id,
                           Tenchucvu = c.Tenchucvu,
                           Tenvitri = v.Tenvitri,
                           Ten=x.Ten,
                           Ngaysinhh=x.Ngaysinhh,
                           Diachi=x.Diachi,
                           Nguoigioithieu = _context.Nhanviens.Where(a => a.Id == x.Nguoigioithieu).FirstOrDefault().Ten,
                           isApply=x.isApply,
                           CV=x.CV,
                           VitriID=x.VitriId,
                           ChucvuID=x.ChucvuId
                       };
            return await data.ToListAsync();
        }

        public bool LoaiCv(int id)
        {
            try
            {
                var data = base._context.Nhanviens.Where(x => x.Id == id).FirstOrDefault();
                data.Trangthai = DATA.Enum.ETrangthai.LoaiCV;
                data.Lydoloai = "CV Không đạt yêu cầu";
                base._context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
