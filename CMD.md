## Commands

```
dotnet test tests/MyWeb.Tests/MyWeb.Tests.csproj \
    --logger trx \
    --configuration Release  \
    /p:CollectCoverage=true
```