using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class MainClass
{
    [STAThread]
    static void Main(string[] args)
    {
        Point p1 = new Point();

        p1.xpoint = 1;
        p1.ypoint = 2;

        Stream stream = File.Open("point.bin", FileMode.Create);
        BinaryFormatter bformatter = new BinaryFormatter();

        bformatter.Serialize(stream, p1);
        stream.Close();

        Stream openStream = File.Open("point.bin", FileMode.Open);
        Point desierializedPoint = new Point();

        desierializedPoint = (Point)bformatter.Deserialize(openStream);
    }
}

[Serializable()]
class Point
{
    public int xpoint;
    public int ypoint;
}