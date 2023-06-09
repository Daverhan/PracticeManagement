﻿using PM.Library.DTO;

namespace PM.Library.Models
{
    public class Client
    {
        public int Id { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public Boolean IsActive { get; set; }
        public string Name { get; set; }
        public string? Notes { get; set; }

        public Client()
        {
            Name = string.Empty;
        }

        public Client(ClientDTO dto)
        {
            this.Id = dto.Id;
            this.Name = dto.Name;
            this.Notes = dto.Notes;
            this.OpenDate = dto.OpenDate;
            this.ClosedDate = dto.ClosedDate;
            this.IsActive = dto.IsActive;
        }

        public override string ToString()
        {
            return Id + ") " + Name;
        }
    }
}