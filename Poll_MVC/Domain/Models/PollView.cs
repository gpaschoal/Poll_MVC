using Poll_MVC.Domain.Models.Contracts;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poll_MVC.Domain.Models
{
    public class PollView : IModel
    {
        public PollView()
        {
            CreatedAt = DateTime.Now;
        }
        [Column(TypeName = "int")]
        public int PollId { get; private set; }
        public virtual Poll Poll { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
