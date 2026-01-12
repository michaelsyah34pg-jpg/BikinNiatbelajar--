using System.Runtime.InteropServices.Marshalling;

int nilai;
string name;
Console.Write("Aplikasi nilai Siswa: ");

Console.Write("Input Nama: ");
name = Console.ReadLine();

Console.Write("Input Nilai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
    Console.WriteLinE("Selamat, Anda Lulus");
else
    Console.WriteLine("Maaf, Anda Tidak Lulus");

