using BLL;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NghiPhepController : Controller
    {
        private INghiPhepBusiness _nghiphepBusiness;
        public NghiPhepController(INghiPhepBusiness nghiphepBusiness)
        {
            _nghiphepBusiness = nghiphepBusiness;
        }
        [Route("create-nghi-phep")]
        [HttpPost]
        public NghiPhepModel Create([FromBody] NghiPhepModel model)
        {
            _nghiphepBusiness.Create(model);
            return model;
        }
        [Route("get-by-date/{date}")]
        [HttpGet]
        public IEnumerable<NghiPhepModel> GetDatabyDate(string date)
        {
            return _nghiphepBusiness.GetDataDate(date);
        }
    }
}
