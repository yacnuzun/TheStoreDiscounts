# TheStoreDiscounts
TheStoreDiscounts Project

Proje bir mağazanın satın alma işlemlerine göre indirim uygulayan bir web tabanlı uygulamadır.

Amacı

Proje bir mağazanın satın alma sırasında yapılacak indirim işlemlerini basitleştirmek amacıyla yazılmıştır.

Başlarken
![Code](https://user-images.githubusercontent.com/96738030/170282690-c5ceeb0f-cf56-4986-be4a-676780f82c9c.png)


Öncelikle uygulamanın Git deposuna gidin  https://github.com/yacnuzun/TheStoreDiscounts uygulamanın hemen üst sağ kısmında bulunan Code butonuna tıklayın.

Buradan istediğiniz türden projeyi indirebilirsiniz.

![SetasStartup](https://user-images.githubusercontent.com/96738030/170284446-8c49bed1-cc12-4f2b-9f08-830fd2fae118.png)

Çalıştırırken

![PackageManager](https://user-images.githubusercontent.com/96738030/170285217-aaa3ecad-be1e-4dcd-95c0-1361459d141e.png)

DataAccess Katmanını başlangıç projesi olarak ayarlayın. 
Tools kısmında Nuget Package Manager Console'u açın. Default Project kısmını DataAccess olarak seçin. Migration hazır olduğu için direk "update-database" komutunu çalıştırın. Böylelikle database oluşturulacaktır. 

![WebAPIStarUp](https://user-images.githubusercontent.com/96738030/170287211-11711161-ffbd-4888-b3a5-95646a0493cf.png)
WebAPIyi başlangıç projesi olarak seçin. Sonrasında Projeyi çalıştırabilirsiniz. 
![Swagger](https://user-images.githubusercontent.com/96738030/170287996-ee222ccc-ad60-42d6-9f54-5646557dc52c.png)
Proje açıldığında sizi Swagger giriş sayfasına yönlendirecektir. Burada Controllerlar ve barındırdığı metodlar bulunur. Müşteri listeleyebilir. Ya da bir fatura bilgisi 
girebilirsiniz. 
![Json](https://user-images.githubusercontent.com/96738030/170296791-5fb4ba09-3f31-43ca-970f-52fedab11b99.png)

Try it out butonuna tıkladıktan sonra açılan Json formatına göre istediğiniz bilgieri girin. Ardından execute butonuna tıkladığınız zaman eğer yanlış
girilmiş bir değer yok ise metod çalışacaktır.

Kullanılan Teknolojiler

WepAPI, #NETCORE, C#, EntityFrameWork 

Bu Proje Yalçın UZUN tarafından yazılmıştır.
