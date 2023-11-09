/* /*
a ¿Qué hace el comando git reset --soft HEAD~1? R= Deshace el commit más reciente (el HEAD apunta al commit actual) pero mantiene los cambios en el área de preparación (staging). Esto significa que los cambios que se realizaron en el commit deshecho estarán listos para ser incluidos en el siguiente commit.
b. ¿Qué hace el comando git restore --staged . ? R= Restaura los cambios en el área de preparación (staging) al estado del commit anterior, lo que efectivamente deshace la preparación de los cambios para el próximo commit. Los cambios en el directorio de trabajo no se ven afectados.
c. ¿Qué hace el comando git restore . ? R= Descarta los cambios en el directorio de trabajo y los restaurantes al estado del commit anterior. Esto deshace los cambios realizados en el directorio de trabajo y los reemplaza con el contenido del commit anterior.
d. ¿Qué hace el comando git clean -f ? R= Se utiliza para eliminar archivos no rastreados en el directorio de trabajo. Puede ser útil para eliminar archivos que no están bajo control de versión y que no están en el área de preparación o en el repositorio Git. La opción -fes necesaria para confirmar la eliminación de archivos.
e. ¿Qué hace el comando git merge --abort  ? R= Se utiliza para cancelar una operación de fusión (merge) que ha tenido conflictos o problemas. Esto deshará la fusión en curso y restaurará el estado del repositorio al estado anterior a la fusión. Es útil cuando se encuentra con conflictos durante una fusión y desea volver atrás sin completarla.
*/
 
