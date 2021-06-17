using System.Collections.Generic;

namespace DesingPartterns.AbstractFactory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var veiculosSocorro = new List<Veiculo>()
            {
                VeiculoCreator.Criar("Gol", Porte.Pequeno),
                VeiculoCreator.Criar("Golf", Porte.Medio),
                VeiculoCreator.Criar("Toareg", Porte.Grande)

            };

            veiculosSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());
        }
    }
}