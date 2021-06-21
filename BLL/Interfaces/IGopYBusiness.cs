using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface IGopYBusiness
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
