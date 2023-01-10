using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Threading.Tasks;
using WS.Application.TopicService;
using WS.Application.TopicService.Dtos;

namespace WS.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicService _service;

        public TopicsController(ITopicService service)
        {
            _service = service;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok("Test OK");
        //}
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetListAsync([FromQuery] ListTopicRequest request)
        {
            if (ModelState.IsValid is true)
            {
                var data = await _service.GetAll(request);
                return Ok(data);
            }
            else
                return BadRequest();
            
        }

        [HttpPost]
        public async Task<IActionResult> CreateTopic([FromBody] TopicCreateRequest request)
        {
            await _service.Create(request);
            return Ok("Create success");
        }

        [HttpDelete("{topicId}")]
        public async Task<IActionResult> DeleteAsync(string topicId)
        {
            await _service.Delete(topicId);
            return Ok("Delete success");
        }

        [HttpPut("{topicId}")]
        public async Task<IActionResult> UpdateTopic(TopicUpdateRequest request)
        {
            await _service.Update(request);
            return Ok("Update success");
        }
    }
}
