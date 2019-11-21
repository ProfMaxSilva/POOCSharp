namespace ProgSlideAulas.Heranca
{
    public class AppHeranca
    {
        public static int Main(string[] args)
        {
            Pessoa pessoinha = new Pessoa();
            pessoinha.Nome = "Josefá";
            pessoinha.Idade = 90;
            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Daniel";
            cliente1.Idade = 18;
            cliente1.Saldo = 3000000000000;

            Gerente gerente1 = new Gerente();
            gerente1.Nome = "Max";
            gerente1.Idade = 17;
            gerente1.Salario = 1000;
            gerente1.Area = "Docente";

            Funcionario func1 = new Funcionario { Nome = "Manguza", Salario = 100 };
            Funcionario func2 = new Funcionario { Nome = "Gueyboy", Salario = 100 };

            gerente1.SetFuncionarios(func1);
            gerente1.SetFuncionarios(func2);

            return 0;
        }
    }
}
