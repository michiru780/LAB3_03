using System;

class GradeChecker
{
    // เมธอดสำหรับคืนค่าเกรดตามคะแนน
    public string GetGrade(int score)
    {
        switch (score / 10)   // ใช้หารเพื่อแบ่งช่วงคะแนน
        {
            case 10:
            case 9:
            case 8: return "Grade A";   // 80-100
            case 7: return "Grade B";   // 70-79
            case 6: return "Grade C";   // 60-69
            case 5: return "Grade D";   // 50-59
            case 4:
            case 3:
            case 2:
            case 1:
            case 0: return "Grade F";   // 0-49
            default: return "คะแนนไม่ถูกต้อง";
        }
    }
}

class Program
{
    static void Main()
    {
        GradeChecker checker = new GradeChecker();  // สร้างออบเจ็กต์สำหรับเช็คเกรด

        Console.Write("กรอกคะแนน (0-100): ");
        string input = Console.ReadLine();          // รับค่าจากคีย์บอร์ด

        if (!int.TryParse(input, out int score))    // เช็คว่าเป็นตัวเลขไหม
        {
            Console.WriteLine("กรุณากรอกตัวเลขเท่านั้น");
            return;
        }

        if (score < 0 || score > 100)               // เช็คว่าคะแนนอยู่ในช่วงหรือเปล่า
        {
            Console.WriteLine("คะแนนไม่ถูกต้อง");
            return;
        }

        Console.WriteLine(checker.GetGrade(score)); // เรียกคลาสมาแสดงเกรด
    }
}
