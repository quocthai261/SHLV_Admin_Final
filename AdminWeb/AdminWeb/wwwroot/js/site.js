function notify(message, type) {
    DevExpress.ui.notify({
        message: message.replace(/"/g, ""),
        type: type,
        displayTime: 5000,
        closeOnClick: true,
        closeOnOutsideClick: true,
        width: $(window).width() * 0.3
    });
}

function confirmDialog(message, title, yes, no) {
    return DevExpress.ui.dialog.custom({
        title: title,
        messageHtml: message,
        buttons: [{
            text: yes,
            onClick: function (e) {
                return { buttonText: e.component.option("text") }
            }
        },
        {
            text: no,
            onClick: function (e) {
                return { buttonText: e.component.option("text") }
            }
        },
        ]
    });
}

async function GetMesssageAsync(_MessageCode, url) {
    const response = await new Promise((resolve, reject) => {
        $.ajax({
            type: "POST",
            url: url,
            dataType: "json",
            cache: false,
            data: {
                MessageCode: _MessageCode,
            },
            success: function (response) {
                resolve(response);
            },
            error: function (response) {
                reject(response);
            }
        });
    });

    return response.responseText.replaceAll('"', '');
}

function DateToString(_Date) {
    var day = _Date.getDate();
    var month = _Date.getMonth() + 1; // Note: month is zero-based
    var year = _Date.getFullYear();

    // Pad the day and month values with leading zeros if needed
    var formattedDay = day < 10 ? "0" + day : day;
    var formattedMonth = month < 10 ? "0" + month : month;

    // Create the formatted date string
    return formattedDay + "/" + formattedMonth + "/" + year;
}


function DateToISOString(_Date) {
    if (_Date !== null && _Date != undefined && _Date !== '') {
        var date = new Date(_Date)
        const yourDate = date.getTime() - (date.getTimezoneOffset() * 60000);
        //console.log("yourDate", yourDate);

        return new Date(yourDate).toISOString().slice(0, 19);
    }
    else return '';
}

async function DateToString_HHmm(dateString) {
    var date = new Date(dateString);
    // Get hours and minutes from the Date object
    var hours = String(date.getHours()).padStart(2, '0');
    var minutes = String(date.getMinutes()).padStart(2, '0');

    // Format the time as "HH:mm"
    var timeString = hours + ':' + minutes;

    // Create the formatted date string
    return timeString;
}


function onConfirmBackToeAppList(url, message, title, yes, no) {
    var myDialog = confirmDialog(message, title, yes, no);
    myDialog.show().done(function (dialogResult) {
        if (dialogResult.buttonText === yes) {
            location.href = url;
        }
    });
}

DevExpress.localization.locale("de-DE");
