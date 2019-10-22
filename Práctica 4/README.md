En primer lugar utilicé como base la práctica anterior y el player (el cubo) lo convertí en un RigidBody que se mueve leyendo tanto WASD como las flechas de dirección. Esto lo he conseguido creando un Script y asociándolo al gameobject.

Luego, lo que he hecho para el sensor es crear una cápsula a la que le he quitado completamente el material y la he dejado transparente. Luego la he colocado como hijo de la esfera y la uso de detector de colisiones. Mediante otro script, cambio el color del cubo según entra, se mantiene o sale de la colisión.

Hice otro script que permite a una segunda esfera en la escena cambiar su trayectoria y velocidad de manera completamente aleatoria. Las colisiones con esta esfera también se detectan.

Por último, también he creado otro gameobject que es una cápsula, al cual le he asociado un script para que se mueva con las letras ILJM y que también detecta colisiones, igual que el cubo.

Podemos ver que la esfera que sale disparada al inicio del GIF es la que se mueve de manera aleatoria. Luego procedo a mover el cubo. Como el frame de entrada y salida de colisión es tan corto, apenas podemos apreciar los colores (azul y verde) que les he asociado. Si se aprecia el color rojo al mantenerse la colisión. Esto también ocurre con el cilindro.

![alt text](https://github.com/alu0100971385/InterfacesInteligentes/blob/master/Pr%C3%A1ctica%204/ezgif.com-video-to-gif.gif "Captura de pantalla")
