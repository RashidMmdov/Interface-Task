using System;

namespace praktika_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            Console.WriteLine("Qrup adini daxil edin:(2 boyuk herif ve 3 reqem olmalidir)");
            string groupNo = Console.ReadLine();
            while (!(groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4])))
            {
                Console.WriteLine("Qrup adini DUZGUN daxil edin:(2 boyuk herif ve 3 reqem olmalidir)");
                groupNo = Console.ReadLine();
            }
            Console.WriteLine("Telebelerin Limitini qeyd edin: (0-20 arasi olmalidir)");
            int Limit = Convert.ToInt32(Console.ReadLine());
            while (!(Limit > 0 && Limit <= 20))
            {
                Console.WriteLine("Telebelerin Limitini DUZGUN qeyd edin: (0-20 arasi olmalidir)");
                Limit = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\t~~~MENU~~~");
            Console.WriteLine("1. Telebe elave et");
            Console.WriteLine("2. Butun telebelere bax");
            Console.WriteLine("3. Telebeler uzre axtaris et");
            Console.WriteLine("0. Proqrami bitir");
            Console.Write("Secin: ");
            int Choose = Convert.ToInt32(Console.ReadLine());
            switch (Choose)
            {
                case 1:
                    Console.WriteLine("Telebenin Adi Ve Soyadi: ");
                    string fullname= Console.ReadLine();
                    Student st = new Student(fullname);
                    Console.WriteLine("Telebenin Adi Ve Soyadi: ");
                    string fullname2 = Console.ReadLine();
                    Student st2 = new Student(fullname2);
                    Console.WriteLine("Telebenin Adi Ve Soyadi: ");
                    string fullname3 = Console.ReadLine();
                    Student st3 = new Student(fullname3);

                    
                    Student[] stFull = {st,st2,st3};
                     fullname = Convert.ToString(st);
                    
                    group.Students = stFull;
                    group.StudentLimit = group.Students.Length;
                    if (group.StudentLimit > Limit)
                    {
                        if (Limit == 1)
                        {
                            Console.WriteLine($"Telebe - {group.Students[0].FullName} elave edildi.");
                        }else if (Limit == 2)
                        {
                            Console.WriteLine($"Telebe - {group.Students[0].FullName} elave edildi.");
                            Console.WriteLine($"Telebe - {group.Students[1].FullName} elave edildi.");
                        }
                        
                        Console.WriteLine("Telebeler bu qrupa gire bilmez qrup DOLUDUR!!!");
                        
                    }
                    else
                    {
                        for (int i = 0; i < stFull.Length; i++)
                        {
                            Console.WriteLine($"Telebe - {group.Students[i].FullName} elave edildi.");
                        }
                        
                    }
                        
                    
                    
                    
                   
                    break;
                case 2:
                    
                    
                    foreach (var item in group.Students)
                    {
                        Console.WriteLine(item.FullName);
                    }
                    break;
                case 3:
                    Console.WriteLine("Search");
                    break;
                case 0:
                    Console.WriteLine("\t~~FINISH~~");
                    
                    break;
                default:
                    Console.WriteLine("Secdiyiniz Tapilmadi...");
                    break;
            }
        }
    }
}
