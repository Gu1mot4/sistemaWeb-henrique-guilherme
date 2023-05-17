using System;
using System.ComponentModel.DataAnnotations;

namespace Rastreamento.Models
{
    public class FuncionarioModel
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Matricula { get; set; }
    }
}

