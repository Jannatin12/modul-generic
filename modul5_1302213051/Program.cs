using modul5_1302213051;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<float, DateTime> simpleDB = new SimpleDataBase<float, DateTime>();

        simpleDB.AddNewData(13, DateTime.UtcNow);
        simpleDB.AddNewData(02, DateTime.UtcNow);
        simpleDB.AddNewData(21, DateTime.UtcNow);

        simpleDB.PrintAllData();
    }
}