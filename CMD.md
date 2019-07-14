## Commands

```
dotnet test tests/MyWeb.Tests/MyWeb.Tests.csproj \
    --configuration Release  \
    --logger trx \
    /p:CollectCoverage=true \
    /p:CoverletOutputFormat=cobertura
```


```
dotnet tool install -g dotnet-reportgenerator-globaltool
reportgenerator -reports:"tests/**/coverage.cobertura.xml" -targetdir:Report -reporttypes:"HtmlInline_AzurePipelines;Cobertura"
```