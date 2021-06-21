using DAL.Helper;
using DAL.Helper.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class NghiPhepRepository : INghiPhepRepository
    {
        private IDatabaseHelper _dbHelper;
        public NghiPhepRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public bool Create(NghiPhepModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "nghi_phep_create",
                "@MaHS", model.HocSinhID,
                "@LiDo", model.Lido,
                "@NgayXinNghi", model.NgayXinNghi,
                "@TenHS", model.TenHS,
                "@HoTenCha", model.HoTenCha);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<NghiPhepModel> GetDataDate(string date)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "hoc_sinh_by_date", "@date", date);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<NghiPhepModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
