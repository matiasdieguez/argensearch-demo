# argensearch-demo

Esta librería es un cliente en C# para las búsqueda de personas en AFIP

## Instalación

install-package argensearch

## Ejemplos

var persona = ArgenSearch.Search(123456);
var id = persona.Documentos[1];

var datos = ArgenSearch.Detail(id);

