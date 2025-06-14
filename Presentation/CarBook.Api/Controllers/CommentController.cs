using CarBook.Application.Features.Mediator.Commands.CommentCommands;
using CarBook.Application.Features.Mediator.Commands.ReservationCommands;
using CarBook.Application.Features.RepositoryPattern;
using CarBookDomain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _repository;
        private readonly IMediator _mediator;

        public CommentController(IGenericRepository<Comment> repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            var values=_repository.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            _repository.Create(comment);
            return Ok("Yorum Eklendi");
        }
        [HttpDelete]
        public IActionResult RemoveComment(int id)
        {
            var value=_repository.GetById(id);
            _repository.Remove(value);
            return Ok("Yorum Silindi");
        }

        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _repository.update(comment);
            return Ok("Yorum Güncellendi");
        }

        [HttpGet("GetComment")]
        public IActionResult GetComment(int id)
        {
           var value= _repository.GetById(id);
            return Ok(value);
        }

        [HttpGet("CommentListByBlog")]
        public IActionResult CommentListByBlog(int id)
        {
            var value = _repository.GetCommentsByBlogId(id);
            return Ok(value);
        }

        [HttpGet("CommentCountByBlog")]
        public IActionResult CommentCountByBlog(int id)
        {
            var value = _repository.GetCountCommentByBlog(id);
            return Ok(value);
        }

        [HttpPost("CreateCommentWithMediator")]
        public async Task<IActionResult> CreateCommentWithMediator(CreateCommentCommands command)
        {
            await _mediator.Send(command);
            return Ok("Yorum Eklendi");
        }
    }
}
