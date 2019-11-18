using System;

namespace GTDGo.Repository.Model
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime DeletionDateTime { get; set; }
        public DateTime CreationDateTime { get; set; }
    }
}