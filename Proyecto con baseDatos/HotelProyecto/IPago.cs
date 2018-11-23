
namespace HotelProyecto
{
    interface IPago
    {
        float Efectivo(float total, float efectivo);
        bool Tarjeta(float total, float saldo, string NumeroTarjeta, string FechaVencimiento, string Cvv);
    }
}
