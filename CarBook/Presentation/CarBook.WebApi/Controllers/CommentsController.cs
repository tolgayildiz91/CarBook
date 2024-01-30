using CarBook.Application.RepositoryPattern;
using CarBook.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _repository;

        public CommentsController(IGenericRepository<Comment> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _repository.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            _repository.Create(comment);
            return Ok("Yorum başarıyla eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteComment(int id)
        {
            var comment = _repository.GetById(id);
            _repository.Remove(comment);
            return Ok("Yorum Başarıyla Silindi.");
        }
        [HttpPut]
        public IActionResult PutComment(Comment comment)
        {
            _repository.Update(comment);
            return Ok("Yorum Başarıyla Güncellendi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            var comment = _repository.GetById(id);
            return Ok(comment);
        }
    }
}
