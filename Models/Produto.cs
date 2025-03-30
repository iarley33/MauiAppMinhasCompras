﻿using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        string _descricao;
        
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao { 
            get => _descricao;

            set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a descrição corretamente");
                }
                _descricao = value;
            }
        }
        public double Quantidade { get; set; }
        public double Preco {  get; set; }

        public DateTime DataCadastro {  get; set; } = DateTime.Now;
        public double Total { get => Quantidade * Preco; }
    }
}