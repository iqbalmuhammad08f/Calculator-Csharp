using System;
using System.Linq;

class Calculator
{
    static int Menghitung(int angka1,string operasi,int angka2)
    {
        switch(operasi)
        {
            case "+":
                return angka1 + angka2;
            case "-":
                return angka1 - angka2;
            case "*":
                return angka1 * angka2;
            case "/":
                return angka1 / angka2;
            default:
                return 0;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("== Calculator sederhana ==");
        Console.WriteLine();
        while (true)
        {
            Console.Write("Pilih operasi(+,-,*,/): ");
            var operasi = Console.ReadLine();
            string[] validOperator = { "+", "-", "*", "/" };
            if (validOperator.Contains(operasi))
            {
                Console.Write("Masukkan angka pertama: ");
                int angka1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan angka kedua: ");
                int angka2 = Convert.ToInt32(Console.ReadLine());
                int hasil = Menghitung(angka1, operasi, angka2);
                Console.WriteLine($"Hasilnya adalah {hasil}");
            }
            else
            {
                Console.WriteLine("operator tidak sesuai, enter untuk megulangi");
                Console.ReadLine();
                Console.Clear();
                continue;
            }
        }
        

        
    }
}