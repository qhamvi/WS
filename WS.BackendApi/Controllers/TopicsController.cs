﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IActionResult> GetListAsync([FromQuery] ListTopicRequest request)
        {
            var data = await _service.GetAll(request);
            return Ok(data);
        }
    }
}
