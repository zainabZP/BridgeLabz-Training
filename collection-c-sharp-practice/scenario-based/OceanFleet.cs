class Vessel{
    public string vesselId;
    public string vesselName;
    public string averageSpeed;
    public string vesselType;
    public Vessel(string vesselId, string vesselName, string averageSpeed, string vesselType){
        this.vesselId=vesselId;
        this.vesselName=vesselName;
        this.averageSpeed=averageSpeed;
        this.vesselType=vesselType;
    }
}

class VesselUtil{
    private List<Vessel> vesselList=new List<Vessel>();

    public List<Vessel> GetList(){
        return vesselList;
    }

    public void addVesselPerformance(Vessel vessel){
        vesselList.Add(vessel);
    }

    public Vessel getVesselById(String vesselId){

        foreach(Vessel vessel in vesselList){
            if(vessel.vesselId==vesselId){
                return vessel;
            }
        }
        Console.WriteLine("Vessel with id : "+vesselId +" Not Found");
        return null;
    }

    public List<Vessel> getHighPerformanceVessels(){
        List<Vessel> highPerformanceVessels=new List<Vessel>();
        double max=0;
        foreach(Vessel vessel in vesselList){
            max=Math.Max(max, double.Parse(vessel.averageSpeed));
        }
        foreach(Vessel vessel in vesselList){
            if(double.Parse(vessel.averageSpeed)==max){
                highPerformanceVessels.Add(vessel);
            }
        }
        return highPerformanceVessels;

    }
}
class Program{
    public static void Main(){
        VesselUtil manager=new VesselUtil();
        Console.WriteLine("Enter Vessels to be Added");
        int n=int.Parse(Console.ReadLine());
        for(int i=0;i<n;i++){
            string[] s=Console.ReadLine().Split(':');
            Vessel vessel=new Vessel(s[0],s[1],s[2],s[3]);
            manager.addVesselPerformance(vessel);
        }
        Console.WriteLine("Enter vessel id which is to be found");
        string id=Console.ReadLine();
        Vessel v=manager.getVesselById(id);
        if(v!=null)
        Console.WriteLine(v.vesselId+"|"+v.vesselName+"|"+v.averageSpeed+"|"+v.vesselType);
        List<Vessel> li=new List<Vessel>();
        li=manager.getHighPerformanceVessels();
        Console.WriteLine("High performance vessels are : ");
        foreach(Vessel ves in li){
            Console.WriteLine(ves.vesselId+"|"+ves.vesselName+"|"+ves.averageSpeed+"|"+ves.vesselType);
        }
    }
}