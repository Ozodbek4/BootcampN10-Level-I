using N21Home1.Classes;

PaymePaymentProvider havasPaymePaymentProvider = new PaymePaymentProvider();
KapitalUzcard havasCard = new KapitalUzcard("9600505023231212", "Apelsin", 0D);


Product product = new Product("Muzqaymoq", 10_000);
Product product1 = new Product("Tuxum", 1_600);
Product product2 = new Product("Pepsi 1.5", 13_000);
Product product3 = new Product("Muzqaymoq", 10_000);

OnlineMarket online = new OnlineMarket(havasPaymePaymentProvider, havasCard);
online.Add(product, 230);
online.Add(product1, 100);
online.Add(product2, 30);
online.Add(product3, 35);


KapitalUzcard kapitalUzcard = new KapitalUzcard("123446574681325", "Apelsin", 1_000_000D);

online.Buy("Muzqaymoq", 2, kapitalUzcard);
online.DisplayBalance(havasCard);
online.DisplayBalance(kapitalUzcard);
