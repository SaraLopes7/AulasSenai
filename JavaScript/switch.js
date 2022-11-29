// Estrutura de decisão - Switch 

let navegador = 'Edge'

switch (navegador) {
    case 'Mozzila': 
        console.log('Achei o Mozzila \n')
        break
    case 'Google': 
        console.log('Achei o Google \n')
        break 
    case 'Edge': 
        console.log('Achei o Edge \n')
        break 
    default:
        console.log('Não achei seu navegador \n')
}

// Estrutura de repetição - While 

let i = 1 

while (i < 10) {
    console.log(i + '\n')
    i++
}

// Estrutura de repetição - Do While 

//let i = 1

do {
    console.log(i + '\n')
    i++
} while (i < 10)

// Estrutura de repetição - For 

for (let i = 0; i < 10; i++) {
    console.log(i + '\n')
}

// For Each 

var arrayNumeros = [1, 2, 3, 4, 5, 6]

function verificarPares (elemento) {
    if (elemento % 2 === 0) {
        console.log(elemento + '\n')
    }
}

arrayNumeros.forEach(verificarPares)

