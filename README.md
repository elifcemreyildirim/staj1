Kullanıcı adı: Elif
Sifre: 12345

Staj Projesi: Fatura İade Yönetim Sistemi (Aras Kargo)

Bu proje, **Aras Kargo Proje Yönetimi Departmanı**'nda gerçekleştirdiğim 20 iş günlük yazılım geliştirme stajım kapsamında, mevcut faturalama sisteminin temel işlevselliğini yeniden oluşturan bireysel bir uygulamadır. Uygulama, müşteri iade faturalarının girişini, yönetimini ve finansal takibini sağlamaktadır.

 Temel Özellikler ve Geliştirilen Modüller

* **Güvenli Giriş Modülü:** Kullanıcı doğrulama ve yetkilendirme sistemi. Şifreler, veri güvenliği için hashlenerek saklanmaktadır.
* **Dinamik Fatura ve Müşteri Arama:** Müşteri adına veya tarih aralığına göre arama yapma yeteneği sunan, sekmeli arama ekranları.
* **Gelişmiş Fatura Satırı Yönetimi:**
    * **Excel'den Veri Aktarımı:** `OfficeOpenXml` kütüphanesi kullanılarak toplu fatura satırı girişi (irsaliye kontrolü, döviz tutarlılığı validasyonları dahil).
    * **Dinamik Finansal Hesaplama:** TL ve Dövizli tutarlar, KDV ve Genel Toplamların anlık, otomatik hesaplanması ve güncellenmesi.
* **Veri Bütünlüğü ve Validasyon:** Tüm formlar için zorunlu alan, format ve iş mantığına dayalı kapsamlı validasyon kontrolleri.
* **Soft Delete (Mantıksal Silme):** Veri tabanında kayıtların kalıcı olarak silinmek yerine güncellenmesi (`ACTIVE_VERSION=0, AUDIT_DELETED=1`).
* **E-posta Bildirim Sistemi:** Yeni kayıt ve güncelleme işlemlerinde otomatik e-posta gönderimi.

 Kullanılan Teknolojiler

| Kategori | Teknoloji / Dil |
| :--- | :--- |
| **Geliştirme Ortamı** | C# (.NET Framework) |
| **Veri Tabanları** | SQL Server, Oracle (Simülasyon) |
| **Veri Entegrasyonu** | OfficeOpenXml (C#) |
| **Kullanıcı Arayüzü (UI)** | Windows Forms (WinForms) |
| **Güvenlik** | Şifre Hashleme Algoritması |
