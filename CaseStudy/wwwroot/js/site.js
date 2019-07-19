
$(function () {
     //re-pop modal to show newly created add message
    if ($("#selectedId").val() > 0) {
        let data = $("#catbtn" + $("#selectedId").val()).data("details");
        CopyToModal($("#selectedId").val(), data);
        $("#details_popup").modal("show");
    }
    // details click - to load popup on catalogue
    $("a.btn-outline-dark").on("click", (e) => {
        $("#results").text("");
        let id = e.target.dataset.id;
        let data = JSON.parse(e.target.dataset.details); // it's a string need an object
        CopyToModal(id, data);
    });
});
 //populate the modal fields
const CopyToModal = (id, data) => {
    $("#qty").val("0");
   // $("#ProductName").text(data.ProductName);
    //$("#CostPrice").text(data.CostPrice);
    $("#ption").text(data.Description);
  //  $("#detailsGraphic").attr("src", "/images/" + data.ProductName);
    $("#selectedId").val(id);
    console.log(data);
    
}