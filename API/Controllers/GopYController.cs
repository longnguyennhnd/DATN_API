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
    public class GopYController : Controller
    {
        private IGopYBusiness _gopyBusiness;
        public GopYController(IGopYBusiness gopyBusiness)
        {
            _gopyBusiness = gopyBusiness;
        }
        [Route("create-gop-y")]
        [HttpPost]
        public GopYModel Create([FromBody] GopYModel model)
        {
            _gopyBusiness.Create(model);
            return model;
        }

        [Route("get-all")]
        [HttpGet]
        public IEnumerable<GopYModel> GetDatabAll()
        {
            return _gopyBusiness.GetDataAll();
        }

        [Route("create-thong-bao")]
        [HttpPost]
        public ThongBaoModel CreateNoti([FromBody] ThongBaoModel model)
        {
            _gopyBusiness.CreateNoti(model);
            return model;
        }

        [Route("get-all-thong-bao")]
        [HttpGet]
        public IEnumerable<ThongBaoModel> GetAllNoti()
        {
            return _gopyBusiness.GetAllNoti();
        }

        //[Route("delete-lop-hoc")]
        //[HttpPost]
        //public IActionResult DeleteUser([FromBody] Dictionary<string, object> formData)
        //{
        //    int id;
        //    //if (formData.Keys.Contains("id") && !string.IsNullOrEmpty(Convert.ToString(formData["id"]))) { id = Convert.ToString(formData["id"]); }
        //    _gopyBusiness.Delete(id);
        //    return Ok();
        //}
        [Route("get-by-id/{id}")]
        [HttpGet]
        public ThongBaoModel GetDatabyID(int id)
        {
            return _gopyBusiness.GetDatabyID(id);
        }

        [Route("update-lop-hoc")]
        [HttpPost]
        public ThongBaoModel UpdateUser([FromBody] ThongBaoModel model)
        {
            _gopyBusiness.Update(model);
            return model;
        }
    }
}
