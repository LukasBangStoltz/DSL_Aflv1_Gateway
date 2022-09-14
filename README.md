# DSL_Aflv1_Gateway

## Status
Der kan sendes et request til : \
```http://localhost:5094/api/WeatherForecast```   
Måske er jeres port noget andet, kig på jeres Ocelot url når i starter programmet. \
For at sætte flere apier op til gatewayen, kig i ocelot.json filen. Det burde give sig selv. \
Lige nu fungerer gatewayen kun sammen med UserAPI´et, og alle vores microserviceApier indeholder kun den klasseiske Weatherforecast dummy. 

