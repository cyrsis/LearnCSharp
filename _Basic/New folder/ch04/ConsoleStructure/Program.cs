using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStructure
{
    class Program
    {
        struct Student
        {
            public int No;
            public string Name;
            public int Score;
        };
        
        static void Main(string[] args)
        {
            int i, j;
            Student temp;
            // 初值置入結構陣列
            // 1001,"Paul",85
            // 1002,"Jack",80
            // 1003,"Mary",70
            // 1004,"Jane",90
            // 1005,"Nacy",75

            // 結構陣列如何在宣告建立結構陣列時,同時設定初值
            //方式1
            // Student[] bcc = new Student[5];
            // bcc[0].No = 1001; bcc[0].Name = "Paul"; bcc[0].Score = 85;
            // bcc[1].No = 1002; bcc[1].Name = "Jack"; bcc[1].Score = 80;
            // bcc[2].No = 1003; bcc[2].Name = "Mary"; bcc[2].Score = 70;
            // bcc[3].No = 1004; bcc[3].Name = "Jane"; bcc[3].Score = 90;
            // bcc[4].No = 1005; bcc[4].Name = "Nacy"; bcc[4].Score = 75;

            //方式2
            Student[] bcc = new Student[] {
               new Student(){No=1001,Name="Paul", Score=85},
               new Student(){No=1002,Name="Jack", Score=80},
               new Student(){No=1003,Name="Mary", Score=70},
               new Student(){No=1004,Name="Jane", Score=90},
               new Student(){No=1005,Name="Nacy", Score=75}
           };
            // 依成績由大而小遞減排序
            for (i = 0; i < bcc.Length; i++)
            {
                for (j = i + 1; j < bcc.Length; j++)
                {
                    if (bcc[j].Score > bcc[i].Score)
                    {
                        temp = bcc[i];
                        bcc[i] = bcc[j];
                        bcc[j] = temp;
                    }
                }
            }
            // 顯示排序結果
            Console.WriteLine("  座號   姓名   計概");
            Console.WriteLine(" ====== ====== ====== ");
            for (i = 0; i < bcc.Length; i++)
            {
                Console.WriteLine("  {0}   {1}    {2}", bcc[i].No, bcc[i].Name, bcc[i].Score);
            }
            Console.Read();
        }
    }
}
