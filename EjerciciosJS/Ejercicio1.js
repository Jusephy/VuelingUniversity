//Crear funcion verifica si eres mayor de edad o no
const persona = [{
    year:1999
},{
    year:1998 
},{
    year:2005
},{
    year:2010
}];

function calcularEdad(){
    const years = Object.values(persona).map(sub=>sub.year)
    const today = new Date();
    
    years.forEach(element => {
        let edad = today.getFullYear() - element;
        if (edad>=18){
            console.log("Tienes "+edad+" años, eres mayor de edad");
        }else{
            console.log("Tienes "+edad+" años, aún eres menor de edad");
        }
    });
}
calcularEdad();