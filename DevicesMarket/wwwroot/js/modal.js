function openModal(parameters) {
    debugger
    const data = parameters.data
    const url = parameters.url

    if (id === undefined || url === undefined) {
        alert("sorry, there are expected problem")
        return
    }

    $.ajax({
        type: "GET",
        url: url,   
        data: {"id" : id},
        success: function (response) {
            modal.find(".modal-body").html(response)
            modal.modal("show")
        },
        failure: function () {
            modal.modal("hide")
        },
        error: function (response) {
            alert(response.responseText)
        }
    })
}