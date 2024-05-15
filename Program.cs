Console.WriteLine("------------------------");
Console.WriteLine("Projeto Máquina de Troco");
Console.WriteLine("------------------------");

int valorCompra = 0;
int valorPago = 0;
int valorTroco = 0;

int[] notasReais = new int[7]; //quantidade de notas(dinheiro) R$
notasReais[0] = 100;
notasReais[1] = 50;
notasReais[2] = 20;
notasReais[3] = 10;
notasReais[4] = 5;
notasReais[5] = 2;
notasReais[6] = 1;

Console.Write("Digite o valor da compra(custo):");
valorCompra = int.Parse(Console.ReadLine());

Console.Write("Digite o valor pago pelo cliente:");
valorPago = int.Parse(Console.ReadLine());

Console.WriteLine("O valor da compra foi R$" + valorCompra + " e o cliente deu R$" + valorPago);
valorTroco = CalculoTroco(valorCompra, valorPago);

if (valorCompra == valorPago){
    Console.WriteLine("Essa compra não gerou troco.");
}
else if(valorCompra < valorPago)
{
    Console.WriteLine("O cashier deve pagar R$" + valorTroco + " de troco");
    Console.WriteLine();
    Console.WriteLine("Cédulas para o troco:");

    foreach (int cedula in notasReais)
    {
        int quantidadeCedulas = valorTroco / cedula;
        if (quantidadeCedulas > 0)
        {
            Console.WriteLine(quantidadeCedulas + " cédula(s) de R$" + cedula);
            valorTroco -= quantidadeCedulas * cedula;
        }
    }
}else
{
    Console.WriteLine("Compra não aceita. Valor inferior ao preço do produto!");
}

static int CalculoTroco(int valorCompra, int valorPago)
{
    if (valorCompra == valorPago)
    {
        return 0;
    }
    else
    {
        int valorTroco = valorPago - valorCompra;
        return valorTroco;
    }
}

