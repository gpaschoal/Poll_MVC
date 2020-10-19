using Poll_MVC.Domain.Models.Contracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poll_MVC.Domain.Models
{
    public class Option : IModel
    {
        public Option(string description)
        {
            Description = description;
        }

        [Key()]
        [Column(TypeName = "int")]
        public int PollId { get; private set; }
        public virtual Poll Poll { get; set; }
        [Column(TypeName = "int")]
        public int Id { get; private set; }
        [Column(TypeName = "char(150)")]
        public string Description { get; private set; }
        public virtual IList<OptionVote> Votes { get; private set; }

        public void AddVote()
        {
            if (Votes is null)
                Votes = new List<OptionVote>();

            Votes.Add(new OptionVote());
        }
    }
}
