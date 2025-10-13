using System;

namespace AppWiglaTCC.Models
{
    public class Sigla
    {
        public int Id { get; set; }

        private string? _sigla;
        private string? _significado;
        private string? _descricao;
        private string? _categoria;


        public string Abreviacao
        {
            get => _sigla;
            set => _sigla = string.IsNullOrWhiteSpace(value)
                ? throw new Exception("Por favor, preencha a sigla.")
                : value;
        }

        public string Significado
        {
            get => _significado;
            set => _significado = string.IsNullOrWhiteSpace(value)
                ? throw new Exception("Por favor, preencha o significado.")
                : value;
        }

        public string Descricao
        {
            get => _descricao;
            set => _descricao = string.IsNullOrWhiteSpace(value)
                ? throw new Exception("Por favor, preencha a descrição.")
                : value;
        }

        public string Categoria
        {
            get => _categoria;
            set => _categoria = string.IsNullOrWhiteSpace(value)
                ? throw new Exception("Por favor, preencha a categoria.")
                : value;
        }
    }
}