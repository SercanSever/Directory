
# Directory

####  Proje bir telefon rehberi demosudur. Rehberdeki kişilerin iletişim bilgilerini crud işlemlerle aktaran bir .Net Core Rest Api projesidir. 

### Katmanlar

#### Entity
 Entity katmanı Db tablolarının nesnel karşılıklarını ve dto nesnelerini içermektedir. Code First yaklaşımı ile Db oluşturulmuştur.
#### DataAccess
 Bu katmanda Db bağlantıları bulunmaktadır. Katmanda bağlantılar generic repository pattern implementasyonuyla yapılmıştır. DbContext, tablolarının DbSetleri ve Migration kayıtları bu katmanda yer almaktadır. 
#### Business
 Projenin iş kurallarının kodlandığı katmandır. Tüm classlar için implementasyon yapılmış ve Dependecy Injection ile katmanlar arası soyutlama uygulanmıştır. Implementasyonlar için olan Dependecy Injection modülü bu katmanda yer almaktadır.
Dependency Injection için Autofac kütüphanesinden yararlanılmıştır.
#### Api
 Projenin sunum katmanıdır. İki ApiController bulunmaktadır. 
 
1 - ContactController - Rehberdeki kişilerin crud işlemlerinin sunulduğu controller.

2 - InformationController - Rehberdeki kişilerin bilgilerinin ve crud işlemlerinin sunulduğu controller. Autofac konfigürasyonu yapılmıştır.
#### Core
 Her projede kullanılabilecek kodlar bu katmanda yer almaktadır. Entitiy FrameworkCore ile crud işlemler kodlanmıştır. Generic Repository Pattern kullanılmış olup DataAccess'e tüm crud işlemler implement edilmiştir.
 #### Core / Utilities 
  * Results - Burada tüm business için ortak dönüş tipi kodlanmıştır. Hata ya da başarılı sonuş için ayrı dönüş tipleri, void ya da data döndüren metotlar için ayrı dönüş tipleri kodlanmıştır.
  * BusinessRules - Business kurallarını daha temiz bir şekilde kodlamak için dönüş tipleri aynı olan metotların kontrolü burada yapılmaktadır. Böylece business katmanında kod yığınında kurtulunmuştur.
  
  #### T-Sql Rehber Raporu Kodu
`select count(l.ContactLocation) as NumberOfLocation, l.ContactLocation, count(distinct c.Name) as NumberOfContaxt , count(p.ContactPhone) as NumberOfPhone from Contacts c inner join [Phones] p on c.ContactId = p.ContactId inner join [Location] l on c.ContactId = l.ContactId group by l.ContactLocation order by count(l.ContactLocation) desc` 
