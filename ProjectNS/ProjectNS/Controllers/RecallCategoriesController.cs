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
    public class RecallCategoriesController : Controller
    {
        private readonly RecallCategoriesService _recallcategoriesservice;
        public RecallCategoriesController(RecallCategoriesService recallcategoriesservice)
        {
            _recallcategoriesservice = recallcategoriesservice;
        }

        [HttpGet]
        [Route("RecallCategories")]
        public IActionResult RecallCategories()
        {
            try
            {
                var recallcategorieslist = _recallcategoriesservice.RecallCategories();
                return StatusCode(StatusCodes.Status200OK, recallcategorieslist);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Faild", Message = "Data Not Found!" });
            }
        }

        [HttpGet]
        [Route("RecallCategoriesById")]
        public IActionResult RecallCategoriesById(int RecallCategoriesId)
        {
            try
            {
                var recallcategorie = _recallcategoriesservice.RecallCategoriesById(RecallCategoriesId);
                return StatusCode(StatusCodes.Status200OK, recallcategorie);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Faild", Message = "Data Not Found!" });
            }
        }

        [HttpPost]
        [Route("AddRecallCategories")]
        public IActionResult AddRecallCategories([FromBody] RecallCategoriesVM recallCategories)
        {
            try
            {
                _recallcategoriesservice.AddRecallCategories(recallCategories);
                return StatusCode(StatusCodes.Status200OK, new Response { Status = "Success", Message = "Details Added Successfully!" });
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Faild", Message = "Data Not Found!" });
            }
        }

        [HttpPut]
        [Route("UpdateRecallCategories")]
        public IActionResult UpdateRecallCategories(RecallCategoriesVM recallCategories)
        {
            try
            {
                _recallcategoriesservice.UpdateRecallCategories(recallCategories);
                return StatusCode(StatusCodes.Status200OK, new Response { Status = "Success", Message = "Details Updated Successfully!" });
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Faild", Message = "Data Not Found!" });
            }
        }

        [HttpDelete]
        [Route("DeleteRecallCategories/{RecallCategoriesId}")]
        public IActionResult DeleteRecallCategories(int RecallCategoriesId)
        {
            try
            {
                _recallcategoriesservice.DeleteRecallCategories(RecallCategoriesId);
                return StatusCode(StatusCodes.Status200OK, new Response { Status = "Success", Message = "Details Deleted Successfully!" });
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Faild", Message = "Data Not Found!" });
            }
        }
    }
}
