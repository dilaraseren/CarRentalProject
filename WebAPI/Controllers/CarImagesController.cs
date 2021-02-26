using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService; //field
        IWebHostEnvironment _environment;

        public CarImagesController(ICarImageService carImageService, IWebHostEnvironment environment)
        {
            _carImageService = carImageService;
            _environment = environment;
        }

        [HttpPost("Add")]
        public async Task<string> Add([FromForm]FileUpload objectFile)
        {
            System.IO.FileInfo ff = new System.IO.FileInfo(objectFile.files.FileName);
            string fileExtension = ff.Extension;

            var result = Guid.NewGuid().ToString("N")
                + "_" + DateTime.Now.Month + "_"
                + DateTime.Now.Day + "_"
                + DateTime.Now.Year + fileExtension;

            try
            {
                if (objectFile.files.Length > 0)
                {
                    
                    string path = _environment.WebRootPath + "\\Upload\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream = System.IO.File.Create(path + result ))
                    {

                        objectFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        return "\\Upload\\" + objectFile.files.FileName;
                         
                    }
                }
                else
                {
                    return "Yükleme başarısız!";
                }
            }
            catch (Exception exception)
            {

                return exception.Message; 
            }
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {


            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(CarImage carImage)
        {
            var result = _carImageService.Update(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
