const exercise3 = {
	

	instruction:'Seleccione la respuesta correcta',
	problem:[4720,0.35],
	options:["6,372","6,370","130","135"],
	result:0

}
var index = 0;  // utilizado para navegar entre los elementos del objeto excercise3(problem & options)



var instructionOrRespuestaReturn = () => {

	return `${exercise3.instruction}  al aumentar ${exercise3.problem[index]}  en un  ${exercise3.problem[index+1]*100}%: A)${exercise3.options[index]} B)${exercise3.options[index+1]} C)${exercise3.options[index+1]} D)${exercise3.options[index+3]}`
}


exercise3.instruction = instructionOrRespuestaReturn();
var respuesta = prompt(instructionOrRespuestaReturn());
exercise3.result = respuesta;


// validar si la respuesta del usuario es correcta
if(respuesta == exercise3.options[0] || respuesta == 6372 || respuesta == 'A' || respuesta == 'a')
alert(`${respuesta} es la respuesta correcta`);
else
alert(`${respuesta} no es la respuesta correcta`);


var Jsonexercise3 = JSON.stringify(exercise3);  //json output


