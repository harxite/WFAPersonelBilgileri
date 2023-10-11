using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPersonelBilgileri
{
    internal class Personel
    {
		private int personelID;

		public int PersonelID
		{
			get 
			{ 
				return personelID; 
			}
			set 
			{
				if (value.ToString().Length != 5)
				{
					throw new Exception("Personel ID 5 karakterden daha az ya da fazla olamaz!");
				}
				else
					personelID = value; 
			}
		}

		private DateTime dogumTarihi;

		public DateTime DogumTarihi
		{
			get 
			{ 
				return dogumTarihi;
			}
			set 
			{
				if((DateTime.Now - value).TotalDays/365.25 < 18) 
				{
                    throw new Exception("Personel 18 yaşından küçük olamaz!");
                }
				else
					dogumTarihi = value; 
			}
		}

		private string email;

		public string Email
		{
			get 
			{
				return email; 
			}
			set 
			{
				if(value.EndsWith("@gmail.com") || value.EndsWith("@hotmail.com"))
                    email = value;
				else
                    throw new Exception("Mail adresi doğru formatta girilmedi !");
            }
		}

		private DateTime iseGirisTarihi;

		public DateTime IseGirisTarihi
		{
			get 
			{
				return iseGirisTarihi;
			}
			set 
			{ 
				if(value > DateTime.Now)
				{
                    throw new Exception("Bugünden daha ileri bir tarihi seçemezsiniz!");
                }
				else
					iseGirisTarihi = value; 
			}
		}

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string ResimYolu { get; set; }

    }
}
