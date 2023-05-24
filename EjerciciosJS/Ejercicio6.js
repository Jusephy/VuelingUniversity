//Crea una función que tome un objeto y devuelva 
//una nueva versión del objeto donde todos los valores son duplicados

function addDuplicateValue(arrayString){
    arrayString.forEach(element => {
        const getIndex= arrayString.indexOf(element);
        arrayString[getIndex]=(element+element);
        //array.push(element+element);
    });
    console.log(arrayString);
}
addDuplicateValue(["aab","daaab", "sdshhh"]);
addDuplicateValue([123,100,8080]);
