//Crea una función que tome un número entero positivo y verifique
//si es un número primo

function numPrimo(num){

    for(let i =2; i<num; i++){
        if(num<=1){
            console.log(num+" No es primo");
            return false;
        }
        else if (num%i===0){
            console.log(num+" No es primo");
            return false;
            //console.log(num+" No es primo");
        }
    }
    console.log(num+" Es primo");
    return true;
}
numPrimo(8);