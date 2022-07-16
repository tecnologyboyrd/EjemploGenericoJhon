// See https://aka.ms/new-console-template for more information
using EjemploGenericoJhon.Models;
using EjemploGenericoJhon.Repository;

Console.WriteLine("Repositorios Genericos");

#region "Grabando en la tabla data1"
//using (var dbcontext = new TESTContext())
//{
//    var Data1Repository = new Repository<Data1>(dbcontext);

//    var Data1 = new Data1() { Comentario = "Esto lo hice con Jhon",  Descripcion = "Trabajo en vivo en la clase" };

//    Data1Repository.Add(Data1);

//    Data1Repository.Save();

//    foreach (var item in dbcontext.Data1s)
//    {
//        Console.WriteLine($"comentario: {item.Comentario}, Descripcion: {item.Descripcion}");
//    }

//}
#endregion

#region "Grabando en tabla DATA2"
using (var dbcontext = new TESTContext())
{
    var Data1Repository = new Repository<Data2>(dbcontext);

    var Data2 = new Data2() { Provincia = "Santo Domingo de Guzman", Ciudad="Distrito Nacional"};

    Data1Repository.Add(Data2);

    Data1Repository.Save();

    foreach (var item in dbcontext.Data2s)
    {
        Console.WriteLine($"Provincia: {item.Provincia}, Ciudad: {item.Ciudad}");
    }

}
#endregion