

$(function(){

    var a = window.location.toString();
    var name = a.substring(a.indexOf("=")+1);
    var car = '@';
    name = name.replace(/%40/, car);

    if (name == 'manager@viki.com') {
        $("#navigation-bar").load("navigation-bar.html #navigation-bar");
        
        $("#dispAddRem").visible();
        ChangeViewMode(0);
    }
    else if (name == "admin@viki.com") {
        $("#navigation-bar").load("navigation-bar-admin.html #navigation-bar");
        $("#viewmenu").invisible();
        ChangeViewMode(3);

    } else {
        $("#navigation-bar").load("navigation-bar-user.html #navigation-bar");
        ChangeViewMode(0);
        $("#dispAddRem").invisible();
    }

});

(function($) {
    $.fn.invisible = function() {
        return this.each(function() {
            $(this).css("visibility", "hidden");
        });
    };
    $.fn.visible = function() {
        return this.each(function() {
            $(this).css("visibility", "visible");
        });
    };
}(jQuery));


/** 
*** @divId: Id do botão
*** @room: Texto/view da divisão escolhida consoante o botão clicado
*****************************************************************************************/
function onLoad()
{
    ChangeViewMode(0);
}

/** Preencher as divisões na grelha
*** @divId: Id do botão
*** @room: Texto/view da divisão escolhida consoante o botão clicado
*****************************************************************************************/
function FillRoomDetails(DivId, room)
{
    var Room = getRoomById(room);

    var h2 = $( "<h2>" +Room.GetName()+"</h2>");
    var h3 = $( "<h3><small>temperatura </small>" +Room.GetTemp()+"</h3>");
    var h4 = $( "<h4><small>humidade </small>" +Room.GetHum()+"</h4>");
    var h5 = $( "<h5><small>energia </small>" +Room.GetEner()+"</h5>");
    
    $('#'+DivId).prepend( h5 );
    $('#'+DivId).prepend( h4 );
    $('#'+DivId).prepend( h3 );
    $('#'+DivId).prepend( h2 );
} 

/** Evento de divisão escolhida
*** @divId: Id do botão
*** @room: Texto/view da divisão escolhida consoante o botão clicado
*****************************************************************************************/
function ClickedRoomEvent(room)
{
    var Room = getRoomById(room);

    window.open("disp.html?room="+Room.GetName(),"_self","","")
}

function getRoomById(room)
{
    var rooms = [Room1, Room2, Room3, Room4, Room5, Room6]; 
    for (var i=0; i<6; i++) {
        if (rooms[i].GetID() == room) {      
            return rooms[i]
        }
    }
}

/** Evento de divisão escolhida
*** @divId: Id do botão
*** @room: Texto/view da divisão escolhida consoante o botão clicado
*****************************************************************************************/
function ChangeViewMode(view)
{
    switch(view) {
        case 0:
            $("#gridview").load("gridview.html");
            break;
        case 1:
            $("#gridview").load("cameras.html")
            break;
        case 2:
            $("#gridview").load("listview.html");
            break;
        case 3:
            $("#gridview").load("admin-list-houses.html");
            break;
    }
    
}


/** Centrar uma DIV consoante a window 
*** Note: Brute force method xD
*** @divId: Id da div a centrar
*****************************************************************************************/
function ShowDivInCenter(divId)
{
    try
    {
        divWidth = 100;
        divHeight = 100;

        var centerX, centerY;
        if (self.innerHeight)
        {
            centerX = self.innerWidth;
            centerY = self.innerHeight;
        }
        else if (document.documentElement && document.documentElement.clientHeight)
        {
            centerX = document.documentElement.clientWidth;
            centerY = document.documentElement.clientHeight;
        }
        else if (document.body)
        {
            centerX = document.body.clientWidth;
            centerY = document.body.clientHeight;
        }
 
        var offsetLeft = (centerX - divWidth) / 2;
        var offsetTop = (centerY - divHeight) / 2;
 

        var ojbDiv = document.getElementById(divId);
         
        ojbDiv.style.position = 'absolute';
        ojbDiv.style.top = offsetTop + 'px';
        ojbDiv.style.left = offsetLeft + 'px';
        ojbDiv.style.display = "block";
    }
    catch (e) {}
}