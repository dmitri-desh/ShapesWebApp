using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShapesLib.Interfaces;

namespace WebApi.Controllers
{
    /// <summary>
    /// Контроллер для обработки запросов, связанных с вычислением площади фигур.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ShapeController : ControllerBase
    {
        private readonly IShapeService _shapeService;
        private readonly ILogger<ShapeController> _logger;

        public ShapeController(IShapeService shapeService, ILogger<ShapeController> logger)
        {
            _shapeService = shapeService;
            _logger = logger;
        }

        /// <summary>
        /// Вычисляет площадь круга по радиусу.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <returns>Площадь круга.</returns>
        [HttpGet("circle/area")]
        public IActionResult GetCircleArea(double radius)
        {
            try
            {
                var area = _shapeService.GetCircleArea(radius);

                return Ok(area);
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex.Message);

                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Вычисляет площадь треугольника по трем сторонам.
        /// </summary>
        /// <param name="sideA">Сторона A треугольника.</param>
        /// <param name="sideB">Сторона B треугольника.</param>
        /// <param name="sideC">Сторона C треугольника.</param>
        /// <returns>Площадь треугольника.</returns>
        [HttpGet("triangle/area")]
        public IActionResult GetTriangleArea(double sideA, double sideB, double sideC)
        {
            try
            {
                var area = _shapeService.GetTriangleArea(sideA, sideB, sideC);

                return Ok(area);
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex.Message);

                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным.
        /// </summary>
        /// <param name="sideA">Сторона A треугольника.</param>
        /// <param name="sideB">Сторона B треугольника.</param>
        /// <param name="sideC">Сторона C треугольника.</param>
        /// <returns>True, если треугольник является прямоугольным, иначе False.</returns>
        [HttpGet("triangle/isRight")]
        public IActionResult IsRightTriangle(double sideA, double sideB, double sideC)
        {
            try
            {
                var isRight = _shapeService.IsRightTriangle(sideA, sideB, sideC);

                return Ok(isRight);
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex.Message);

                return BadRequest(ex.Message);
            }
        }

    }
}
