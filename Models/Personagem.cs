using System;
using RpgApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgApi.Models.Enuns;
using System.Text.Json.Serialization;

namespace RpgApi.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }
        public ClasseEnum Classe { get; set; }

        public List<PersonagemHabilidade> PersonagemHabilidades { get; set; } = [];

        public byte[]? FotoPersonagem { get; set; }
        public int? UsuarioId { get; set; }

        [JsonIgnore]
        public Usuario? Usuario { get; set; }

        [JsonIgnore]
        public Armas? Arma { get; set; }
        public int Disputas { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
    }

}