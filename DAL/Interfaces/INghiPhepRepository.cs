using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
    public partial interface INghiPhepRepository
    {
        bool Create(NghiPhepModel model);
        List<NghiPhepModel> GetDataDate(string date);
    }
}
