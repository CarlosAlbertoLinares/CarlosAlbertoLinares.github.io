const sumExercise = {

instruction:'Seleccione el resultado de la siguiente  suma:',
problem: [4,5],
options: [9,6,8,10],
result:0
}

var anwerOrInstructionReturn = () =>{

	return `${sumExercise.instruction} ${sumExercise.problem[x]} + ${sumExercise.problem[x+1]} con las siguientes posibles opciones A) ${sumExercise.options[x]} B)${sumExercise.options[x+1]} C)${sumExercise.options[x+2]} D)${sumExercise.options[x+3]}`
}

sumExercise.instruction = anwerOrInstructionReturn();



var anwer = prompt(anwerOrInstructionReturn());
 sumExercise.result =anwer; // cambiar el contenido del elemento result en el objeto sumExercise con respecto a lo ingresado por el usuario como respuesta.

 // validar si la respuesta del usuario es correcta
if (anwer == sumExercise.options[0] || anwer == 'a' || anwer == 'A' )
alert(`${sumExercise.result} es la respuesta correcta!`);
else
	alert(`${sumExercise.result} no es la respuesta correcta.`);




var JsonSumExcercise = JSON.stringify(sumExercise);





