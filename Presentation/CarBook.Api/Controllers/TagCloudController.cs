﻿using CarBook.Application.Features.Mediator.Commands.TagCloudCommands;
using CarBook.Application.Features.Mediator.Queries.TagCloudQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagCloudController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagCloudController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagCloudList()
        {
            var values = await _mediator.Send(new GetTagCloudQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagCloud(int id)
        {
            var values = await _mediator.Send(new GetTagCloudByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTagCloud(CreateTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveTagCloud(RemoveTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik güncellendi");
        }

        [HttpGet("GetTadCloudsByBlogId")]
        public async Task<IActionResult> GetTadCloudsByBlogId(int id)
        {
           var values= await _mediator.Send(new GetTagCloudByBlogIdQuery(id));
            return Ok(values);
        }
    }
}
