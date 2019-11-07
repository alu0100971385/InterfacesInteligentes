Light mapping:
>Hornea mapas de luz para su escena en función de cómo se configura su escena dentro de Unity, teniendo en cuenta mallas, materiales, texturas y luces.
(realiza un breve paso de preparación para procesar actualizaciones de geometría e instancias, y genera el G-buffer y las máscaras de gráficos. Luego produce la salida de forma inmediata y la refina progresivamente con el tiempo para un flujo de trabajo de iluminación interactivo muy mejorado. Además, los tiempos de cocción son mucho más predecibles porque Progressive Lightmapper proporciona un tiempo estimado mientras se hornea.)

Bump mapping:
Consiste en dar un aspecto rugoso a las superficies de los objetos. Esta técnica modifica las normales de la superficie sin cambiar su geometría.(Esto se logra al perturbar las normales de la superficie del objeto y al usar la normal perturbada durante los cálculos de iluminación.)

Hay dos métodos principales para realizar mapeo de relieve.
El primero utiliza un mapa de altura para simular el desplazamiento de la superficie produciendo la normalidad modificada. 
El otro método es especificar un mapa normal que contenga la normal modificada para cada punto en la superficie directamente. Como lo normal se especifica directamente en lugar de derivarlo de un mapa de altura, este método generalmente conduce a resultados más predecibles.

Normal mapping:
Son un tipo especial de textura que le permite a usted agregar detalles en las superficies como golpes/bultos/bumps, surcos, rayones a un modelo que atrapa la luz como si fuera representado por una geometría real.
Los mapas normales se almacenan comúnmente como imágenes RGB normales donde los componentes RGB corresponden a las coordenadas X, Y y Z, respectivamente, de la superficie normal .

Sky Box
Los Skyboxes son una envoltura alrededor de su escena entera que muestra cómo el mundo se vería más allá de su geometría.Se renderizan alrededor de la escena entera con el fin de darle una impresión de un escenario complejo en el horizonte.

Enviroment mapping
es un método para aplicar reflexiones ambientales en una superficie reflectante. En lugar de representar realmente los objetos reflejados en una superficie reflectante, preparamos una textura que es una vista panorámica de los alrededores del objeto y luego miramos hacia arriba dentro de las coordenadas de textura. El mapeo ambiental puede no tener nada que ver con el entorno real del objeto. Esta técnica genera una apariencia realista de una superficie reflectante y requiere mucho menos tiempo que el trazado de rayos.

Iluminación global
 Es un grupo de técnicas utilizados en gráficos 3D que están destinados a agregar una iluminación más realista a las escenas 3D. Dichos algoritmos tienen en cuenta no solo la luz que proviene directamente de una fuente de luz , sino también casos posteriores en los que los rayos de luz de la misma fuente se reflejan en otras superficies de la escena, ya sean reflectantes o no.
 Los reflejos , las refracciones y las sombras son todos ejemplos de iluminación global.
