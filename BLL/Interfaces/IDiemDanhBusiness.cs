using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface IDiemDanhBusiness
    {
        bool Create(DiemDanhModel model);
        bool Update(DiemDanhModel model);
        bool Delete(int id);
        DiemDanhModel GetDatabyID(int id);
        List<DiemDanhDate> GetDataAll();
        List<DiemDanhDate> GetDiemDanhByDate(string date, string malop, int TrangThai);
        List<DiemDanhModel> Search(int pageIndex, int pageSize, out long total, string monhoc, string buoi, string ngay);
    }
}

