using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {

            var result = _carService.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {

            var result = _carService.Add(car);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {

            var result = _carService.Update(car);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {

            var result = _carService.Delete(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        public IActionResult GetCarsByBrandId(int brandId)
        {
            var result = _carService.GetCarsByBrandId(brandId);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
        public IActionResult GetCarsByColorId(int colorId)
        {
            var result = _carService.GetCarsByBrandId(colorId);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }

            return Ok(result);

        }
    }
}


//IDataResult<List<Car>> GetAll();
//IDataResult<Car> GetById(int id);
//IResult Add(Car car);
//IResult Update(Car car);
//IResult Delete(int id);
//IDataResult<List<Car>> GetCarsByBrandId(int brandId);
//IDataResult<List<Car>> GetCarsByColorId(int colorId);

//IDataResult<List<CarDetailDto>> GetCarDetails();