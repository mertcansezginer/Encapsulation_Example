namespace Encapsulation_Example
{
    class BankaHesabi
    {
        private string _hesapNumarasi; // Hesap no saklamak icin private alan olusturduk   //encapsulation
        private decimal _bakiye; // Bakiyeyi saklamak icin private bir alan olusturduk

        
        public BankaHesabi(string hesapNumarasi, decimal bakiye) //BankaHesabi sinifi icin constructor method
        {
            _hesapNumarasi = hesapNumarasi; // Hesap numarası atadık
            _bakiye = bakiye; // Başlangıç bakiyesi atadık
        }

        // HesapNumarasiAl metodu, hesap numarasını döndürür
        public string HesapNumarasiAl()  //Hesap numarisini döndürür,encapsulation yaptık, _hesapNumarasi na direkt erişim yok.
        {
            return _hesapNumarasi;
        }

        
        public decimal Bakiye           //bakiye(property) değerini döndürür, encapsulation yaptık, _bakiye ye direkt erişim yok.
        {
            get {return _bakiye; }   //property tanımladığımız için get kullandık
        }


        
        public void ParaYatir(decimal miktar)  //hesaba para yatırma metodu tanımladık
        {
            if (miktar > 0) //geçerli bir bakiye değeri girilip girilmediğine bakılır
            {
                _bakiye += miktar; // miktar _bakiye degerine eklenir
                Console.WriteLine($"{miktar} TL yatırıldı. Yeni bakiye: {_bakiye} TL"); 
            }
            else
            {
                Console.WriteLine("Hatalı miktar!"); 
            }
        }

        
        public void ParaCek(decimal miktar)  //hesaptan para çekme metodu
        {
            if (miktar > 0 && miktar <= _bakiye) // geçerli bir değer girildi mi ve _bakiye değeri yeterli mi bakılır.
            {
                _bakiye -= miktar; // miktar degeri _bakiye değerinden çıkarılır
                Console.WriteLine($"{miktar} TL çekildi. Yeni bakiye: {_bakiye} TL"); 
            }
            else
            {
                Console.WriteLine("Hatalı miktar veya yetersiz bakiye!"); 
            }
        }
    }
}
