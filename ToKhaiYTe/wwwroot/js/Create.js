$(function () {
    $("#Province").change(function () {
        var url = "/ToKhaiYTe/GetDistrictById";
        var ddlsource = "#Province";
        $.getJSON(url, { id: $(ddlsource).val() }, function (data) {
            var items = '';
            $("#DistrictId").empty();
            $.each(data, function (i, row) {
                items += "<option value='" + row.value + "'>" + row.text + "</option>";
            });
            $("#District").html(items);

            var url = "/ToKhaiYTe/GetWardById";
            var DistrictVal = "#District";
            $.getJSON(url, { id: $(DistrictVal).val() }, function (data) {
                var items = '';
                $("#WardId").empty();
                $.each(data, function (i, row) {
                    items += "<option value='" + row.value + "'>" + row.text + "</option>";
                });
                $("#Ward").html(items);
            });
        });
    });
}
);
$(function () {
    $("#District").change(function () {
        var url = "/ToKhaiYTe/GetWardById";
        var ddlsource = "#District";
        $.getJSON(url, { id: $(ddlsource).val() }, function (data) {
            var items = '';
            $("#WardId").empty();
            $.each(data, function (i, row) {
                items += "<option value='" + row.value + "'>" + row.text + "</option>";
            });
            $("#Ward").html(items);
        });
    });
}
);
$(".custom-file-input").on("change", function () {
    var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});

$(document).ready(function () {
    $("#example").dataTable(
        {
            "columnDefs": [
                {
                    "targets": 3,
                    "orderable": false,
                    "searchable": false
                },
                {
                    "targets": 4,
                    "orderable": false,
                    "searchable": false
                },
                {
                    "targets": 5,
                    "orderable": false,
                    "searchable": false
                },
                {
                    "targets": 6,
                    "orderable": false,
                    "searchable": false
                }
            ]
        }
    );
});

var ToKhai = ToKhai || {};

ToKhai.delete = function (id) {
    bootbox.confirm({
        title: "Warning",
        message: "are you sure?",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> No'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Yes'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: `/ToKhaiYTe/Delete/${id}`,
                    method: "GET",
                    contentType: 'json',
                    success: function (data) {
                        if (data.result > 0) {
                            window.location.href = "/ToKhaiYTe/Index/";
                        }
                    }
                });
            }
        }
    });
}

