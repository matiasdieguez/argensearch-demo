# argensearch-demo

Esta librería es un cliente en C# para las búsqueda de personas en AFIP

## Instalación

install-package argensearch

## Ejemplos

```csharp
using ArgenSearch;

var persona = await ArgenSearchClient.Search(123456);

var id = persona.Data[0];

var datos = await ArgenSearchClient.Detail(id);
```
