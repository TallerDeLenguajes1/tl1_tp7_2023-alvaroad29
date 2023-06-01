# Ejercicio 1 🤚

El parámetro "--output" en el comando "dotnet new console --output ." se utiliza para especificar la ubicación de salida del nuevo proyecto de consola que se está creando. Al llamarlo de la manera indicada, el punto (".") se utiliza para representar el directorio actual, lo que significa que el proyecto de consola se creará en el directorio en el que se está ejecutando el comando. Osea a diferencia de dotnet new console -n <nombre> no crea una carpeta adicional. Directamente crea los archivos necesarios del proyecto en la misma carpeta donde estamos parados.

Al utilizar "--output .", el nuevo proyecto de consola se creará en el directorio actual, lo cual puede tener algunas consecuencias dependiendo de la ubicación desde la cual se esté ejecutando el comando. Estas consecuencias pueden incluir:

1. Reemplazo de archivos existentes: Si ya existe un proyecto de consola o archivos con el mismo nombre en el directorio actual, el comando "--output ." podría reemplazarlos sin previo aviso. Por lo tanto, es importante tener cuidado al utilizar este comando para evitar la pérdida de datos.

2. Desorden en el directorio actual: Si se ejecuta el comando "--output ." desde un directorio con muchos archivos y carpetas, el nuevo proyecto de consola se creará en ese mismo directorio, lo que podría generar desorden y dificultar la organización de los archivos.

Por lo tanto, se recomienda revisar cuidadosamente el directorio actual y asegurarse de que no se sobrescriban archivos importantes antes de utilizar el comando "--output ." de esta manera.

----------------------------------------

El comando "dotnet new console -n" se utiliza para crear un nuevo proyecto de consola, pero a diferencia del parámetro "--output", el parámetro "-n" se utiliza para especificar el nombre del proyecto.

Cuando se usa "dotnet new console -n <nombre>", se crea un nuevo proyecto de consola con el nombre especificado en lugar de utilizar el nombre predeterminado. Por ejemplo, si ejecutas el comando "dotnet new console -n MiProyecto", se creará un nuevo proyecto de consola con el nombre "MiProyecto".

En resumen, mientras que "--output" se utiliza para especificar la ubicación de salida del proyecto de consola, "-n" se utiliza para especificar el nombre del proyecto en sí. Ambos parámetros pueden ser utilizados juntos para crear un nuevo proyecto de consola con un nombre personalizado en una ubicación específica. Por ejemplo, "dotnet new console -n MiProyecto --output C:\Proyectos" creará un nuevo proyecto de consola llamado "MiProyecto" en el directorio "C:\Proyectos".