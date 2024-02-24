//$(document).ready(() => {

//    var connection = new signalR.HubConnectionBuilder().withUrl("https://localhost:7260/SignalRHub").build();

//    $("#connstatus").text(connection.state);
//    //console.log(connection.state);

//    connection.start().then(() => {
//        $("#connstatus").text(" " + connection.state);

//        setInterval(() => {
//            connection.invoke("SendTableStatusList");
//        }, 5000);    //  time = 1sn

//    }).catch((err) => { console.log(err) });

//    connection.on("ReceiveTableListByStatus", (value) => {
//        console.log(value);
//        $("#restauranttablelistall").empty();
//        let color = "";
//        let status = "";
//        let tablehtml = "";
//        $.each(value, (index, item) => {

//        });
//    });
//});

var connection = new signalR.HubConnectionBuilder().withUrl("https://localhost:7260/SignalRHub").build();

document.querySelector("#sendbutton").disabled = true;
connection.on("ReceiveMesssage", function (user, message) {
    var currentTime = new Date();
    var currentHour = currentTime.getHours();
    var currentMinute = currentTime.getMinutes();

    var li = document.createElement("li");
    var span = document.createElement("span");
    span.style.fontWeight = "bold";
    span.textContent = user;
    li.appendChild(span);
    li.innerHTML +=` :${message} - ${currentHour}:${currentMinute}`;
    document.querySelector("#messagelist").appendChild(li);

});

connection.start().then(() => {
    document.querySelector("#sendbutton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString);
});

document.querySelector("#sendbutton").addEventListener("click", function (event) {
    var user = document.querySelector("#userinput").value;
    var message = document.querySelector("#messageinput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString);
    });
    event.preventDefault();
});
