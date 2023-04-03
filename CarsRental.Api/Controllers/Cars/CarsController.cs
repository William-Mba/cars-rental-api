using CarsRental.Application.Cars.Commands.Create;
using CarsRental.Application.Cars.Commands.Update;
using CarsRental.Application.Cars.Queries.GetAll;
using CarsRental.Application.Cars.Queries.GetById;
using CarsRental.Domain.Cars;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace CarsRental.Api.Controllers.Cars
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class CarsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<CarsController>
        [HttpGet]
        public async Task<IEnumerable<ReadCarModel>> Get()
        {
            var query = new GetAllCarsQuery();

            var cars = await _mediator.Send(query);

            return cars;
        }

        // GET api/<CarsController>/5
        [HttpGet("{id}")]
        public async Task<ReadCarModel> Get(string id)
        {
            var query = new GetCarByIdQuery(id);

            var car = await _mediator.Send(query);

            return car;
        }

        // POST api/<CarsController>
        [HttpPost]
        public async Task<Car> Post([FromBody] CreateCarModel car)
        {
            var command = new CreateCarCommand(car);

            var createdCar = await _mediator.Send(command);

            return createdCar;
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public async Task<Car> Put(string id, [FromBody] UpdateCarModel car)
        {
            var command = new UpdateCarCommand(id, car);

            var createdCar = await _mediator.Send(command);

            return createdCar;
        }

        // DELETE api/<CarsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {

        }
    }
}
