using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class Program
    {
        static LinkedList<Video> videos = new LinkedList<Video>();
        static LinkedList<Exam> exams = new LinkedList<Exam>();
        static LinkedList<Admin> admins = new LinkedList<Admin>();
        static LinkedList<Manager> Managers = new LinkedList<Manager>();
        static LinkedList<Trainee> Trainees = new LinkedList<Trainee>();

        static void Admin()
        {
            Console.WriteLine("1:For Create Account");
            Console.WriteLine("2:For Login");
            Console.WriteLine("Enter 1 or 2 ");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("Enter Your Name");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter Your ID");
                    string Id = Console.ReadLine();
                    Console.WriteLine("Enter Your Password");
                    string password = Console.ReadLine();
                    Admin admin = new Admin();
                    admin.SetName(Name);
                    admin.SetID(Id);
                    admin.SetPassword(password);
                    admins.AddLast(admin);
                    break;
                case 2:
                    Console.WriteLine("Enter Your Name");
                    string Name1 = Console.ReadLine();
                    Console.WriteLine("Enter Your ID");
                    string Id1 = Console.ReadLine();
                    Console.WriteLine("Enter Your Password");
                    string password1 = Console.ReadLine();
                    bool ISFound = false;
                    foreach (Admin manager in admins)
                    {
                        if (manager.GetName() == Name1 && manager.GetID() == Id1 && manager.GetPassword() == password1)
                        {
                            ISFound = true;
                        }
                        if (ISFound == true)
                        {
                            Console.WriteLine("1:For Add Video ");
                            Console.WriteLine("2:For Remove Video");
                            Console.WriteLine("3:For Add Exam");
                            Console.WriteLine("4:For Remove Exam");
                            int Choose = int.Parse(Console.ReadLine());
                            switch (Choose)
                            {
                                case 1:
                                    Console.WriteLine("Enter Name video");
                                    string NameVideo = Console.ReadLine();
                                    Console.WriteLine("Enter Time video");
                                    int TimeVideo = int.Parse(Console.ReadLine());
                                    Video NewVideo = new Video();
                                    NewVideo.UploadVideo(NameVideo, TimeVideo);
                                    videos.AddLast(NewVideo);
                                    break;
                                case 2:
                                    foreach (Video video in videos)
                                    {
                                        Console.WriteLine($"The Name Video:{video.NameVideo}, Time Video:{video.TimeVideo}, Time is Upload Video:{video.NowVideo}");
                                    }

                                    Console.WriteLine("Enter Name video");
                                    string NameVideo1 = Console.ReadLine();
                                    Console.WriteLine("Enter Time video");
                                    int TimeVideo1 = int.Parse(Console.ReadLine());
                                    Video NewVideo1 = new Video();
                                    bool IsFound = false;
                                    foreach (Video video in videos)
                                    {
                                        if (NameVideo1 == video.NameVideo && TimeVideo1 == video.TimeVideo)
                                        {
                                            IsFound = true;
                                            NewVideo1 = video;
                                        }

                                    }
                                    if (IsFound == true)
                                    {
                                        videos.Remove(NewVideo1);
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("Enter Name Exam");
                                    string NameExam = Console.ReadLine();
                                    Console.WriteLine("Enter Time Exam");
                                    int TimeExam = int.Parse(Console.ReadLine());
                                    Exam exam = new Exam();
                                    exam.UploadExam(NameExam, TimeExam);
                                    exams.AddLast(exam);
                                    break;
                                case 4:
                                    Console.WriteLine("Enter Name Exam");
                                    string NameExam1 = Console.ReadLine();
                                    Console.WriteLine("Enter Time Exam");
                                    int TimeExam1 = int.Parse(Console.ReadLine());
                                    foreach (Exam exams in exams)
                                    {
                                        Console.WriteLine($"The Name Exam:{exams.NameExam}, Time Video:{exams.TimeExam}, Time is Upload Video:{exams.NowExam}");

                                    }

                                    Exam exam1 = new Exam();
                                    bool IsFound1 = false;
                                    foreach (Exam Exams in exams)
                                    {
                                        if (NameExam1 == Exams.NameExam && TimeExam1 == Exams.TimeExam)
                                        {
                                            IsFound1 = true;
                                            exam = Exams;
                                        }

                                    }
                                    if (IsFound1 == true)
                                    {
                                        exams.Remove(exam1);
                                    }
                                    break;
                            }

                        }
                    }
                    break;
            }


        }
        static void Manager()
        {
            Console.WriteLine("1:For Create Account");
            Console.WriteLine("2:For Login");
            Console.WriteLine("Enter 1 or 2 ");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("Enter Your Name");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter Your ID");
                    string Id = Console.ReadLine();
                    Console.WriteLine("Enter Your Password");
                    string password = Console.ReadLine();
                    Manager manager = new Manager();
                    manager.SetName(Name);
                    manager.SetID(Id);
                    manager.SetPassword(password);
                    Managers.AddLast(manager);
                    break;
                case 2:
                    Console.WriteLine("Enter Your Name");
                    string Name1 = Console.ReadLine();
                    Console.WriteLine("Enter Your ID");
                    string Id1 = Console.ReadLine();
                    Console.WriteLine("Enter Your Password");
                    string password1 = Console.ReadLine();
                    bool ISFound = false;
                    foreach (Manager manager1 in Managers)
                    {
                        if (manager1.GetName() == Name1 && manager1.GetID() == Id1 && manager1.GetPassword() == password1)
                        {
                            ISFound = true;
                        }
                        if (ISFound == true)
                        {
                            Console.WriteLine("1:For Add Trainer ");
                            Console.WriteLine("2:For Remove Trainer");
                            Console.WriteLine("3:For View Details Of Trainer");

                            int Choose = int.Parse(Console.ReadLine());
                            switch (Choose)
                            {
                                case 1:
                                    Console.WriteLine("Enter Your Name");
                                    string Name2 = Console.ReadLine();
                                    Console.WriteLine("Enter Your ID");
                                    string Id2 = Console.ReadLine();
                                    Console.WriteLine("Enter Your Password");
                                    string password2 = Console.ReadLine();
                                    Trainee trainee = new Trainee();
                                    trainee.SetName(Name2);
                                    trainee.SetID(Id2);
                                    trainee.SetPassword(password2);
                                    Trainees.AddLast(trainee);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter Your Name");
                                    string Name3 = Console.ReadLine();
                                    Console.WriteLine("Enter Your ID");
                                    string Id3 = Console.ReadLine();
                                    Console.WriteLine("Enter Your Password");
                                    string password3 = Console.ReadLine();
                                    bool IsFound = false;
                                    Trainee trainee1 = new Trainee();
                                    foreach (Trainee trainee2 in Trainees)
                                    {
                                        if (trainee2.GetName() == Name3 && trainee2.GetID() == Id3 && trainee2.GetPassword() == password3)
                                        {
                                            IsFound = true;
                                            trainee1 = trainee2;
                                        }
                                    }
                                    if (IsFound == true)
                                    {
                                        Trainees.AddLast(trainee1);

                                    }
                                    break;
                                case 3:
                                    foreach (Trainee NewTrainee in Trainees)
                                    {
                                        Console.WriteLine($"Name:{NewTrainee.GetName()} ID:{NewTrainee.GetID()},Password:{NewTrainee.GetPassword()} Number Of Trainee:{Trainees.Count}");
                                    }
                                    break;
                            }
                        }
                    }

                    break;
            }
        }

        static void Trainee()
        {
            Console.WriteLine("Enter Your Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Your ID");
            string Id = Console.ReadLine();
            Console.WriteLine("Enter Your Password");
            string password = Console.ReadLine();
            bool IsFound = false;
            foreach (Trainee NTrainee in Trainees)
            {
                if (NTrainee.GetName() == Name && NTrainee.GetID() == Id && NTrainee.GetPassword() == password)
                {
                    IsFound = true;
                }
            }
            if (IsFound == true)
            {
                Console.WriteLine("1:For View Video");
                Console.WriteLine("2:For Solve Exam");
                Console.WriteLine("Enter Number 1 or 2");
                int Choose = int.Parse(Console.ReadLine());
                switch (Choose)
                {
                    case 1:
                        foreach (Video video in videos)
                        {
                            Console.WriteLine($"Name:{video.NameVideo} Time:{video.TimeVideo}");
                        }
                        Console.WriteLine("Enter Name Video");
                        string NameV = Console.ReadLine();
                        bool IsFound1 = false;
                        foreach (Video video in videos)
                        {
                            if (video.NameVideo == NameV)
                            {
                                IsFound1 = true;
                            }
                        }
                        if (IsFound1 == true)
                        {
                            Console.WriteLine("Watched");
                        }
                        break;
                    case 2:
                        foreach (Exam Exam in exams)
                        {
                            Console.WriteLine($"Name:{Exam.NameExam} Time:{Exam.TimeExam}");
                        }
                        Console.WriteLine("Enter Name Video");
                        string NameE = Console.ReadLine();
                        bool IsFoundE = false;
                        foreach (Exam Exam in exams)
                        {
                            if (Exam.NameExam == NameE)
                            {
                                IsFoundE = true;
                            }
                        }
                        if (IsFoundE == true)
                        {
                            Console.WriteLine("Solved");
                        }

                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1:For Admin");
                Console.WriteLine("2:For Manager");
                Console.WriteLine("3:For Trainer");
                Console.WriteLine("4:For Exit");
                Console.WriteLine("Enter 1,2,3 or 4");
                int Choose = int.Parse(Console.ReadLine());
                switch (Choose)
                {
                    case 1:
                        Admin();
                        break;
                    case 2:
                        Manager();
                        break;
                    case 3:
                        Trainee();
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        Environment.Exit(10);
                        break;
                }

            }


        }
    }
}
