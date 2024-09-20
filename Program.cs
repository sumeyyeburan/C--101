using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Channels;

class Program
{

    static List<string> todoList = new List<string>();

    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("TODO List Uygulaması");
            Console.WriteLine();
            Console.WriteLine("1. Görev Ekle");
            Console.WriteLine("2. Görevleri Listele");
            Console.WriteLine("3. Görevi Sil");
            Console.WriteLine("4. Çıkış");

            Console.WriteLine();
            Console.Write("Bir seçenek giriniz: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    RemoveTask();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Geçersiz seçenek.Devam etmek için bir tuşa basınız! ");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Clear();

        Console.Write("Yeni görev giriniz: ");
        string task = Console.ReadLine();

        todoList.Add(task);

        Console.WriteLine();
        Console.WriteLine("Görev başarılı bir şekilde eklendi !");
        Console.WriteLine();
        Console.WriteLine("Devam etmek için bir tuşa basınız.");

        Console.ReadLine();

    }

    static void ShowTasks()
    {

        Console.Clear();

        Console.WriteLine("Görevler: ");

        if (todoList.Count == 0)
        {
            Console.WriteLine("Henüz görev eklenmedi !");
        }
        else
        {
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Devam etmek için bir tuşa basınız.");
        Console.ReadLine();
    }

    static void RemoveTask()
    {

        Console.Clear();

        if (todoList.Count > 0)
        {
            Console.WriteLine();
            Console.Write("Silmek istediğiniz görev numarasını giriniz: ");

            int removeTask = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            if ((removeTask - 1) >= 0 && ((removeTask-1) < todoList.Count))
            {
                todoList.RemoveAt(removeTask - 1);
                Console.WriteLine("Görev silindi !");

            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Henüz görev eklenmedi  !");
        }

        Console.WriteLine();
        Console.WriteLine("Devam etmek için bir tuşa basınız.");
        Console.ReadLine();

    }

}
