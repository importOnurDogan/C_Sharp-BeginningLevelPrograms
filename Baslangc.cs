
int sayi = 175;

int Ybasamagi = sayi / 100;
int Obasamagi = (sayi / 10) % 10;
int Bbasamagi = sayi % 10;
Console.WriteLine("Yuzler basamagi : " + Ybasamagi + " Onlar basamagi : " + Obasamagi + " Birler basamagi : " + Bbasamagi);


byte sayiByte = 15;
short sayiShort = sayiByte;

char karakter2 = 'A';
int karakter = karakter2;
byte degisken = 10;
int sonuc = degisken + degisken;

short degiskenShort = 10;
int shortSonuc = degiskenShort + degiskenShort;

string girilenSayi = "158";
short gelenSayi = short.Parse(girilenSayi);
int gelenIntSayi = Convert.ToInt32(girilenSayi);

double gelenDoubleSayi = Convert.ToDouble(girilenSayi);
decimal gelenDecimalSayi = Convert.ToDecimal(gelenDoubleSayi);
float gelenFloatSayi = Convert.ToSingle(gelenDecimalSayi);
int donusturulecekFarkliSayi = 257;
