namespace faltas
{
    internal class Program
    {
        static void Main()
        {
            // Definição das matérias e suas horas
            string[] materias = {
                "Aspectos Fisiopatológicos e Mecanismos das Doenças",
                "Processo de Cuidar na Saúde Mental e na Enfermagem Psiquiátrica",
                "Farmacoterapia",
                "Processo de Cuidar em Emergência",
                "Projeto de Capacitação da Comunidade em Primeiros Socorros",
                "Processo de Cuidar em Saúde do Adulto e Idoso"
            };

            while (true) // Loop para continuar perguntando ao usuário
            {
                // Exibição das matérias para o usuário
                Console.WriteLine("\nEscolha uma matéria para verificar suas faltas (digite o número):");
                for (int i = 0; i < materias.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {materias[i]}");
                }

                // Leitura da escolha do usuário
                int escolhaMateria = Convert.ToInt32(Console.ReadLine()) - 1;

                // Validação da escolha
                if (escolhaMateria < 0 || escolhaMateria >= materias.Length)
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    continue; // Continua o loop para nova entrada
                }

                // Definição da quantidade total de aulas de acordo com a matéria escolhida
                int totalAulas = 0;
                switch (escolhaMateria)
                {
                    case 0: totalAulas = 4 * 18; break; // 4 aulas por semana
                    case 1: totalAulas = 2 * 18; break; // 2 aulas por semana
                    case 2: totalAulas = 4 * 18; break; // 4 aulas por semana
                    case 3: totalAulas = 4 * 18; break; // 4 aulas por semana
                    case 4: totalAulas = 2 * 18; break; // 2 aulas por semana
                    case 5: totalAulas = 4 * 18; break; // 4 aulas por semana
                }

                // Cálculo das faltas permitidas
                int faltasPermitidas = (int)(totalAulas * 0.25); // 25% de faltas

                // Pergunta quantas faltas já foram feitas
                Console.WriteLine("Quantas vezes você já faltou?");
                int faltasJaFeitas = Convert.ToInt32(Console.ReadLine());

                // Cálculo das faltas restantes
                int faltasRestantes = faltasPermitidas - faltasJaFeitas;

                // Linha divisória para melhor visualização
                Console.WriteLine(new string('-', 50));

                // Mensagem final
                if (faltasJaFeitas > faltasPermitidas) // Aviso se estourou o limite
                {
                    Console.WriteLine("vish, você já estourou o limite de faltas. se ferrou! :(");
                }
                else if (faltasRestantes > 0)
                {
                    Console.WriteLine($"Você ainda pode faltar {faltasRestantes} vez(es)! Pode faltar tranquilo hehe");

                    // Notificação se faltas restantes forem abaixo de 3
                    if (faltasRestantes < 3)
                    {
                        Console.WriteLine("!Cuidado! Você tem poucas faltas restantes!");
                    }
                }
                else
                {
                    Console.WriteLine("Vai ter que ir kkkkk n pode mais faltar lol");
                }

                // Pergunta se o usuário quer ver mais matérias
                Console.WriteLine("\nVocê gostaria de verificar mais matérias? (s/n)");
                char resposta = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Para nova linha após a resposta

                if (char.ToLower(resposta) != 's') // Se a resposta não for 's', sai do loop
                {
                    break; // Sai do loop e finaliza o programa
                }
            }

            Console.WriteLine("tamo jota");
        }
    }
}

