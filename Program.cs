using v21;

Kalkulator hitung = new Kalkulator();

//hitung.tambah();
//hitung.kurang();

Console.Write("masukkan panjang : ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("masukkan lebar : ");
int l = Convert.ToInt32(Console.ReadLine());

Rumus rumus = new Rumus();
int luas = rumus.persegiPanjang(p,l);

Console.WriteLine($"luas persegi panjang dengan P = {p} dan L= {l} adalah {luas}");


