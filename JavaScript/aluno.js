// Percorrer de Zero até o número de alunos

let numeroAlunos = 10

for (let i = 0; i <= numeroAlunos; i++) {
    // console.log(`Rodou ${i} vezes`)

    // Se o número for zero, escreva 'zero' e o número correspondente
    if (i == 0) {
        console.log(`${i} Zero`)
    } 
    // Se o número for par, escreva 'par' e o número correspondente
    else if (i % 2 == 0) {
        console.log(`${i} Par`)
    } 
    // Se o número for ímpar, escreva 'ímpar' e o número correspondente
    else {
        console.log(`${i} Ímpar`)
    }
}









