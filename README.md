# Funcionamiento Base de Datos

## Tabla de Articulos
!["Imagen"](https://i.imgur.com/MCebcZt.png)
### > ID

**Descripcion:** Esta columna servirá como identificador único en la tabla para caracterizar e individualizar consultas. 
**Características:** [Integer] Clave Primaria, Auto Incrementable, Se asigna automaticamente


### > Nombre

**Descripcion:** Esta columna contiene el nombre del articulo
**Características:** [Text] Necesario


### > Cantidad

**Descripcion:** Esta columna contiene la cantidad por la columna de articulos.unidad
**Características:** [Integer] Default 0


### > Descripcion

**Descripcion:** Esta columna contiene la descripcion general del articulo
**Características:** [Text] No Necesario


### > Codigo

**Descripcion:** Esta columna contiene el codigo del producto en texto
**Características:** [Text] Necesario


### > Unidad

**Descripcion:** Esta columna contiene la unidad a elegir
**Características:** [SmallInt] Se basa en numeros únicos que harán como clasificadores al momento de codificarse

**Codificaciones**
**0:** Indefinido
**1:** Unidad (ej: 1* botella de agua)
**2:** Kg (ej: 1* Kilo de Mango)
**3:** Litros (ej: 1* Litro de Agua)
- [x] #739
- [ ] https://github.com/octo-org/octo-repo/issues/740
- [ ] Add delight to the experience when all tasks are complete :tada: