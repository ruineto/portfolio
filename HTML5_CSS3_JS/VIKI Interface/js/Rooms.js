
function Room(vname, vtemp, vhum, vener)
{
	var id = 0;
    var name = "";
    var temp = "";
    var hum = "";
    var ener = "";
    var img = "";

	this.GetID = function() { return id;}
    this.SetID = function(xT) { id = xT; }

    this.GetName = function() { return name;}
    this.SetName = function(xT) { name = xT; }

    this.GetTemp = function() { return temp;}
    this.SetTemp = function(xT) { temp = xT; }

    this.GetHum = function() { return hum;}
    this.SetHum = function(xT) { hum = xT; }

    this.GetEner = function() { return ener;}
    this.SetEner = function(xT) { ener = xT; }

    this.GetImg = function() { return img;}
    this.SetImg = function(xT) { img = xT; }

    this.ToString = function() { return id + " " + name + " " + temp+ " " +hum+ " " +ener+ " " +img}
}
 

Room1 = new Room;
Room1.SetName("Sala");
Room1.SetTemp("18ºC");
Room1.SetHum("57%");
Room1.SetEner("0,65kwh");
Room1.SetImg("img/livingroom.png");
Room1.SetID(0);

Room2 = new Room ()
Room2.SetName("Cozinha");
Room2.SetTemp("19ºC");
Room2.SetHum("60%");
Room2.SetEner("1,05kwh");
Room2.SetImg("img/kitchen.png");
Room2.SetID(1);

Room3 = new Room ()
Room3.SetName("Quarto Principal");
Room3.SetTemp("21ºC");
Room3.SetHum("45%");
Room3.SetEner("0,3kwh");
Room3.SetImg("img/bedroom.png");
Room3.SetID(2);

Room4 = new Room ()
Room4.SetName("Quarto da Rita");
Room4.SetTemp("21ºC");
Room4.SetHum("42%");
Room4.SetEner("0,2kwh");
Room4.SetImg("img/bedroom2.png");
Room4.SetID(3);

Room5 = new Room ()
Room5.SetName("Casa de Banho");
Room5.SetTemp("20ºC");
Room5.SetHum("76%");
Room5.SetEner("0,4kwh");
Room5.SetImg("img/bathroom.png");
Room5.SetID(4);

Room6 = new Room ()
Room6.SetName("Garagem");
Room6.SetTemp("15ºC");
Room6.SetHum("67%");
Room6.SetEner("0,1kwh");
Room6.SetImg("img/garage.png");
Room6.SetID(5);