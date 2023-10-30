let currentYear = new Date().getFullYear();

for (let index = currentYear; index >= currentYear - 100; index--) {
    $("#yearDropDownList").append(`<option>${index}</option>`);
}