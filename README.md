### United Payment Case Study

Bu uygulama gönderilmiş olan case study isterlerini içeren .Net Core Web Api Uygulamasıdır.Uygulama katmanlı mimari ve code first yaklaşımı ile geliştirilmiştir.

## Kullanılan Teknoloji ve Kütüphaneler

<ul>
    <li>AutoMapper</li>
    <li>Npgsql</li>
    <li>NHibernate & Fluent NHibernate</li>
    <li>Fluent Validation</li>
</ul>

## Uygulamanın Çalıştırılması

Yukarıda belirtilen teknoloji ve kütüphanelerin projeye dahil edilmesi gerekmektedir.
Gerekli kütüphaneler eklendikten sonra AppSettings.json dosyası içerisinde aşağıda belirtilen bilgilerin girilmesi gerekmektedir.
Bilgileri girdikten sonra uygulamayı çalıştırabilirsiniz.

###### Veri Tabanı Baglantı Ayarları
```json
"AllowedHosts": "*",
    "ConnectionStrings": { 
    "PostgreSqlConnection": "User ID = '';Password = '';Server='' ;Port='' ;Database = '';Integrated Security= true;Pooling= true;" 
  }
```
