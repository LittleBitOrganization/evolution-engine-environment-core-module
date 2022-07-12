# Environment Core Module

## AdRevenueAnalytics

Класс, который автоматически отправляет ивенты Ad Revenue, т.е. является связующим звеном между <b> Ads Module </b> и <b> Analytics Module </b>

Интеграция: 
1. Проверить, что интегрированы <b> Ads Module </b> 2.1.2, <b> Analytics Module </b> 1.0.8, <b> Environment Core Module </b> 1.0.2 

2. Если <b> Analytics Module </b> уже интегрирован, проверить, чтобы биндинг <b> EventService </b> соответствовал следующему стандарту (чтобы также биндились его интерфейсы):
```c#
Container
  .BindInterfacesAndSelfTo<EventsService>()
  .AsSingle()
  .NonLazy();
```

3. Инстанцировать <b> AdRevenueAnalytics </b>:
```c#
Container
  .BindInterfacesAndSelfTo<AdRevenueAnalytics>()
  .AsSingle()
  .NonLazy();
```

Можно посмотреть, как это сделано на Garden Evolution:

```c#
            var builder = new MaxSdkAdsServiceBuilder(_adsConfig, _coroutineRunner);

            builder.BuildInterAdUnit();
            builder.BuildRewardedAdUnit();

            var adsService = builder.GetResult();
            adsService.Run();

            Container
                .Bind<IReadOnlyList<IAdUnit>>()
                .FromInstance(builder.CreatedAdUnits)
                .AsSingle()
                .NonLazy();

            Container
                .Bind<MaxSdkInitializer>()
                .FromInstance((MaxSdkInitializer) builder.Initializer)
                .AsSingle()
                .NonLazy();

            Container
                .Bind<IMediationNetworkAnalytics>()
                .To<MaxSdkAnalytics>()
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<IAdsService>()
                .FromInstance(adsService);

            Container
                .Bind<Ads.AdsServiceWrapper>()
                .AsSingle()
                .NonLazy();

                //Отслеживает доход с рекламы
            Container
                 .Bind<AdRevenueAnalytics>()
                 .AsSingle()
                 .NonLazy();

```
