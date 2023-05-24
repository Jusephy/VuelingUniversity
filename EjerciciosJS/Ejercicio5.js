//Crea una función que tome una cadena de palabras
//separadas por espacios y devuelva la palabra más larga
function getLongerString(){
    const separar = cadena.split(" ");
    console.log(separar);
    let palabraMasLarga = separar[0];

    for(let palabra of separar){
        if(palabra.length>=palabraMasLarga.length){
            palabraMasLarga=palabra;
        }
    }
    console.log(palabraMasLarga);
}
const cadena = "hola la palabra es Califrastilistico espialidoso";
getLongerString();