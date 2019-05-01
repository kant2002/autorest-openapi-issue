# AutoRest OpenAPI issue

> see https://aka.ms/autorest

Steps to reproduce

    # Currently version is 3.0.5196
    npm i -g autorest@beta
    autorest
    dotnet build Client

```yaml 
use-extension:
  "@microsoft.azure/autorest.csharp": "2.3.84"

input-file: openapi.yaml
csharp:
  output-folder: Client
```

You will see 2 warnings and 4 errors.

```
OpenAPI.cs(256,68): error CS1503: Argument 2: cannot convert from 'int' to 'string'
OpenAPI.cs(260,76): error CS1503: Argument 2: cannot convert from 'int?' to 'string'
OpenAPI.cs(264,71): error CS1503: Argument 2: cannot convert from 'bool?' to 'string'
OpenAPI.cs(268,72): error CS1503: Argument 2: cannot convert from 'bool' to 'string'
OpenAPI.cs(254,16): warning CS0472: The result of the expression is always 'true' since a value of type 'int' is never equal to 'null' of type 'int?'
OpenAPI.cs(266,16): warning CS0472: The result of the expression is always 'true' since a value of type 'bool' is never equal to 'null' of type 'bool?'
```
