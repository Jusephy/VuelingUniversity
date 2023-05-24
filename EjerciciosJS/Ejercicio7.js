//Obtener el promedio de las edades de los usuarios mayores de edad

const persona = [{
    year:1999
},{
    year:1998 
},{
    year:2005
}];

function calcularEdad(){
    const years = Object.values(persona).map(sub=>sub.year)
    let array=[];
    const today = new Date();
    
    years.forEach(element => {
        console.log("Tu año de nacimiento es: "+element);
        let edad = today.getFullYear() - element;
        //funcion verifica si eres mayor de edad o no
        if (edad>=18){
            array.push(edad);
            console.log("Tienes "+edad+" años, eres mayor de edad\n");
        }else{
            console.log("Tienes "+edad+" años, aún eres menor de edad\n");
        }
    });

    let total=0;
    for (let i of array) total+=i;

    let promedioEdad =total/array.length;
    console.log("El promedio es: "+promedioEdad);
}
calcularEdad();


