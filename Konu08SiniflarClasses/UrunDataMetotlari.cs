﻿namespace Konu08SiniflarClasses
{
	public class UrunDataMetotlari
	{
		internal void UrunEkle(Urun urun) //parametre direkt urun alındı
		{
			Console.WriteLine(urun.Adi + " ürünü eklendi!");
		}
		internal void UrunGuncelle(Urun urun)
		{
			Console.WriteLine(urun.Adi + " ürünü güncellendi!");
		}
		internal void UrunSil(Urun urun)
		{
			Console.WriteLine(urun.Adi + " ürünü silindi!");
		}
		internal Urun UrunGetir() //veri dönüş değeri urun sınıfından nesne
		{
			Urun urun = new Urun()
			{
				Adi = "Tv",
				Durum = true,
				Fiyati = 3333
			};
			return urun;
		}
		internal Urun[] Urunler() //Urun dizisi oluşturduk
		{
			return new Urun[] //dönüş değeri Urun
			{
				new()
				{
					Adi = "Bilgisayar",
					Durum = false,
					Fiyati = 42000,
					Id = 1,
					Markasi = "Monster",
					UrunAciklamasi = "Oyun bilgisayarı",
				},
				new()
				{
					Adi = "Laptop",
					Durum = false,
					Fiyati = 48000,
					Id = 2,
					Markasi = "Toshiba",
					UrunAciklamasi = "Dizüstü",
				},
				new()
				{
					Adi = "Telefon",
					Durum = true,
					Fiyati = 58000,
					Id = 3,
					Markasi = "Samsung",
					UrunAciklamasi = "Cep Telefonu",
				}
			};
		}
	}
}