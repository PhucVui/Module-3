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

