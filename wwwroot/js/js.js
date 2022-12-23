function Validar(form)  {
      
    caixa_nome = document.querySelector(".msg-nome");
    caixa_nome.style.display='nome';
     
    if(document.getElementById('nome').value.length < 2 ){

     caixa_nome.innerHTML = "Preencha o campo Nome ";
     caixa_nome.style.display='block';
     document.getElementById('nome').focus();

     return false;
    } 
    caixa_telefone = document.querySelector(".msg-telefone");
    caixa_telefone.style.display='telefone';
     
    if(document.getElementById('telefone').value.length < 11 ){

     caixa_telefone.innerHTML = "Preencha o campo Telefone";
     caixa_telefone.style.display='block';
     document.getElementById('telefone').focus();

     return false;
    } 



caixa_Data = document.querySelector(".msg-Data");
caixa_Data.style.display='Data';
 
if(document.getElementById('Data').value.length < 5 ){

 caixa_Data.innerHTML = "Preencha o campo Data";
 caixa_Data.style.display='block';
 document.getElementById('Data').focus();

 return false;
} 



caixa_Doce = document.querySelector(".msg-Doce");
caixa_Doce.style.display='Doce';
 
if(document.getElementById('Doce').value.length < 5 ){

 caixa_Doce.innerHTML = "Preencha o campo Doce";
 caixa_Doce.style.display='block';
 document.getElementById('Doce').focus();

 return false;
} 



caixa_horario = document.querySelector(".msg-horario");
caixa_horario.style.display='horario';
 
if(document.getElementById('horario').value.length < 5){

 caixa_horario.innerHTML = "Preencha o campo Horário";
 caixa_horario.style.display='block';
 document.getElementById('horario').focus();

 return false;
} 




caixa_quantidade = document.querySelector(".msg-quantidade");
caixa_quantidade.style.display='quantidade';

if(document.getElementById('quantidade').value.length < 1 ){

 caixa_quantidade.innerHTML = "Preencha o campo Quantidade";
 caixa_quantidade.style.display='block';
 document.getElementById('quantidade').focus();

 return false;
} 



 }