🧩 N Katmanlı Mimari (C# - ADO.NET)

Bu proje, C# dili kullanılarak N Katmanlı Mimari (N-Layer Architecture) yapısında geliştirilmiş örnek bir uygulamadır. Amaç; yazılım projelerinde katmanlar arası bağımlılığı azaltmak, bakımı kolaylaştırmak ve kurumsal ölçekli yapılara uygun bir mimariyi örneklemektir.

📐 Mimari Yapı

Proje dört ana katmandan oluşur:

Katman	Açıklama
EntityLayer	Veritabanı tablolarını temsil eden Entity sınıfları bulunur.
DataAccessLayer (DAL)	Veritabanı işlemleri (CRUD) ve sorgular ADO.NET ile gerçekleştirilir.
LogicLayer (BLL)	İş mantığı, doğrulama, ve veritabanı işlemlerinin kontrolü burada yapılır.
NKatmanliMimari (UI)	Kullanıcı arayüzü veya sunum katmanıdır (örnek olarak konsol veya WinForms).
⚙️ Kullanılan Teknolojiler

C# / .NET Framework

ADO.NET

Katmanlı Mimari (N-Layer Architecture)

Object-Oriented Programming (OOP)

💡 Proje Amacı

Katmanlı mimarinin çalışma mantığını göstermek,
veri erişim katmanını soyutlayarak iş mantığı katmanından ayırmak
ve temiz, yeniden kullanılabilir, sürdürülebilir kod yapısı oluşturmaktır.

🚀 Uygulama Senaryosu

Kullanıcı, veritabanı üzerinden kayıt ekleme, silme, güncelleme ve listeleme işlemlerini
arayüz veya konsol ekranı aracılığıyla gerçekleştirebilir.

🧠 Kazanımlar

Katmanlı mimarinin temel mantığını anlama

DAL, BLL, ve Entity katmanları arasındaki ilişkiyi öğrenme

Bağımlılık yönetimi ve soyutlama kavramlarını uygulama

Kurumsal uygulamalarda sık kullanılan mimari yaklaşımı öğrenme
