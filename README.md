# Environment Core Module

## AdRevenueAnalytics

Класс, который автоматически отправляет ивенты Ad Revenue, т.е. является связующим звеном между <b> Ads Module </b> и <b> Analytics Module </b>

Интеграция: 
1. Проверить, что версии модулей <b> Ads Module </b>, <b> Analytics Module </b>, <b> Environment Core Module </b> на всех проектах актуальны

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

Можно посмотреть, как это сделано на Garden Evolution (AdsInstaller, AnalyticsSystemInstaller)
