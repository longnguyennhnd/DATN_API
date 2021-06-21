using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface INghiPhepBusiness
    {
        bool Create(NghiPhepModel model);
        List<NghiPhepModel> GetDataDate(string date);
    }
}
