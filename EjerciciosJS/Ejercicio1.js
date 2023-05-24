//Crear funcion verifica si eres mayor de edad o no
const persona = {
    year:1999
};

function calcularEdad(ano){
    const today = new Date();
    for (i=0; i < ano.leng; i++) {
        let edad = today.getFullYear() - ano
        if (edad>18){
            console.log(edad);
        }else{
            console.log("Tienes "+edad+" aún eres menor de edad");
        }
    }

}
calcularEdad(1999, 1998);