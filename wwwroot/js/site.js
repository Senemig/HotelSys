﻿function myFunction(i){
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

function CompareDates() {
        console.log('Function start')
        var from = document.getElementById('from').value;
        var to = document.getElementById('to').value;

        console.log(from);
        console.log(to);

        var splitFrom = from.split('-');
        var splitTo = to.split('-');

        var fromDate = new Date(splitFrom[0] + ' ' + splitFrom[1] + ' ' + splitFrom[2]);
        var toDate = new Date(splitTo[0] + ' ' + splitTo[1] + ' ' + splitTo[2]);

        console.log(fromDate);
        console.log(toDate);

        if (toDate > fromDate) {
            document.getElementById('subBtn').removeAttribute('disabled');
            document.getElementById('subBtn').classList.remove('btn-secondary');
            document.getElementById('subBtn').classList.add('btn-primary');
            document.getElementById('alerta').style.display = 'none';
            console.log('toDate > fromDate');
        }
        else {
            document.getElementById('subBtn').setAttribute('disabled', 'disabled');
            document.getElementById('subBtn').classList.remove('btn-primary');
            document.getElementById('subBtn').classList.add('btn-secondary');
            document.getElementById('alerta').style.display = 'block';
            console.log('toDate < fromDate');
        }
    }