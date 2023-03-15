using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde
{
    public class Endereco
    {
        private int Id;
        private string Cep;
        private string Rua;
        private int Numero;
        private string Bairro;
        private string Cidade;

        public Endereco(int id, string cep, string rua, int numero, string bairro, string cidade)
        {
            Id = id;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }

        public void AtualizarEndereco(string rua, int numero, string bairro)
        {
            setBairro(bairro);
            setNumero(numero);
            setRua(rua);
        }

        public string EnderecoCompleto()
        {
            return "Rua " + Rua + ", Nº " + Numero + " Bairro " + Bairro + " Cidade: " + Cidade;
        }

        public int getId()
        {
            return Id;
        }
        public string getCep()
        {
            return Cep;
        }
        public string getRua()
        {
            return Rua;
        }
        public int getNumero()
        {
            return Numero;
        }
        public string getBairro()
        {
            return Bairro;
        }
        public string getCidade()
        {
            return Cidade;
        }

        public void setId(int id)
        {
            Id = id;
        }
        public void setCep(string cep)
        {
            Cep = cep;
        }
        public void setRua(string rua)
        {
            Rua = rua;
        }
        public void setNumero(int numero)
        {
            Numero = numero;
        }
        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }
        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }
    }
}
