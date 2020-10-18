using Poll_MVC.Domain.Models.Contracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poll_MVC.Domain.Models
{
    public class Poll : IModel
    {
        public Poll(string description)
        {
            Description = description;
            Options = null;
            Views = null;
        }

        [Key()]
        public int Id { get; private set; }
        [Column(TypeName = "varchar(150)")]
        public string Description { get; private set; }
        public virtual IList<Option> Options { get; private set; }
        public virtual IList<PollView> Views { get; private set; }

        public void AddOption(string option)
        {
            if (string.IsNullOrWhiteSpace(option))
                return;

            if (Options is null)
                Options = new List<Option>();

            Options.Add(new Option(option));
        }

        public void AddView()
        {
            if (Views is null)
                Views = new List<PollView>();

            Views.Add(new PollView());
        }
    }
}
