
using System.Security.Cryptography.X509Certificates;

Venta ventas = new Venta(12);
VentaconImpuestos ventas1 = new (154);
var mensage2 = ventas1.impuesto(154); 

var message = ventas1.GetInfo();
Console.WriteLine(message + " impuestos total son " + mensage2 );


class Venta {

    public decimal Total { get; set; }

    public Venta(decimal total) {
        this.Total = total;
    }

    public string GetInfo() { 
        return "El total es " + Total;
    }
    private string _SoloEnLaClase()
    {
        return "El total es " + Total;
    }

    protected String SoloHeredados()
    {
        return "El total es " + Total;
    }
}
class VentaconImpuestos : Venta 
{
    public VentaconImpuestos(decimal total) : base(total)
    { }

    public decimal impuesto(decimal impuesto) { 
      var total =  this.Total *  impuesto;
        return total;
    }
}
