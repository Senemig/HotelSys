function myFunction(i){
    if(i == 1){
        var input, filter, li, ul, div, idCliente;
        input = document.getElementById("searchBox");
        idCliente = document.getElementById("idCliente");
        filter = input.value.toUpperCase();
        div = document.getElementById("opcoes");
        div.style.display = "";
        if(input.value.toUpperCase() == ""){
            div.style.display = "none";
            idCliente.value = "0";
        }
        li = div.getElementsByTagName("li");

        for(i = 0; i < li.length; i++){
            txtValue = li[i].txtContent || li[i].innerText;
            if(txtValue.toUpperCase().indexOf(filter) > -1){
                li[i].style.display = "";
                idCliente.value = li[i].innerText.split('|')[0].trim();
            }
            else{
                li[i].style.display = "none";
                idCliente.value = "0";
            }
        }
    }
    else{
        document.getElementById("opcoes").style.display = "none";
    }
    
}

function Escolher(li){
    document.getElementById("searchBox").value = li.innerText.split('|')[1].trim();
    myFunction(0);
}