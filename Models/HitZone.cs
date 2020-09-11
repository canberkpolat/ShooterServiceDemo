using System.Collections.Generic;

namespace ShooterServiceDemo.Models
{
    public class HitZone
    {
        public HitZone() { }
        public HitZone(int id) { 
            ID = id;
            switch (id)
            {
                case 1:
                    Value = "Head";
                    break;
                case 2:
                    Value = "Arm";
                    break;
                case 3:
                    Value = "Leg";
                    break;
                case 4:
                    Value = "Trunk";
                    break;
                case 5:
                    Value = "Foot";
                    break;
                case 6:
                    Value = "Hand";
                    break;
                default:
                    ID = 1;
                    Value = "Head";
                    break;
            }
        }
        public string Value { get; set; }
        public int ID { get; set; }
        public static List<HitZone> Options { 
            get { return new List<HitZone> { HEAD,ARM,LEG,TRUNK,FOOT,HAND }; } 
        }
        public static HitZone HEAD { get { return new HitZone(1); } }
        public static HitZone ARM { get { return new HitZone(2); } }
        public static HitZone LEG { get { return new HitZone(3); } }
        public static HitZone TRUNK { get { return new HitZone(4); } }
        public static HitZone FOOT { get { return new HitZone(5); } }
        public static HitZone HAND { get { return new HitZone(6); } }
    }
}