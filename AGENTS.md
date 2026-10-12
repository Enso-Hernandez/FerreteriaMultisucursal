# AGENTS.md — Programación II

## Antes de trabajar
1. Leer README.md.
2. Leer AGENTS.md.
3. Leer MEMORY.md.
4. Leer el SKILL.md indicado en el prompt.
5. Proponer un plan antes de modificar código.

## Tecnologías obligatorias
- C#.
- .NET Framework.
- Windows Forms.
- SqlServer
- Arquitectura por capas.

## Arquitectura
- Entidad: clases que representan los datos.
- Datos: conexión y operaciones con SqlServer.
- Negocio: reglas y validaciones.
- Presentación: formularios Windows Forms.

Presentación NO debe acceder directamente a Sqlsever.
Presentación utiliza Negocio.
Negocio utiliza Datos y Entidad.
Datos utiliza Entidad.

## Base de datos
- Tablas con prefijo Tbl_.
- Llaves primarias con prefijo Codigo.
- Respetar el modelo de datos aprobado.
- No crear tablas o relaciones adicionales sin autorización.
- Utilizar consultas parametrizadas.

## Forma de trabajo
- Mantener el código comprensible para estudiantes.
- No agregar complejidad innecesaria.
- Explicar los cambios realizados.
- No modificar módulos ajenos a la tarea solicitada.
- No afirmar que algo funciona si no fue probado.
- Actualizar MEMORY.md únicamente con resultados verificados.
- No colocar contraseñas reales en archivos versionados.
