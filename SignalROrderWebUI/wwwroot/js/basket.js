console.log("deneme");

let deleteProduct = function (value) {
    console.log(value);

    $.ajax({
        contentType: "application/json",
        dataType: "json",
        type: "Get",
        url: "/Baskets/DeleteBasket/"+value,
        //data: { id: value },
        success: function (func) {
            Swal.fire({
                title: "The product id you clicked is : " + value,
                text: "IT IS DELETED",
                icon: "success"
            });
            console.log(value);
           

        }
    });
}

    // function deleteProduct(value) {
    //     $.ajax({
    //         contentType: "application/json",
    //         dataType: "json",
    //         type: "Get",
    //         url: "/Baskets/DeleteBasket/",
    //         data: { id: value },
    //         success: function (func) {
    //             Swal.fire({
    //                 title: "The product id you clicked is : " + value,
    //                 text: "IT IS DELETED",
    //                 icon: "success"
    //             });
    //             console.log(value);

    //         };
    //     });

    // };