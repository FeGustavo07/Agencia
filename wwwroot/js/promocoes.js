
const nextSpan = document.querySelector("#next-span")
const prevSpan = document.querySelector("#prev-span")
const title = document.querySelector("h3")
const valorAntigo = document.querySelector("del")
const valorNovo = document.querySelector("#valor-novo")


let contador = 0

const incrementaContador = () => {
    contador += 1

    if (contador >= 3) {
        contador = 0
    }

    if (contador < 0) {
        contador = 2
    }
}

const decrementaContador = () => {
    contador -= 1

    if (contador >= 3) {
        contador = 0
    }

    if (contador < 0) {
        contador = 2
    }
}

const renderizaDados = () => {
   
    if (contador == 0) {
        title.textContent = "Petra - Jordânia"
        valorAntigo.textContent = "R$ 1899,99"
        valorNovo.textContent = "por R$ 1299,99"
    }
    else if (contador == 1) {
        title.textContent = "Ilhas Maldivas"
        valorAntigo.textContent = "R$ 799,99"
        valorNovo.textContent = "por R$ 699,99"
    }
    else {
        title.textContent = "Keystone - EUA"
        valorAntigo.textContent = "R$ 999,99"
        valorNovo.textContent = "R$ 899,99"
    }
}



nextSpan.addEventListener('click', function () {
    incrementaContador()
    renderizaDados()
})

prevSpan.addEventListener('click', function () {
    decrementaContador()
    renderizaDados()
})






