namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 11 - Calcula Poupanca ");
            double valorInvestido = 1000;
  
            for (int contadorMes = 1;  contadorMes <= 12; contadorMes++)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Apos " + contadorMes + " meses, voce tera R$" + valorInvestido);

                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                //contadorMes++;
            }

            /* 0.36% = 0.0036
            valorInvestido = valorInvestido + (valorInvestido * 0.0036) ;
            Console.WriteLine("Apos um mes, voce tera R$" + valorInvestido);

            valorInvestido = valorInvestido + (valorInvestido * 0.0036);
            Console.WriteLine("Apos 2 meses, voce tera R$" + valorInvestido); */

            Console.ReadLine();
        }
    }
}