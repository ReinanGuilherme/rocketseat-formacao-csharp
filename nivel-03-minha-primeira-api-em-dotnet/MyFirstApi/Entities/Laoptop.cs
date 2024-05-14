namespace MyFirstApi.Entities
{
    public class Laoptop: Device
    {
        public override string GetBranch()
        {
            Hello();

            return "Apple";
        }

        public override string Hello()
        {
            return "Reinan";
        }

        public string GetModel()
        {
            var isConnected = IsConnected();
            if (isConnected)
                return "Macbook";

            return "Unknow";
        }
    }
}
