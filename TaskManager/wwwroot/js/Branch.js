class Branch {
    update() {
        $.ajax({
            type: 'POST',
            url: '/Branch/Update/', // Change this to your backend endpoint
            data: $("#EntityForm").serialize(),
            success: function (response) {
                // Handle successful response
                console.log(response);
                $("#EntityForm")[0].reset()
                ticket.getList()
            },
            error: function (xhr, status, error) {
                // Handle errors
                console.error(xhr.responseText);
            }
        });
    }

    getList(page = 1) {
        $.ajax({
            type: 'POST',
            url: '/Branch/GetList/', // Change this to your backend endpoint
            data: {page: page},
            success: function (response) {
                $('#tableBody').empty()
                response.forEach((item) => {
                    let updateAction = "<button class='btn btn-primary btn-sm m-1' onclick='ticket.edit(this)'>Edit</button>";
                    let deleteAction = "<button class='btn btn-danger btn-sm m-1' onclick='ticket.delete("+item.id+")'>Delete</button>";

                    let row = "<tr>" +
                        "<td class='id'>" + item.id + "</td>" +
                        "<td class='title'>" + item.title + "</td>" +
                        "<td class='description'>" + item.description + "</td>" +
                        "<td>" + item.parent + "</td>" +
                        "<td>" + updateAction + deleteAction + "</td>" +
                        "</tr>";

                    $('#tableBody').append(row);
                })

                if (response.length) {
                    $("#pageNumber").text(page)
                } 
            },
            error: function (xhr, status, error) {
                console.error(xhr.responseText);
            }
        });


        for (let i = 1; i <= 10; i++) {

        }
    }

    delete(id) {
        $.ajax({
            type: 'POST',
            url: '/Branch/Delete/', // Change this to your backend endpoint
            data: {id},
            success: function (response) {
                $("#EntityForm")[0].reset()
                ticket.getList()
            },
            error: function (xhr, status, error) {
                // Handle errors
                console.error(xhr.responseText);
            }
        });
    }

    edit(elm) {
        let row = $(elm).closest("tr")
        $("[name=Id]").val(row.find('.id').text())
        $("[name=Title]").val(row.find('.title').text())
        $("[name=Description]").val(row.find('.description').text())
    }
}

const ticket = new Branch();

$(document).ready(() => {
    ticket.getList()
})