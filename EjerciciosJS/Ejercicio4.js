//Encontrar el número más grande en un array 
//de números negativos y positivo
function getMaxMin(){
    let array=[-3, -5, 6, 10];
    let maximo=0;
    let minimo=0;
    //también se puede hacer con un array.forEach()
    for (i = 0; i < array.length; i++) {
        if (array[i]>maximo)
        {
            maximo=array[i]
        }else if(array[i]<minimo){
            minimo=array[i]
        }
    }
    console.log(maximo);
    console.log(minimo);
}
getMaxMin();