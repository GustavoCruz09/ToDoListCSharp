using ToDoListCSharp;
using ToDoListCSharp.models;


List<Assignment> assignmentList = new List<Assignment>();

string option = "";

while (option != "4")
{
    Console.WriteLine("==== Lista de Tarefas ====\n");
    listAssignments(assignmentList);

    Console.WriteLine("\nOpções:");
    Console.WriteLine("1. Adicionar Tarefa");
    Console.WriteLine("2. Marcar Tarefa como Concluída");
    Console.WriteLine("3. Remover Tarefa");
    Console.WriteLine("4. Sair");

    Console.Write("Escolha uma opção (1-4): ");
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            addAssignment(assignmentList);
            break;
        case "2":
            markAsCompleted(assignmentList);
            break;
        case "3":
            removeAssignment(assignmentList);
            break;
        case "4":
            Console.WriteLine("\nQualquer ajuda estamos aqui, ate a proxima\n");
            return;
        default:
            Console.WriteLine("\nOpção inválida. Tente novamente.\n");
            break;
    }
}


static void listAssignments(List<Assignment> tarefas)
{

    if (tarefas.Count == 0)
    {
        Console.WriteLine("Nenhuma tarefa na lista.");
    }
    else
    {
        for (int i = 0; i < tarefas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. [{(tarefas[i].Completed ? "X" : " ")}] {tarefas[i].Description}");
        }
    }

}

static void addAssignment(List<Assignment> tarefas)
{
    Console.Write("\nDigite a descrição da nova tarefa: ");
    string descricao = Console.ReadLine();

    Assignment novaTarefa = new Assignment(descricao);
    tarefas.Add(novaTarefa);

    Console.WriteLine("\nTarefa adicionada com sucesso!\n");
}

static void markAsCompleted(List<Assignment> tarefas)
{
    Console.Write("\nDigite o número da tarefa a ser marcada como concluída: ");
    if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= tarefas.Count)
    {
        tarefas[indice - 1].Completed = true;
        Console.WriteLine("\nTarefa marcada como concluída!\n");
    }
    else
    {
        Console.WriteLine("\nNúmero de tarefa inválido. Tente novamente.\n");
    }
}

static void removeAssignment(List<Assignment> tarefas)
{
    Console.Write("\nDigite o número da tarefa a ser removida: ");
    if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= tarefas.Count)
    {
        tarefas.RemoveAt(indice - 1);
        Console.WriteLine("\nTarefa removida com sucesso!\n");
    }
    else
    {
        Console.WriteLine("\nNúmero de tarefa inválido. Tente novamente.\n");
    }
}
