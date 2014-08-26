using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide__and__Seek
{
    class RoomWithDoor: RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration,string hidingPlace, string doorDescription)
            : base(name, decoration,hidingPlace)
        {
            this.doorDescription = doorDescription;
        }

        private string doorDescription;

        public string DoorDescription
        {
            get { return doorDescription; }
            set { doorDescription = value; }
        }

        private Location doorLocation;

        public Location DoorLocation
        {
            get { return doorLocation; }
            set { doorLocation = value; }
        }
    }
}
