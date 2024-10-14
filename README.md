# smARt Kids
Aplicación de Realidad Aumentada

Introducción: smARt Kids es una aplicación de realidad aumentada (AR) diseñada para mejorar el aprendizaje de los niños mediante la interacción con fichas educativas. Cada ficha contiene una letra del abecedario, y al enfocarla con la cámara de la aplicación, se despliega un video animado que enseña palabras o conceptos relacionados con esa letra. La idea es que los niños asocien las letras con objetos y palabras familiares, facilitando el proceso de alfabetización.

Objetivo: El objetivo principal de smARt Kids es utilizar la realidad aumentada para hacer que el aprendizaje de letras y vocabulario sea más interactivo, divertido y efectivo para los niños, ayudándoles a mejorar su capacidad de retención de información a través de experiencias visuales.

Funcionalidades:

    Reconocimiento de Fichas: Cada ficha de letra es un "target" que, al ser reconocida por la cámara, activa un video animado con ejemplos de palabras que empiezan con esa letra.
    Interfaz de Usuario (UI): El menú principal cuenta con opciones como "Play", "Continue", "Options" y "Quit", que permiten a los usuarios navegar fácilmente entre las distintas secciones de la aplicación.
    Múltiples Targets: La aplicación tiene la capacidad de reconocer más de un target, de manera que, dependiendo de la ficha enfocada, se despliega el video correspondiente a cada letra.
    Botones de Navegación: Los usuarios pueden regresar al menú principal o cambiar de escena utilizando botones intuitivos. Además, se puede regresar desde la escena de video educativo al menú o a escenas anteriores.

Implementación Técnica: La aplicación utiliza Vuforia para el reconocimiento de targets (fichas con letras). Los targets son predefinidos y se cargan dentro del entorno de Unity. A nivel de programación, se han implementado botones interactivos para cambiar entre las diferentes escenas y opciones del menú.

    Menú Inicial: Contiene las opciones principales: "Play", "Continue", "Options" y "Quit".
    Escena de Cámara: Activa la cámara del dispositivo para reconocer las fichas con letras. Cuando un target es identificado, se inicia la reproducción del video correspondiente a esa ficha.
    Botón de Regreso: Un botón dentro de la escena de reconocimiento permite al usuario regresar al menú principal.

Conclusión: smARt Kids es una herramienta innovadora que combina tecnología y educación, ofreciendo una experiencia lúdica para los niños mientras aprenden. La realidad aumentada permite que los pequeños interactúen de forma directa con los materiales educativos, haciendo que el proceso de aprendizaje sea más dinámico y entretenido.
