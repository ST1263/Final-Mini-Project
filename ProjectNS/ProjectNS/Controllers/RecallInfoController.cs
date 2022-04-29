using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectNS.Model;
using ProjectNS.Service;
using ProjectNS.ViewModel;
using System;
using System.IO;
using System.Net.Http.Headers;

namespace ProjectNS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecallInfoController : Controller
    {
        readonly RecallInfoService _recallinfoservice;
        public RecallInfoController(RecallInfoService recallinfoservice)
        {
            _recallinfoservice = recallinfoservice;
        }

        [HttpGet]
        [Route("GetRecallInfos")]
        public IActionResult GetRecallInfos()
        {
            var allrecallinfo = _recallinfoservice.GetRecallInfos();
            return Ok(allrecallinfo);
        }

        [HttpGet]
        [Route("GetRecallInfoById")]
        public IActionResult GetRecallInfoById(int RecallinfoId)
        {
            var result = _recallinfoservice.GetRecallInfoById(RecallinfoId);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddRecallInfo")]
        public IActionResult AddRecallInfo([FromBody] RecallInfoVM recallInfo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "RecallInfo Details Failed! Please check your details and try again." });
                }
                /*var file = Request.Form.Files[0];
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                   
                }*/
               /* else
                {
                    return BadRequest();
                }*/
                _recallinfoservice.AddRecallInfo(recallInfo);
                return Ok(new Response { Status = "Success", Message = "RecallInfo Details Add successfully!" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateRecallInfo")]
        public IActionResult UpdateRecallInfo(RecallInfoVM recallInfo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Update Failed! Please check your details and try again." });
                }
                _recallinfoservice.UpdateRecallInfo(recallInfo);
                return Ok(new Response { Status = "Success", Message = "Update RecallInfo    Details successfully!" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteRecallInfo/{RecallinfoId}")]
        public IActionResult DeleteRecallInfo(int RecallinfoId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Delete Failed! Please check your details and try again." });
                }
                _recallinfoservice.DeleteRecallInfo(RecallinfoId);
                return Ok(new Response { Status = "Success", Message = "Delete RecallInfo Details Delete successfully!" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
