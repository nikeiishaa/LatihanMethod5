string pilihan, ulang;
decimal hasil;

decimal konversiSuhu(decimal celcius)
{
    return 1.8m * celcius + 32;
}

decimal konversiJarak(decimal km)
{
    return km * 0.62m;
}

decimal konversiMataUang(decimal idr, decimal rate = 16000)
{
    return idr / rate;
}

while (true)
{
    Console.Clear();
    
    Console.WriteLine("Smart Unit Converter");
    Console.WriteLine("[1] Konversi Celcius - fahrenheit");
    Console.WriteLine("[2] Konversi Kilometer - Miles");
    Console.WriteLine("[3] Konversi IDR - USD");
    Console.WriteLine("[4] Exit");
    Console.Write("Pilihan Anda: " );
    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        Console.Write("Masukkan suhu celcius: ");
        decimal celcius = decimal.Parse(Console.ReadLine());

        hasil = konversiSuhu(celcius);
        Console.WriteLine($"Hasil: {hasil} F");
    }
    else if (pilihan == "2")
    {
        Console.Write("Masukkan kilometer: ");
        decimal km = decimal.Parse(Console.ReadLine());

        hasil = konversiJarak(km);
        Console.WriteLine($"Hasil: {hasil} miles");
    }
    else if (pilihan == "3")
    {
        Console.Write("Masukkan IDR: ");
        decimal idr = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Nilai rate saat ini Rp 16000. Apakah ingin mengubah rate? (Y)");
        pilihan = Console.ReadLine();
        if (pilihan.ToUpper() == "Y")
        {
            Console.Write("Rate yang diinginkan: Rp ");
            decimal rate = decimal.Parse(Console.ReadLine());

            hasil = konversiMataUang(idr, rate);
        }
        else
        {
            hasil = konversiMataUang(idr);
        }
        Console.WriteLine($"Hasil: {hasil} USD"); 
    }
    else if (pilihan == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("PILIHAN ANDA INVALID");
    }

    Console.ReadLine();
}

