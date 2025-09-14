using SQLite;

namespace AppMinhasCompras.Models
{
    public class Produto
    {
        String _descricao;
        double _quantidade;
        double _valor;
        String _categoria;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Descricao { 
            get=> _descricao;
            set
            {
                if(value == null)
                {
                    throw new Exception("Por favor, preencha a descrição");
                }

                _descricao = value;
            }
        }

        public double Quantidade
        {
            get => _quantidade;
            set
            {
                if (value == 0)
                {
                    throw new Exception("Por favor, preencha a quantidade");
                }

                _quantidade = value;
            }
        }
        public double Preco
        {
            get => _valor;
            set
            {
                if (value == 0)
                {
                    throw new Exception("Por favor, preencha o valor");
                }

                _valor = value;
            }
        }

        public string Categoria
        {

            get => _categoria;
            set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a categoria");
                }

                _categoria = value;
            }

        }
        public double Total { get => Quantidade * Preco; }
    }
}
