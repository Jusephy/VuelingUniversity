//Crea una función que tome un número entero positivo y verifique
//si es un número primo

function numPrimo(num){
    while(esprimo<11){
        let esprimo=0;
        let arr=[];
        let primo;

        if(num<=1){
            console.log(num+" No es primo");
        }
        for(let i =2; i<num; i++){
            if (num%i===0){
                primo=false;
                //console.log(num+" No es primo");
            }
        }
        if(primo==true){
            esprimo++;
            arr.push(num);
            console.log(num+" Es primo");
        }else{
            console.log(num+" No es primo");
        }
        console.log(arr);
    }
}
numPrimo();

//Calcular los primeros 10 numeros primos y
// mostrarlos por pantalla en una lista (array)
let contador=0;
let arr =[];
let num=2;
while(lista.length<10){
    if(primo){

    }
}
/*while(contador<11){
    
}*/