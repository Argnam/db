using System;
using Npgsql;
using System.Runtime.InteropServices;
using System.Threading;
public class Guidgenerate
{   
    
}
class Program
{
    static void Main()
    {
        Thread Thread1 = new Thread(Fool1);
        Thread Thread2 = new Thread(Fool1);
        Thread Thread3 = new Thread(Fool1);
        Thread Thread4 = new Thread(Fool1);
        Thread Thread5 = new Thread(Fool1);
        Thread1.Start();
        Thread2.Start();
        Thread3.Start();
        Thread4.Start();
        Thread5.Start();
    }
    public static void Fool1(object obj)
    {
        Guid nach, guicat, guius;
        int schet1 = 0;
        int schet2 = 0;
        int schet3 = 0;
        String connectionString = "Server=localhost;Port=5432;User id=postgres;Password=TRophy1987;Database=Forum;";
        NpgsqlConnection PostgreSQL = new NpgsqlConnection(connectionString);
        PostgreSQL.Open();
        Console.WriteLine("Соединение с БД открыто");
        string[] a = new string[500000 / 5];
        string[] b = new string[5000 / 5];
        string[] c = new string[10000000 / 5];
        var rand = new Random();
        rand.Next(1, 16);
        byte[] dancat = new byte[] { Convert.ToByte(rand.Next(0, 31)), Convert.ToByte(rand.Next(0, 31)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)) };
        byte[] danmes = new byte[] { Convert.ToByte(rand.Next(0, 31)), Convert.ToByte(rand.Next(0, 31)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)) };
        byte[] danus = new byte[] { Convert.ToByte(rand.Next(0, 31)), Convert.ToByte(rand.Next(0, 31)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)), Convert.ToByte(rand.Next(1, 17)) };
        nach = Guid.NewGuid();
        guicat = Guid.NewGuid();
        guius = Guid.NewGuid();
        a[0] = "insert INTO users VALUES ('" + guius + "','Миша')";
        b[0] = "insert INTO categories VALUES ('" + guicat + "','Категория0'," + "'" + guicat + "'" + ")";
        c[0] = "insert INTO messages VALUES ('" + nach + "','text0','" + guicat + "','10:40:50','" + guius + "')";
        for (int k = 1; k <= 5000 / 5 - 1; k++)
        {
            schet1 += 1;
            dancat[rand.Next(0, 16)] += 1;
            guicat = Guid.NewGuid();
            b[schet1] = ",('" + guicat + "','Категория" + dancat + "','" + guicat + "')";
            for (int j = 1; j <= 100; j++)
            {
                schet2 += 1;
                danus[rand.Next(0, 16)] += 1;
                guius = Guid.NewGuid();
                a[schet2] = ",('" + guius + "','Миша')";
                for (int q = 1; q <= 20; q++)
                {
                    schet3 += 1;
                    danmes[rand.Next(0, 16)] += 1;
                    nach = Guid.NewGuid();
                    c[schet3] = ",('" + nach + "'" + ",'text" + schet3 + "','" + guicat + "','" + q + ":40:50','" + guius + "')";
                }
            }
        }
        NpgsqlCommand npgSqlCommand = new NpgsqlCommand(string.Join("", b), PostgreSQL);
        int count = npgSqlCommand.ExecuteNonQuery();
        if (count >= 1)
            Console.WriteLine("Таблица categories заполненна");
        else
            Console.WriteLine("Не удалось вставить новую запись ");
        NpgsqlCommand npgSqlCommand1 = new NpgsqlCommand(string.Join("", a), PostgreSQL);
        int count1 = npgSqlCommand1.ExecuteNonQuery();
        if (count1 >= 1)
            Console.WriteLine("Таблица users заполнена");
        else
            Console.WriteLine("Не удалось вставить новую запись ");
        NpgsqlCommand npgSqlCommand2 = new NpgsqlCommand(string.Join("", c), PostgreSQL);
        int count2 = npgSqlCommand2.ExecuteNonQuery();
        if (count2 >= 1)
            Console.WriteLine("Таблица messages заполнена");
        else
            Console.WriteLine("Не удалось вставить новую запись ");
        PostgreSQL.Close();
        Console.ReadKey(true);
    }
}
