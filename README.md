```diff
+ yapildi
``` 
1. Aldığı id route değerine göre arama motoruna yönlenen action'ını yazın. Örneğin;


gorev/arama/google => google.com
gorev/arama/yandex => yandex.com.tr gibi


eğer olmayan bir arama motoru girerse default google'a yönlensin.

```diff
+ yapildi
``` 
2. Rastgele resim döndüren action
gorev/resim => wwwroot/images içinde yer alan resimlerden birini rastgele döndürebilir.


ipucu: resimlerin adlarını 1.png, 2.png şeklinde verip random sınıfını kullanabilirsiniz.

```diff
+ yapildi
``` 
3. Verdiğiniz string koleksiyonunu aşağıdaki bootstrap listesine çeviren tag helper'ı oluşturup kullanın.


<listele ogeler="dizi" />


<ul class="list-group">
  <li class="list-group-item">Ankara</li>
  <li class="list-group-item">İzmir</li>
  <li class="list-group-item">Bursa</li>
  <li class="list-group-item">İstanbul</li>
</ul>


not: element mümkünse kendini kapatan tag'dan oluşsun.

```diff
- Yapımadı
``` 
4. Anasayfanızın vitrinine bir slide show koymak istiyorsunuz. Burada sitenizle ilgili bazı görseller dönecektir. Bunun için https://getbootstrap.com/docs/5.1/components/carousel/#with-captions adresindeki carousel'i kullanabilirsiniz.


Ancak kod kalabalığını önlemek adına bunu bir partial view içinde oluşturup sayfanıza dahil etmeniz istenmektedir.


Not: Örnek resimler için https://picsum.photos/ adresini kullanabilirsiniz.


```diff
- Yapımadı
``` 
5. gorev/rastgele adresine girildiğinde rastgele 6 sayıyı json formatında döndürsün.

```diff
+ yapildi
``` 
6. [EXTRA] 
gorev/kirp/orman.jpg?genislik=500&yukseklik=400
adresine girildiğinde wwwroot/images/orman.jpg dosyasını belirtilen boyutlarda kırparak resim dosyası olarak döndürsün.
