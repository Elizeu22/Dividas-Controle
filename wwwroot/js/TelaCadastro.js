

$(document).ready(function () {

    $("#SalvarDados").click(function () {

        try {
            var ValorProduto = parseFloat($("#ValorProduto").val().replace(',', '.'));
            var QtdeProduto = parseInt($("#QtdeProduto").val());

            var total = (ValorProduto * QtdeProduto).toFixed(2);

            $("#ValorDivida").val(total);
        }

        catch(err) {
            alert("Erro ao Salvar Dados");
        }
           
    }); 



    $("#AtualizaDivida").click(function () {

        try {
            var ValorProduto = parseFloat($("#ValorProduto").val().replace(',', '.'));
            var QtdeProduto = parseInt($("#QtdeProduto").val());

            var total = (ValorProduto * QtdeProduto).toFixed(2);

            $("#ValorDivida").val(total);
        }

        catch (err) {
            alert("Erro ao Atualizar dados");
        }

    }); 








}); 