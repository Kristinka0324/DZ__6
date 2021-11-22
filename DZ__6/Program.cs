using System;
using System.Diagnostics;



namespace DZ__6
{
    class Program
    {
        static void Main(string[] args)
        {

             var processes = Process.GetProcesses();
             foreach (var process in Process.GetProcesses())

                 Console.WriteLine($"TaskManager {nameof(process.ProcessName)}: {process.ProcessName},{nameof(Process.Id)}: {process.Id}");
             Console.WriteLine("Введите число 1 : для завершения процесса поимени или число 2 : для завершения процесса по ID");

             string str = Console.ReadLine();
             try
             {
                 if (str == "1")
                 {
                     Console.WriteLine("Введите наименование процесса");
                     string processName = Console.ReadLine();
                     foreach (Process process in Process.GetProcessesByName(processName)) process.Kill();
                     Console.WriteLine("Процесс " + processName + " был закрыт");

                 }
                 if (str == "2")
                 {
                     Console.WriteLine("Введите Id ");
                     int processId = Convert.ToInt32(Console.ReadLine());
                     Process.GetProcessById(processId).Kill();

                     Console.WriteLine(string.Format("Процесс был закрыт :" + (object)processId));
                 }

             }
             catch
             {
                 if ((str != "2") && (str != "1"))
                 {
                     Console.WriteLine("Вы ввели неверное число. Введите число 1 или 2");
                 }
             }

           // что-то я тут кажется намудрила

        }
    }
}
