# Práctica 3 - Introducción a los scripts en Unity

En primer lugar he creado un plano al que le he añadido un color.

He modificado los parámetros de rotación de la cámara para que ésta mire completamente hacia abajo.

Luego he creado un cubo(con el fin de apreciar bien la rotación) y lo he colocado encima del plano.

He creado un script en c# con el que haciendo uso de la clase Transform e Input, detecto qué teclas pulsa el usuario y acto seguido realiza 
una traslación hacia la dirección que haya pulsado. La longitud de esta traslación depende de la velocidad que se puede ajustar bien desde
Unity o bien desde el propio script.

Luego, he añadido que se detecte si el usuario pulsa WASD para poder rotar el cubo en el eje OY mediante la clase Transform.

Finalmente, este script lo he hecho "hijo" del cubo para que se le aplicara todo lo mencionado.

![alt text](https://github.com/alu0100971385/InterfacesInteligentes/blob/master/Pr%C3%A1ctica%203/ezgif.com-video-to-gif.gif "Captura de pantalla")
