using Ex2.Entities;

int numeroNovosEmpregados = Insertar.Int("\nQuantos empregados novos vai inserir?: ");
int i = 0;
bool isOutSource = true;
List<Employee> employees = new();
List<OutSourcedEmployee> outSources = new();

while(i != numeroNovosEmpregados)
{
    Console.WriteLine($"\n{++i}º empregado");

    isOutSource = Insertar.IsOutput();
    if (isOutSource)
    {
        outSources.Add(Insertar.OutSourcedEmployee());
        continue;
    }

    employees.Add(Insertar.Employee());
}

if(employees.Count > 0)
{
    Console.WriteLine("\n--- Pagos dos empregados registrados ---");

    foreach (Employee emp in employees)
        Console.WriteLine($"{emp.Name} - $ {emp.Payment():n2}");

}

if (outSources.Count > 0)
{
    Console.WriteLine("\n--- Pagos dos empregados externos registrados ---");

    foreach (OutSourcedEmployee emp in outSources)
        Console.WriteLine($"{emp.Name} - $ {emp.Payment():n2}");

}

if (employees.Count == 0 && outSources.Count == 0)
    Console.WriteLine("Parabéns, você não lhe têm que pagar a nenhum empregado :D");

Console.WriteLine("\nMuchas gracias por ter utilizado este programa :)");