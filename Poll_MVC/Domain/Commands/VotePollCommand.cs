using Poll_MVC.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace Poll_MVC.Domain.Commands
{
    public class VotePollCommand : ICommand
    {
        [Required(ErrorMessage = "You should add a Poll id!")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Poll id")]
        public int PollId { get; set; }
        [Required(ErrorMessage = "You should add an option id")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Option Id")]
        public int Option_id { get; set; }
    }
}
