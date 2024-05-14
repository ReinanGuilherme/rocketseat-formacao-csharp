namespace MyFirstApi.Entities
{
    public class Laoptop: Device
    {
        public override string GetBranch()
        {
            return "Apple";
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
