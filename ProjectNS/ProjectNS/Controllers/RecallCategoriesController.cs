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
        readonly RecallCategoriesService _recallcategoriesservice;
        public RecallCategoriesController(RecallCategoriesService recallcategoriesservice)
        {
            _recallcategoriesservice = recallcategoriesservice;
        }

        [HttpGet]
        [Route("GetRecallCategories")]
        public IActionResult GetRecallCategories()
        {
            var allrecallcategories = _recallcategoriesservice.GetRecallCategories();
            return Ok(allrecallcategories);
        }

        [HttpGet]
        [Route("GetRecallCategoriesById")]
        public IActionResult GetRecallCategoriesById(int RecallCategoriesId)
        {
            var result = _recallcategoriesservice.GetRecallCategoriesById(RecallCategoriesId);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddRecallCategories")]
        public IActionResult AddRecallCategories([FromBody] RecallCategoriesVM recallCategories)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "RecallCategories Details Failed! Please check your details and try again." });
                }
                _recallcategoriesservice.AddRecallCategories(recallCategories);
                return Ok(new Response { Status = "Success", Message = "RecallCategories Details Add successfully!" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateRecallCategories")]
        public IActionResult UpdateRecallCategories(RecallCategoriesVM recallCategories)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Update Failed! Please check your details and try again." });
                }
                _recallcategoriesservice.UpdateRecallCategories(recallCategories);
                return Ok(new Response { Status = "Success", Message = "Update RecallCategories Details successfully!" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteRecallCategories/{RecallCategoriesId}")]
        public IActionResult DeleteRecallCategories(int RecallCategoriesId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Delete Failed! Please check your details and try again." });
                }
                _recallcategoriesservice.DeleteRecallCategories(RecallCategoriesId);
                return Ok(new Response { Status = "Success", Message = "Delete RecallCategories Details Delete successfully!" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
