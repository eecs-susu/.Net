namespace TankConstruction.Models.Base
{
    public abstract class Engine : TankComponent, IMovable
    {      
        protected Engine(string serialNumber) : base(serialNumber)
        {
        }

        public abstract uint Move();
    }
}
