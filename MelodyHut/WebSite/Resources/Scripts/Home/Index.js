$.ajax({
    url: '/Home/TestRequest/',
    success: function (response) {
        alert('hello');
    }
});

$.ajax({
    url: '/Home/TestPostRequest/',
    method: 'post',
    success: function (response) {
        alert('hello Post');
    }
});

$.ajax({
    url: '/Home/TestDataRequest/',
    data : {name: "Wedaka", id: 10},
    success: function (response) {
        alert(response);
    }
});