using System;

class Calculator
{
    static double Menghitung(double angka1,string operasi,double angka2)
    {
        switch (operasi)
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
            Console.Write("Pilih operasi(+,-,*,/,0=keluar): ");
            var operasi = Console.ReadLine() ?? string.Empty;
            string[] validOperator = { "+", "-", "*", "/" };
            if (validOperator.Contains(operasi))
            {
                Console.Write("Masukkan angka pertama: ");
                double angka1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan angka kedua: ");
                double angka2 = Convert.ToInt32(Console.ReadLine());
                if (operasi == "/" && angka2 == 0)
                {
                    Console.WriteLine("tidak bisa membagi dengan 0, enter untuk mengulangi");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    double hasil = Menghitung(angka1, operasi, angka2);
                    Console.WriteLine($"Hasilnya adalah {hasil}");
                    Console.WriteLine("enter untuk megulangi");
                    Console.ReadLine();
                    Console.Clear();
                }
                
            }
            else if (operasi == "0")
            {
                Console.Clear();
                break;
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