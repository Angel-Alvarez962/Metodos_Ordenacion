# MetodosOrdenacion

Este proyecto tiene como objetivo implementar y comparar distintos algoritmos de ordenación dentro de una aplicación de consola en C#. Los algoritmos de ordenación juegan un papel fundamental en la informática, ya que permiten organizar datos de manera eficiente y optimizar el acceso y procesamiento de información.
En este proyecto usamos diferentes metodos de ordenacion, tales como:

1. Ordenamiento Burbuja: Algoritmo sencillo pero ineficiente para grandes volúmenes de datos.
2. Ordenamiento de Sacudida: Variante del Burbuja que optimiza el recorrido bidireccional.
3. Ordenamiento por Inserción: Adecuado para conjuntos pequeños o casi ordenados.
4. Ordenamiento por Selección: Selecciona el elemento mínimo y lo coloca en su posición final.
5. Shell Sort: Mejora Inserción con pasos intermedios, optimizando el rendimiento.
6. Quicksort: Algoritmo eficiente basado en la estrategia de "divide y vencerás".
7. Heapsort: Utiliza una estructura de árbol para ordenar eficientemente los datos.

En el proyecto se implementaron diferentes archivos para separar cada codigo de los metodos de ordenamiento, con el fin de hacerlo mas sencillo de darle mantenimiento tanto como el poder comparar cada metodo.

El archivo Programa.cs es el punto de entrada de la aplicación y cumple las siguientes funciones:
1. Recibir la entrada de datos por consola.
2. Mostrar un menú con las opciones de ordenación.
3. Permitir al usuario elegir el algoritmo a ejecutar.
4. Medir el tiempo de ejecución con Stopwatch y mostrar el resultado ordenado.

Como conclusión, podemos decir que cada algoritmo tiene sus ventajas y desventajas dependiendo de cómo se apliquen y en qué tipo de datos trabajen:

-Ordenamiento Burbuja y Sacudida
Son fáciles de entender e implementar pero muy ineficientes en grandes conjuntos de datos (O(n²)).
Solo se recomiendan para conjuntos muy pequeños o parcialmente ordenados.

-Ordenamiento por Inserción y Selección
Inserción es eficiente en listas pequeñas o casi ordenadas (O(n²) en peor caso, pero eficiente en orden parcial).
Selección mantiene O(n²), aunque realiza menos intercambios, útil para estructuras donde los movimientos de datos son costosos.

-Shell Sort
Extensión de Inserción, optimiza el rendimiento con pasos intermedios (O(n log n) en muchos casos).
Es una mejora rápida sin necesidad de estructuras auxiliares.

-Quicksort
Uno de los algoritmos más eficientes (O(n log n) en promedio).
Su rendimiento depende de la elección del pivote, pero en general es excelente para datos desordenados grandes.

-Heapsort
Basado en estructuras de árbol, garantiza rendimiento estable de O(n log n).
Es una opción útil cuando se necesita estabilidad en el rendimiento sin depender de pivotes como en Quicksort.


Metodos	      10 elementos	  25 elementos	  50 elementos

Burbuja	      0.5 ms	        1.8 ms	        4.2 ms

Sacudida	    0.4 ms	        1.7 ms	        4.0 ms

Inserción	    0.3 ms	        1.2 ms	        3.0 ms

Selección	    0.6 ms	        1.9 ms	        3.8 ms

Shell Sort	  0.2 ms	        0.7 ms	        1.5 ms

Quicksort	    0.1 ms	        0.5 ms	        1.1 ms

Heapsort	    0.2 ms	        0.6 ms	        1.3 ms


Tenemos una tabla de comparaciones en los tiempos de ejecución sobre los diferentes métodos de ordenamiento. De esta podemos sacar la siguiente conclusión:

En arreglos muy pequeños (10 elementos), todos los algoritmos son rápidos, pero Quicksort es el más eficiente. Conforme va aumentando el tamaño de los elementos, los métodos de Burbuja, Sacudida y Selección presentan tiempos más altos, lo que nos da a entender que tienen limitaciones. También se puede resaltar que los métodos de Shell Sort, Quicksort y Heapsort siguen siendo más rápidos a pesar de manejar un mayor número de elementos, siendo Quicksort el que destaca entre ellos.

