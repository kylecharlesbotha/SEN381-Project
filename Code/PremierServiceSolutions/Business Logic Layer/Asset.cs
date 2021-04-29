using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class Asset : IComparable<Asset>
    {
        private string clientID;
        private string manufacturer;
        private string model;
        private string serialNumber;
        private string assetName;

        AssetDH objAssetDH = new AssetDH();

        public Asset(string clientID, string manufacturer, string model, string serialNumber, string assetName)
        {
            this.clientID = clientID;
            this.manufacturer = manufacturer;
            this.model = model;
            this.serialNumber = serialNumber;
            this.assetName = assetName;
        }
        public Asset()
        {

        }

        public string ClientID { get => clientID; set => clientID = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Model { get => model; set => model = value; }
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string AssetName { get => assetName; set => assetName = value; }

        public List<Asset> GetAll()
        {
            List<Asset> newlist = new List<Asset>();
            try
            {
                newlist = objAssetDH.GetAll().ToList();
                return newlist;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
               
            }
        }

        public int CompareTo(Asset other)
        {
            string oldname = this.assetName;
            string newname = other.assetName;
            return newname.CompareTo(oldname);
        }
    }
}
