using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id)
        {
            var values = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveBlog(int id)
        {
            var command = new RemoveBlogCommand(id);
            await _mediator.Send(command);
            return Ok("Özellik silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik güncellendi");
        }

        [HttpGet("GetLast3BlogWithAuthor")]
        public async Task<IActionResult> GetLast3BlogWithAuthor()
        {
            var values = await _mediator.Send(new GetLast3BlogsWithAuthorQuery());
            return Ok(values);
        }

        [HttpGet("GetAllBlogWithAuthorList")]
        public async Task<IActionResult> GetAllBlogWithAuthorList()
        {
            var values = await _mediator.Send(new GetAllBlogWithAuthorQuery());
            return Ok(values);
        }

        [HttpGet("GetBlogByAuthorId")]
        public async Task<IActionResult> GetAllBlogWithAuthorList(int id)
        {
            var values = await _mediator.Send(new GetBlogByAuthorIdQuery(id));
            return Ok(values);
        }
    }
}
