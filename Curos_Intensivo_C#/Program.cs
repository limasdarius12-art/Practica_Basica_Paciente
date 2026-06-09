using System.ComponentModel.Design;

string  SIS = "SI";
Console.WriteLine("CONSULTORIO MEDICO");
Console.WriteLine("------------------");
//Verificación si es mayor de edad el Paciente , corroborar si cuenta con un SIS , Historial medico.
Console.WriteLine("Ingrese los datos según los que pidan");
Console.WriteLine("Ingresar todas las respuestas en MAYÚSUCULAS");
Console.WriteLine("Nombre del paciente");
string?  Nombre = Console.ReadLine();
Console.WriteLine("Ingrese su edad");
int Edad = int.Parse(Console.ReadLine()!);
Console.WriteLine("Cumple con el SIS / Solo responder SI - NO");
string? SISI = Console.ReadLine();
if (Edad>=18)
{
    Console.WriteLine("Es mayor de edad");
   

}
else
{
    Console.WriteLine("Autorizar padre");
}
if (SIS == SISI)
{
    Console.WriteLine("TOME ASIENTE A QUE LE LLAMEN");
}
else
{
    Console.WriteLine("VUELVA PRONTO MAS INFORMACIÓN +123");
}