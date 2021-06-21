using DAL;
using Model;
using System;
using BLL;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial class NghiPhepBusiness : INghiPhepBusiness
    {
        private INghiPhepRepository _res;
        public NghiPhepBusiness(INghiPhepRepository res)
        {
            _res = res;
        }
        public bool Create(NghiPhepModel model)
        {
            return _res.Create(model);
        }
        public List<NghiPhepModel> GetDataDate(string date)
        {
            return _res.GetDataDate(date);
        }
    }
}
