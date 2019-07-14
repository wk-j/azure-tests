## Commands

```
dotnet test tests/MyWeb.Tests/MyWeb.Tests.csproj \
    --configuration Release  \
    --logger trx \
    /p:CollectCoverage=true \
    /p:CoverletOutputFormat=cobertura
```