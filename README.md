# Tarea

Patrón seleccionado: Factory Method

Descripción del proyecto (de que se trata o que se espera ver)

Este proyecto tiene el objetivo de crear tropas de "heroes" de diferentes tipos, cada heroe creado descontara energia, cuando te quedes en <0 de energia no podras crear mas heroes para tu tropa.

Modo de uso: Presione 1,2.3.4 y 5 para crear a los diferentes tipos de heroes.

Cuál es la problemática con la que nos encontraríamos en el ejercicio si no aplicaramos el patrón?

Si no se usa el Factory Method , el código que necesita crear héroes podría necesitar conocer las clases concretas de los tipos de héroes, como "Asesino" o "Mago". Esto podria llegar a generar algun tipo de acoplamiento en el codigo de creacion y las clases de tipos de heroes. Tambien dificultaria la flexibilidad y el mantenimiento del codigo. Esto puede resultar en código repetitivo y difícil de mantener, especialmente si deseas agregar nuevos tipos de héroes en el futuro.

Porqué el patrón soluciona esa problemática? de que forma lo hace?

El patrón Factory Method aborda estas problemáticas en el contexto de la fábrica de héroes, ya que, la fabrica de heroes "HeroFactory" se encargaria de administrar y declara un método para crear héroes "CreateHero". Las clases concretas que implementan esta interfaz (por ejemplo, Mago, Guerrero, etc.) se encargan de la creación de héroes concretos "Hero". Esto desacopla el código que necesita crear héroes de las clases concretas de héroes, reduciendo el acoplamiento. La clase "Hero" junto con "HeroFactory" encapsula la lógica de creación específica del tipo "Heroe". Esto simplifica la gestión de creación y evita la duplicación de código.

Que ventajas y desventajas tiene el patrón seleccionado?

Ventajas

Reduce el acoplamiento a través de una interfaz común "HeroFactory" en lugar de conocer las clases concretas de héroes. Facilita la introducción de nuevos tipos de héroes. Facilita el mantenimiento y la organización del código al separar la lógica de creación

Desventajas

Puede resultar en un aumento en la cantidad de clases en el código, lo que podría ser excesivo para situaciones muy simples de creación de héroes.
