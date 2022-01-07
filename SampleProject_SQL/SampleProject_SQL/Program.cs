// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;
using System;
//Sql server Connection
SqlConnection con = new SqlConnection(@"Data Source=AD-PC\SQLEXPRESS; Initial Catalog =Tutorials; Integrated Security = True;");
SqlDataAdapter Da = new SqlDataAdapter("Select * from TutorialInfo", con);
DataTable dtbl = new DataTable();
Da.Fill(dtbl);

Console.WriteLine("***********Tutorials**********");
Console.WriteLine("ID\t|TutorialName");
foreach (DataRow row in dtbl.Rows)
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"{row["id"]}\t|{row["TutorialName"]}");
}
Console.ReadKey();