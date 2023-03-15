// See https://aka.ms/new-console-template for more information
using ConsoleApp_Tarde;
using ConsoleApp_Tarde.Heranca;
using System.Collections.Generic;

Produto p1 = new Produto(1,"Mouse xing ling", 10.90M);
Produto p2 = new Produto(2,"Teclado multilaser", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(29.90M);
p1.setDescricao("Mouse Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco e1 = new Endereco(1,
    "15906304",
    "Mario Miziara",
    91,
    "Sobral",
    "Taquaritinga"
    );

Cliente c1 = new Cliente(1, "Fernando", "991340447",e1);
Cliente c2 = new Cliente(2, "Victoria", "991340447",e1);
Cliente c3 = new Cliente(3, "Rafael", "991340447", e1);
Cliente c4 = new Cliente(4, "Lucas", "9913409876" ,e1  );
Cliente c5 = new Cliente(5, "Eduardo", "991340447", e1);


Console.WriteLine(c1.getEndereco().EnderecoCompleto()  );
c1.getEndereco().setRua("Prudente de Morais");
Console.WriteLine(c1.getEndereco().EnderecoCompleto() );
c1.getEndereco().AtualizarEndereco("Julio de Moraes", 585, "POrtal Itamaraca");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());

Carro car = new Carro();
car.cor = "Vermelho";
car.quantidadeRoda = 4;
car.quantidadeAcento = 5;
car.TemMotor = true;

Bike bicicleta = new Bike();
bicicleta.cor = "Azul";
bicicleta.quantidadeRoda = 2;
bicicleta.quantidadeAcento = 1;
bicicleta.TemMotor = false;

Aviao aviao = new Aviao();
aviao.cor = "Branco";
aviao.quantidadeRoda = 12;
aviao.quantidadeAcento = 500;
aviao.TemMotor = true;


List<Veiculo> veiculolista = new List<Veiculo>();
veiculolista.Add(car);
veiculolista.Add(aviao);
veiculolista.Add(bicicleta);

foreach (var item in veiculolista)
{
    Console.WriteLine(item.ExibirDados());
}
Console.WriteLine("Qtd itens da lista" + veiculolista.Count);

//Crie duas listas 
//Uma lista de produtos com 400 produtos
//Outra lista de clientes com 250 clientes
Random rand = new Random();

List < Produto> lsProdutos = new List<Produto>();


for (int i=0; i < rand.Next(200,500);i++)
    
{
    Produto p = new Produto(i, "Produto tal" + i, i / 2 * 15);
    lsProdutos.Add(p);
}

foreach (var item in lsProdutos)
{
    Console.WriteLine(item.ExibirDados());
}

List<Cliente> listacliente = new List<Cliente>();
for (int i = 0; i < rand.Next(200, 500); i++)

{
    Endereco p = new Endereco(i, "Produto tal" + i, i / 2 * 15);
    lsProdutos.Add(p);
}




