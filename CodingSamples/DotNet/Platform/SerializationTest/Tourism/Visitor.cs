namespace Tourism;

public class Visitor
{
    public string Id { get; set; }

    public int VisitCount { get; set; }

    public DateTime LastVisit { get; set; }

    /*
    [System.Xml.Serialization.XmlIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public string Pass { get; set; }
    */

    public long Visit()
    {
        VisitCount += 1;
        LastVisit = DateTime.Now;
        return LastVisit.Ticks % 1000000;
    }
}
