$("#chk1").change((e)=>{
    if ($("#chk1").is(":checked")){
        $("#span1").html("Checkbox is checked");
    }else{
        $("#span1").html("Checkbox is unchecked");
    }

})

