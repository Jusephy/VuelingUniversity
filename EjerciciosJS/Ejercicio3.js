//Calcular los primeros 10 numeros primos y
// mostrarlos por pantalla en una lista (array)

function numPrimo(num){

    for(let i =2; i<num; i++){
        if(num<=1){
            return false;
        }
        else if (num%i===0){
            return false;
        }
    }
    console.log(num+" Es primo");
    return true;
}

function addPrimos(){
    let listPrimos=[];
    let contador=2;
    while(listPrimos.length<10){
        if(numPrimo(contador)){
            listPrimos.push(contador)
        }
        contador++;
    }
}
addPrimos();