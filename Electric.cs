namespace Garage
{
    public interface IElectricVehicle
    {
         void ChargeBattery();
         string GetCurrentChargePercentage();
    }
}