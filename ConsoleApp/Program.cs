#region 1.ÖDEV
//Console.WriteLine("Merhaba\r\nNasılsın ?\r\nİyiyim\r\nSen nasılsın ?\r\n");
#endregion
#region 2.ÖDEV
//int tamSayi = 0;
//string metinsel = " ";
//Console.WriteLine(tamSayi);
//Console.WriteLine(metinsel);
#endregion
#region 3.ÖDEV
//Random rnd = new Random();
//int rasgeleSayi = rnd.Next();
//Console.WriteLine(rasgeleSayi);
#endregion
#region 4.ÖDEV
//Random rastgele = new Random();
//int sayi = rastgele.Next();
//Console.WriteLine(sayi%3);


#endregion
#region 5.ÖDEV
//Console.WriteLine("Yaşınızı girin");
//int age = int.Parse(Console.ReadLine());
//if (age < 18)
//{
//    Console.WriteLine("18den büyük");
//}

//else Console.WriteLine("18den küçük");

#endregion
#region 6.ÖDEV
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
//}
#endregion
#region 7.ÖDEV
//string name1 = "Gülse Birsel";
//string name2 = "Demet Evgar";
//string degistirilmisHali = name1;
//name1 = name2;
//name2 = degistirilmisHali;
//Console.WriteLine(name1);
//Console.WriteLine(name2);
#endregion
#region 8.ÖDEV
//benDegerDondurmem();
//void benDegerDondurmem()
//{
//    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
//}
#endregion
#region 9.ÖDEV
//Topla();
//int Topla()
//{
//    Console.WriteLine("Bir Sayı Giriniz");
//    int sayi1=int.Parse(Console.ReadLine());
//    Console.WriteLine("İkinci Sayı Giriniz");
//    int sayi2 = int.Parse(Console.ReadLine());
//    Console.WriteLine(sayi1+sayi2);
//    return  sayi1 + sayi2;
//}
#endregion
#region 10.ÖDEV

//kullancıdanGirilenDeger(a);


//string kullancıdanGirilenDeger(bool deger)
//{
//    return deger ? "Giriş Başarılı" : "Giriş Başarısız..";
//}



#endregion
#region 11.ÖDEV

//int yasHesaplayanMetot()
//{
//    Console.WriteLine("1.Yas gir");
//    int yas1 = int.Parse(Console.ReadLine());
//    Console.WriteLine("2.Yas gir");
//    int yas2 = int.Parse(Console.ReadLine());
//    Console.WriteLine("3.Yas gir");
//    int yas3 = int.Parse(Console.ReadLine());

//    if (yas1 > yas2 && yas1 > yas3)
//    {
//        Console.WriteLine("en büyük" + yas1);
//        return yas1;
//    }
//    else if (yas2 > yas1 && yas2 > yas3)
//    {

//        Console.WriteLine("en büyük" + yas2);
//        return yas2;
//    }
//    else if (yas3 > yas2 && yas3 > yas1)
//    {

//        Console.WriteLine("en büyük" + yas3);
//        return yas3;
//    }
//    else Console.WriteLine("Sayılar birbirine eşittir.");
//    return 0;


//}

#endregion
#region 12.ÖDEV
//int sınırsızSayiMetod()
//{
//    List<int> numbers = new List<int>();
//    string input;
//    Console.WriteLine("Bir sayı giriniz/Çıkmak için 'q' harfine basınız");

//    while (true)
//    {
//        input = Console.ReadLine();
//        if (input == "q")
//        {
//            Console.WriteLine("");
//            break;
//        }

//        if (int.TryParse(input, out int number))
//        {
//            numbers.Add(number);
//            Console.WriteLine("numara eklendi..");
//        }
//        else
//        {
//            Console.WriteLine("tekrar dene");
//        }
//    }
//    int enbüyük = 0;
//    foreach (int number in numbers)
//    {
//        if (number > enbüyük)
//        {
//            enbüyük = number;
//        }

//    }

//    Console.WriteLine("En büyük sayı :" + enbüyük);
//    return enbüyük;

//}

#endregion
#region 13.ÖDEV
//Console.WriteLine("İsim Giriniz");
//string name1 = Console.ReadLine();
//Console.WriteLine("İsim Giriniz");
//string name2 = Console.ReadLine();
//string switchName = "";
//switchFunaction(name1, name2);


//string switchFunaction(string name1, string name2)
//{
//    Console.WriteLine($"ilk isin {name1}, ikinci isim {name2}");
//    switchName = name1;
//    name1 = name2;
//    name2 = switchName;
//    Console.WriteLine($"ilk isim {name1}, ikinci isim {name2}");
//    return name1;
//    return name2;

//}


#endregion
#region 14.ÖDEV
//Console.WriteLine("Sayı Giriniz");
//int number = int.Parse(Console.ReadLine());
//bool result;
//Condition();



//bool Condition()
//{
//    if (number % 2 == 0)
//    {
//        Console.WriteLine("Sayı çifttir");
//        result = true;
//    }
//    else
//    {
//        Console.WriteLine("Sayı Tektir.");
//        result = false;
//    }
//    return result;
//}


#endregion
#region 15.ÖDEV
//double yolHesaplama()
//{
//    Console.WriteLine("Saatte kaç Km Hızla Gittin.");
//    int hiz = int.Parse(Console.ReadLine());
//    Console.WriteLine("Kaç Saat Gittin");
//    double saat = double.Parse(Console.ReadLine());
//    double gidilenyol = saat * hiz;
//    Console.WriteLine(gidilenyol);
//    return gidilenyol;

//}

#endregion
#region 16.ÖDEV
//double AlanHesaplama()
//{
//    Console.WriteLine("Kullanıcıdan bir yarıçap giriniz");
//    double yariCap = double.Parse(Console.ReadLine());
//    double alan = yariCap * Math.PI;
//    return alan;

//}
#endregion
#region 17.ÖDEV

//string cümle = "ZamAn BiR GeRi SaYıM";
//Console.WriteLine(cümle.ToLower());
//Console.WriteLine(cümle.ToUpper());


#endregion
#region 18.ÖDEV
//string hi = "   Selam   ";
//Console.WriteLine(hi.Trim());
#endregion