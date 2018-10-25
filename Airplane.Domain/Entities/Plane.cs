using System;
namespace Airplane.Domain.Entities
{
    public class Airplane: BaseEntity
    {
        public string Model { get; set; }

        public int Capacity { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
