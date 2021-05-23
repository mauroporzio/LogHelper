# LogHelper_EdsaAcademy
Proyecto de LogHelper por Mauro Porizo

En este repositorio se encuentra la Solucion de un Log Helper. Para luego implementar en la solucion de Agenda.

  Dentro de esta solucion se podra encontrar:
      
        Una proyecto "LogHelper" donde se ubica la interfaz "ILogger" y la libreria de clase "Logger" con el metodo para logear un error.
        Dicho metodo recibe por parametro un errorMessage que proviene del error arojado durante una ejecucion. Luego junto a un valor proveniente de una key en el web.config,
        determina el path donde se ubicara el log.txt donde se almacena el error. Ademas se agregar al fecha y hora del logeo.
        
        Ademas, dentro de esta solucion se encuentra un proyecto "WebApplicationTest" donde se podra probar el correcto funcionamiento del logger.
        Alli se imprime por pantalla la direccion donde se guardo el archivo de registro.
        
 
