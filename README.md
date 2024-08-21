# Araba Fabrikası Simülasyonu

Bu program, bir araba fabrikasında araba üretimi simülasyonu yapmaktadır. Kullanıcı, araba üretmek isteyip istemediğini seçer, özelliklerini belirler ve üretilen arabalar bir listeye eklenir. Kullanıcı programın sonuna geldiğinde üretilen arabaların seri numaraları ve markaları listelenir.
## Program Akışı

1. **Araba Üretim Sorusu:**
   - Kullanıcıya araba üretmek isteyip istemediği sorulur. Evet için `e`, hayır için `h` tuşlarına basması istenir. Büyük/küçük harf duyarlılığı ortadan kaldırılmıştır. 
   - Geçersiz bir cevap verildiğinde, kullanıcıya uyarı mesajı verilir ve soru tekrar sorulur.

2. **Araba Üretimi:**
   - Kullanıcı 'evet' cevabını verirse, araba üretimi başlar.
   - Kullanıcıdan aşağıdaki özellikleri girmesi istenir:
     - Marka
     - Model
     - Renk
     - Kapı Sayısı (Kapı sayısında sayısal olmayan bir değer girildiğinde, kullanıcıya hata mesajı verilir ve tekrar denemesi istenir.)

3. **Üretim Tarihi:**
   - Üretim tarihi, araba nesnesi üretildiği anda otomatik olarak atanır.

4. **Araba Nesnesi ve Listeye Ekleme:**
   - Üretilen araba nesnesi `arabalar` isimli listeye eklenir.

5. **Tekrar Üretim Sorusu:**
   - Kullanıcıya yeni bir araba üretmek isteyip istemediği sorulur. Evet cevabı verilirse, program tekrar araba üretim aşamasına döner. Hayır cevabı verilirse, program sonlanır ve tüm üretilen arabaların seri numaraları ve markaları listelenir.

## Hata Yönetimi
- Kapı sayısı için sayısal olmayan bir değer girildiğinde, program kullanıcıyı uyarır ve doğru bir değer girene kadar giriş işlemi tekrarlanır.
- Kullanıcıya geçerli olmayan bir cevap verildiğinde, hata mesajı verilir ve tekrar giriş yapması istenir.

## Nasıl Kullanılır
1. Programı çalıştırın.
2. Araba üretmek isteyip istemediğinizi seçin (`e` veya `h`).
3. Araba üretimi sırasında sizden istenen bilgileri girin.
4. Her araba üretiminden sonra yeni bir araba üretmek isteyip istemediğiniz sorulacaktır.
5. Programı sonlandırdığınızda, üretilen arabaların seri numaraları ve markaları ekranda listelenecektir.

## Gereksinimler
- .NET Framework (veya Core) 5.0 ve üzeri
- Visual Studio IDE (ya da alternatif bir geliştirme ortamı)

## Geliştirici Notları
- Program `goto` komutunu kullanarak yanlış girişlerde kullanıcıyı tekrar giriş yapması için yönlendirir.
- Programda araba nesneleri, dinamik bir listeye (`List<Araba>`) eklenir ve program sonlandırıldığında tüm liste elemanları ekrana yazdırılır.
