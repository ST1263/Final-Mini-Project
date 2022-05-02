using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectNS.Model;
using ProjectNS.Service;
using ProjectNS.ViewModel;
using System;

namespace ProjectNS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecallTypeController : Controller
    {
        private readonly RecallTypeService _recalltypeservice;
        public RecallTypeController(RecallTypeService recalltypeservice)
        {
            _recalltypeservice = recalltypeservice;
        }

        [HttpGet]
        [Route("RecallTypes")]
        public IActionResult RecallTypes()
        {
            try
            {
                var recalllist = _recalltypeservice.RecallTypes();
                return StatusCode(StatusCodes.Status200OK, recalllist);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Faild", Message = "Data Not Found!" });
            }
        }

        [HttpGet]
        [Route("RecallTypeById")]
        public IActionResult RecallTypeById(int RecallTypeId)
        {
            try
            {
                var recallType = _recalltypeservice.RecallTypeById(RecallTypeId);
                return StatusCode(StatusCodes.Status200OK, recallType);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Faild", Message = "Data Not Found!" });
            }
        }

        [HttpPost]
        [Route("AddRecallType")]
        public IActionResult AddRecallType([FromBody] RecallTypeVM recallType)
        {
           try
            {
                _recalltypeservice.AddRecallType(recallType);
                return StatusCode(StatusCodes.Status200OK, new Response { Status = "Success", Message = "Details Added Successfully!" });
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Faild", Message = "Data Not Found!" });
            }
        }

        [HttpPut]
        [Route("UpdateRecallType")]
        public IActionResult UpdateRecallType(RecallTypeVM recallType)
        {
            try
            {
                _recalltypeservice.UpdateRecallType(recallType);
                return StatusCode(StatusCodes.Status200OK, new Response { Status = "Success", Message = "Details Added Successfully!" });
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Faild", Message = "Data Not Found!" });
            }
        }

        [HttpDelete]
        [Route("DeleteRecallType/{RecallTypeId}")]
        public IActionResult DeleteRecallType(int RecallTypeId)
        {
            try
            {
                _recalltypeservice.DeleteRecallType(RecallTypeId);
                return StatusCode(StatusCodes.Status200OK, new Response { Status = "Success", Message = "Details Added Successfully!" });
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Faild", Message = "Data Not Found!" });
            }
        }
    }
}
