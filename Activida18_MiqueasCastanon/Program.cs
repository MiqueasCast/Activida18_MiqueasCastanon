void Menu()
{
    Console.WriteLine("Menú: \n1. Registrar el estudiante \n2. Mostrar promedio general\n3. Mostrar cantidad aprobados y reprobados\n4. Salir");

}

int opcion = 0;

do
{
    Menu();
    Console.WriteLine("");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        default:
            break;
    }
}while(opcion != 4)