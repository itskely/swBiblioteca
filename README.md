# ACA -- Programación Avanzada

# Sistema de Gestión de Biblioteca

------------------------------------------------------------------------

## PORTADA

**Corporación Unificada Nacional de Educación Superior CUN.**

**PROGRAMA: Programación Avanzada**

### ACA -- Programación Avanzada

### Sistema de Gestión de Biblioteca

**Presentado por:**
Kely Yohana Quilindo Hernandez

**Docente:**\
Veronica Castro

**Fecha:**\
zipaquira septiembre 2026

------------------------------------------------------------------------

# CONTRAPORTADA

**Sistema de Gestión de Biblioteca**

Proyecto desarrollado como evidencia del curso de **Programación
Avanzada**, aplicando Programación Orientada a Objetos, base de datos
relacional, arquitectura por capas, operaciones CRUD, validaciones,
manejo de excepciones y conexión con SQL Server.

**Estudiante(s):** Kely Yohana Quilindo Hernandez
**Programa:** Programación Avanzada
**Grupo:** 53304
**Docente:** Veronica Castro\
**Institución:** Corporación Unificada Nacional de Educación Superior CUN.
**Año:** 2026

------------------------------------------------------------------------

# TABLA DE CONTENIDO



1.  Introducción
2.  Objetivos
    -   2.1 Objetivo general
    -   2.2 Objetivos específicos
3.  Planteamiento del problema
4.  Análisis de requerimientos
5.  Casos de uso
6.  Diagrama de clases
7.  Modelo entidad-relación
8.  Diccionario de datos
9.  Arquitectura del sistema
10. Explicación de los módulos desarrollados
11. Capturas de pantalla del sistema
12. Pruebas de funcionamiento
13. Conclusiones
14. Recomendaciones
15. Referencias bibliográficas

------------------------------------------------------------------------

# 1. INTRODUCCIÓN



El presente documento detalla el desarrollo de un Sistema de Gestión de Biblioteca
en formato de escritorio, diseñado para automatizar la administración de libros, 
estudiantes y el control de préstamos en una institución educativa. La solución se 
construyó utilizando el lenguaje C# y el motor de bases de datos SQL Server, 
aplicando los principios de la Programación Orientada a Objetos (POO).

A lo largo del informe se exponen el planteamiento del problema, los requerimientos del software, 
los diagramas demodelado (clases, casos de uso y entidad-relación), el diccionario de datos y la arquitectura 
técnica del sistema, ofreciendo una visión integral del proyecto desarrollado.

------------------------------------------------------------------------

# 2. OBJETIVOS

## 2.1 Objetivo general

Desarrollar una aplicación de escritorio utilizando C# y SQL Server que permita
gestionar los procesos principales de una biblioteca mediante la aplicación de
Programación Orientada a Objetos y conexión a bases de datos.


## 2.2 Objetivos específicos

Para el correcto desarrollo e implementacion del sistema,se plantean las siguientes metas tecnicas y operativas:
- Aplicar los principios de Programación Orientada a Objetos.
- Diseñar una base de datos relacional.
- Implementar operaciones CRUD.
- Utilizar SQL Server como gestor de base de datos.
- Implementar arquitectura por capas.
- Validar información ingresada por el usuario.
- Manejar excepciones.
- Utilizar Git y GitHub como sistema de control de versiones.
- Documentar técnicamente el proyecto. 

------------------------------------------------------------------------

# 3. PLANTEAMIENTO DEL PROBLEMA

## 3.1 Descripción del problema

Una institución educativa desea automatizar el proceso de administración de su
biblioteca.
Actualmente toda la información relacionada con los libros, estudiantes,
préstamos y devoluciones se realiza manualmente, ocasionando pérdida de
información, errores en los registros y dificultad para consultar el estado de los
préstamos.
Para solucionar esta problemática se requiere desarrollar un sistema de escritorio
que permita administrar de forma organizada toda la información de la biblioteca.

## 3.2 Justificación

El desarrollo de este sistema permitirá organizar y facilitar la administración de
la biblioteca, reduciendo errores y pérdida de información. Además, permitirá controlar
de manera rápida y eficiente los libros, estudiantes, préstamos y devoluciones, mejorando
el manejo de la información y el servicio de la biblioteca.

## 3.3 Alcance

El sistema permitirá:

-   Gestionar libros.
-   Gestionar autores.
-   Gestionar categorías.
-   Gestionar usuarios.
-   Registrar préstamos.
-   Registrar devoluciones.
-   Consultar disponibilidad.
-   Consultar historial de préstamos.




------------------------------------------------------------------------

# 4. ANÁLISIS DE REQUERIMIENTOS

## 4.1 Descripción general

El Sistema de Gestión de Biblioteca permitirá administrar la información de libros,
autores, categorías y usuarios, además de controlar los procesos de préstamos, 
devoluciones y consultas de disponibilidad e historial.

## 4.2 Actores del sistema

  -----------------------------------------------------------------------
  Actor                               Descripción
  ----------------------------------- -----------------------------------
  Bibliotecario / Administrador       Se encarga de registrar y gestionar libros, autores,
                                      categorías y usuarios. También registra préstamos y
                                      devoluciones, consulta la disponibilidad de los libros
                                      y revisa el historial de préstamos.

 



## 4.3 Requerimientos funcionales

  -----------------------------------------------------------------------
  Código                  Requerimiento           Descripción
  ----------------------- ----------------------- -----------------------
  RF01                    Gestionar libros        Registrar, consultar,
                                                  actualizar, eliminar y
                                                  buscar libros.

  RF02                    Gestionar autores       Registrar, consultar,
                                                  actualizar y eliminar
                                                  autores.

  RF03                    Gestionar categorías    Registrar, consultar,
                                                  actualizar y eliminar
                                                  categorías.

  RF04                    Gestionar usuarios      Registrar, consultar,
                                                  actualizar y eliminar
                                                  usuarios.

  RF05                    Registrar préstamos     Registrar préstamos y
                                                  actualizar la
                                                  disponibilidad de los
                                                  libros.

  RF06                    Registrar devoluciones  Registrar devoluciones,
                                                  calcular retrasos y
                                                  multa cuando aplique.

  RF07                    Realizar consultas      Consultar libros
                                                  disponibles, libros
                                                  prestados, historial y
                                                  usuarios con préstamos
                                                  activos.





## 4.4 Requerimientos no funcionales

  -----------------------------------------------------------------------
  Código                  Requerimiento           Descripción
  ----------------------- ----------------------- -----------------------
  RNF01                   Usabilidad              La interfaz debe ser
                                                  clara, sencilla y fácil
                                                  de utilizar.

  RNF02                   Validación              El sistema debe validar
                                                  la información
                                                  ingresada por el
                                                  usuario.

  RNF03                   Mantenibilidad          El código debe estar
                                                  organizado y
                                                  documentado.

  RNF04                   Arquitectura            El sistema debe
                                                  utilizar una
                                                  arquitectura por capas.

  RNF05                   Manejo de excepciones   Las operaciones deben
                                                  manejar errores de
                                                  forma controlada.

  RNF06                   Integridad de datos     La información debe
                                                  mantenerse consistente
                                                  en la base de datos.

  RNF07                   Consultas               Las consultas a la base
                          parametrizadas          de datos deben utilizar
                                                  parámetros.

  
## 4.5 Reglas de negocio

### RN01 -- Código único del libro

No se permitirá registrar dos libros con el mismo código.

### RN02 -- Datos obligatorios

No se permitirá almacenar registros con campos obligatorios vacíos.

### RN03 -- Usuario existente

No se podrá registrar un préstamo para un usuario inexistente.

### RN04 -- Libro existente

No se podrá registrar un préstamo para un libro inexistente.

### RN05 -- Disponibilidad

No se podrá prestar un libro cuando no existan ejemplares disponibles.

### RN06 -- Actualización de disponibilidad

Al registrar un préstamo, la disponibilidad del libro deberá
actualizarse.

### RN07 -- Devolución

Al registrar una devolución, la disponibilidad deberá actualizarse
nuevamente.

### RN08 -- Multa

La multa se calculará únicamente cuando exista retraso en la devolución.


------------------------------------------------------------------------

# 5. CASOS DE USO

## 5.1 Descripción

Describir cómo interactúan los actores con las funcionalidades
principales del sistema.

## 5.2 Diagrama de casos de uso



`![Diagrama de casos de uso](Diagrama De Casos De Uso - Biblioteca .png)`

## 5.3 Descripción de casos de uso

### CU01 -- Gestionar libros

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar, consultar, actualizar, eliminar y
buscar libros.

**Precondiciones:** - El usuario debe tener acceso al sistema.

**Flujo principal:** 1. El actor ingresa al módulo de libros. 2. El
sistema muestra los libros registrados. 3. El actor selecciona la
operación que desea realizar. 4. El sistema procesa la solicitud. 5. El
sistema muestra el resultado.


------------------------------------------------------------------------

### CU02 -- Registrar préstamo

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar el préstamo de uno o varios libros a
un usuario.

**Precondiciones:** - El usuario debe existir. - El libro debe
existir. - Debe existir disponibilidad.

**Flujo principal:** 1. Seleccionar usuario. 2. Seleccionar libro. 3.
Verificar disponibilidad. 4. Registrar préstamo. 5. Actualizar
disponibilidad. 6. Mostrar confirmación.

**Flujos alternativos:** - Usuario inexistente. - Libro inexistente. -
Libro sin disponibilidad.
**Postcondiciones:** - El préstamo queda registrado. - La disponibilidad
del libro queda actualizada.

------------------------------------------------------------------------

### CU03 -- Registrar devolución

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar la devolución de un libro prestado.

**Precondiciones:** - Debe existir un préstamo activo.

**Flujo principal:** 1. Seleccionar el préstamo. 2. Registrar la
devolución. 3. Calcular días de retraso. 4. Calcular multa cuando
corresponda. 5. Actualizar disponibilidad. 6. Actualizar el estado del
préstamo. 7. Mostrar confirmación.


**Postcondiciones:** - La devolución queda registrada. - El libro vuelve
a estar disponible según corresponda.

------------------------------------------------------------------------

# 6. DIAGRAMA DE CLASES

## 6.1 Descripción

Describir las principales clases utilizadas en el sistema y su
responsabilidad.

## 6.2 Diagrama de clases

Insertar aquí el diagrama de clases.

`![Diagrama de clases](Diagrama De Clases - Biblioteca .png)`

## 6.3 Principales clases

  Clase             Responsabilidad
  ----------------- --------------------------------------------------------
  Libro             Representar y gestionar la información de los libros.
  Autor             Representar y gestionar los autores.
  Categoria         Representar las categorías de los libros.
  Usuario           Representar los usuarios de la biblioteca.
  Prestamo          Gestionar la información de los préstamos.
  DetallePrestamo   Relacionar los libros incluidos en un préstamo.
  Devolucion        Gestionar las devoluciones y calcular retrasos/multas.
 
## 6.4 Aplicación de POO



-  Clases: Se crearon clases para representar las entidades principales del sistema, como Libro, Autor, Categoría, Usuario y Préstamo.
-  Objetos: Se crean objetos a partir de las clases para trabajar con la información de cada libro, usuario, préstamo, entre otros.
-  Constructores: Se utilizan para inicializar los objetos con sus datos correspondientes.
-  Métodos: Permiten realizar acciones como registrar, actualizar, eliminar y consultar información.
-  Propiedades: Representan los datos de cada objeto, como el título de un libro, nombre del autor o información del usuario.
-  Encapsulamiento: Se utiliza para proteger los datos de las clases mediante propiedades y modificadores de acceso.
-  Colecciones: Se pueden utilizar colecciones para almacenar y manejar grupos de objetos, como listas de libros o usuarios.

------------------------------------------------------------------------

# 7. MODELO ENTIDAD-RELACIÓN

## 7.1 Descripción

El Modelo Entidad-Relación (MER) diseñado representa la estructura lógica
de los datos que soportan las operaciones de la biblioteca, asegurando la
integridad, consistencia y eliminación de redundancias mediante relaciones 
bien definidas.

## 7.2 Diagrama entidad-relación



`![Modelo entidad-relación](Analisis BD.png)`

## 7.3 Relaciones principales

A continuación se describen las relaciones e integridad referencial establecidas en el modelo de datos:

- *Un autor puede escribir muchos libros:* La tabla LIBROS recibe la clave foránea IdAutor para asociar la obra con su respectivo creador.
- *Una editorial puede publicar muchos libros:* Se establece una relación de uno a muchos ($1:N$) mediante la clave foránea IdEditorial en la tabla LIBROS.
- *Un usuario puede realizar muchos préstamos:* Cada transacción en la tabla PRESTAMOS se vincula con el lector usando la clave foránea IdUsuario.
- *Un préstamo corresponde a un libro específico:* La tabla PRESTAMOS almacena de forma directa el ISBN del libro que ha sido retirado.
------------------------------------------------------------------------

# 8. DICCIONARIO DE DATOS

`![Diccionario de datos](Diccionario De Datos - Biblioteca .png)`

## 8.1 Convenciones

  Abreviatura   Significado
  ------------- -----------------------------
  PK            Clave primaria
  FK            Clave foránea
  UQ            Campo con valor único
  NULL          Campo que puede estar vacío
  NOT NULL      Campo obligatorio

## 8.2 Tabla: Autor

  Campo             Tipo de dato   Clave   Nulo   Descripción
  ----------------- -------------- ------- ------ --------------------------------
  idAutor           INT            PK      No     Identificador único del autor.
  nombre            VARCHAR(100)   \-      No     Nombre del autor.
  apellidos         VARCHAR(100)   \-      No     Apellidos del autor.
  nacionalidad      VARCHAR(50)    \-      Sí     Nacionalidad del autor.
  fechaNacimiento   DATE           \-      Sí     Fecha de nacimiento.

## 8.3 Tabla: Categoria

  Campo         Tipo de dato   Clave   Nulo   Descripción
  ------------- -------------- ------- ------ --------------------------------------
  idCategoria   INT            PK      No     Identificador único de la categoría.
  nombre        VARCHAR(50)    UQ      No     Nombre de la categoría.
  descripcion   VARCHAR(200)   \-      Sí     Descripción de la categoría.

## 8.4 Tabla: Libro

  Campo             Tipo de dato   Clave   Nulo   Descripción
  ----------------- -------------- ------- ------ -----------------------------------
  idLibro           INT            PK      No     Identificador único del libro.
  codigo            VARCHAR(20)    UQ      No     Código único del libro.
  titulo            VARCHAR(200)   \-      No     Título del libro.
  anioPublicacion   INT            \-      Sí     Año de publicación.
  idAutor           INT            FK      No     Autor asociado al libro.
  idCategoria       INT            FK      No     Categoría del libro.
  cantidad          INT            \-      No     Cantidad de ejemplares.
  estado            VARCHAR(20)    \-      No     Estado del libro.
  sinopsis          VARCHAR(500)   \-      Sí     Descripción o sinopsis del libro.

## 8.5 Tabla: Usuario

  Campo             Tipo de dato   Clave   Nulo   Descripción
  ----------------- -------------- ------- ------ ----------------------------------
  idUsuario         INT            PK      No     Identificador único del usuario.
  documento         VARCHAR(20)    UQ      No     Número de documento.
  tipoDocumento     VARCHAR(20)    \-      No     Tipo de documento.
  nombre            VARCHAR(100)   \-      No     Nombre del usuario.
  apellidos         VARCHAR(100)   \-      No     Apellidos del usuario.
  direccion         VARCHAR(150)   \-      Sí     Dirección del usuario.
  telefono          VARCHAR(20)    \-      Sí     Teléfono de contacto.
  correo            VARCHAR(100)   \-      Sí     Correo electrónico.
  fechaNacimiento   DATE           \-      Sí     Fecha de nacimiento.
  estado            VARCHAR(20)    \-      No     Estado del usuario.

## 8.6 Tabla: Prestamo

  Campo           Tipo de dato   Clave   Nulo   Descripción
  --------------- -------------- ------- ------ -----------------------------------
  idPrestamo      INT            PK      No     Identificador único del préstamo.
  idUsuario       INT            FK      No     Usuario que realiza el préstamo.
  fechaPrestamo   DATETIME       \-      No     Fecha del préstamo.
  estado          VARCHAR(20)    \-      No     Estado del préstamo.

## 8.7 Tabla: DetallePrestamo

  ---------------------------------------------------------------------------------------
  Campo                     Tipo de dato    Clave          Nulo           Descripción
  ------------------------- --------------- -------------- -------------- ---------------
  idDetalle                 INT             PK             No             Identificador
                                                                          único del
                                                                          detalle.

  idPrestamo                INT             FK             No             Préstamo al que
                                                                          pertenece.

  idLibro                   INT             FK             No             Libro prestado.

  fechaDevolucionEstimada   DATE            \-             No             Fecha estimada
                                                                          de devolución.

  fechaDevolucionReal       DATE            \-             Sí             Fecha real de
                                                                          devolución.

  valor                     DECIMAL(10,2)   \-             No             Valor asociado
                                                                          al préstamo, si
                                                                          aplica.

  multa                     DECIMAL(10,2)   \-             Sí             Valor de la
                                                                          multa generada.

  estado                    VARCHAR(20)     \-             No             Estado del
                                                                          detalle.

  ---------------------------------------------------------------------------------------

## 8.8 Tabla: Devolucion

  Campo             Tipo de dato    Clave   Nulo   Descripción
  ----------------- --------------- ------- ------ ---------------------------------------
  idDevolucion      INT             PK      No     Identificador único de la devolución.
  idDetalle         INT             FK      No     Detalle del préstamo devuelto.
  fechaDevolucion   DATETIME        \-      No     Fecha de devolución.
  diasRetraso       INT             \-      No     Número de días de retraso.
  multa             DECIMAL(10,2)   \-      Sí     Valor de la multa, si aplica.



------------------------------------------------------------------------

# 9. ARQUITECTURA DEL SISTEMA

## 9.1 Descripción general

El Sistema de Gestión de Biblioteca se desarrolla utilizando una
**arquitectura por capas**, con el propósito de separar las
responsabilidades del sistema y facilitar su mantenimiento, organización
y evolución.

La arquitectura está compuesta por:

1.  Capa de Presentación.
2.  Capa de Lógica de Negocio.
3.  Capa de Acceso a Datos.
4.  Capa de Base de Datos.

## 9.2 Diagrama de arquitectura



`![Arquitectura del sistema](Arquitectura Del Sistema.png)`

## 9.3 Capa de Presentación

**Responsabilidad:**

Es la capa mediante la cual el usuario interactúa con el sistema.

**Componentes:**

-   FrmPrincipal
-   FrmLibros
-   FrmAutores
-   FrmCategorias
-   FrmUsuarios
-   FrmPrestamos
-   FrmDevoluciones

**Tecnología utilizada:**

-   C#
-   Windows Forms
-   Visual Studio

## 9.4 Capa de Lógica de Negocio

**Responsabilidad:**

Procesa las solicitudes provenientes de la interfaz, aplica las reglas
de negocio y coordina las operaciones.

**Componentes:**

-   LibroController
-   AutorController
-   CategoriaController
-   UsuarioController
-   PrestamoController
-   DevolucionController

**Ejemplos de reglas:**

-   Validar disponibilidad.
-   Validar existencia del usuario.
-   Validar existencia del libro.
-   Calcular días de retraso.
-   Calcular multa.
-   Actualizar estados.

## 9.5 Capa de Acceso a Datos

**Responsabilidad:**

Gestiona la comunicación entre la aplicación y SQL Server.

**Componentes:**

-   Conexion
-   LibroDAO
-   AutorDAO
-   CategoriaDAO
-   UsuarioDAO
-   PrestamoDAO
-   DevolucionDAO

**Tecnologías utilizadas:**

-   SQL Server.
-   Consultas parametrizadas.

## 9.6 Capa de Base de Datos

La información del sistema se almacena en:

**Base de datos:** `[swBiblioteca]`

**Tablas principales:**

-   Autor
-   Categoria
-   Libro
-   Usuario
-   Prestamo
-   DetallePrestamo
-   Devolucion

## 9.7 Flujo de información

``` text
Usuario
   ↓
Presentación
   ↓
Lógica de Negocio
   ↓
Acceso a Datos
   ↓
SQL Server
```

Las respuestas de la base de datos realizan el recorrido inverso hasta
llegar nuevamente a la interfaz.

------------------------------------------------------------------------

# 10. EXPLICACIÓN DE CADA MÓDULO DESARROLLADO

## 10.1 Módulo de libros

**Objetivo:** Este módulo proporciona la interfaz gráfica necesaria para que
el administrador o bibliotecario gestione de manera integral el catálogo de 
obras de la biblioteca. Permite realizar el ciclo completo de mantenimiento de
datos (CRUD) sobre la entidad Libro, asegurando el control preciso del inventario
y la correcta categorización de los textos antes de ser procesados en el sistema 
de préstamos.

**Funcionalidades:** 1. *Consulta y Visualización de Catálogo:*
   * Cuenta con un componente de rejilla de datos (DataGridView) que despliega en tiempo real el listado completo de los libros registrados, detallando atributos clave como: ISBN, Título, IdAutor, IdEditorial, Categoría, Año y Existencias.

2. *Búsqueda Avanzada:*
   * Incorpora una barra de búsqueda indexada por el campo ISBN. Al ingresar el código único del libro y presionar el botón *"Buscar"*, el sistema filtra automáticamente el catálogo para agilizar la localización de ejemplares específicos.

3. *Operaciones de Mantenimiento (CRUD):*
   * *Nuevo / Guardar:* Habilita los campos del formulario para realizar el registro de un nuevo ejemplar en el sistema, validando la obligatoriedad de sus datos técnicos.
   * *Editar:* Permite la modificación de los atributos de un libro existente (como actualizar el título, corregir el año de publicación o reasignar su autor/editorial) seleccionándolo previamente desde la lista principal.
   * *Eliminar:* Remueve del catálogo activo el registro del libro seleccionado, restringiendo la acción si el ejemplar cuenta con dependencias activas o préstamos en curso.
   * *Cancelar:* Revierte cualquier acción en proceso, bloqueando nuevamente las cajas de texto y limpiando el formulario para prevenir modificaciones accidentales.
**Validaciones:**
`![Modulo de libros](libros.PNG)`
## 10.2 Módulo de autores

**Objetivo:** \[Descripción.\]

**Funcionalidades:** - Registrar. - Consultar. - Actualizar. - Eliminar.

## 10.3 Módulo de categorías

**Objetivo:** \[Descripción.\]

**Funcionalidades:** - Registrar. - Consultar. - Actualizar. - Eliminar.

## 10.4 Módulo de usuarios

**Objetivo:** \[Descripción.\]

**Funcionalidades:** - Registrar. - Consultar. - Actualizar. - Eliminar.

## 10.5 Módulo de préstamos

**Objetivo:** \[Descripción.\]

**Funcionalidades:** - Registrar préstamo. - Consultar préstamos
activos. - Consultar historial. - Actualizar disponibilidad.

## 10.6 Módulo de devoluciones

**Objetivo:** \[Descripción.\]

**Funcionalidades:** - Registrar devolución. - Calcular días de
retraso. - Calcular multa cuando aplique. - Actualizar disponibilidad.

## 10.7 Módulo de consultas

**Consultas implementadas:**

-   Total de libros registrados.
-   Total de usuarios registrados.
-   Libros disponibles.
-   Libros prestados.
-   Usuarios con préstamos activos.
-   Historial de préstamos.
-   Libros más prestados.


------------------------------------------------------------------------

# 11. CAPTURAS DE PANTALLA DEL SISTEMA

En esta sección se deben incluir evidencias de las principales
funcionalidades.

## 11.1 Menú principal

![Menú principal](ruta/captura-menu.png)

**Descripción:** \[Explicar brevemente la pantalla.\]

## 11.2 Gestión de libros

![Gestión de libros](ruta/captura-libros.png)

**Descripción:** \[Explicar la funcionalidad.\]

## 11.3 Gestión de autores

![Gestión de autores](ruta/captura-autores.png)

**Descripción:** \[Explicar la funcionalidad.\]

## 11.4 Gestión de categorías

![Gestión de categorías](ruta/captura-categorias.png)

**Descripción:** \[Explicar la funcionalidad.\]

## 11.5 Gestión de usuarios

![Gestión de usuarios](ruta/captura-usuarios.png)

**Descripción:** \[Explicar la funcionalidad.\]

## 11.6 Registro de préstamos

![Registro de préstamos](ruta/captura-prestamos.png)

**Descripción:** \[Explicar la funcionalidad.\]

## 11.7 Registro de devoluciones

![Registro de devoluciones](ruta/captura-devoluciones.png)

**Descripción:** \[Explicar la funcionalidad.\]

## 11.8 Consultas

![Consultas](ruta/captura-consultas.png)

**Descripción:** \[Explicar la funcionalidad.\]


------------------------------------------------------------------------


# 13. CONCLUSIONES

## Conclusión 1

\[Explicar qué se logró con el desarrollo del proyecto.\]

## Conclusión 2

\[Explicar los conocimientos de Programación Orientada a Objetos
aplicados.\]

## Conclusión 3

\[Explicar los resultados obtenidos con la base de datos y la
arquitectura por capas.\]

## Conclusión 4

\[Explicar dificultades encontradas y cómo fueron solucionadas.\]

------------------------------------------------------------------------

# 14. RECOMENDACIONES

-   \[Recomendación relacionada con futuras mejoras.\]
-   \[Recomendación relacionada con seguridad.\]
-   \[Recomendación relacionada con mantenimiento.\]
-   \[Recomendación relacionada con nuevas funcionalidades.\]
-   \[Otra recomendación.\]

------------------------------------------------------------------------

# 15. REFERENCIAS BIBLIOGRÁFICAS

> Utilizar **Normas APA, última edición**.

Ejemplos de formato:

**Libro:**

Apellido, N. (Año). *Título del libro*. Editorial.

**Página web:**

Autor/Organización. (Año). *Título del recurso*. URL

**Documentación técnica:**

Microsoft. (Año). *\[Título de la documentación consultada\]*. Microsoft
Learn.

> **Importante:** incluir únicamente las fuentes que realmente fueron
> consultadas durante el desarrollo del proyecto.

------------------------------------------------------------------------

# ANEXOS

## Anexo A. Repositorio GitHub

**Repositorio:** \[Enlace al repositorio\]

## Anexo B. Script de base de datos

**Archivo:** `[Nombre del archivo .sql]`

## Anexo C. Evidencia de Git y GitHub

Insertar capturas que evidencien:

-   Creación del repositorio.
-   Commits realizados.
-   Organización del proyecto.
-   Publicación del código.
-   README.md.

## Anexo D. Otras evidencias

\[Agregar cualquier evidencia adicional relevante.\]

------------------------------------------------------------------------

# LISTA DE VERIFICACIÓN ANTES DE ENTREGAR

-   [ ] Portada.
-   [ ] Contraportada.
-   [ ] Introducción.
-   [ ] Objetivos.
-   [ ] Tabla de contenido.
-   [ ] Numeración de páginas.
-   [ ] Planteamiento del problema.
-   [ ] Análisis de requerimientos.
-   [ ] Casos de uso.
-   [ ] Diagrama de casos de uso.
-   [ ] Diagrama de clases.
-   [ ] Modelo entidad-relación.
-   [ ] Diccionario de datos.
-   [ ] Arquitectura del sistema.
-   [ ] Explicación de cada módulo.
-   [ ] Capturas de pantalla.
-   [ ] Pruebas de funcionamiento.
-   [ ] Conclusiones.
-   [ ] Recomendaciones.
-   [ ] Referencias bibliográficas en formato APA.
-   [ ] Código fuente completo.
-   [ ] Script SQL.
-   [ ] Datos de prueba.
-   [ ] Repositorio GitHub.
-   [ ] README.md.
-   [ ] Evidencia de commits.

------------------------------------------------------------------------








