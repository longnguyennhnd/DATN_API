using DAL;
using Model;
using System;
using BLL;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial class GopYBusiness : IGopYBusiness
    {
        private IGopYRespository _res;
        public GopYBusiness(IGopYRespository res)
        {
            _res = res;
        }
        public bool Create(GopYModel model)
        {
            return _res.Create(model);
        }
        public List<GopYModel> GetDataAll()
        {
            return _res.GetDataAll();
        }
        public bool CreateNoti(ThongBaoModel model)
        {
            return _res.CreateNoti(model);
        }
        public List<ThongBaoModel> GetAllNoti()
        {
            return _res.GetAllNoti();
        }
        public bool Update(ThongBaoModel model)
        {
            return _res.Update(model);
        }
        public bool Delete(int id)
        {
            return _res.Delete(id);
        }
        public ThongBaoModel GetDatabyID(int id)
        {
            return _res.GetDatabyID(id);
        }
    }
}
