
using System.Security.Cryptography.X509Certificates;

Venta ventas = new Venta(12);
VentaconImpuestos ventas1 = new (154, 15.65m);
var mensage2 = ventas1.impuesto(154); 

var message = ventas1.GetInfo();
Console.WriteLine(message + "  impuestos total son " + mensage2 );
Console.WriteLine(ventas1.getInfoCliente("Ever Sorto"));

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

    public virtual string getInfoCliente() {
        return "El cliente se llama Carlor";
    }

}
class VentaconImpuestos : Venta 
{

    decimal porcentaje;
    public VentaconImpuestos(decimal total, decimal porcentaje) : base(total){
        this.porcentaje = porcentaje;
    
    }

    public decimal impuesto(decimal impuesto) { 
      var total =  this.Total *  impuesto;
        return total;
    }

    public override string getInfoCliente()
    {
            return "El cliete se llama Juan " + porcentaje ;
    }

    public  string getInfoCliente( string cliente)
    {
        return cliente;
    }
}
