namespace ProxyCenter.Model
{
    public class ProxyIpEntity
    {
        public ProxyIpEntity()
        {
            this.Status = "未验证";
        }
        public string Ip { get; set; }

        public int Port { get; set; }

        public string Address { get; set; }

        public string Status { get; set; }
    }
}
