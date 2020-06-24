using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
// Compiler version 4.0, .NET Framework 4.5


namespace Dcoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Nama\t: Bayu Baskoro");
            Console.WriteLine("NIM\t: 19.11.2794");
            Console.WriteLine("Kelas\t: IF 04");

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "2794";
            karyawanTetap.Nama = "Bayu Bas";
            karyawanTetap.GajiBulanan = 15000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "1911";
            karyawanHarian.Nama = "Baskoro Bas";
            karyawanHarian.UpahPerJam = 120000;
            karyawanHarian.JumlahJamKerja = 8;

            Sales sales = new Sales();
            sales.NIK = "1127";
            sales.Nama = "Bayu Bas";
            sales.JumlahPenjualan = 15;
            sales.Komisi = 85000;

            List<Karyawan> Karyawan = new List<Karyawan>();

            Karyawan.Add(karyawanTetap);
            Karyawan.Add(karyawanHarian);
            Karyawan.Add(sales);


           
            Console.WriteLine(" NO | NIK / NAMA\t\t Gaji\t\t |");
       
            for (int i = 0; i < Karyawan.Count; i++)
            {

                Console.WriteLine(" {0}. | {1} {2} \t\t| {3} \t |", i + 1, Karyawan[i].NIK, Karyawan[i].Nama, Karyawan[i].Gaji());
            }

            Console.ReadKey();
        }
    }

    public abstract class Karyawan
    {
        public string NIK;
        public string Nama;
        public abstract double Gaji();
    }

    public class KaryawanTetap : Karyawan
    {
        public double GajiBulanan;
        public override double Gaji()
        {
            return this.GajiBulanan;
        }
    }

    public class KaryawanHarian : Karyawan
    {
        public double UpahPerJam;
        public double JumlahJamKerja;
        public override double Gaji()
        {
            return this.UpahPerJam * this.JumlahJamKerja;
        }
    }

    public class Sales : Karyawan
    {
        public double JumlahPenjualan;
        public double Komisi;
        public override double Gaji()
        {
            return this.JumlahPenjualan * this.Komisi;
        }
    }
}