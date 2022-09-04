using Microsoft.AspNetCore.Mvc;
using Notes.Application.Notes.Queries.GetNoteDetails;
using Notes.Application.Notes.Queries.GetNoteList;

namespace Notes.WebApi.Controllers
{
    public class NoteController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var query = new GetNoteListQuery
            {
                UserId = UserId
            };

            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            var query = new GetNoteDetailsQuery
            {
                UserId = UserId,
                Id = id
            };

            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
    }
}
