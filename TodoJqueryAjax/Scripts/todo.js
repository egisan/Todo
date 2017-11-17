(() => {
    function add(task = null) {
        let text = $('#addItem').val();
        if (task != null) {
            text = task.Text;
        }
        if (!text) return;

        const $remove = $('<button class="remove">')
            .text("–");

        const $item = $('<li>')
            .text(text)
            .click(() => $item.toggleClass("checked"))
            .append($remove)
            .insertBefore($("li#input"));

        $remove.click(() => $item.remove());
        //$("#addItem").val("");
    }

    $("form").submit(add);
    //$('#addItem').change(add);
    //$('#add').click(add);

    $.getJSON("/app/list", (data, status, jqxhr) => {
        //console.log(status, data, jqxhr);
        if (status == "success") {
            //for (i = 0; i < data.length; i++) {
            //    let task = data[i];
            //    add(task);
            //}

            data.forEach(v => add(v));

        }
    });
})();