# AlgoritmaOdev
 Algoritma Analizi Ödev

Dijkstra algoritması ve Zhu-Takaoka algoritması,
 graf tabanlı problemleri çözmek için kullanılan algoritmalar olarak öne çıkmaktadır.

Dijkstra algoritması,
 en kısa yol problemi olarak bilinen bir sorunu çözmek için kullanılmaktadır. Bu problemin amacı, bir graf içindeki iki nokta arasındaki en kısa yolun bulunmasıdır.
  Algoritma, bir başlangıç noktasından diğer tüm noktalara olan en kısa yolları hesaplar ve bir sonlandırma noktası belirtilene kadar devam eder. 
  Algoritma, genellikle bir öncül tablo (predecessor table) kullanarak en kısa yolları takip eder ve öncül tablo, her düğümün en kısa yolu için önceki düğümü gösterir. Dijkstra algoritmasının en iyi durumda çalışma zamanı, V düğüm sayısı ve E kenar sayısı için O((V+E) log V)'dir.

Zhu-Takaoka algoritması ise,
 bir grafın yapısını analiz etmek için kullanılır. Bu algoritma, graf içindeki düğümleri birbirleriyle bağlayan yolları bir araya getirerek düğüm grupları (node cluster) oluşturur.
 Bunu yaparken, düğümlerin birbirine benzerliklerine göre grupları belirler ve benzerliklerin belirlenmesi için bir benzerlik ölçüsü kullanır. Algoritma, düğümlerin benzerliklerine dayanarak farklı birleştirme (merge) stratejileri kullanır. Bu stratejiler, farklı düzeylerdeki benzerlikleri bir araya getirerek grupların oluşturulmasını sağlar.
 Zhu-Takaoka algoritmasının en iyi ve en kötü durumda çalışma zamanı, V düğüm sayısı ve E kenar sayısı için O(V^2)'dir.

En iyi, en kötü ve ortalama sınırlar, bir algoritmanın farklı veri kümeleri üzerinde nasıl çalıştığını ve performansının ne kadar verimli olduğunu belirtir.
 En iyi durum, algoritmanın en hızlı ve en az kaynak tüketen senaryosudur. En kötü durum, algoritmanın en yavaş ve en fazla kaynak tüketen senaryosudur. Ortalama durum ise, veri kümesinin istatistiksel dağılımına dayalı olarak algoritmanın tipik performansını belirtir. 
 Bu nedenle, bir algoritmanın sınırları, çalışma zamanını öngörmede önemli bir özellik olarak kabul edilir.