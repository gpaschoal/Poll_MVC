using Poll_MVC.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace Poll_MVC.Domain.Commands
{
    public class CreatePollCommand : ICommand
    {
        [Required(ErrorMessage = "You should add description to your poll!")]
        [MaxLength(150)]
        public string Poll_description { get; set; }
        [Required(ErrorMessage = "You should add a description to this option!")]

        [MaxLength(150)]
        public string Option1 { get; set; }
        [Required(ErrorMessage = "You should add a description to this option!")]

        [MaxLength(150)]
        public string Option2 { get; set; }
        [Required(ErrorMessage = "You should add a description to this option!")]

        [MaxLength(150)]
        public string Option3 { get; set; }
    }
}
