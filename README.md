# Cocodrilo-Dentista

Han sido contratados por la empresa gestion.co, una compañía pionera en el desarrollo de chats.
Dada su experiencia y sus conocimientos se les ha encargado el construir un sistema distribuido basado en una arquitectura cliente-servidor.

El sistema a crear es un juego denominado el Dentista Cocodrilo: 
1) Para empezar el juego, se requiere contar con al menos 2 clientes.
2) Cada cliente deberá permitir indicar los datos del jugador (un nickname y u password al menos), antes de iniciar.
3) El cliente presentará una interfaz que contará con la cara de un cocodrilo y sus dientes, el cliente podrá "extraer" los dientes del cocodrilo,
   es decir el usuario podrá escoger cuál de los dientes quiere remover, una vez escogido el diente, el sistema le permitirá darle un peso al diente a extraer (número entre 1 al 6).
   Si el número escogido es el "correcto" se extrae el diente, y desaparece de la pantalla. Si el número es "incorrecto" se le quita una vida al usuario.
4) El número de vidas será 5.
5) El juego estará basado en turnos, es decir en el primer turno todos los clientes conectados deben escoger el diente a remover, enviar sus mensajes al servidor y una vez que todos
   hayan enviado sus mensajes, el servidor debe responderles indicándoles que dientes deben remover del cocodrilo o quienes han perdido vidas.
6) Los clientes deben presentar la información de los otros jugadores (es decir debe mostrar cuantos jugadores hay, quienes son, cuantos dientes han removido, cuántas vidas tienen).
7) El ganador será aquel que quede con la mayor cantidad de vidas, si ya no hay dientes, o aquel que haya logrado sacar el mayor número de dientes.
8) El servidor decidirá si es correcto "extraer" o es "incorrecto".
9) El cliente debe enviar un mensaje al servidor indicando: número de diente a remover, nickname y peso del diente. 
   Los dientes deben ser numerados del 0 al 23 (12 dientes superiores y 12 inferiores). 
10) Para decidir si es correcto "extraer" el servidor analizará cuantos usuarios quieren remover la misma pieza dental.
    Si cada cliente escogió una pieza distinta, el servidor generará un número aleatorio entre el 1 al 6, si el número del servidor es mayor que el número del cliente,
    el servidor dirá "incorrecto", si es menor dirá "extraer", si el número es igual al del cliente, generará un segundo número y aplicará la condición anterior,
    si es mayor o igual dirá "incorrecto", si es menor dirá "extraer".
11) Si dos o más clientes escogieron la misma pieza, el servidor generará el número aleatorio, el ganador será el número menor de todos  y recibirá un "extraer",
    el resto perderá una vida; si hay empate con el servidor, el servidor generará un nuevo número y lo comparará, el ganador será el menor de todos,
    si de nuevo hay empate con el servidor, todos recibirán "incorrecto". Si por el contrario el empate es entre clientes (dos ganadores o más), en ese caso el servidor debe seleccionar
    aleatoriamente al ganador, el cual será uno solo.
12) Al finalizar debe mostrar estadísticas del juego, cuantos "extraer", cuantos "incorrectos", cuantos empates se han producido, y debe llevar un registro de todos los juegos realizados.

