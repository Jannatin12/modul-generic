using modul5_1302213051;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Generic Method");
        Penjumlahan<float> jum = new Penjumlahan<float>();
        Console.WriteLine("Hasil Penjumlahan 3 angka: ");
        jum.JumlahTigaAngka(13, 02, 21);
        Console.WriteLine(" ");


        Console.WriteLine("Generic Class");
        SimpleDataBase<float, DateTime> simpleDB = new SimpleDataBase<float, DateTime>();

        simpleDB.AddNewData(13, DateTime.UtcNow);
        simpleDB.AddNewData(02, DateTime.UtcNow);
        simpleDB.AddNewData(21, DateTime.UtcNow);

        simpleDB.PrintAllData();
    }
}