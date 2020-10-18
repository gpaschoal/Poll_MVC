using Poll_MVC.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace Poll_MVC.Domain.Commands
{
    public class CreatePollCommand : ICommand
    {
        [Required(ErrorMessage = "You should add description to your poll!")]
        [MaxLength(150)]
        public string Poll_description { get; set; }
        [Required(ErrorMessage = "You should add options to your poll!")]
        [MinLength(2)]
        public string[] Options { get; set; }
    }
}
