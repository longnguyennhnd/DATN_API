using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
    public partial interface IGopYRespository
    {
        bool Create(GopYModel model);
        List<GopYModel> GetDataAll();
        bool CreateNoti(ThongBaoModel model);
        List<ThongBaoModel> GetAllNoti();
        bool Update(ThongBaoModel model);
        bool Delete(int id);
        ThongBaoModel GetDatabyID(int id);
    }
}
