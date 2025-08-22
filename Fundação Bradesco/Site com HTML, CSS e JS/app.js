'use strict'//Para combater essas deficiências, você pode ativar o modo estrito, que reduz erros silenciosos, melhora o desempenho, fornece mais avisos e menos recursos não seguros.
// use document.querySelector para obter a referência do botão.

const switcher = document.querySelector('.btn');
//adicione o ouvinte e o manipulador do evento click
//A função passada para o ouvinte de eventos é seu manipulador de eventos real.

switcher.addEventListener('click', function(){
    document.body.classList.toggle('dark-theme')
    var className = document.body.className;
    if(className == "light-theme"){
        this.textContent = "Dark";
    }
    else{
        this.textContent = "Light";
    }
    console.log('current class name: '+ className);
});

//você usou o método toggle para alternar o elemento para a classe dark-theme.