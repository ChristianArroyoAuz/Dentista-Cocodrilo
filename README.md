# Cocodrilo-Dentista

Han sido contratados por la empresa gestion.co, una compa��a pionera en el desarrollo de chats.
Dada su experiencia y sus conocimientos se les ha encargado el construir un sistema distribuido basado en una arquitectura cliente-servidor.

El sistema a crear es un juego denominado el Dentista Cocodrilo: 
1) Para empezar el juego, se requiere contar con al menos 2 clientes.
2) Cada cliente deber� permitir indicar los datos del jugador (un nickname y u password al menos), antes de iniciar.
3) El cliente presentar� una interfaz que contar� con la cara de un cocodrilo y sus dientes, el cliente podr� "extraer" los dientes del cocodrilo,
   es decir el usuario podr� escoger cu�l de los dientes quiere remover, una vez escogido el diente, el sistema le permitir� darle un peso al diente a extraer (n�mero entre 1 al 6).
   Si el n�mero escogido es el "correcto" se extrae el diente, y desaparece de la pantalla. Si el n�mero es "incorrecto" se le quita una vida al usuario.
4) El n�mero de vidas ser� 5.
5) El juego estar� basado en turnos, es decir en el primer turno todos los clientes conectados deben escoger el diente a remover, enviar sus mensajes al servidor y una vez que todos
   hayan enviado sus mensajes, el servidor debe responderles indic�ndoles que dientes deben remover del cocodrilo o quienes han perdido vidas.
6) Los clientes deben presentar la informaci�n de los otros jugadores (es decir debe mostrar cuantos jugadores hay, quienes son, cuantos dientes han removido, cu�ntas vidas tienen).
7) El ganador ser� aquel que quede con la mayor cantidad de vidas, si ya no hay dientes, o aquel que haya logrado sacar el mayor n�mero de dientes.
8) El servidor decidir� si es correcto "extraer" o es "incorrecto".
9) El cliente debe enviar un mensaje al servidor indicando: n�mero de diente a remover, nickname y peso del diente. 
   Los dientes deben ser numerados del 0 al 23 (12 dientes superiores y 12 inferiores). 
10) Para decidir si es correcto "extraer" el servidor analizar� cuantos usuarios quieren remover la misma pieza dental.
    Si cada cliente escogi� una pieza distinta, el servidor generar� un n�mero aleatorio entre el 1 al 6, si el n�mero del servidor es mayor que el n�mero del cliente,
    el servidor dir� "incorrecto", si es menor dir� "extraer", si el n�mero es igual al del cliente, generar� un segundo n�mero y aplicar� la condici�n anterior,
    si es mayor o igual dir� "incorrecto", si es menor dir� "extraer".
11) Si dos o m�s clientes escogieron la misma pieza, el servidor generar� el n�mero aleatorio, el ganador ser� el n�mero menor de todos  y recibir� un "extraer",
    el resto perder� una vida; si hay empate con el servidor, el servidor generar� un nuevo n�mero y lo comparar�, el ganador ser� el menor de todos,
    si de nuevo hay empate con el servidor, todos recibir�n "incorrecto". Si por el contrario el empate es entre clientes (dos ganadores o m�s), en ese caso el servidor debe seleccionar
    aleatoriamente al ganador, el cual ser� uno solo.
12) Al finalizar debe mostrar estad�sticas del juego, cuantos "extraer", cuantos "incorrectos", cuantos empates se han producido, y debe llevar un registro de todos los juegos realizados.

